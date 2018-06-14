/*
 * Created by SharpDevelop.
 * User: rodri
 * Date: 14/06/2018
 * Time: 11:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Comilao
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCodigosClick(object sender, EventArgs e)
		{
	        FormCodigos frmc = new FormCodigos();
            frmc.ShowDialog();
		}
		void BtnIniciarClick(object sender, EventArgs e)
		{
	        FormGame fg = new FormGame();
            fg.Show();
		}
		void BtnOpcoesClick(object sender, EventArgs e)
		{
	        FormOpcoes fo = new FormOpcoes();
            fo.ShowDialog();
		}
	}
}
