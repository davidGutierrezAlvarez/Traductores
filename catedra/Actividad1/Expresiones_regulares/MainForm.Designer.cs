/*
 * Creado por SharpDevelop.
 * Usuario: dagur
 * Fecha: 01/02/2020
 * Hora: 10:57 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Expresiones_regulares
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
			this.btnHour = new System.Windows.Forms.Button();
			this.lblTextHour = new System.Windows.Forms.Label();
			this.textBoxHour = new System.Windows.Forms.TextBox();
			this.lblHour = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.lblTextEmail = new System.Windows.Forms.Label();
			this.btnEmail = new System.Windows.Forms.Button();
			this.lblLink = new System.Windows.Forms.Label();
			this.textBoxLink = new System.Windows.Forms.TextBox();
			this.lblTextLink = new System.Windows.Forms.Label();
			this.btnLink = new System.Windows.Forms.Button();
			this.lblNumber = new System.Windows.Forms.Label();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.llbTextNumber = new System.Windows.Forms.Label();
			this.btnNumber = new System.Windows.Forms.Button();
			this.lblVar = new System.Windows.Forms.Label();
			this.textBoxVar = new System.Windows.Forms.TextBox();
			this.lblTextVar = new System.Windows.Forms.Label();
			this.btnVar = new System.Windows.Forms.Button();
			this.btnColor = new System.Windows.Forms.Button();
			this.lblTextColor = new System.Windows.Forms.Label();
			this.textBoxColor = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblColor = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnHour
			// 
			this.btnHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHour.Location = new System.Drawing.Point(333, 89);
			this.btnHour.Name = "btnHour";
			this.btnHour.Size = new System.Drawing.Size(155, 30);
			this.btnHour.TabIndex = 0;
			this.btnHour.Text = "Validar";
			this.btnHour.UseVisualStyleBackColor = true;
			this.btnHour.Click += new System.EventHandler(this.BtnHourClick);
			// 
			// lblTextHour
			// 
			this.lblTextHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextHour.Location = new System.Drawing.Point(12, 124);
			this.lblTextHour.Name = "lblTextHour";
			this.lblTextHour.Size = new System.Drawing.Size(315, 23);
			this.lblTextHour.TabIndex = 1;
			this.lblTextHour.Text = "Hora:23:59";
			// 
			// textBoxHour
			// 
			this.textBoxHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxHour.Location = new System.Drawing.Point(12, 89);
			this.textBoxHour.Name = "textBoxHour";
			this.textBoxHour.Size = new System.Drawing.Size(315, 30);
			this.textBoxHour.TabIndex = 2;
			// 
			// lblHour
			// 
			this.lblHour.BackColor = System.Drawing.SystemColors.Control;
			this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHour.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblHour.Location = new System.Drawing.Point(512, 86);
			this.lblHour.Name = "lblHour";
			this.lblHour.Size = new System.Drawing.Size(33, 33);
			this.lblHour.TabIndex = 3;
			// 
			// lblEmail
			// 
			this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblEmail.Location = new System.Drawing.Point(512, 147);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(33, 33);
			this.lblEmail.TabIndex = 7;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEmail.Location = new System.Drawing.Point(12, 150);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(315, 30);
			this.textBoxEmail.TabIndex = 6;
			// 
			// lblTextEmail
			// 
			this.lblTextEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextEmail.Location = new System.Drawing.Point(12, 185);
			this.lblTextEmail.Name = "lblTextEmail";
			this.lblTextEmail.Size = new System.Drawing.Size(315, 23);
			this.lblTextEmail.TabIndex = 5;
			this.lblTextEmail.Text = "E-mail:name@gmail.com";
			// 
			// btnEmail
			// 
			this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmail.Location = new System.Drawing.Point(333, 150);
			this.btnEmail.Name = "btnEmail";
			this.btnEmail.Size = new System.Drawing.Size(155, 30);
			this.btnEmail.TabIndex = 4;
			this.btnEmail.Text = "Validar";
			this.btnEmail.UseVisualStyleBackColor = true;
			this.btnEmail.Click += new System.EventHandler(this.BtnEmailClick);
			// 
			// lblLink
			// 
			this.lblLink.BackColor = System.Drawing.SystemColors.Control;
			this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLink.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblLink.Location = new System.Drawing.Point(512, 208);
			this.lblLink.Name = "lblLink";
			this.lblLink.Size = new System.Drawing.Size(33, 33);
			this.lblLink.TabIndex = 11;
			// 
			// textBoxLink
			// 
			this.textBoxLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLink.Location = new System.Drawing.Point(12, 211);
			this.textBoxLink.Name = "textBoxLink";
			this.textBoxLink.Size = new System.Drawing.Size(315, 30);
			this.textBoxLink.TabIndex = 10;
			// 
			// lblTextLink
			// 
			this.lblTextLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextLink.Location = new System.Drawing.Point(12, 246);
			this.lblTextLink.Name = "lblTextLink";
			this.lblTextLink.Size = new System.Drawing.Size(315, 23);
			this.lblTextLink.TabIndex = 9;
			this.lblTextLink.Text = "Link:google.com.mx";
			// 
			// btnLink
			// 
			this.btnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLink.Location = new System.Drawing.Point(333, 211);
			this.btnLink.Name = "btnLink";
			this.btnLink.Size = new System.Drawing.Size(155, 30);
			this.btnLink.TabIndex = 8;
			this.btnLink.Text = "Validar";
			this.btnLink.UseVisualStyleBackColor = true;
			this.btnLink.Click += new System.EventHandler(this.BtnLinkClick);
			// 
			// lblNumber
			// 
			this.lblNumber.BackColor = System.Drawing.SystemColors.Control;
			this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumber.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblNumber.Location = new System.Drawing.Point(512, 269);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(33, 33);
			this.lblNumber.TabIndex = 15;
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNumber.Location = new System.Drawing.Point(12, 272);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(315, 30);
			this.textBoxNumber.TabIndex = 14;
			// 
			// llbTextNumber
			// 
			this.llbTextNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llbTextNumber.Location = new System.Drawing.Point(12, 307);
			this.llbTextNumber.Name = "llbTextNumber";
			this.llbTextNumber.Size = new System.Drawing.Size(315, 23);
			this.llbTextNumber.TabIndex = 13;
			this.llbTextNumber.Text = "Numero:3.14159";
			// 
			// btnNumber
			// 
			this.btnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNumber.Location = new System.Drawing.Point(333, 272);
			this.btnNumber.Name = "btnNumber";
			this.btnNumber.Size = new System.Drawing.Size(155, 30);
			this.btnNumber.TabIndex = 12;
			this.btnNumber.Text = "Validar";
			this.btnNumber.UseVisualStyleBackColor = true;
			this.btnNumber.Click += new System.EventHandler(this.BtnNumberClick);
			// 
			// lblVar
			// 
			this.lblVar.BackColor = System.Drawing.SystemColors.Control;
			this.lblVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVar.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblVar.Location = new System.Drawing.Point(512, 330);
			this.lblVar.Name = "lblVar";
			this.lblVar.Size = new System.Drawing.Size(33, 33);
			this.lblVar.TabIndex = 19;
			// 
			// textBoxVar
			// 
			this.textBoxVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxVar.Location = new System.Drawing.Point(12, 333);
			this.textBoxVar.Name = "textBoxVar";
			this.textBoxVar.Size = new System.Drawing.Size(315, 30);
			this.textBoxVar.TabIndex = 18;
			// 
			// lblTextVar
			// 
			this.lblTextVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextVar.Location = new System.Drawing.Point(12, 368);
			this.lblTextVar.Name = "lblTextVar";
			this.lblTextVar.Size = new System.Drawing.Size(315, 23);
			this.lblTextVar.TabIndex = 17;
			this.lblTextVar.Text = "Variable:hola";
			// 
			// btnVar
			// 
			this.btnVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVar.Location = new System.Drawing.Point(333, 333);
			this.btnVar.Name = "btnVar";
			this.btnVar.Size = new System.Drawing.Size(155, 30);
			this.btnVar.TabIndex = 16;
			this.btnVar.Text = "Validar";
			this.btnVar.UseVisualStyleBackColor = true;
			this.btnVar.Click += new System.EventHandler(this.BtnVarClick);
			// 
			// btnColor
			// 
			this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnColor.Location = new System.Drawing.Point(333, 394);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(155, 30);
			this.btnColor.TabIndex = 20;
			this.btnColor.Text = "Validar";
			this.btnColor.UseVisualStyleBackColor = true;
			this.btnColor.Click += new System.EventHandler(this.BtnColorClick);
			// 
			// lblTextColor
			// 
			this.lblTextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTextColor.Location = new System.Drawing.Point(12, 429);
			this.lblTextColor.Name = "lblTextColor";
			this.lblTextColor.Size = new System.Drawing.Size(315, 23);
			this.lblTextColor.TabIndex = 21;
			this.lblTextColor.Text = "Color:123,255,100";
			// 
			// textBoxColor
			// 
			this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxColor.Location = new System.Drawing.Point(12, 394);
			this.textBoxColor.Name = "textBoxColor";
			this.textBoxColor.Size = new System.Drawing.Size(315, 30);
			this.textBoxColor.TabIndex = 22;
			// 
			// lblTitle
			// 
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(557, 47);
			this.lblTitle.TabIndex = 24;
			this.lblTitle.Text = "Expresiones regulares";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblColor
			// 
			this.lblColor.BackColor = System.Drawing.SystemColors.Control;
			this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblColor.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblColor.Location = new System.Drawing.Point(512, 391);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(33, 33);
			this.lblColor.TabIndex = 23;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(557, 511);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.textBoxColor);
			this.Controls.Add(this.lblTextColor);
			this.Controls.Add(this.btnColor);
			this.Controls.Add(this.lblVar);
			this.Controls.Add(this.textBoxVar);
			this.Controls.Add(this.lblTextVar);
			this.Controls.Add(this.btnVar);
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.llbTextNumber);
			this.Controls.Add(this.btnNumber);
			this.Controls.Add(this.lblLink);
			this.Controls.Add(this.textBoxLink);
			this.Controls.Add(this.lblTextLink);
			this.Controls.Add(this.btnLink);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.lblTextEmail);
			this.Controls.Add(this.btnEmail);
			this.Controls.Add(this.lblHour);
			this.Controls.Add(this.textBoxHour);
			this.Controls.Add(this.lblTextHour);
			this.Controls.Add(this.btnHour);
			this.Name = "MainForm";
			this.Text = "Expresiones_regulares";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnColor;
		private System.Windows.Forms.Label lblTextColor;
		private System.Windows.Forms.TextBox textBoxColor;
		private System.Windows.Forms.Label lblColor;
		private System.Windows.Forms.Button btnVar;
		private System.Windows.Forms.Label lblTextVar;
		private System.Windows.Forms.TextBox textBoxVar;
		private System.Windows.Forms.Label lblVar;
		private System.Windows.Forms.Button btnNumber;
		private System.Windows.Forms.Label llbTextNumber;
		private System.Windows.Forms.TextBox textBoxNumber;
		private System.Windows.Forms.Label lblNumber;
		private System.Windows.Forms.Button btnLink;
		private System.Windows.Forms.Label lblTextLink;
		private System.Windows.Forms.TextBox textBoxLink;
		private System.Windows.Forms.Label lblLink;
		private System.Windows.Forms.Button btnEmail;
		private System.Windows.Forms.Label lblTextEmail;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label lblHour;
		private System.Windows.Forms.TextBox textBoxHour;
		private System.Windows.Forms.Label lblTextHour;
		private System.Windows.Forms.Button btnHour;

	}
}
