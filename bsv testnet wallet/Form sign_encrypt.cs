using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitcoinSVCryptor;

namespace bsv_testnet_wallet
{
	public partial class F_s_e : Form
	{

		public F_s_e(Form form=null)
		{
			InitializeComponent();
		}

		private void F_s_e_Load(object sender, EventArgs e)
		{
			if (Program.bsvTestWallet != null && Program.bsvTestWallet.WalletType != Class_wallet.walletTypeAddress)
			{
				tb_wifKey.Text = Program.bsvTestWallet.WifKeyStr;
				tb_compressedPubkey.Text = Program.bsvTestWallet.CompressedPubKeyStr;
			}
		}

		private void bt_sign_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			try
			{
				tb_sig_cipher.Text = BitcoinSVCryptor_class.sign(tb_wifKey.Text, tb_plaintext.Text);
			}
			catch (Exception ex)
			{
				// Display the exception type and message
				MessageBox.Show(ex.GetType().Name + ", " + ex.Message, "Info", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			this.Enabled = true;
		}

		private void bt_verify_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			try
			{
				if (BitcoinSVCryptor_class.verifySignature(tb_compressedPubkey.Text, tb_plaintext.Text,
					tb_sig_cipher.Text))
					MessageBox.Show("Signature verification successful!", "info", MessageBoxButtons.OK,
						MessageBoxIcon.Exclamation);
				else
					MessageBox.Show("Signature verification failed!", "info", MessageBoxButtons.OK,
						MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.GetType().Name + ", " + ex.Message, "Info", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			this.Enabled = true;
		}

		private void bt_encrypt_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			try
			{
				tb_sig_cipher.Text = BitcoinSVCryptor_class.ECCEncrypt(tb_compressedPubkey.Text, tb_plaintext.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.GetType().Name + ", " + ex.Message, "Info", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			this.Enabled = true;
		}

		private void bt_decrypt_Click(object sender, EventArgs e)
		{
			this.Enabled = false;
			try
			{
				tb_plaintext.Text = BitcoinSVCryptor_class.ECCDecrypt(tb_wifKey.Text, tb_sig_cipher.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.GetType().Name + ", " + ex.Message, "Info", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			this.Enabled = true;
		}
	}
}
