using System;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{

	public partial class EditarCajero : Form
	{
		public EditarCajero()
		{
			InitializeComponent();
		}
		 void Button1Click(object sender, EventArgs e)
		{
			EditarCajero2 Edcajeros = new EditarCajero2();
			Edcajeros.MdiParent = this;
			Edcajeros.Show();
		}
	}
}
