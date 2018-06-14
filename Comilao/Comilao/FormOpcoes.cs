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
	/// Description of FormOpcoes.
	/// </summary>
	public partial class FormOpcoes : Form
	{
		public FormOpcoes()
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
	        if (radioCharSnaky.Checked == true){
                ClassDados.Personagem = ClassDados.GameCharacter.Snaky;
            }
            else if (radioCharPunky.Checked == true){
                ClassDados.Personagem = ClassDados.GameCharacter.Punky;
            }
            else if (radioCharMario.Checked == true){
                ClassDados.Personagem = ClassDados.GameCharacter.Mario;
            }

            if (radioDifFacil.Checked == true){
                ClassDados.Dificuldade = ClassDados.GameDifficult.Facil;
            }
            else if (radioDifMedio.Checked == true){
                ClassDados.Dificuldade = ClassDados.GameDifficult.Normal;
            }
            else if (radioDifDificil.Checked == true){
                ClassDados.Dificuldade = ClassDados.GameDifficult.Dificil;
            }

            if (checkBoxSons.Checked == true){
                ClassDados.Sons = ClassDados.GameSoundEffects.On;
            }
            else{
                ClassDados.Sons = ClassDados.GameSoundEffects.Off;
            }

            Close();
		}
	}
}
