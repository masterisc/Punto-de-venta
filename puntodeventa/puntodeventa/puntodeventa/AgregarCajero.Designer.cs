﻿/*
 * Created by SharpDevelop.
 * User: FAMILIA
 * Date: 04/04/2015
 * Time: 11:28 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace puntodeventa
{
	partial class AgregarCajero
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Guardar;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Guardar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// Guardar
			// 
			this.Guardar.Location = new System.Drawing.Point(54, 213);
			this.Guardar.Name = "Guardar";
			this.Guardar.Size = new System.Drawing.Size(75, 23);
			this.Guardar.TabIndex = 0;
			this.Guardar.Text = "Guardar";
			this.Guardar.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(206, 213);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(29, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Matricula:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(29, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nombre de usuario:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(30, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Contraseña:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(29, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(306, 20);
			this.textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(29, 73);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(133, 20);
			this.textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(30, 112);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(132, 20);
			this.textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(30, 153);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 10;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(30, 176);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(100, 23);
			this.linkLabel1.TabIndex = 11;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Ayuda";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// AgregarCajero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(347, 262);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Guardar);
			this.Name = "AgregarCajero";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AgregarCajero";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
