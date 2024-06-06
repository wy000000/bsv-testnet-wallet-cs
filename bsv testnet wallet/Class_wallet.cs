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
		Network NbitNetWork = null;
		readonly string id =null; //id=10000
		readonly string originalKeyStr =null;
		//readonly Key key = null;
		//BitcoinSecret bitcoinSecret = null; //wifKey
		readonly string wifKeyStr = null;
		//readonly PubKey compressedPubKey = null;
		readonly string compressedPubKeyStr = null;
		//readonly BitcoinAddress address = null;
		readonly string pubKeyHashStr = null;
		readonly string addressStr = null;
		long displayBalance = 0;
		long utxoBalance = 0;
		//RestApiUtxo_class[] utxos = null;
		internal const int walletTypeID = 0;
		internal const int walletTypeWifKey = 1;
		internal const int walletTypeAddress = 2;
		readonly int walletType = -1;
		readonly string uri = bsvConfiguration_class.RestApiUri;
		internal string NetWork { get { return netWork; } }
		//internal Network NbitNetwork { get { return NbitNetwork; } }
		internal string ID { get { return id; } }
		internal string OriginalKeyStr { get { return originalKeyStr; } }
		internal string WifKeyStr { get { return wifKeyStr; } }
		internal string CompressedPubKeyStr { get { return compressedPubKeyStr; } }
		internal string PubKeyHashStr { get { return pubKeyHashStr; } }
		internal string AddressStr { get { return addressStr; } }
		internal long BalanceSats { get { return displayBalance; } }
		internal int WalletType { get { return walletType; } }

		//internal RestApiUtxo_class[] Utxos { get { GetUtxosForOutside(); return utxos; } }

		Class_wallet(string netStr, Network net, int walletTypep, string idp = null, string originalKey = null,
			string wifKey = null, string pubKey = null, string pubkeyHash = null, string address = null)
			//long displayBalancep = 0, long utxoBalancep=0)
		{
			netWork = netStr;
			NbitNetWork = net;
			walletType = walletTypep;
			id=idp;
			originalKeyStr= originalKey;
			wifKeyStr= wifKey;
			compressedPubKeyStr = pubKey;
			pubKeyHashStr = pubkeyHash;
			addressStr = address;
			//displayBalance=displayBalancep;
			//utxoBalance=utxoBalancep;
			getUtxosAndRefreshBalance();
		}
		//static bool isValidAddress(string str, Network net, out BitcoinPubKeyAddress address)
		//{
		//	address = null;
		//	try
		//	{
		//		// 尝试创建一个Bitcoin地址实例
		//		address = new BitcoinPubKeyAddress(str, net);
		//		// 如果没有异常抛出，说明地址有效
		//		return true;
		//	}
		//	catch (FormatException)
		//	{
		//		// 如果有异常抛出，说明地址无效
		//		MessageBox.Show("Invalid address!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//	return false;
		//}
		//internal static bool isValidWifKey(string str, Network net, out BitcoinSecret wifKey)
		//{
		//	wifKey = null;
		//	try
		//	{
		//		wifKey=new BitcoinSecret(str, net);
		//		return true;
		//	}
		//	catch (FormatException)
		//	{
		//		// 如果有异常抛出，说明地址无效
		//		MessageBox.Show("Invalid WifKey", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//	return (false);
		//}
		internal static Class_wallet createBsvWallet(string str, bool isTestnet, int walletTypep)
		{
			try
			{
				Network net = isTestnet ? Network.TestNet : Network.Main;
				string netStr = isTestnet ? bsvConfiguration_class.testNetwork : bsvConfiguration_class.mainNetwork;
				if (walletTypep == walletTypeAddress)
				{
					BitcoinPubKeyAddress address = new BitcoinPubKeyAddress(str, net);
					//if (!isValidAddress(str, net, out address)) { return null; }
					Class_wallet aBsvWallet = new Class_wallet(netStr, net, walletTypep, null, null, null, null,
						address.Hash.ToString(), address.ToString());
					return (aBsvWallet);
				}
				if (walletTypep == walletTypeWifKey)
				{
					BitcoinSecret wifKey = new BitcoinSecret(str, net);
					//if (!isValidWifKey(str, net, out wifKey)) { return null; }
					Class_wallet aBsvWallet = new Class_wallet(netStr, net, walletTypep, null, null,
						wifKey.ToString(), wifKey.PubKey.ToString(), wifKey.PubKey.Hash.ToString(),
						wifKey.GetAddress().ToString());
					return (aBsvWallet);
				}
				if (walletTypep == walletTypeID)
				{
					string keyStr = null;
					byte[] sha256bytes;
					using (SHA256 sha256Hash = SHA256.Create())
					{
						// 将输入字符串转换为字节数组并计算哈希数据
						sha256bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str));
						// 将字节数组转换为十六进制的字符串
						keyStr = Hex.ToHexString(sha256bytes);
					}
					Key key = new Key(sha256bytes);
					BitcoinSecret wifKey = key.GetWif(net);
					//wifKey = key.GetBitcoinSecret(net);
					Class_wallet aBsvWallet = new Class_wallet(netStr, net, walletTypep, str, keyStr, wifKey.ToString(),
						wifKey.PubKey.ToString(), wifKey.PubKeyHash.ToString(), wifKey.GetAddress().ToString());
					return (aBsvWallet);
				}
			}
			catch (Exception ex)
			{
				// Display the exception type and message
				MessageBox.Show(ex.GetType().Name + ", " + ex.Message, "Info", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			return (null);
		}
		internal RestApiUtxo_class[] getUtxosAndRefreshBalance()
		{
			try
			{
				RestApiUtxo_class[] utxos = getUtxos();
				if (utxos == null) { return null; }
				long sum = 0;
				foreach (RestApiUtxo_class utxo in utxos)
					sum += utxo.Value;
				utxoBalance = sum;
				displayBalance = sum;
				return (utxos);
			}
			catch (Exception ex)
			{
				// Display the exception type and message
				MessageBox.Show(ex.GetType().Name + ", " + ex.Message, "Info", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			return (null);
		}
		RestApiUtxo_class[] getUtxos()
		{
			if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
			{
				MessageBox.Show("No Internet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			RestApiUtxo_class[] utxos = null;
			Task t = Task.Run(() =>
			{
				utxos = RestApi_class.getUtxosByAnAddress(uri, netWork, addressStr);
			});
			t.Wait();
			return utxos;
		}
		internal RestApiAddressHistoryTx[] getTxs()
		{
			if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
			{
				MessageBox.Show("No Internet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			try
			{
				RestApiAddressHistoryTx[] txs = null;
				Task t = Task.Run(() =>
				{
					txs = RestApi_class.getAddressHistory(uri, netWork, addressStr);
				});
				t.Wait();
				return txs;
			}
			catch (Exception ex)
			{
				// Display the exception type and message
				MessageBox.Show(ex.GetType().Name + ", " + ex.Message, "Info", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			return (null);
		}

		internal bool sendCoins(long sendSats, string destAddress, string changeBackAddress,
			string op_returnString, out string outSendInfo)
		{
			outSendInfo = null;
			if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
			{
				MessageBox.Show("No Internet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			try
			{
				BitcoinAddress addr = BitcoinAddress.Create(destAddress, NbitNetWork);
				BitcoinAddress addr2=BitcoinAddress.Create(changeBackAddress, NbitNetWork);
				Transaction tx = null;
				long fee = 0;
				long donaFee = 0;
				Dictionary<string, string> sendTxResponse = null;
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
			catch (Exception ex)
			{
				// Display the exception type and message
				MessageBox.Show(ex.GetType().Name + ", " + ex.Message, "Info", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			return false;
		}

	}
}
