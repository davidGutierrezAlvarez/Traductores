/*
 * Creado por SharpDevelop.
 * Usuario: dagur
 * Fecha: 24/01/2020
 * Hora: 02:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Actividad1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnGenerateClick(object sender, EventArgs e) {
			TextAreaDestiny.Text = TextAreaOrigin.Text;
			
			generateList();
			
			btnGenerate.Enabled = false;
			btnErase.Enabled = true;
			
		}
		
		void BtnEraseClick(object sender, EventArgs e) {
			TextAreaDestiny.Text = "";
			
			listBoxResult.Items.Clear();
			
			btnGenerate.Enabled = true;
			btnErase.Enabled = false;
		}
		
		void generateList() {
			string cadena = TextAreaOrigin.Text, palabra = "";
			for(int i = 0; i < cadena.Length; i++) {
				if(cadena[i] == ' ') {
					if(palabra != "") { listBoxResult.Items.Add(palabra); }
					palabra = "";
				} else {
					palabra += cadena[i];
				}
			}
			if(palabra != "") {
				listBoxResult.Items.Add(palabra);
				palabra = "";
			}
		}
		
		
		
	}
}
