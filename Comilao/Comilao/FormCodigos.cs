/*
 * Created by SharpDevelop.
 * User: rodri
 * Date: 14/06/2018
 * Time: 11:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Comilao
{
	/// <summary>
	/// Description of FormCodigos.
	/// </summary>
	public partial class FormCodigos : Form
	{
		public FormCodigos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
	        if (editCodigo.Text == "SUPERMARIO"){
                MessageBox.Show("Código válido: personagem Mário disponível!!!");
                ClassDados.PersonagemMario = true;
            }
            else if (editCodigo.Text == "ETERNAL"){
                MessageBox.Show("Código válido: 99 vidas!!!");
                ClassDados.Vidas = 99;
            }
            else{
                MessageBox.Show("Código inválido!!!");
            }
		}
		void Button2Click(object sender, EventArgs e)
		{
	        Close();
		}
	}
}
