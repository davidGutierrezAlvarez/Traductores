/*
 * Creado por SharpDevelop.
 * Usuario: dagur
 * Fecha: 24/01/2020
 * Hora: 02:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Actividad1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.TextAreaOrigin = new System.Windows.Forms.RichTextBox();
			this.TextAreaDestiny = new System.Windows.Forms.RichTextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnErase = new System.Windows.Forms.Button();
			this.listBoxResult = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// TextAreaOrigin
			// 
			this.TextAreaOrigin.Location = new System.Drawing.Point(12, 12);
			this.TextAreaOrigin.Name = "TextAreaOrigin";
			this.TextAreaOrigin.Size = new System.Drawing.Size(300, 170);
			this.TextAreaOrigin.TabIndex = 0;
			this.TextAreaOrigin.Text = "";
			// 
			// TextAreaDestiny
			// 
			this.TextAreaDestiny.Enabled = false;
			this.TextAreaDestiny.Location = new System.Drawing.Point(12, 236);
			this.TextAreaDestiny.Name = "TextAreaDestiny";
			this.TextAreaDestiny.ShortcutsEnabled = false;
			this.TextAreaDestiny.Size = new System.Drawing.Size(300, 170);
			this.TextAreaDestiny.TabIndex = 1;
			this.TextAreaDestiny.Text = "";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(12, 188);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(110, 42);
			this.btnGenerate.TabIndex = 2;
			this.btnGenerate.Text = "Generar";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.BtnGenerateClick);
			// 
			// btnErase
			// 
			this.btnErase.Location = new System.Drawing.Point(202, 188);
			this.btnErase.Name = "btnErase";
			this.btnErase.Size = new System.Drawing.Size(110, 42);
			this.btnErase.TabIndex = 4;
			this.btnErase.Text = "Borrar";
			this.btnErase.UseVisualStyleBackColor = true;
			this.btnErase.Click += new System.EventHandler(this.BtnEraseClick);
			// 
			// listBoxResult
			// 
			this.listBoxResult.FormattingEnabled = true;
			this.listBoxResult.ItemHeight = 16;
			this.listBoxResult.Location = new System.Drawing.Point(318, 12);
			this.listBoxResult.Name = "listBoxResult";
			this.listBoxResult.Size = new System.Drawing.Size(120, 388);
			this.listBoxResult.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 421);
			this.Controls.Add(this.listBoxResult);
			this.Controls.Add(this.btnErase);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.TextAreaDestiny);
			this.Controls.Add(this.TextAreaOrigin);
			this.Name = "MainForm";
			this.Text = "Actividad1";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox listBoxResult;
		private System.Windows.Forms.Button btnErase;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.RichTextBox TextAreaDestiny;
		private System.Windows.Forms.RichTextBox TextAreaOrigin;
	}
}
