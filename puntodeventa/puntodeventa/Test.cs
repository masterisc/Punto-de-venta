/*
 * Created by SharpDevelop.
 * User: FAMILIA
 * Date: 22/02/2015
 * Time: 09:49 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace puntodeventa
{
	/// <summary>
	/// Description of Test.
	/// </summary>
	public partial class Test : Form
	{
		public Test()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
	
		void Button1Click(object sender, EventArgs e)
		{
			MainForm frm1 = new MainForm();
    		frm1.Show();
    		
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
	 
	}
}
