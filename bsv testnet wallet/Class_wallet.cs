﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Utilities.Encoders;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using NBitcoin;
using BsvSimpleLibrary;

namespace bsv_testnet_wallet
{
	internal class Class_wallet
	{
		readonly string id=null; //10000
		readonly string originalKeyStr=null;
		readonly Key key = null;
		readonly string netWork = null;
		//readonly string NbitNetWork = null;
		readonly Network NbitNetWork = null;
		readonly BitcoinSecret bitcoinSecret = null;
		readonly string wifKeyStr = null;
		readonly PubKey compressedPubKey = null;
		readonly string compressedPubKeyStr = null;
		readonly BitcoinAddress address = null;
		readonly string addressStr = null;
		internal string ID { get { return id; } }
		internal string OriginalKeyStr { get { return originalKeyStr; } }
		internal string WifKeyStr { get { return wifKeyStr; } }
		internal string CompressedPubKeyStr { get { return compressedPubKeyStr; } }
		internal string PubKeyHashStr { get { return compressedPubKey.Hash.ToString(); } }
		internal string AddressStr { get { return addressStr; } }
		internal Class_wallet(string IDstr, bool isTestnet)
		{
			id = IDstr;
			byte[] sha256bytes;
			using (SHA256 sha256Hash = SHA256.Create())
			{
				// 将输入字符串转换为字节数组并计算哈希数据
				sha256bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(IDstr));
				// 将字节数组转换为十六进制的字符串
				originalKeyStr= Hex.ToHexString(sha256bytes);
			}
			key = new Key(sha256bytes);
			if(isTestnet)
			{
				netWork = bsvConfiguration_class.testNetwork;
				NbitNetWork = Network.TestNet;
			}
			else
			{
				netWork = bsvConfiguration_class.mainNetwork;
				NbitNetWork = Network.Main;
			}
			bitcoinSecret = key.GetBitcoinSecret(NbitNetWork);
			wifKeyStr = bitcoinSecret.ToWif();
			compressedPubKey = key.PubKey.Compress();
			compressedPubKeyStr = compressedPubKey.ToHex();
			address = compressedPubKey.GetAddress(NbitNetWork);
			addressStr = address.ToString();

			
		}

	}
}
