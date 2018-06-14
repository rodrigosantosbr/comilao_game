/*
 * Created by SharpDevelop.
 * User: rodri
 * Date: 14/06/2018
 * Time: 11:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Comilao
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCodigos;
		private System.Windows.Forms.Button btnOpcoes;
		private System.Windows.Forms.Button btnIniciar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnCodigos = new System.Windows.Forms.Button();
			this.btnOpcoes = new System.Windows.Forms.Button();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(0, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 39);
			this.label1.TabIndex = 7;
			this.label1.Text = "Comilão";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCodigos
			// 
			this.btnCodigos.Location = new System.Drawing.Point(96, 145);
			this.btnCodigos.Name = "btnCodigos";
			this.btnCodigos.Size = new System.Drawing.Size(106, 30);
			this.btnCodigos.TabIndex = 6;
			this.btnCodigos.Text = "[ C Ó D I G O S ]";
			this.btnCodigos.UseVisualStyleBackColor = true;
			this.btnCodigos.Click += new System.EventHandler(this.BtnCodigosClick);
			// 
			// btnOpcoes
			// 
			this.btnOpcoes.Location = new System.Drawing.Point(96, 191);
			this.btnOpcoes.Name = "btnOpcoes";
			this.btnOpcoes.Size = new System.Drawing.Size(106, 30);
			this.btnOpcoes.TabIndex = 5;
			this.btnOpcoes.Text = "[ O P Ç Õ E S ]";
			this.btnOpcoes.UseVisualStyleBackColor = true;
			this.btnOpcoes.Click += new System.EventHandler(this.BtnOpcoesClick);
			// 
			// btnIniciar
			// 
			this.btnIniciar.Location = new System.Drawing.Point(96, 97);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(106, 30);
			this.btnIniciar.TabIndex = 4;
			this.btnIniciar.Text = "[ I N I C I A R ]";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += new System.EventHandler(this.BtnIniciarClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 248);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(259, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Desenvolvido por: Antonio Rodrigo dos Santos Silva";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 266);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(259, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "2009-2018";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 294);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCodigos);
			this.Controls.Add(this.btnOpcoes);
			this.Controls.Add(this.btnIniciar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Comilão v2.0";
			this.ResumeLayout(false);

		}
	}
}
