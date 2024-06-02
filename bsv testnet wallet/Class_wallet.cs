using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Utilities.Encoders;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using NBitcoin;
using BsvSimpleLibrary;
using System.Security.Policy;
using System.Windows.Forms;

namespace bsv_testnet_wallet
{
	internal class Class_wallet
	{
		readonly string netWork = null;
		readonly Network NbitNetWork = null;
		string id=null; //id=10000
		string originalKeyStr=null;
		//readonly Key key = null;
		//BitcoinSecret bitcoinSecret = null; //wifKey
		string wifKeyStr = null;
		//readonly PubKey compressedPubKey = null;
		string compressedPubKeyStr = null;
		//readonly BitcoinAddress address = null;
		string pubKeyHashStr= null;
		string addressStr = null;
		long displayBalance = 0;
		long utxoBalance = 0;
		//RestApiUtxo_class[] utxos = null;
		const int walletTypeID = 0;
		const int walletTypeWifKey = 1;
		const int walletTypeAddress = 2;
		readonly int walletType = -1;
		readonly string uri = bsvConfiguration_class.RestApiUri;
		internal string ID { get { return id; } }
		internal string OriginalKeyStr { get { return originalKeyStr; } }
		internal string WifKeyStr { get { return wifKeyStr; } }
		internal string CompressedPubKeyStr { get { return compressedPubKeyStr; } }
		internal string PubKeyHashStr { get { return pubKeyHashStr; } }
		internal string AddressStr { get { return addressStr; } }
		internal long BalanceSats { get { return displayBalance; } }
		//internal RestApiUtxo_class[] Utxos { get { GetUtxosForOutside(); return utxos; } }

		internal Class_wallet(string str, bool isTestnet, int walletTypep)
		{			
			//if (isTestnet)
			//{
			//	netWork = bsvConfiguration_class.testNetwork;
			//	NbitNetWork = Network.TestNet;
			//}
			//else
			//{
			//	netWork = bsvConfiguration_class.mainNetwork;
			//	NbitNetWork = Network.Main;
			//}
			walletType = walletTypep;
			if (walletType == walletTypeAddress)
				createWalletFromAddress(str);
			if (walletType == walletTypeWifKey)
				createWalletFromWifKey(str);
			if (walletType == walletTypeID)
				createWalletFromID(str);


			////id = IDstr;
			//byte[] sha256bytes;
			//using (SHA256 sha256Hash = SHA256.Create())
			//{
			//	// 将输入字符串转换为字节数组并计算哈希数据
			//	sha256bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(IDstr));
			//	// 将字节数组转换为十六进制的字符串
			//	originalKeyStr= Hex.ToHexString(sha256bytes);
			//}
			//key = new Key(sha256bytes);
			
			//BitcoinSecret bitcoinSecret = key.GetBitcoinSecret(NbitNetWork);
			//wifKeyStr = bitcoinSecret.ToWif();
			//compressedPubKey = key.PubKey.Compress();
			//compressedPubKeyStr = compressedPubKey.ToHex();
			//address = compressedPubKey.GetAddress(NbitNetWork);
			//addressStr = address.ToString();
			//getUtxoBalance();
		}
		internal void setNetwork(bool isTestnet)
		{
			if (isTestnet)
			{
				netWork = bsvConfiguration_class.testNetwork;
				NbitNetWork = Network.TestNet;
			}
			else
			{
				netWork = bsvConfiguration_class.mainNetwork;
				NbitNetWork = Network.Main;
			}
		}
		bool createWalletFromAddress(string str)
		{
			try
			{
				// 尝试创建一个Bitcoin地址实例
				BitcoinAddress bitcoinAddress = BitcoinAddress.Create(str, NbitNetWork);
				addressStr = str;
				pubKeyHashStr = bitcoinAddress.ScriptPubKey.ToString();
				getUtxosAndRefreshBalance();
				// 如果没有异常抛出，说明地址有效
				return true;
			}
			catch (FormatException)
			{
				// 如果有异常抛出，说明地址无效
				MessageBox.Show("地址格式不对", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		bool createWalletFromWifKey(string str)
		{
			try
			{
				// 尝试创建一个wifkey
				BitcoinSecret wifKey=new BitcoinSecret(str, NbitNetWork);
				wifKeyStr = wifKey.ToString();
				compressedPubKeyStr = wifKey.PubKey.ToString();
				pubKeyHashStr = wifKey.PubKey.Hash.ToString();
				addressStr = wifKey.GetAddress().ToString();
				getUtxosAndRefreshBalance();
				// 如果没有异常抛出，说明地址有效
				return true;
			}
			catch (FormatException)
			{
				// 如果有异常抛出，说明地址无效
				MessageBox.Show("钱包私钥格式不对", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return (false);
		}
		bool createWalletFromID(string str)
		{
			id = str;
			byte[] sha256bytes;
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// 将输入字符串转换为字节数组并计算哈希数据
				sha256bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str));
				// 将字节数组转换为十六进制的字符串
				originalKeyStr = Hex.ToHexString(sha256bytes);
			}
			Key key = new Key(sha256bytes);
			BitcoinSecret wifKey = key.GetWif(NbitNetWork);
			PubKey pubKey = wifKey.PubKey;
			wifKeyStr = wifKey.ToString();
			compressedPubKeyStr = pubKey.Compress().ToString();
			pubKeyHashStr= pubKey.Hash.ToString();
			addressStr = pubKey.GetAddress(NbitNetWork).ToString();
			getUtxosAndRefreshBalance();
			return (true);
		}

		internal RestApiUtxo_class[] getUtxosAndRefreshBalance()
		{
			RestApiUtxo_class[] utxos = getUtxos();
			long sum = 0;
			foreach(RestApiUtxo_class utxo in utxos)
				sum += utxo.Value;
			utxoBalance = sum;
			displayBalance = sum;
			return (utxos);
		}
		RestApiUtxo_class[] getUtxos()
		{
			RestApiUtxo_class[] utxos = null;
			Task t = Task.Run(() =>
			{
				utxos = RestApi_class.getUtxosByAnAddress(uri, netWork, addressStr);
			});
			t.Wait();
			return utxos;
		}

		//internal RestApiUtxo_class[] GetUtxosForOutside()//bool forceRefresh = false)//会更新余额
		//{
		//	//if (!forceRefresh && displayBalance == utxoBalance)
		//	//{
		//	//	return (utxos);
		//	//}
		//	RestApiUtxo_class[] utxos = getUtxoBalance();//更新utxo和余额
		//	return (utxos);
		//}
		internal RestApiAddressHistoryTx[] getTxs()
		{
			RestApiAddressHistoryTx[] txs = null;
			Task t = Task.Run(() =>
			{
				txs = RestApi_class.getAddressHistory(uri, netWork, addressStr);
			});
			t.Wait();
			return txs;
		}

		internal bool sendCoins(long sendSats, string destAddress, string changeBackAddress,
			string op_returnString, out string outSendInfo)
		{
			Transaction tx = null;
			long fee = 0;
			long donaFee = 0;
			Dictionary<string, string> sendTxResponse = null;
			outSendInfo = null;
			bool sendSuccess = false;
			Task t = Task.Run(() =>
			{
				sendTxResponse = bsvTransaction_class.send(WifKeyStr, sendSats, netWork, out tx, out fee, out donaFee,
				destAddress, changeBackAddress, op_returnString, 1, 0);
			});
			t.Wait();
			if (sendTxResponse != null)
			{
				outSendInfo = sendTxResponse.First().Value;
				if (outSendInfo != null && !outSendInfo.Contains("unexpected")) //发送成功
				{
					long expectedBalance = displayBalance - sendSats - fee - donaFee;
					displayBalance = expectedBalance;
					if (destAddress != null && destAddress == addressStr)
						displayBalance += sendSats;
					sendSuccess = true;
				}
			}
			return (sendSuccess);
		}


	}
}
