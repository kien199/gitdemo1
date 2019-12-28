using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatMMT
{
	public partial class Form1 : Form
	{
		Thread thread;
		int[] a = { 128, 64, 32, 16, 8, 4, 2, 1};
		public Form1()
		{
			InitializeComponent();
			//txInput.KeyPress += (o, e) => { if (!char.IsLetter(e.KeyChar) && e.KeyChar!='\b') e.Handled = true; };
			txInput.TextChanged += (o, e) => { txResCheckSum.Text = textBox1.Text = null; lbOutput.Items.Clear(); };
			//FormClosing += (o, e) => { Hide(); e.Cancel = true; };
			txKey.Text = "10101";
		}

		string getBit(char c)
		{
			StringBuilder res = new StringBuilder();
			int i = 0, temp = c;
			while (temp >0)
			{
				while (i<8 && temp < a[i]) { i++; res.Append("0"); }
				if (i >= 8) break;
				temp -= a[i];
				res.Append("1");
				i++;
			}
			while (res.Length < 8) res.Append("0");
			return res.ToString();
		}

		private void btGet_Click(object sender, EventArgs e)
		{
			if (txInput.Text.Length == 1)
			{
				textBox1.Text = MySolution.toBinary(txInput.Text[0]);
				return;
			}
			foreach (char c in txInput.Text)
			{
				lbOutput.Items.Add(c.ToString()+" : "+MySolution.toBinary(c) + " ( "+(int)c+" )");
			}
			//MessageBox.Show(getBit(txInput.Text[0]));
		}

		private void btCheckSum_Click(object sender, EventArgs e)
		{
			txResCheckSum.Text = MySolution.getCheckSum(txInput.Text);
			
		}

		private void btSolve_Click(object sender, EventArgs e)
		{
			txRes.Text = MySolution.getCRC(MySolution.getDataCRC(txData.Text), txKey.Text);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string input = txInputHm.Text.Trim().Replace(" ","");
			//MessageBox.Show(input);
			if (!checkBox1.Checked)
			{
				txResHamming.Text = MySolution.getHammingEndcode(input);
				lbRes.Text = null;
				return;
			}
			txResHamming.Text = (MySolution.DectectAndFix(input));
			//txResHamming.Text = HammingEncodeing.DectectAndFix(input);
			lbRes.Text = MySolution.toChar(txResHamming.Text.Split('|')[0]).ToString();
		}

        private void TxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxInputHm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
