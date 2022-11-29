using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace turnos
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();

		}
		public string armolinea (string turno)
		{
			string lineahora ="";
			char delimitador = '#';
			string[] campos = turno.Split(delimitador);
			lineahora = campos[0]+" - Paciente: "+campos[1]+" DNI:"+campos[2]+" Obra Social:"+campos[3];
			return lineahora;
		}

		void Button2Click(object sender, EventArgs e)
		{
			Nombre.Clear();
			DNI.Clear();
			ObraSocial.Clear();
			Hora.SelectedIndex = 0;
			dia.SelectionStart = dia.TodayDate;
				
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (Convert.ToSByte(Hora.SelectedIndex)!=-1 && Nombre.Text!="" && DNI.Text!="" && ObraSocial.Text!="")
			{
				string seldia=Convert.ToString(dia.SelectionStart);
				string a= seldia.Substring(6,4);
				string m= seldia.Substring(3,2);
				string d= seldia.Substring(0,2);
				string registro = Hora.SelectedItem+"#"+Nombre.Text+"#"+DNI.Text+"#"+ObraSocial.Text;
				fefe.Text = "Se agrega al dia"+d+"/"+ m +"/"+ a +" a las "+Hora.SelectedItem+"Hs. turno para "+Nombre.Text+"| DNI:"+DNI.Text+"| O.S.:"+ObraSocial.Text;
				string nombrearchivo = a+m+d;
				StreamWriter sw = new StreamWriter(nombrearchivo+".txt",true);
				sw.WriteLine(registro);
				sw.Close();
				//Reinicia el contenido del formulario
				Nombre.Clear();
				DNI.Clear();
				ObraSocial.Clear();
				Hora.SelectedIndex = 0;
			}else{
				label6.Visible = true;
				label6.Text = "Faltan Datos!";
			}
		}
		void DiaDateChanged(object sender, DateRangeEventArgs e)
		{
			Hora.Items.Clear();
			SelectHora.Items.Clear();
			//Armono Nombre del Archivo
			string seldia=Convert.ToString(dia.SelectionStart);
			string a= seldia.Substring(6,4);
			string m= seldia.Substring(3,2);
			string d= seldia.Substring(0,2);
			verdia.Text = d+"/"+m+"/"+a;
			
			//Armo la Tabla
			//Defino el archivo que voy a leer segun el dia seleccionado
			string nombrearchivo = a+m+d;
				
				h08.Text="08hs";
				h09.Text="09hs";
				h10.Text="10hs";
				h11.Text="11hs";
				h15.Text="15hs";
				h16.Text="16hs";
				h17.Text="17hs";
				h18.Text="18hs";
			//Compruebo si existe el archivo y lo abro
			if (File.Exists(nombrearchivo+".txt")== true){
			StreamReader leodia = new StreamReader(nombrearchivo+".txt");
				int i = 0;
				string turno;
				Hora.Items.Clear();
				string[] hrs = {"08","09","10","11","15","16","17","18"};
				foreach (string h in hrs){
					Hora.Items.Add(h);
				}
				while((turno = leodia.ReadLine()) != null)
					{  
					char delimitador = '#';
					string[] campos = turno.Split(delimitador);
					if(campos[0]=="08")
						{h08.Text=armolinea(turno);
						SelectHora.Items.Add("08");
						Hora.Items.RemoveAt(0);}
					if(campos[0]=="09")
					{h09.Text=armolinea(turno);
						SelectHora.Items.Add("09");
						Hora.Items.RemoveAt(1);}
					if(campos[0]=="10")
						{h10.Text=armolinea(turno);
						SelectHora.Items.Add("10");
						Hora.Items.RemoveAt(2);}
					if(campos[0]=="11")
						{h11.Text=armolinea(turno);
						SelectHora.Items.Add("11");
						Hora.Items.RemoveAt(3);}
					if(campos[0]=="15")
						{h15.Text=armolinea(turno);
						SelectHora.Items.Add("15");
						Hora.Items.RemoveAt(4);}
					if(campos[0]=="16")
						{h16.Text=armolinea(turno);
						SelectHora.Items.Add("16");
						Hora.Items.RemoveAt(5);}
					if(campos[0]=="17")
						{h17.Text=armolinea(turno);
						SelectHora.Items.Add("17");
						Hora.Items.RemoveAt(6);}
					if(campos[0]=="18")
						{h18.Text=armolinea(turno);
						SelectHora.Items.Add("18");
						Hora.Items.RemoveAt(7);}
					i++;
					}
				leodia.Close();
			}
			
			else //si no existe es porque no hay turnos para ese dia
			{
				verdia.Text = verdia.Text + " - No hay Turnos ";
				string[] hrs = {"08","09","10","11","15","16","17","18"};
				foreach (string h in hrs){
					Hora.Items.Add(h);
				}
			}
			
		}
		void BorraturnoClick(object sender, EventArgs e)
		{
			string seldia=Convert.ToString(dia.SelectionStart);
			string a= seldia.Substring(6,4);
			string m= seldia.Substring(3,2);
			string d= seldia.Substring(0,2);
			string archivo = a+m+d+".txt";
			string hora = Convert.ToString(SelectHora.SelectedItem);
			
			//Codigo para borrar un turno, toma archivo como nombre del txt y hora para buscar la hora
			fefe.Text = "borra en "+archivo+" el turno de las "+hora;
			label6.Visible = true;
			label6.Text = "Elimino o no un registro";
			StreamReader releodia = new StreamReader(archivo);
			int i = 0;
			string turno;
			string queda="";
			while((turno = releodia.ReadLine()) != null)
				{  
				if(turno.Substring(0,2)!=hora)
					queda = queda+turno;
				    i++;
				}
			releodia.Close();
			StreamWriter sw = new StreamWriter(archivo);
			sw.WriteLine(queda);
			sw.Close();
			SelectHora.Items.Clear();
			MessageBox.Show(queda);
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void FefeTextChanged(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
	}
}
