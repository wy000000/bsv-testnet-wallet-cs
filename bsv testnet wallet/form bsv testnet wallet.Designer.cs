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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_wallet));
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
			this.label13 = new System.Windows.Forms.Label();
			this.tb_sats = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.tb_network = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_wifKey
			// 
			this.tb_wifKey.Location = new System.Drawing.Point(145, 102);
			this.tb_wifKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_wifKey.Name = "tb_wifKey";
			this.tb_wifKey.ReadOnly = true;
			this.tb_wifKey.Size = new System.Drawing.Size(651, 25);
			this.tb_wifKey.TabIndex = 45;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(319, 20);
			this.label8.TabIndex = 56;
			this.label8.Text = "Balance needs to be refreshed manually.";
			// 
			// bt_encryptSign
			// 
			this.bt_encryptSign.Location = new System.Drawing.Point(487, 418);
			this.bt_encryptSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_encryptSign.Name = "bt_encryptSign";
			this.bt_encryptSign.Size = new System.Drawing.Size(207, 28);
			this.bt_encryptSign.TabIndex = 55;
			this.bt_encryptSign.Text = "Sign:Verify Encrypt:Decrypt";
			this.bt_encryptSign.UseVisualStyleBackColor = true;
			this.bt_encryptSign.Click += new System.EventHandler(this.bt_encryptSign_Click);
			// 
			// bt_utxo
			// 
			this.bt_utxo.Location = new System.Drawing.Point(182, 418);
			this.bt_utxo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_utxo.Name = "bt_utxo";
			this.bt_utxo.Size = new System.Drawing.Size(114, 28);
			this.bt_utxo.TabIndex = 54;
			this.bt_utxo.Text = "Coins(UTXOs)";
			this.bt_utxo.UseVisualStyleBackColor = true;
			this.bt_utxo.Click += new System.EventHandler(this.bt_utxo_Click);
			// 
			// bt_refreshBalance
			// 
			this.bt_refreshBalance.Location = new System.Drawing.Point(487, 229);
			this.bt_refreshBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_refreshBalance.Name = "bt_refreshBalance";
			this.bt_refreshBalance.Size = new System.Drawing.Size(128, 28);
			this.bt_refreshBalance.TabIndex = 53;
			this.bt_refreshBalance.Text = "Refresh Balance";
			this.bt_refreshBalance.UseVisualStyleBackColor = true;
			this.bt_refreshBalance.Click += new System.EventHandler(this.bt_refreshBalance_Click);
			// 
			// bt_login
			// 
			this.bt_login.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_login.Location = new System.Drawing.Point(717, 33);
			this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_login.Name = "bt_login";
			this.bt_login.Size = new System.Drawing.Size(79, 28);
			this.bt_login.TabIndex = 52;
			this.bt_login.Text = "Login";
			this.bt_login.UseVisualStyleBackColor = true;
			this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(82, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 17);
			this.label7.TabIndex = 51;
			this.label7.Text = "WifKey:";
			// 
			// tb_balance
			// 
			this.tb_balance.Location = new System.Drawing.Point(145, 229);
			this.tb_balance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_balance.Name = "tb_balance";
			this.tb_balance.ReadOnly = true;
			this.tb_balance.Size = new System.Drawing.Size(289, 25);
			this.tb_balance.TabIndex = 48;
			// 
			// tb_address
			// 
			this.tb_address.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_address.ForeColor = System.Drawing.Color.Blue;
			this.tb_address.Location = new System.Drawing.Point(145, 197);
			this.tb_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_address.Name = "tb_address";
			this.tb_address.ReadOnly = true;
			this.tb_address.Size = new System.Drawing.Size(470, 25);
			this.tb_address.TabIndex = 49;
			this.tb_address.TextChanged += new System.EventHandler(this.tb_address_TextChanged);
			this.tb_address.DoubleClick += new System.EventHandler(this.tb_address_DoubleClick);
			// 
			// tb_pubKeyHash
			// 
			this.tb_pubKeyHash.Location = new System.Drawing.Point(145, 165);
			this.tb_pubKeyHash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_pubKeyHash.Name = "tb_pubKeyHash";
			this.tb_pubKeyHash.ReadOnly = true;
			this.tb_pubKeyHash.Size = new System.Drawing.Size(651, 25);
			this.tb_pubKeyHash.TabIndex = 47;
			// 
			// tb_compressedPubkey
			// 
			this.tb_compressedPubkey.Location = new System.Drawing.Point(145, 133);
			this.tb_compressedPubkey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_compressedPubkey.Name = "tb_compressedPubkey";
			this.tb_compressedPubkey.ReadOnly = true;
			this.tb_compressedPubkey.Size = new System.Drawing.Size(651, 25);
			this.tb_compressedPubkey.TabIndex = 46;
			// 
			// tb_originalKey
			// 
			this.tb_originalKey.Location = new System.Drawing.Point(145, 70);
			this.tb_originalKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_originalKey.Name = "tb_originalKey";
			this.tb_originalKey.ReadOnly = true;
			this.tb_originalKey.Size = new System.Drawing.Size(651, 25);
			this.tb_originalKey.TabIndex = 44;
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(145, 38);
			this.tb_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.ReadOnly = true;
			this.tb_ID.Size = new System.Drawing.Size(289, 25);
			this.tb_ID.TabIndex = 43;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(80, 237);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 17);
			this.label6.TabIndex = 42;
			this.label6.Text = "Balance:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(79, 205);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 17);
			this.label5.TabIndex = 41;
			this.label5.Text = "Address:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 173);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 17);
			this.label4.TabIndex = 40;
			this.label4.Text = "PubKeyHash:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 17);
			this.label3.TabIndex = 39;
			this.label3.Text = "Compressed PubKey:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 38;
			this.label2.Text = "Raw Key:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(112, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 17);
			this.label1.TabIndex = 37;
			this.label1.Text = "ID:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(529, 12);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(95, 17);
			this.linkLabel1.TabIndex = 36;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Testnet Faucet";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// bt_tx
			// 
			this.bt_tx.Location = new System.Drawing.Point(319, 418);
			this.bt_tx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_tx.Name = "bt_tx";
			this.bt_tx.Size = new System.Drawing.Size(114, 28);
			this.bt_tx.TabIndex = 54;
			this.bt_tx.Text = "Transactions";
			this.bt_tx.UseVisualStyleBackColor = true;
			this.bt_tx.Click += new System.EventHandler(this.bt_tx_Click);
			// 
			// tb_destAddress
			// 
			this.tb_destAddress.Location = new System.Drawing.Point(145, 275);
			this.tb_destAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_destAddress.Name = "tb_destAddress";
			this.tb_destAddress.Size = new System.Drawing.Size(651, 25);
			this.tb_destAddress.TabIndex = 49;
			// 
			// bt_send
			// 
			this.bt_send.Location = new System.Drawing.Point(487, 369);
			this.bt_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_send.Name = "bt_send";
			this.bt_send.Size = new System.Drawing.Size(60, 28);
			this.bt_send.TabIndex = 53;
			this.bt_send.Text = "Send";
			this.bt_send.UseVisualStyleBackColor = true;
			this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(84, 283);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 17);
			this.label10.TabIndex = 42;
			this.label10.Text = "Send to:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(31, 314);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(108, 17);
			this.label11.TabIndex = 42;
			this.label11.Text = "Change Address:";
			// 
			// tb_changeAddress
			// 
			this.tb_changeAddress.Location = new System.Drawing.Point(145, 306);
			this.tb_changeAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_changeAddress.Name = "tb_changeAddress";
			this.tb_changeAddress.Size = new System.Drawing.Size(651, 25);
			this.tb_changeAddress.TabIndex = 49;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(60, 345);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(79, 17);
			this.label12.TabIndex = 42;
			this.label12.Text = "OP_Return:";
			// 
			// tb_opReturn
			// 
			this.tb_opReturn.Location = new System.Drawing.Point(145, 336);
			this.tb_opReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_opReturn.Name = "tb_opReturn";
			this.tb_opReturn.Size = new System.Drawing.Size(651, 25);
			this.tb_opReturn.TabIndex = 49;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(81, 377);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(58, 17);
			this.label13.TabIndex = 42;
			this.label13.Text = "Amount:";
			// 
			// tb_sats
			// 
			this.tb_sats.Location = new System.Drawing.Point(145, 369);
			this.tb_sats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_sats.Name = "tb_sats";
			this.tb_sats.Size = new System.Drawing.Size(288, 25);
			this.tb_sats.TabIndex = 43;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(439, 380);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(31, 17);
			this.label14.TabIndex = 42;
			this.label14.Text = "sats";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(454, 46);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(63, 17);
			this.label15.TabIndex = 37;
			this.label15.Text = "Network:";
			// 
			// tb_network
			// 
			this.tb_network.Location = new System.Drawing.Point(523, 37);
			this.tb_network.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_network.Name = "tb_network";
			this.tb_network.ReadOnly = true;
			this.tb_network.Size = new System.Drawing.Size(171, 25);
			this.tb_network.TabIndex = 43;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(439, 240);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(31, 17);
			this.label16.TabIndex = 42;
			this.label16.Text = "sats";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(621, 197);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(175, 57);
			this.label9.TabIndex = 57;
			this.label9.Text = "Double click on the address to jump to the website.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::bsv_testnet_wallet.Properties.Resources.bsv_testnet_wallet_127x127;
			this.pictureBox1.Location = new System.Drawing.Point(719, 369);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(77, 77);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 58;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// F_wallet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(811, 461);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label9);
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
			this.Controls.Add(this.tb_network);
			this.Controls.Add(this.tb_ID);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "F_wallet";
			this.Text = "BSV Testnet Wallet";
			this.Load += new System.EventHandler(this.F_wallet_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tb_sats;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox tb_network;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

