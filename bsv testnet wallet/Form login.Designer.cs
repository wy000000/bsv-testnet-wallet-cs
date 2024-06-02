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
			this.SuspendLayout();
			// 
			// tb_wifKey
			// 
			this.tb_wifKey.Location = new System.Drawing.Point(106, 40);
			this.tb_wifKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_wifKey.Name = "tb_wifKey";
			this.tb_wifKey.ReadOnly = true;
			this.tb_wifKey.Size = new System.Drawing.Size(619, 25);
			this.tb_wifKey.TabIndex = 56;
			// 
			// bt_login
			// 
			this.bt_login.Location = new System.Drawing.Point(365, 98);
			this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bt_login.Name = "bt_login";
			this.bt_login.Size = new System.Drawing.Size(60, 25);
			this.bt_login.TabIndex = 59;
			this.bt_login.Text = "登录";
			this.bt_login.UseVisualStyleBackColor = true;
			this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
			// 
			// tb_address
			// 
			this.tb_address.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tb_address.Location = new System.Drawing.Point(106, 69);
			this.tb_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_address.Name = "tb_address";
			this.tb_address.ReadOnly = true;
			this.tb_address.Size = new System.Drawing.Size(619, 25);
			this.tb_address.TabIndex = 57;
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(106, 11);
			this.tb_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(619, 25);
			this.tb_ID.TabIndex = 55;
			this.tb_ID.Text = "100000";
			// 
			// rb_id
			// 
			this.rb_id.AutoSize = true;
			this.rb_id.Checked = true;
			this.rb_id.Location = new System.Drawing.Point(12, 17);
			this.rb_id.Name = "rb_id";
			this.rb_id.Size = new System.Drawing.Size(58, 19);
			this.rb_id.TabIndex = 60;
			this.rb_id.TabStop = true;
			this.rb_id.Text = "学号";
			this.rb_id.UseVisualStyleBackColor = true;
			this.rb_id.CheckedChanged += new System.EventHandler(this.rb_id_CheckedChanged);
			// 
			// rb_wifKey
			// 
			this.rb_wifKey.AutoSize = true;
			this.rb_wifKey.Location = new System.Drawing.Point(12, 46);
			this.rb_wifKey.Name = "rb_wifKey";
			this.rb_wifKey.Size = new System.Drawing.Size(88, 19);
			this.rb_wifKey.TabIndex = 60;
			this.rb_wifKey.Text = "钱包密钥";
			this.rb_wifKey.UseVisualStyleBackColor = true;
			this.rb_wifKey.CheckedChanged += new System.EventHandler(this.rb_wifKey_CheckedChanged);
			// 
			// rb_address
			// 
			this.rb_address.AutoSize = true;
			this.rb_address.Location = new System.Drawing.Point(12, 75);
			this.rb_address.Name = "rb_address";
			this.rb_address.Size = new System.Drawing.Size(58, 19);
			this.rb_address.TabIndex = 60;
			this.rb_address.Text = "地址";
			this.rb_address.UseVisualStyleBackColor = true;
			this.rb_address.CheckedChanged += new System.EventHandler(this.rb_address_CheckedChanged);
			// 
			// F_login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 135);
			this.Controls.Add(this.rb_address);
			this.Controls.Add(this.rb_wifKey);
			this.Controls.Add(this.rb_id);
			this.Controls.Add(this.tb_wifKey);
			this.Controls.Add(this.bt_login);
			this.Controls.Add(this.tb_address);
			this.Controls.Add(this.tb_ID);
			this.Name = "F_login";
			this.Text = "登录";
			this.Load += new System.EventHandler(this.F_login_Load);
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
	}
}