using System;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{

	public partial class Admin : Form
	{
		public Admin()
		{
			InitializeComponent();
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			MainForm frm1 = new MainForm();
			frm1.Show();
			this.Hide();
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true) {
				AgregarCajero Acajero = new AgregarCajero();
				Acajero.Show();
				
			}
		if (radioButton2.Checked == true) {
				EditarCajero Edcajero = new EditarCajero();
				Edcajero.Show();
				
			}
			if (radioButton3.Checked == true) {
				ElimiCajero Elcajero = new ElimiCajero();
				Elcajero.Show();
				
			}
		}
	}
}
