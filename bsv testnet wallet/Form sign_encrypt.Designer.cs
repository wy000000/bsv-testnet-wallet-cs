namespace bsv_testnet_wallet
{
	partial class F_s_e
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
			this.label7 = new System.Windows.Forms.Label();
			this.tb_compressedPubkey = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_plaintext = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_sig_cipher = new System.Windows.Forms.TextBox();
			this.bt_sign = new System.Windows.Forms.Button();
			this.bt_verify = new System.Windows.Forms.Button();
			this.bt_encrypt = new System.Windows.Forms.Button();
			this.bt_decrypt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tb_wifKey
			// 
			this.tb_wifKey.Location = new System.Drawing.Point(94, 16);
			this.tb_wifKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_wifKey.Name = "tb_wifKey";
			this.tb_wifKey.Size = new System.Drawing.Size(651, 25);
			this.tb_wifKey.TabIndex = 53;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 17);
			this.label7.TabIndex = 55;
			this.label7.Text = "WifKey:";
			// 
			// tb_compressedPubkey
			// 
			this.tb_compressedPubkey.Location = new System.Drawing.Point(94, 48);
			this.tb_compressedPubkey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tb_compressedPubkey.Name = "tb_compressedPubkey";
			this.tb_compressedPubkey.Size = new System.Drawing.Size(651, 25);
			this.tb_compressedPubkey.TabIndex = 54;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 17);
			this.label3.TabIndex = 52;
			this.label3.Text = "PubKey:";
			// 
			// tb_plaintext
			// 
			this.tb_plaintext.Location = new System.Drawing.Point(94, 115);
			this.tb_plaintext.Multiline = true;
			this.tb_plaintext.Name = "tb_plaintext";
			this.tb_plaintext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tb_plaintext.Size = new System.Drawing.Size(651, 221);
			this.tb_plaintext.TabIndex = 56;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 114);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 17);
			this.label1.TabIndex = 52;
			this.label1.Text = "Plaintext:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 342);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 34);
			this.label2.TabIndex = 52;
			this.label2.Text = "Signature or\r\nCiphertext:";
			// 
			// tb_sig_cipher
			// 
			this.tb_sig_cipher.Location = new System.Drawing.Point(94, 342);
			this.tb_sig_cipher.Multiline = true;
			this.tb_sig_cipher.Name = "tb_sig_cipher";
			this.tb_sig_cipher.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tb_sig_cipher.Size = new System.Drawing.Size(651, 221);
			this.tb_sig_cipher.TabIndex = 56;
			// 
			// bt_sign
			// 
			this.bt_sign.Location = new System.Drawing.Point(94, 82);
			this.bt_sign.Name = "bt_sign";
			this.bt_sign.Size = new System.Drawing.Size(75, 28);
			this.bt_sign.TabIndex = 57;
			this.bt_sign.Text = "Sign";
			this.bt_sign.UseVisualStyleBackColor = true;
			this.bt_sign.Click += new System.EventHandler(this.bt_sign_Click);
			// 
			// bt_verify
			// 
			this.bt_verify.Location = new System.Drawing.Point(175, 82);
			this.bt_verify.Name = "bt_verify";
			this.bt_verify.Size = new System.Drawing.Size(75, 28);
			this.bt_verify.TabIndex = 57;
			this.bt_verify.Text = "Verify";
			this.bt_verify.UseVisualStyleBackColor = true;
			this.bt_verify.Click += new System.EventHandler(this.bt_verify_Click);
			// 
			// bt_encrypt
			// 
			this.bt_encrypt.Location = new System.Drawing.Point(302, 82);
			this.bt_encrypt.Name = "bt_encrypt";
			this.bt_encrypt.Size = new System.Drawing.Size(75, 28);
			this.bt_encrypt.TabIndex = 57;
			this.bt_encrypt.Text = "Encrypt";
			this.bt_encrypt.UseVisualStyleBackColor = true;
			this.bt_encrypt.Click += new System.EventHandler(this.bt_encrypt_Click);
			// 
			// bt_decrypt
			// 
			this.bt_decrypt.Location = new System.Drawing.Point(383, 82);
			this.bt_decrypt.Name = "bt_decrypt";
			this.bt_decrypt.Size = new System.Drawing.Size(75, 28);
			this.bt_decrypt.TabIndex = 57;
			this.bt_decrypt.Text = "Decrypt";
			this.bt_decrypt.UseVisualStyleBackColor = true;
			this.bt_decrypt.Click += new System.EventHandler(this.bt_decrypt_Click);
			// 
			// F_s_e
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 577);
			this.Controls.Add(this.bt_decrypt);
			this.Controls.Add(this.bt_encrypt);
			this.Controls.Add(this.bt_verify);
			this.Controls.Add(this.bt_sign);
			this.Controls.Add(this.tb_sig_cipher);
			this.Controls.Add(this.tb_plaintext);
			this.Controls.Add(this.tb_wifKey);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_compressedPubkey);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaximizeBox = false;
			this.Name = "F_s_e";
			this.Text = "Sign:Verify Encrypt:Decrypt";
			this.Load += new System.EventHandler(this.F_s_e_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_wifKey;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_compressedPubkey;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_plaintext;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_sig_cipher;
		private System.Windows.Forms.Button bt_sign;
		private System.Windows.Forms.Button bt_verify;
		private System.Windows.Forms.Button bt_encrypt;
		private System.Windows.Forms.Button bt_decrypt;
	}
}