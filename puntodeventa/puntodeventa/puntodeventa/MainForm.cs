using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{

	public partial class MainForm : Form
	{
		
		//bool tipousuario = false;
		
		public MainForm()
		{
			InitializeComponent();
			textBox2.PasswordChar = '*';
			textBox2.MaxLength = 10;
		}
		
		
		void Usuario(object sender, EventArgs e)
		{ 		
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			pictureBox1.Image = Image.FromFile(@"C:\Users\FAMILIA\Desktop\oracle.jpg");
		}
		void Button2Click(object sender, EventArgs e)
		{
			 if(textBox1.Text != "Eduardo")
				MessageBox.Show("Usuario incorrecto!!!", "ERROR");
			
			else if(textBox2.Text != "Cutonala")
				MessageBox.Show("Contraseña incorrecta!!!", "ERROR");			
			else if (comboBox1.Text == "")
				MessageBox.Show("Seleccione tipo de usuario valido!!!", "ERROR");
			else if(comboBox1.Text == "Administrador") {
				Admin frm3 = new Admin();
    			frm3.Show();
    			this.Hide();
			}
			else if (comboBox1.Text == "Cajero"){
				Cajero frm = new Cajero();
				frm.Show();
				this.Hide();
			}
			else if (comboBox1.Text == "Soporte tecnico") {
				SuperUsuario frm2 = new SuperUsuario();
    			frm2.Show();
    			this.Hide();
				
			}
			
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void OlvidoContraseña(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Contacta a tu administrador!!!","ERROR");
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void ToolStripMenuItem4Click(object sender, EventArgs e)
		{
				MessageBox.Show("\t\tAutores: \n\tEduardo Mora Martínez\t\n\tOscar Alfredo Flores Solano\t\n\twww.ejemplo.com.mx\t","INFORMACION GENERAL");

		}
		void ToolStripMenuItem2Click(object sender, EventArgs e)
		{
			System.Environment.Exit(0);
		}
	}
}

