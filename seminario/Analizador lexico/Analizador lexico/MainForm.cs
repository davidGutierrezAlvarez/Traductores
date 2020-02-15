/*
 * Creado por SharpDevelop.
 * Usuario: dagur
 * Fecha: 02/02/2020
 * Hora: 06:57 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Analizador_lexico
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm() {
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			dataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataTableError.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void EjecutarToolStripMenuItemClick(object sender, EventArgs e) {
		//codigo a ejecutar
			String entrada = textBox.Text;
			AnalizadorLexico lex = new AnalizadorLexico(entrada);
			LinkedList<Token> lTokens = lex.escanear();
			//MessageBox.Show();
			LinkedList<Token> lTokensError = lex.listError();
			
			limpiar();
			rellenar(lTokens, lTokensError);
		
			//analizador sintactico
			analizadorSintactico sin = new analizadorSintactico(lTokens);
			if(sin.analizar()) {
				MessageBox.Show("valido");
			} else {
				MessageBox.Show("invalido");
			}
			//
		}
		
		void rellenar(LinkedList<Token> lista, LinkedList<Token> listaError) {
			foreach(Token item in lista) {
				dataTable.Rows.Add(item.getStado(), item.getToken(), item.getFila(), item.gefColumna(), item.getId());
				//System.Windows.Forms.MessageBox.Show(item.getStado()+"---"+item.getToken());
			}
			foreach(Token item in listaError) {
				dataTableError.Rows.Add(item.getToken(), item.getFila(), item.gefColumna());
			}
		}
		
		void limpiar() {
			dataTable.Rows.Clear();
			dataTable.Refresh();
			dataTableError.Rows.Clear();
			dataTableError.Refresh();
		}
		
		
	}
}
