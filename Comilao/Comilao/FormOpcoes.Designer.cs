/*
 * Created by SharpDevelop.
 * User: rodri
 * Date: 14/06/2018
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Comilao
{
	partial class FormOpcoes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox checkBoxSons;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioDifDificil;
		private System.Windows.Forms.RadioButton radioDifMedio;
		private System.Windows.Forms.RadioButton radioDifFacil;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioCharMario;
		private System.Windows.Forms.RadioButton radioCharSnaky;
		private System.Windows.Forms.RadioButton radioCharPunky;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox imgMario;
		private System.Windows.Forms.PictureBox imgComilao;
		private System.Windows.Forms.PictureBox imgPunky;
		
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
			this.checkBoxSons = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioDifDificil = new System.Windows.Forms.RadioButton();
			this.radioDifMedio = new System.Windows.Forms.RadioButton();
			this.radioDifFacil = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioCharMario = new System.Windows.Forms.RadioButton();
			this.radioCharSnaky = new System.Windows.Forms.RadioButton();
			this.radioCharPunky = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.imgMario = new System.Windows.Forms.PictureBox();
			this.imgComilao = new System.Windows.Forms.PictureBox();
			this.imgPunky = new System.Windows.Forms.PictureBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgMario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgComilao)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgPunky)).BeginInit();
			this.SuspendLayout();
			// 
			// checkBoxSons
			// 
			this.checkBoxSons.AutoSize = true;
			this.checkBoxSons.Location = new System.Drawing.Point(30, 191);
			this.checkBoxSons.Name = "checkBoxSons";
			this.checkBoxSons.Size = new System.Drawing.Size(69, 17);
			this.checkBoxSons.TabIndex = 18;
			this.checkBoxSons.Text = "Sons ON";
			this.checkBoxSons.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(378, 191);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 17;
			this.button1.Text = "Confirmar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioDifDificil);
			this.groupBox2.Controls.Add(this.radioDifMedio);
			this.groupBox2.Controls.Add(this.radioDifFacil);
			this.groupBox2.Location = new System.Drawing.Point(339, 50);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(114, 135);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			// 
			// radioDifDificil
			// 
			this.radioDifDificil.AutoSize = true;
			this.radioDifDificil.Location = new System.Drawing.Point(11, 73);
			this.radioDifDificil.Name = "radioDifDificil";
			this.radioDifDificil.Size = new System.Drawing.Size(52, 17);
			this.radioDifDificil.TabIndex = 2;
			this.radioDifDificil.TabStop = true;
			this.radioDifDificil.Text = "Difícil";
			this.radioDifDificil.UseVisualStyleBackColor = true;
			// 
			// radioDifMedio
			// 
			this.radioDifMedio.AutoSize = true;
			this.radioDifMedio.Location = new System.Drawing.Point(11, 46);
			this.radioDifMedio.Name = "radioDifMedio";
			this.radioDifMedio.Size = new System.Drawing.Size(54, 17);
			this.radioDifMedio.TabIndex = 1;
			this.radioDifMedio.TabStop = true;
			this.radioDifMedio.Text = "Médio";
			this.radioDifMedio.UseVisualStyleBackColor = true;
			// 
			// radioDifFacil
			// 
			this.radioDifFacil.AutoSize = true;
			this.radioDifFacil.Location = new System.Drawing.Point(11, 19);
			this.radioDifFacil.Name = "radioDifFacil";
			this.radioDifFacil.Size = new System.Drawing.Size(47, 17);
			this.radioDifFacil.TabIndex = 0;
			this.radioDifFacil.TabStop = true;
			this.radioDifFacil.Text = "Fácil";
			this.radioDifFacil.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(336, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "DIFICULDADE";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.imgPunky);
			this.groupBox1.Controls.Add(this.imgComilao);
			this.groupBox1.Controls.Add(this.imgMario);
			this.groupBox1.Controls.Add(this.radioCharMario);
			this.groupBox1.Controls.Add(this.radioCharSnaky);
			this.groupBox1.Controls.Add(this.radioCharPunky);
			this.groupBox1.Location = new System.Drawing.Point(31, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(286, 135);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			// 
			// radioCharMario
			// 
			this.radioCharMario.AutoSize = true;
			this.radioCharMario.Location = new System.Drawing.Point(6, 73);
			this.radioCharMario.Name = "radioCharMario";
			this.radioCharMario.Size = new System.Drawing.Size(51, 17);
			this.radioCharMario.TabIndex = 5;
			this.radioCharMario.TabStop = true;
			this.radioCharMario.Text = "Mario";
			this.radioCharMario.UseVisualStyleBackColor = true;
			// 
			// radioCharSnaky
			// 
			this.radioCharSnaky.AutoSize = true;
			this.radioCharSnaky.Location = new System.Drawing.Point(6, 29);
			this.radioCharSnaky.Name = "radioCharSnaky";
			this.radioCharSnaky.Size = new System.Drawing.Size(62, 17);
			this.radioCharSnaky.TabIndex = 1;
			this.radioCharSnaky.TabStop = true;
			this.radioCharSnaky.Text = "Comilão";
			this.radioCharSnaky.UseVisualStyleBackColor = true;
			// 
			// radioCharPunky
			// 
			this.radioCharPunky.AutoSize = true;
			this.radioCharPunky.Location = new System.Drawing.Point(127, 31);
			this.radioCharPunky.Name = "radioCharPunky";
			this.radioCharPunky.Size = new System.Drawing.Size(95, 17);
			this.radioCharPunky.TabIndex = 2;
			this.radioCharPunky.TabStop = true;
			this.radioCharPunky.Text = "Comilão Punky";
			this.radioCharPunky.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(95, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 16);
			this.label1.TabIndex = 13;
			this.label1.Text = "SELECIONE O PERSONAGEM";
			// 
			// imgMario
			// 
			this.imgMario.Image = global::Comilao.Properties.Resources.marioRight;
			this.imgMario.Location = new System.Drawing.Point(63, 64);
			this.imgMario.Name = "imgMario";
			this.imgMario.Size = new System.Drawing.Size(40, 40);
			this.imgMario.TabIndex = 19;
			this.imgMario.TabStop = false;
			// 
			// imgComilao
			// 
			this.imgComilao.Image = global::Comilao.Properties.Resources.snakyRight;
			this.imgComilao.Location = new System.Drawing.Point(64, 19);
			this.imgComilao.Name = "imgComilao";
			this.imgComilao.Size = new System.Drawing.Size(40, 40);
			this.imgComilao.TabIndex = 21;
			this.imgComilao.TabStop = false;
			// 
			// imgPunky
			// 
			this.imgPunky.Image = global::Comilao.Properties.Resources.punkyRight;
			this.imgPunky.Location = new System.Drawing.Point(228, 19);
			this.imgPunky.Name = "imgPunky";
			this.imgPunky.Size = new System.Drawing.Size(40, 40);
			this.imgPunky.TabIndex = 20;
			this.imgPunky.TabStop = false;
			// 
			// FormOpcoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 255);
			this.Controls.Add(this.checkBoxSons);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormOpcoes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Opções do jogo";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgMario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgComilao)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgPunky)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
