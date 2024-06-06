namespace bsv_testnet_wallet
{
	partial class F_login
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tb_wifKey = new System.Windows.Forms.TextBox();
			this.bt_login = new System.Windows.Forms.Button();
			this.tb_address = new System.Windows.Forms.TextBox();
			this.tb_ID = new System.Windows.Forms.TextBox();
			this.rb_id = new System.Windows.Forms.RadioButton();
			this.rb_wifKey = new System.Windows.Forms.RadioButton();
			this.rb_address = new System.Windows.Forms.RadioButton();
			this.radioButton_mainnet = new System.Windows.Forms.RadioButton();
			this.radioButton_testnet = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_wifKey
			// 
			this.tb_wifKey.Location = new System.Drawing.Point(93, 117);
			this.tb_wifKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_wifKey.Name = "tb_wifKey";
			this.tb_wifKey.ReadOnly = true;
			this.tb_wifKey.Size = new System.Drawing.Size(619, 25);
			this.tb_wifKey.TabIndex = 56;
			// 
			// bt_login
			// 
			this.bt_login.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_login.Location = new System.Drawing.Point(174, 17);
			this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_login.Name = "bt_login";
			this.bt_login.Size = new System.Drawing.Size(72, 28);
			this.bt_login.TabIndex = 59;
			this.bt_login.Text = "Login";
			this.bt_login.UseVisualStyleBackColor = true;
			this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
			// 
			// tb_address
			// 
			this.tb_address.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tb_address.Location = new System.Drawing.Point(93, 150);
			this.tb_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_address.Name = "tb_address";
			this.tb_address.ReadOnly = true;
			this.tb_address.Size = new System.Drawing.Size(619, 25);
			this.tb_address.TabIndex = 57;
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(93, 85);
			this.tb_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(619, 25);
			this.tb_ID.TabIndex = 55;
			// 
			// rb_id
			// 
			this.rb_id.AutoSize = true;
			this.rb_id.Checked = true;
			this.rb_id.Location = new System.Drawing.Point(6, 88);
			this.rb_id.Name = "rb_id";
			this.rb_id.Size = new System.Drawing.Size(48, 21);
			this.rb_id.TabIndex = 60;
			this.rb_id.TabStop = true;
			this.rb_id.Text = "ID:";
			this.rb_id.UseVisualStyleBackColor = true;
			this.rb_id.CheckedChanged += new System.EventHandler(this.rb_id_CheckedChanged);
			// 
			// rb_wifKey
			// 
			this.rb_wifKey.AutoSize = true;
			this.rb_wifKey.Location = new System.Drawing.Point(6, 121);
			this.rb_wifKey.Name = "rb_wifKey";
			this.rb_wifKey.Size = new System.Drawing.Size(78, 21);
			this.rb_wifKey.TabIndex = 60;
			this.rb_wifKey.Text = "WifKey:";
			this.rb_wifKey.UseVisualStyleBackColor = true;
			this.rb_wifKey.CheckedChanged += new System.EventHandler(this.rb_wifKey_CheckedChanged);
			// 
			// rb_address
			// 
			this.rb_address.AutoSize = true;
			this.rb_address.Location = new System.Drawing.Point(6, 154);
			this.rb_address.Name = "rb_address";
			this.rb_address.Size = new System.Drawing.Size(81, 21);
			this.rb_address.TabIndex = 60;
			this.rb_address.Text = "Address:";
			this.rb_address.UseVisualStyleBackColor = true;
			this.rb_address.CheckedChanged += new System.EventHandler(this.rb_address_CheckedChanged);
			// 
			// radioButton_mainnet
			// 
			this.radioButton_mainnet.AutoSize = true;
			this.radioButton_mainnet.Location = new System.Drawing.Point(80, 24);
			this.radioButton_mainnet.Name = "radioButton_mainnet";
			this.radioButton_mainnet.Size = new System.Drawing.Size(75, 21);
			this.radioButton_mainnet.TabIndex = 62;
			this.radioButton_mainnet.Text = "mainnet";
			this.radioButton_mainnet.UseVisualStyleBackColor = true;
			// 
			// radioButton_testnet
			// 
			this.radioButton_testnet.AutoSize = true;
			this.radioButton_testnet.Checked = true;
			this.radioButton_testnet.Location = new System.Drawing.Point(6, 24);
			this.radioButton_testnet.Name = "radioButton_testnet";
			this.radioButton_testnet.Size = new System.Drawing.Size(68, 21);
			this.radioButton_testnet.TabIndex = 61;
			this.radioButton_testnet.TabStop = true;
			this.radioButton_testnet.Text = "testnet";
			this.radioButton_testnet.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton_testnet);
			this.groupBox1.Controls.Add(this.radioButton_mainnet);
			this.groupBox1.Controls.Add(this.bt_login);
			this.groupBox1.Location = new System.Drawing.Point(93, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(262, 59);
			this.groupBox1.TabIndex = 63;
			this.groupBox1.TabStop = false;
			// 
			// F_login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(733, 192);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.rb_address);
			this.Controls.Add(this.rb_wifKey);
			this.Controls.Add(this.rb_id);
			this.Controls.Add(this.tb_wifKey);
			this.Controls.Add(this.tb_address);
			this.Controls.Add(this.tb_ID);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.Name = "F_login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.F_login_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_wifKey;
		private System.Windows.Forms.Button bt_login;
		private System.Windows.Forms.TextBox tb_address;
		private System.Windows.Forms.TextBox tb_ID;
		private System.Windows.Forms.RadioButton rb_id;
		private System.Windows.Forms.RadioButton rb_wifKey;
		private System.Windows.Forms.RadioButton rb_address;
		private System.Windows.Forms.RadioButton radioButton_mainnet;
		private System.Windows.Forms.RadioButton radioButton_testnet;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}