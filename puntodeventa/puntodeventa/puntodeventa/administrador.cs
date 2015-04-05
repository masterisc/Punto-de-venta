using System;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{

	public partial class SuperUsuario : Form
	{
		public SuperUsuario()
		{
			InitializeComponent();
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void ModCajero(object sender, EventArgs e)
		{
			
		}
		void ModAdmin(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
	  		MainForm frm1 = new MainForm();
			frm1.Show();
			this.Hide();
		}
		void Button3Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true) {
				if (comboBox1.Text == "Agregar...") {
				AgregarCajero Acajero = new AgregarCajero();
				Acajero.Show();
				}
				else if (comboBox1.Text == "") 
					MessageBox.Show("Elija una accion a realizar","ERROR");
			}
			 if (radioButton2.Checked == true) {
				if (comboBox1.Text == "Agregar...") {
				AgregarAdmin Aadmin = new AgregarAdmin();
				Aadmin.Show();
			}
				else if (comboBox1.Text == "") 
					MessageBox.Show("Elija una accion a realizar","ERROR");
				else if (comboBox1.Text == "Editar...") {
					
					EditarCajero Edcajero = new EditarCajero();
					Edcajero.Show();
				}
				else if (comboBox1.Text == "Eliminar...") {
					
					
				}
				
		}
		}
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			
		}
		void SuperUsuarioLoad(object sender, EventArgs e)
		{
	
		}
	}
}
