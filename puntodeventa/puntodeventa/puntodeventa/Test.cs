using System;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{
	public partial class Cajero : Form
	{
		public Cajero()
		{
			InitializeComponent();
		}
		void IdProducto(object sender, EventArgs e)
		{
			
		}
		void CerrarSesion(object sender, EventArgs e)
		{
			MainForm frm1 = new MainForm();
			frm1.Show();
			this.Hide();	
		}
		void CancelarVenta(object sender, EventArgs e)
		{
	
		}
		void BotonPago(object sender, EventArgs e)
		{
	
		}
		void ListaCompra(object sender, EventArgs e)
		{
	
		}
	}
}
