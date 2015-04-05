using System;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{
	public partial class AgregarAdmin : Form
	{
		public AgregarAdmin()
		{
			
			InitializeComponent();
			
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("La clave tiene que ser Alfanumerica con un minnimo de 8 digitos y maximo 10 digitos", "AYUDA CLAVE");
		}
		void Button2Click(object sender, EventArgs e)
		{
    			this.Hide();
		}
	}
}
