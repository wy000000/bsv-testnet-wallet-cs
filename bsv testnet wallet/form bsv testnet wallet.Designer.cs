namespace bsv_testnet_wallet
{
	partial class F_wallet
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.tb_wifKey = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.bt_encryptSign = new System.Windows.Forms.Button();
			this.bt_utxo = new System.Windows.Forms.Button();
			this.bt_refreshBalance = new System.Windows.Forms.Button();
			this.bt_login = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_balance = new System.Windows.Forms.TextBox();
			this.tb_address = new System.Windows.Forms.TextBox();
			this.tb_pubKeyHash = new System.Windows.Forms.TextBox();
			this.tb_compressedPubkey = new System.Windows.Forms.TextBox();
			this.tb_originalKey = new System.Windows.Forms.TextBox();
			this.tb_ID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.bt_tx = new System.Windows.Forms.Button();
			this.tb_destAddress = new System.Windows.Forms.TextBox();
			this.bt_send = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tb_changeAddress = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tb_opReturn = new System.Windows.Forms.TextBox();
			this.radioButton_testnet = new System.Windows.Forms.RadioButton();
			this.radioButton_mainnet = new System.Windows.Forms.RadioButton();
			this.label13 = new System.Windows.Forms.Label();
			this.tb_sats = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tb_wifKey
			// 
			this.tb_wifKey.Location = new System.Drawing.Point(92, 87);
			this.tb_wifKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_wifKey.Name = "tb_wifKey";
			this.tb_wifKey.ReadOnly = true;
			this.tb_wifKey.Size = new System.Drawing.Size(651, 25);
			this.tb_wifKey.TabIndex = 45;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label8.Location = new System.Drawing.Point(8, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(464, 18);
			this.label8.TabIndex = 56;
			this.label8.Text = "输入学号登录会自动生成固定密钥。余额需手动刷新。";
			// 
			// bt_encryptSign
			// 
			this.bt_encryptSign.Location = new System.Drawing.Point(406, 366);
			this.bt_encryptSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_encryptSign.Name = "bt_encryptSign";
			this.bt_encryptSign.Size = new System.Drawing.Size(150, 25);
			this.bt_encryptSign.TabIndex = 55;
			this.bt_encryptSign.Text = "加解密与签名验证";
			this.bt_encryptSign.UseVisualStyleBackColor = true;
			// 
			// bt_utxo
			// 
			this.bt_utxo.Location = new System.Drawing.Point(230, 366);
			this.bt_utxo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_utxo.Name = "bt_utxo";
			this.bt_utxo.Size = new System.Drawing.Size(60, 25);
			this.bt_utxo.TabIndex = 54;
			this.bt_utxo.Text = "币";
			this.bt_utxo.UseVisualStyleBackColor = true;
			this.bt_utxo.Click += new System.EventHandler(this.bt_utxo_Click);
			// 
			// bt_refreshBalance
			// 
			this.bt_refreshBalance.Location = new System.Drawing.Point(406, 199);
			this.bt_refreshBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_refreshBalance.Name = "bt_refreshBalance";
			this.bt_refreshBalance.Size = new System.Drawing.Size(85, 25);
			this.bt_refreshBalance.TabIndex = 53;
			this.bt_refreshBalance.Text = "刷新余额";
			this.bt_refreshBalance.UseVisualStyleBackColor = true;
			this.bt_refreshBalance.Click += new System.EventHandler(this.bt_refreshBalance_Click);
			// 
			// bt_login
			// 
			this.bt_login.Location = new System.Drawing.Point(406, 31);
			this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_login.Name = "bt_login";
			this.bt_login.Size = new System.Drawing.Size(60, 25);
			this.bt_login.TabIndex = 52;
			this.bt_login.Text = "登录";
			this.bt_login.UseVisualStyleBackColor = true;
			this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 15);
			this.label7.TabIndex = 51;
			this.label7.Text = "钱包密钥：";
			// 
			// tb_balance
			// 
			this.tb_balance.Location = new System.Drawing.Point(92, 199);
			this.tb_balance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_balance.Name = "tb_balance";
			this.tb_balance.ReadOnly = true;
			this.tb_balance.Size = new System.Drawing.Size(289, 25);
			this.tb_balance.TabIndex = 48;
			// 
			// tb_address
			// 
			this.tb_address.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tb_address.Location = new System.Drawing.Point(92, 171);
			this.tb_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_address.Name = "tb_address";
			this.tb_address.ReadOnly = true;
			this.tb_address.Size = new System.Drawing.Size(504, 25);
			this.tb_address.TabIndex = 49;
			this.tb_address.TextChanged += new System.EventHandler(this.tb_address_TextChanged);
			this.tb_address.DoubleClick += new System.EventHandler(this.tb_address_DoubleClick);
			// 
			// tb_pubKeyHash
			// 
			this.tb_pubKeyHash.Location = new System.Drawing.Point(92, 143);
			this.tb_pubKeyHash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_pubKeyHash.Name = "tb_pubKeyHash";
			this.tb_pubKeyHash.ReadOnly = true;
			this.tb_pubKeyHash.Size = new System.Drawing.Size(651, 25);
			this.tb_pubKeyHash.TabIndex = 47;
			// 
			// tb_compressedPubkey
			// 
			this.tb_compressedPubkey.Location = new System.Drawing.Point(92, 115);
			this.tb_compressedPubkey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_compressedPubkey.Name = "tb_compressedPubkey";
			this.tb_compressedPubkey.ReadOnly = true;
			this.tb_compressedPubkey.Size = new System.Drawing.Size(651, 25);
			this.tb_compressedPubkey.TabIndex = 46;
			// 
			// tb_originalKey
			// 
			this.tb_originalKey.Location = new System.Drawing.Point(92, 59);
			this.tb_originalKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_originalKey.Name = "tb_originalKey";
			this.tb_originalKey.ReadOnly = true;
			this.tb_originalKey.Size = new System.Drawing.Size(651, 25);
			this.tb_originalKey.TabIndex = 44;
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(92, 31);
			this.tb_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(289, 25);
			this.tb_ID.TabIndex = 43;
			this.tb_ID.Text = "100000";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(42, 209);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 15);
			this.label6.TabIndex = 42;
			this.label6.Text = "余额：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(42, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 15);
			this.label5.TabIndex = 41;
			this.label5.Text = "地址：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 15);
			this.label4.TabIndex = 40;
			this.label4.Text = "公钥HASH：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 15);
			this.label3.TabIndex = 39;
			this.label3.Text = "压缩公钥：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 15);
			this.label2.TabIndex = 38;
			this.label2.Text = "原始私钥：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 37;
			this.label1.Text = "学号：";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.linkLabel1.Location = new System.Drawing.Point(662, 11);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(82, 15);
			this.linkLabel1.TabIndex = 36;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "申请测试币";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// bt_tx
			// 
			this.bt_tx.Location = new System.Drawing.Point(320, 366);
			this.bt_tx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_tx.Name = "bt_tx";
			this.bt_tx.Size = new System.Drawing.Size(60, 25);
			this.bt_tx.TabIndex = 54;
			this.bt_tx.Text = "交易";
			this.bt_tx.UseVisualStyleBackColor = true;
			this.bt_tx.Click += new System.EventHandler(this.bt_tx_Click);
			// 
			// tb_destAddress
			// 
			this.tb_destAddress.Location = new System.Drawing.Point(92, 240);
			this.tb_destAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_destAddress.Name = "tb_destAddress";
			this.tb_destAddress.Size = new System.Drawing.Size(651, 25);
			this.tb_destAddress.TabIndex = 49;
			// 
			// bt_send
			// 
			this.bt_send.Location = new System.Drawing.Point(431, 323);
			this.bt_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_send.Name = "bt_send";
			this.bt_send.Size = new System.Drawing.Size(60, 25);
			this.bt_send.TabIndex = 53;
			this.bt_send.Text = "发送";
			this.bt_send.UseVisualStyleBackColor = true;
			this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 250);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(82, 15);
			this.label10.TabIndex = 42;
			this.label10.Text = "发送币到：";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 277);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 15);
			this.label11.TabIndex = 42;
			this.label11.Text = "找零币到：";
			// 
			// tb_changeAddress
			// 
			this.tb_changeAddress.Location = new System.Drawing.Point(92, 267);
			this.tb_changeAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_changeAddress.Name = "tb_changeAddress";
			this.tb_changeAddress.Size = new System.Drawing.Size(651, 25);
			this.tb_changeAddress.TabIndex = 49;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(0, 304);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(94, 15);
			this.label12.TabIndex = 42;
			this.label12.Text = "OP_Return：";
			// 
			// tb_opReturn
			// 
			this.tb_opReturn.Location = new System.Drawing.Point(92, 294);
			this.tb_opReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_opReturn.Name = "tb_opReturn";
			this.tb_opReturn.Size = new System.Drawing.Size(651, 25);
			this.tb_opReturn.TabIndex = 49;
			// 
			// radioButton_testnet
			// 
			this.radioButton_testnet.AutoSize = true;
			this.radioButton_testnet.Checked = true;
			this.radioButton_testnet.Location = new System.Drawing.Point(489, 37);
			this.radioButton_testnet.Name = "radioButton_testnet";
			this.radioButton_testnet.Size = new System.Drawing.Size(84, 19);
			this.radioButton_testnet.TabIndex = 59;
			this.radioButton_testnet.TabStop = true;
			this.radioButton_testnet.Text = "testnet";
			this.radioButton_testnet.UseVisualStyleBackColor = true;
			this.radioButton_testnet.CheckedChanged += new System.EventHandler(this.radioButton_testnet_CheckedChanged);
			// 
			// radioButton_mainnet
			// 
			this.radioButton_mainnet.AutoSize = true;
			this.radioButton_mainnet.Location = new System.Drawing.Point(579, 37);
			this.radioButton_mainnet.Name = "radioButton_mainnet";
			this.radioButton_mainnet.Size = new System.Drawing.Size(84, 19);
			this.radioButton_mainnet.TabIndex = 60;
			this.radioButton_mainnet.Text = "mainnet";
			this.radioButton_mainnet.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(12, 333);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(82, 15);
			this.label13.TabIndex = 42;
			this.label13.Text = "发送数量：";
			// 
			// tb_sats
			// 
			this.tb_sats.Location = new System.Drawing.Point(92, 323);
			this.tb_sats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_sats.Name = "tb_sats";
			this.tb_sats.Size = new System.Drawing.Size(288, 25);
			this.tb_sats.TabIndex = 43;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(386, 333);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(39, 15);
			this.label14.TabIndex = 42;
			this.label14.Text = "sats";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(602, 181);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(142, 15);
			this.label9.TabIndex = 42;
			this.label9.Text = "双击地址跳转网站。";
			// 
			// F_wallet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 407);
			this.Controls.Add(this.radioButton_mainnet);
			this.Controls.Add(this.radioButton_testnet);
			this.Controls.Add(this.tb_wifKey);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.bt_encryptSign);
			this.Controls.Add(this.bt_tx);
			this.Controls.Add(this.bt_utxo);
			this.Controls.Add(this.bt_send);
			this.Controls.Add(this.bt_refreshBalance);
			this.Controls.Add(this.bt_login);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tb_balance);
			this.Controls.Add(this.tb_opReturn);
			this.Controls.Add(this.tb_changeAddress);
			this.Controls.Add(this.tb_destAddress);
			this.Controls.Add(this.tb_address);
			this.Controls.Add(this.tb_pubKeyHash);
			this.Controls.Add(this.tb_compressedPubkey);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.tb_originalKey);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.tb_sats);
			this.Controls.Add(this.tb_ID);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label13);
			this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "F_wallet";
			this.Text = "BSV Testnet Wallet";
			this.Load += new System.EventHandler(this.F_wallet_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_wifKey;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button bt_encryptSign;
		private System.Windows.Forms.Button bt_utxo;
		private System.Windows.Forms.Button bt_refreshBalance;
		private System.Windows.Forms.Button bt_login;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_balance;
		private System.Windows.Forms.TextBox tb_address;
		private System.Windows.Forms.TextBox tb_pubKeyHash;
		private System.Windows.Forms.TextBox tb_compressedPubkey;
		private System.Windows.Forms.TextBox tb_originalKey;
		private System.Windows.Forms.TextBox tb_ID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button bt_tx;
		private System.Windows.Forms.TextBox tb_destAddress;
		private System.Windows.Forms.Button bt_send;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tb_changeAddress;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tb_opReturn;
		private System.Windows.Forms.RadioButton radioButton_testnet;
		private System.Windows.Forms.RadioButton radioButton_mainnet;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tb_sats;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label9;
	}
}

