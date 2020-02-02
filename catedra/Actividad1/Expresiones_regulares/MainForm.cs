/*
 * Creado por SharpDevelop.
 * Usuario: dagur
 * Fecha: 01/02/2020
 * Hora: 10:57 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Expresiones_regulares {
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form {
		String hour   = @"([0-1][0-9]|2[0-3])(:[0-5][0-9]){1,2}$";
		String email  = @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$";
		String link   = @"((h|H)(t|T){2}(p|P)(s|S)?:\/\/)?([a-zA-Z_0-9]+\.)+[a-zA-Z_0-9]+(\/[a-zA-Z_0-9]*)*$";
		String number = @"[0-9]*\.?[0-9]+$";
		String var    = @"[a-zA-Z_][a-zA-Z0-9_]*$";
		String color  = @"(([0-1][0-9]{2}|2[0-5]{2}),){2}([0-1][0-9]{2}|2[0-5]{2})$";
		public MainForm() {
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnHourClick(object sender, EventArgs e) {
			isValid(textBoxHour, hour, lblHour);
		}
		
		void BtnEmailClick(object sender, EventArgs e) {
			isValid(textBoxEmail, email, lblEmail);
		}
		
		void BtnLinkClick(object sender, EventArgs e) {
			isValid(textBoxLink, link, lblLink);
		}
		
		void BtnNumberClick(object sender, EventArgs e) {
			isValid(textBoxNumber, number, lblNumber);
		}
		
		void BtnVarClick(object sender, EventArgs e) {
			isValid(textBoxVar, var, lblVar);
		}
		
		void BtnColorClick(object sender, EventArgs e) {
			isValid(textBoxColor, color, lblColor);
		}
		
		void isValid(TextBox textBox, String str, Label lbl) {
			if(Regex.IsMatch(textBox.Text, str) && Regex.Replace(textBox.Text, str, String.Empty).Length == 0) {
				lbl.BackColor = Color.Green;
			} else {
				lbl.BackColor = Color.Red;
			}
		}
	}
}
