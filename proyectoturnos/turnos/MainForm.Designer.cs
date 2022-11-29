/*
 * Created by SharpDevelop.
 * User: david
 * Date: 08/10/2021
 * Time: 17:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace turnos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox Nombre;
		private System.Windows.Forms.TextBox DNI;
		private System.Windows.Forms.TextBox ObraSocial;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MonthCalendar dia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Hora;
		private System.Windows.Forms.TextBox fefe;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label verdia;
		private System.Windows.Forms.Label h08;
		private System.Windows.Forms.Label h09;
		private System.Windows.Forms.Label h10;
		private System.Windows.Forms.Label h11;
		private System.Windows.Forms.Label h15;
		private System.Windows.Forms.Label h16;
		private System.Windows.Forms.Label h17;
		private System.Windows.Forms.Label h18;
		private System.Windows.Forms.ComboBox SelectHora;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button borraturno;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.Nombre = new System.Windows.Forms.TextBox();
			this.DNI = new System.Windows.Forms.TextBox();
			this.ObraSocial = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dia = new System.Windows.Forms.MonthCalendar();
			this.label4 = new System.Windows.Forms.Label();
			this.Hora = new System.Windows.Forms.ComboBox();
			this.fefe = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.verdia = new System.Windows.Forms.Label();
			this.h08 = new System.Windows.Forms.Label();
			this.h09 = new System.Windows.Forms.Label();
			this.h10 = new System.Windows.Forms.Label();
			this.h11 = new System.Windows.Forms.Label();
			this.h15 = new System.Windows.Forms.Label();
			this.h16 = new System.Windows.Forms.Label();
			this.h17 = new System.Windows.Forms.Label();
			this.h18 = new System.Windows.Forms.Label();
			this.SelectHora = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.borraturno = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.DarkGreen;
			this.button1.Location = new System.Drawing.Point(330, 177);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.DimGray;
			this.button2.Location = new System.Drawing.Point(442, 177);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(65, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Nombre
			// 
			this.Nombre.Location = new System.Drawing.Point(8, 41);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(227, 22);
			this.Nombre.TabIndex = 2;
			// 
			// DNI
			// 
			this.DNI.Location = new System.Drawing.Point(8, 88);
			this.DNI.Name = "DNI";
			this.DNI.Size = new System.Drawing.Size(188, 22);
			this.DNI.TabIndex = 3;
			// 
			// ObraSocial
			// 
			this.ObraSocial.Location = new System.Drawing.Point(8, 139);
			this.ObraSocial.Name = "ObraSocial";
			this.ObraSocial.Size = new System.Drawing.Size(227, 22);
			this.ObraSocial.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nombre y Apellido";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 10);
			this.label2.TabIndex = 6;
			this.label2.Text = "DNI";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Obra Social";
			// 
			// dia
			// 
			this.dia.Location = new System.Drawing.Point(260, 6);
			this.dia.MaxDate = new System.DateTime(2025, 10, 11, 0, 0, 0, 0);
			this.dia.MinDate = new System.DateTime(2021, 10, 11, 0, 0, 0, 0);
			this.dia.Name = "dia";
			this.dia.TabIndex = 9;
			this.dia.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DiaDateChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(198, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "Hora";
			// 
			// Hora
			// 
			this.Hora.FormattingEnabled = true;
			this.Hora.Location = new System.Drawing.Point(52, 167);
			this.Hora.Name = "Hora";
			this.Hora.Size = new System.Drawing.Size(45, 24);
			this.Hora.TabIndex = 14;
			// 
			// fefe
			// 
			this.fefe.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fefe.Location = new System.Drawing.Point(12, 220);
			this.fefe.Name = "fefe";
			this.fefe.Size = new System.Drawing.Size(495, 22);
			this.fefe.TabIndex = 16;
			this.fefe.TextChanged += new System.EventHandler(this.FefeTextChanged);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DarkRed;
			this.label6.Location = new System.Drawing.Point(10, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(314, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "Faltan Datos";
			this.label6.Visible = false;
			// 
			// verdia
			// 
			this.verdia.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.verdia.ForeColor = System.Drawing.Color.DarkRed;
			this.verdia.Location = new System.Drawing.Point(12, 245);
			this.verdia.Name = "verdia";
			this.verdia.Size = new System.Drawing.Size(456, 23);
			this.verdia.TabIndex = 19;
			this.verdia.Text = "-";
			// 
			// h08
			// 
			this.h08.Location = new System.Drawing.Point(9, 18);
			this.h08.Name = "h08";
			this.h08.Size = new System.Drawing.Size(447, 15);
			this.h08.TabIndex = 20;
			this.h08.Text = "08hs";
			// 
			// h09
			// 
			this.h09.Location = new System.Drawing.Point(9, 33);
			this.h09.Name = "h09";
			this.h09.Size = new System.Drawing.Size(466, 15);
			this.h09.TabIndex = 21;
			this.h09.Text = "09hs";
			// 
			// h10
			// 
			this.h10.Location = new System.Drawing.Point(9, 48);
			this.h10.Name = "h10";
			this.h10.Size = new System.Drawing.Size(466, 15);
			this.h10.TabIndex = 22;
			this.h10.Text = "10hs";
			// 
			// h11
			// 
			this.h11.Location = new System.Drawing.Point(9, 63);
			this.h11.Name = "h11";
			this.h11.Size = new System.Drawing.Size(466, 15);
			this.h11.TabIndex = 23;
			this.h11.Text = "11hs";
			// 
			// h15
			// 
			this.h15.Location = new System.Drawing.Point(9, 78);
			this.h15.Name = "h15";
			this.h15.Size = new System.Drawing.Size(466, 15);
			this.h15.TabIndex = 24;
			this.h15.Text = "15hs";
			// 
			// h16
			// 
			this.h16.Location = new System.Drawing.Point(9, 93);
			this.h16.Name = "h16";
			this.h16.Size = new System.Drawing.Size(466, 15);
			this.h16.TabIndex = 25;
			this.h16.Text = "16hs";
			// 
			// h17
			// 
			this.h17.Location = new System.Drawing.Point(9, 108);
			this.h17.Name = "h17";
			this.h17.Size = new System.Drawing.Size(466, 15);
			this.h17.TabIndex = 26;
			this.h17.Text = "17hs";
			// 
			// h18
			// 
			this.h18.Location = new System.Drawing.Point(9, 123);
			this.h18.Name = "h18";
			this.h18.Size = new System.Drawing.Size(466, 15);
			this.h18.TabIndex = 27;
			this.h18.Text = "18hs";
			// 
			// SelectHora
			// 
			this.SelectHora.FormattingEnabled = true;
			this.SelectHora.Location = new System.Drawing.Point(17, 19);
			this.SelectHora.Name = "SelectHora";
			this.SelectHora.Size = new System.Drawing.Size(45, 24);
			this.SelectHora.TabIndex = 28;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(68, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 23);
			this.label5.TabIndex = 29;
			this.label5.Text = "Hs.";
			// 
			// borraturno
			// 
			this.borraturno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.borraturno.ForeColor = System.Drawing.Color.DarkRed;
			this.borraturno.Location = new System.Drawing.Point(103, 19);
			this.borraturno.Name = "borraturno";
			this.borraturno.Size = new System.Drawing.Size(96, 23);
			this.borraturno.TabIndex = 30;
			this.borraturno.Text = "Borrar Turno";
			this.borraturno.UseVisualStyleBackColor = true;
			this.borraturno.Click += new System.EventHandler(this.BorraturnoClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.borraturno);
			this.groupBox1.Controls.Add(this.SelectHora);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(10, 423);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(497, 62);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Eliminar Turnos";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.h08);
			this.groupBox2.Controls.Add(this.h09);
			this.groupBox2.Controls.Add(this.h18);
			this.groupBox2.Controls.Add(this.h10);
			this.groupBox2.Controls.Add(this.h17);
			this.groupBox2.Controls.Add(this.h11);
			this.groupBox2.Controls.Add(this.h15);
			this.groupBox2.Controls.Add(this.h16);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(10, 271);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(497, 146);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Disponibilidad de Turnos";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.Nombre);
			this.groupBox3.Controls.Add(this.DNI);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.ObraSocial);
			this.groupBox3.Controls.Add(this.Hora);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(241, 200);
			this.groupBox3.TabIndex = 33;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Nuevo Turno";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 497);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.verdia);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.fefe);
			this.Controls.Add(this.dia);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm";
			this.Text = "turnos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		}
	}
