using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms0000
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		/// <summary>
		/// Generates a random integer based on the min and Max Textboxes
		/// </summary>
		/// <variable name = "min"> The minimum number allowed in the generation.</variable>
		/// <variable name = "max"> The maximum number allowed in the generation<./variable>
		private void GenButton_Click(object sender, EventArgs e)
		{
			try
			{
				int min = Convert.ToInt32(MinInput.Text); 
				int max = Convert.ToInt32(MaxInput.Text);
				string output = string.Empty;
				Random random = new Random();

				if (useFractions.Checked)
				{
					output = (Convert.ToDouble(random.Next(min * 10, (max * 10) + 1)) / 10).ToString();
				}
				else
				{
					output = random.Next(min, max + 1).ToString();
				}

				OutputLabel.Text = output;
			}
			catch (Exception)
			{
				MessageBox.Show("Please use Whole integers for this because I haven't implemented floating point numbers and who needs them in a Random number generator anyway");
				return;
			}
		}

		/// <summary>
		/// if someone puts the funny number in the thing then it says "Nice"
		/// </summary>

		private void FunnyNumberCheck()
		{
			if (MinInput.Text == "69" && MaxInput.Text == "420")
			{
				MessageBox.Show("Nice");
			}
		}

		private void MinInput_TextChanged(object sender, EventArgs e)
		{
			FunnyNumberCheck();
		}

		private void MaxInput_TextChanged(object sender, EventArgs e)
		{
			FunnyNumberCheck();
		}
	}
}
