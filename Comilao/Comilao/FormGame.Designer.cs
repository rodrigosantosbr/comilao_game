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
	partial class FormGame
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBoxInimigo3;
		private System.Windows.Forms.PictureBox pictureBoxInimigo2;
		private System.Windows.Forms.PictureBox pictureBoxInimigo1;
		private System.Windows.Forms.PictureBox snaky;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelVidas;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelTempo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label labelTotalMacas;
		private System.Windows.Forms.Label labelTotalChaves;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelDificuldade;
		private System.Windows.Forms.Label labelNivel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelPontos;
		private System.Windows.Forms.Timer timerAnda;
		private System.Windows.Forms.PictureBox pictureBox3;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
			this.pictureBoxInimigo3 = new System.Windows.Forms.PictureBox();
			this.pictureBoxInimigo2 = new System.Windows.Forms.PictureBox();
			this.pictureBoxInimigo1 = new System.Windows.Forms.PictureBox();
			this.snaky = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelVidas = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.labelTempo = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.labelTotalMacas = new System.Windows.Forms.Label();
			this.labelTotalChaves = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.labelDificuldade = new System.Windows.Forms.Label();
			this.labelNivel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelPontos = new System.Windows.Forms.Label();
			this.timerAnda = new System.Windows.Forms.Timer(this.components);
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInimigo3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInimigo2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInimigo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.snaky)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxInimigo3
			// 
			this.pictureBoxInimigo3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxInimigo3.Image = global::Comilao.Properties.Resources.monsterDown;
			this.pictureBoxInimigo3.Location = new System.Drawing.Point(245, 79);
			this.pictureBoxInimigo3.Name = "pictureBoxInimigo3";
			this.pictureBoxInimigo3.Size = new System.Drawing.Size(40, 40);
			this.pictureBoxInimigo3.TabIndex = 4;
			this.pictureBoxInimigo3.TabStop = false;
			// 
			// pictureBoxInimigo2
			// 
			this.pictureBoxInimigo2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxInimigo2.Image = global::Comilao.Properties.Resources.monsterDown;
			this.pictureBoxInimigo2.Location = new System.Drawing.Point(80, 151);
			this.pictureBoxInimigo2.Name = "pictureBoxInimigo2";
			this.pictureBoxInimigo2.Size = new System.Drawing.Size(40, 40);
			this.pictureBoxInimigo2.TabIndex = 5;
			this.pictureBoxInimigo2.TabStop = false;
			// 
			// pictureBoxInimigo1
			// 
			this.pictureBoxInimigo1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxInimigo1.Image = global::Comilao.Properties.Resources.monsterDown;
			this.pictureBoxInimigo1.Location = new System.Drawing.Point(221, 168);
			this.pictureBoxInimigo1.Name = "pictureBoxInimigo1";
			this.pictureBoxInimigo1.Size = new System.Drawing.Size(40, 40);
			this.pictureBoxInimigo1.TabIndex = 6;
			this.pictureBoxInimigo1.TabStop = false;
			// 
			// snaky
			// 
			this.snaky.BackColor = System.Drawing.Color.Transparent;
			this.snaky.Image = global::Comilao.Properties.Resources.snakyDown;
			this.snaky.Location = new System.Drawing.Point(417, 65);
			this.snaky.Name = "snaky";
			this.snaky.Size = new System.Drawing.Size(40, 40);
			this.snaky.TabIndex = 7;
			this.snaky.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Khaki;
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.labelVidas);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.labelTempo);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.labelTotalMacas);
			this.groupBox1.Controls.Add(this.labelTotalChaves);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.labelDificuldade);
			this.groupBox1.Controls.Add(this.labelNivel);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.labelPontos);
			this.groupBox1.Location = new System.Drawing.Point(809, 18);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(142, 576);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// labelVidas
			// 
			this.labelVidas.AutoSize = true;
			this.labelVidas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelVidas.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.labelVidas.Location = new System.Drawing.Point(85, 377);
			this.labelVidas.Name = "labelVidas";
			this.labelVidas.Size = new System.Drawing.Size(22, 24);
			this.labelVidas.TabIndex = 18;
			this.labelVidas.Text = "0";
			this.labelVidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(60, 371);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(31, 32);
			this.label8.TabIndex = 17;
			this.label8.Text = "=";
			// 
			// labelTempo
			// 
			this.labelTempo.AutoSize = true;
			this.labelTempo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTempo.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.labelTempo.Location = new System.Drawing.Point(9, 454);
			this.labelTempo.Name = "labelTempo";
			this.labelTempo.Size = new System.Drawing.Size(22, 24);
			this.labelTempo.TabIndex = 15;
			this.labelTempo.Text = "0";
			this.labelTempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(9, 421);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 24);
			this.label7.TabIndex = 14;
			this.label7.Text = "Tempo:";
			// 
			// labelTotalMacas
			// 
			this.labelTotalMacas.AutoSize = true;
			this.labelTotalMacas.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalMacas.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.labelTotalMacas.Location = new System.Drawing.Point(85, 332);
			this.labelTotalMacas.Name = "labelTotalMacas";
			this.labelTotalMacas.Size = new System.Drawing.Size(22, 24);
			this.labelTotalMacas.TabIndex = 13;
			this.labelTotalMacas.Text = "0";
			this.labelTotalMacas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelTotalChaves
			// 
			this.labelTotalChaves.AutoSize = true;
			this.labelTotalChaves.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalChaves.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.labelTotalChaves.Location = new System.Drawing.Point(85, 287);
			this.labelTotalChaves.Name = "labelTotalChaves";
			this.labelTotalChaves.Size = new System.Drawing.Size(22, 24);
			this.labelTotalChaves.TabIndex = 12;
			this.labelTotalChaves.Text = "0";
			this.labelTotalChaves.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(60, 328);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 32);
			this.label6.TabIndex = 11;
			this.label6.Text = "=";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(60, 283);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 32);
			this.label5.TabIndex = 10;
			this.label5.Text = "=";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 321);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(43, 44);
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 280);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 35);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 237);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "Elementos:";
			// 
			// labelDificuldade
			// 
			this.labelDificuldade.AutoSize = true;
			this.labelDificuldade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDificuldade.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.labelDificuldade.Location = new System.Drawing.Point(6, 195);
			this.labelDificuldade.Name = "labelDificuldade";
			this.labelDificuldade.Size = new System.Drawing.Size(22, 24);
			this.labelDificuldade.TabIndex = 6;
			this.labelDificuldade.Text = "0";
			this.labelDificuldade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelNivel
			// 
			this.labelNivel.AutoSize = true;
			this.labelNivel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNivel.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.labelNivel.Location = new System.Drawing.Point(6, 57);
			this.labelNivel.Name = "labelNivel";
			this.labelNivel.Size = new System.Drawing.Size(22, 24);
			this.labelNivel.TabIndex = 5;
			this.labelNivel.Text = "0";
			this.labelNivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Dificuldade:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Pts:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nivel:";
			// 
			// labelPontos
			// 
			this.labelPontos.AutoSize = true;
			this.labelPontos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPontos.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.labelPontos.Location = new System.Drawing.Point(6, 121);
			this.labelPontos.Name = "labelPontos";
			this.labelPontos.Size = new System.Drawing.Size(22, 24);
			this.labelPontos.TabIndex = 1;
			this.labelPontos.Text = "0";
			this.labelPontos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// timerAnda
			// 
			this.timerAnda.Enabled = true;
			this.timerAnda.Interval = 200;
			this.timerAnda.Tick += new System.EventHandler(this.TimerAndaTick);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Comilao.Properties.Resources.vidas;
			this.pictureBox3.Location = new System.Drawing.Point(12, 371);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(40, 40);
			this.pictureBox3.TabIndex = 20;
			this.pictureBox3.TabStop = false;
			// 
			// FormGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 600);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBoxInimigo3);
			this.Controls.Add(this.pictureBoxInimigo2);
			this.Controls.Add(this.pictureBoxInimigo1);
			this.Controls.Add(this.snaky);
			this.Name = "FormGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Comilão v2.0 - Jogo em execução";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGameFormClosing);
			this.Load += new System.EventHandler(this.FormGameLoad);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGameKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInimigo3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInimigo2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxInimigo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.snaky)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
