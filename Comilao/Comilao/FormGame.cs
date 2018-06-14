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
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Comilao
{
	/// <summary>
	/// Description of FormGame.
	/// </summary>
	public partial class FormGame : Form
	{
		ClassDados.MonsterPosition inimigo1Pos, inimigo2Pos, inimigo3Pos;        
        
        int passosInimigo = 20;        

        // movimentação dos inimigos
        Timer inimigo1 = new Timer();
        Timer inimigo2 = new Timer();
        Timer inimigo3 = new Timer();

        bool colisao1_1 = false;
        bool colisao1_2 = false;
        bool colisao1_3 = false;
        bool colisao2_1 = false;
        bool colisao2_2 = false;
        bool colisao2_3 = false;
        bool colisao3_1 = false;
        bool colisao3_2 = false;
        bool colisao3_3 = false;

        // detecta colisão
        Timer collision = new Timer();
        
        // decrementar tempo
        Timer decrementaTempo = new Timer();

        //----------------------------------------------------
        // decrementar Tempo
        //----------------------------------------------------
        private void timerDecrementaTempo(){
            decrementaTempo.Interval = 1000;
            decrementaTempo.Enabled = true;
            decrementaTempo.Tick += new System.EventHandler(timerDecrementaTempo_Tick);
        }
        private void timerDecrementaTempo_Tick(object sender, EventArgs e){
            ClassDados.Segundos--;
            if (ClassDados.Segundos == -1){
                ClassDados.Minutos--;
                ClassDados.Segundos = 59;
            }
            if (ClassDados.Minutos < 10){
                if (ClassDados.Segundos < 10){
                    labelTempo.Text = "0" + ClassDados.Minutos + ":" + "0" + ClassDados.Segundos;
                }
                else{
                    labelTempo.Text = "0" + ClassDados.Minutos + ":" + ClassDados.Segundos;
                }
            }
            else{
                if (ClassDados.Segundos < 10){
                    labelTempo.Text = ClassDados.Minutos + ":" + "0" + ClassDados.Segundos;
                }
                else{
                    labelTempo.Text = ClassDados.Minutos + ":" + ClassDados.Segundos;
                }
            }
            if (ClassDados.Minutos == 0 && ClassDados.Segundos == 0){
                perdeuJogo();
            }
        }

        //----------------------------------------------------
        // IA/movimentação do inimigo 1
        //----------------------------------------------------     
        private void timerInimigo1(){
            switch(ClassDados.Dificuldade){
                case ClassDados.GameDifficult.Facil:
                    inimigo1.Interval = 350;
                    break;
                case ClassDados.GameDifficult.Normal:
                    inimigo1.Interval = 250;
                    break;
                case ClassDados.GameDifficult.Dificil:
                    inimigo1.Interval = 100;
                    break;
            }
            inimigo1.Enabled = true;
            inimigo1.Tick += new System.EventHandler(timerInimigo1_Tick);
        }

        //----------------------------------------------------
        // INTELIGENCIA ARTIFICIAL DOS MONSTROS
        //----------------------------------------------------        
        private void inteligenciaMonstroMove(int monstroID){
            ClassDados.MonsterPosition posicao = inimigo1Pos;
            PictureBox monstro = null;

            switch (monstroID){
                case 1:
                    posicao = inimigo1Pos;
                    monstro = pictureBoxInimigo1;
                    break;
                case 2:
                    posicao = inimigo2Pos;
                    monstro = pictureBoxInimigo2;
                    break;
                case 3:
                    posicao = inimigo3Pos;
                    monstro = pictureBoxInimigo3;
                    break;
            } 

            switch (posicao)
            {
                case ClassDados.MonsterPosition.Down:
                    monstro.Top += passosInimigo;
                    monstro.Image = Comilao.Properties.Resources.monsterDown;
                    break;
                case ClassDados.MonsterPosition.Up:
                    monstro.Top -= passosInimigo;
                    monstro.Image = Comilao.Properties.Resources.monsterUp;
                    break;
                case ClassDados.MonsterPosition.Left:
                    monstro.Left -= passosInimigo;
                    monstro.Image = Comilao.Properties.Resources.monsterLeft;
                    break;
                case ClassDados.MonsterPosition.Right:
                    monstro.Left += passosInimigo;
                    monstro.Image = Comilao.Properties.Resources.monsterRight;
                    break;
            }
        }
        private void monstroIACollision(int monstroID){
            switch (monstroID)
            {
                case 1:
                    colisao1_1 = Stages.checkCollision(pictureBoxInimigo1, pictureBoxInimigo2);
                    colisao1_2 = Stages.checkCollision(pictureBoxInimigo1, pictureBoxInimigo3);
                    colisao1_3 = checkInimigoCollisionWall(pictureBoxInimigo1);
                    break;
                case 2:
                    colisao2_1 = Stages.checkCollision(pictureBoxInimigo2, pictureBoxInimigo1);
                    colisao2_2 = Stages.checkCollision(pictureBoxInimigo2, pictureBoxInimigo3);
                    colisao2_3 = checkInimigoCollisionWall(pictureBoxInimigo2);
                    break;
                case 3:
                    colisao3_1 = Stages.checkCollision(pictureBoxInimigo3, pictureBoxInimigo1);
                    colisao3_2 = Stages.checkCollision(pictureBoxInimigo3, pictureBoxInimigo2);
                    colisao3_3 = checkInimigoCollisionWall(pictureBoxInimigo3);
                    break;
            }
        }
        public void monstroIACollisionEscape(int monstroID, int rn){
            ClassDados.MonsterPosition posicao = inimigo1Pos;
            PictureBox monstro = null;
            int valorRegresso = 20;

            switch (monstroID){
                case 1:
                    posicao = inimigo1Pos;
                    monstro = pictureBoxInimigo1;
                    break;
                case 2:
                    posicao = inimigo2Pos;
                    monstro = pictureBoxInimigo2;
                    break;
                case 3:
                    posicao = inimigo3Pos;
                    monstro = pictureBoxInimigo3;
                    break;
            }

            if (posicao == ClassDados.MonsterPosition.Down){
                monstro.Top -= valorRegresso;
                switch (rn){
                    case 1:
                    case 2:
                        posicao = ClassDados.MonsterPosition.Up; break;
                    case 3:
                    case 4:
                        posicao = ClassDados.MonsterPosition.Right; break;
                    case 5:
                    case 6:
                        posicao = ClassDados.MonsterPosition.Left; break;
                }
            }
            else if (posicao == ClassDados.MonsterPosition.Up){
                monstro.Top += valorRegresso;
                switch (rn){
                    case 1:
                    case 2:
                        posicao = ClassDados.MonsterPosition.Down; break;
                    case 3:
                    case 4:
                        posicao = ClassDados.MonsterPosition.Right; break;
                    case 5:
                    case 6:
                        posicao = ClassDados.MonsterPosition.Left; break;
                }
            }
            else if (posicao == ClassDados.MonsterPosition.Right){
                monstro.Left -= valorRegresso;
                switch (rn){
                    case 1:
                    case 2:
                        posicao = ClassDados.MonsterPosition.Up; break;
                    case 3:
                    case 4:
                        posicao = ClassDados.MonsterPosition.Right; break;
                    case 5:
                    case 6:
                        posicao = ClassDados.MonsterPosition.Left; break;
                }
            }
            else if (posicao == ClassDados.MonsterPosition.Left){
                monstro.Left += valorRegresso;
                switch (rn){
                    case 1:
                    case 2:
                        posicao = ClassDados.MonsterPosition.Up; break;
                    case 3:
                    case 4:
                        posicao = ClassDados.MonsterPosition.Right; break;
                    case 5:
                    case 6:
                        posicao = ClassDados.MonsterPosition.Down; break;
                }
            }
            switch (monstroID)
            {
                case 1: inimigo1Pos = posicao; break;
                case 2: inimigo2Pos = posicao; break;
                case 3: inimigo3Pos = posicao; break;
            }
        }
        

        private void timerInimigo1_Tick(object sender, EventArgs e){
            inteligenciaMonstroMove(1);
            monstroIACollision(1);           

            if (colisao1_1 == true || colisao1_2 == true || colisao1_3 == true){
                int rn = RandomNumber.NextVal(1, 6);               
                monstroIACollisionEscape(1,rn);
            }            
        }

        //----------------------------------------------------
        // IA/movimentação do inimigo 2
        //----------------------------------------------------     
        private void timerInimigo2()
        {
            switch (ClassDados.Dificuldade){
                case ClassDados.GameDifficult.Facil:
                    inimigo2.Interval = 350;
                    break;
                case ClassDados.GameDifficult.Normal:
                    inimigo2.Interval = 250;
                    break;
                case ClassDados.GameDifficult.Dificil:
                    inimigo2.Interval = 100;
                    break;
            }
            inimigo2.Enabled = true;
            inimigo2.Tick += new System.EventHandler(timerInimigo2_Tick);
        }
        private void timerInimigo2_Tick(object sender, EventArgs e){
            inteligenciaMonstroMove(2);
            monstroIACollision(2);
            if (colisao2_1 == true || colisao2_2 == true || colisao2_3 == true){
                int rn = RandomNumber.NextVal(1, 6);                
                monstroIACollisionEscape(2, rn);
            }                         
        }

        //----------------------------------------------------
        // IA/movimentação do inimigo 3
        //----------------------------------------------------     
        private void timerInimigo3()
        {
            switch(ClassDados.Dificuldade){
                case ClassDados.GameDifficult.Facil:
                    inimigo3.Interval = 350;
                    break;
                case ClassDados.GameDifficult.Normal:
                    inimigo3.Interval = 250;
                    break;
                case ClassDados.GameDifficult.Dificil:
                    inimigo3.Interval = 100;
                    break;
            }
            inimigo3.Enabled = true;
            inimigo3.Tick += new System.EventHandler(timerInimigo3_Tick);
        }
        private void timerInimigo3_Tick(object sender, EventArgs e)
        {
            inteligenciaMonstroMove(3);
            monstroIACollision(3);
            if (colisao3_1 == true || colisao3_2 == true || colisao3_3 == true){
                int rn = RandomNumber.NextVal(1, 6);
                monstroIACollisionEscape(3, rn);
            }
        }

        //----------------------------------------------------
        // verifica se o comilao pegou a chave
        //----------------------------------------------------
        private void checkSnakyPegaChave(){
            if (ClassDados.TotalChaves > 0){
                if (Stages.checkCollision(snaky,Stages.Chave) == true){                
                    this.Controls.Remove(Stages.Chave);                    
                    ClassDados.TotalChaves -= 1;
                    labelTotalChaves.Text = Convert.ToString(ClassDados.TotalChaves);                    
                }
            }
        }

        //----------------------------------------------------
        // verifica se o comilao pegou uma maçã
        //----------------------------------------------------
        private void checkSnakyPegaMaca(){
            if (ClassDados.TotalMacas > 0){
                if (Stages.checkCollision(snaky,Stages.Maca) == true){
                    Stages.SomAndando.Enabled = false;

                    // remove a maçã pega
                    this.Controls.Remove(Stages.Maca);
                    if (ClassDados.Sons == ClassDados.GameSoundEffects.On){
                        Stages.playSoundMordida();
                    }
                    // aumenta os pontos (somente no label)
                    // não definitivamente: só aumenta ao passar de fase ou quando vidas == 0
                    ClassDados.setMaisPontosFase();
                    labelPontos.Text = Convert.ToString(ClassDados.PontosFase);                    

                    // diminui a quantidade de maçãs a pegar
                    ClassDados.TotalMacas -= 1;
                    labelTotalMacas.Text = Convert.ToString(ClassDados.TotalMacas);

                    // cria nova maça
                    if (ClassDados.TotalMacas > 0){
                        Stages.criarMaca();
                    }

                    Stages.SomAndandoAposMaca.Enabled = true;
                }
            }
        }

        //----------------------------------------------------
        // verifica se o comilao encontrou a porta
        //----------------------------------------------------
        private void checkSnakyEntraPorta(){
            if (Stages.checkCollision(snaky,Stages.Porta) == true){
                if (ClassDados.TotalChaves == 0 && ClassDados.TotalMacas == 0){
                    timerAnda.Enabled = false;
                    Stages.SomAndando.Enabled = false;
                    inimigo1.Enabled = false;
                    inimigo2.Enabled = false;
                    inimigo3.Enabled = false;
                    MessageBox.Show("Nível concluído!");
                    ClassDados.Nivel += 1;
                    ClassDados.Pontos += ClassDados.PontosFase;
                    FormGame frg = new FormGame();
                    frg.ShowDialog();
                    this.Close();
                }
            }
        }

        //----------------------------------------------------
        // eventos que acontecem quando o comilao é destruído
        //----------------------------------------------------
        private void perdeuJogo(){
            snaky.Image = Comilao.Properties.Resources.explosion;
            System.Drawing.Drawing2D.GraphicsPath gp = Transparent(snaky.Image);
            snaky.Region = new System.Drawing.Region(gp);
            timerAnda.Enabled = false;
            Stages.SomAndando.Enabled = false;
            decrementaTempo.Enabled = false;
            //inimigo1.Enabled = false;
            //inimigo2.Enabled = false;
            //inimigo3.Enabled = false;
            ClassDados.Perdeu = true;
            if (ClassDados.Sons == ClassDados.GameSoundEffects.On){
                Stages.playSoundExplosion();
            }
            ClassDados.Vidas -= 1;
        }

        //----------------------------------------------------
        // checa se o snaky colidiu com o muro
        //----------------------------------------------------
        private void checkCollisionWall(){
            foreach (Control ctl in this.Controls){
                if (ctl.GetType() == typeof(PictureBox)){
                    PictureBox pb2 = (PictureBox)ctl;
                    if (pb2.Name.ToString() == "wall"){
                        if (Stages.checkCollision(snaky, pb2) == true){
                            perdeuJogo();
                        }
                    }
                }
            }
        }

        //----------------------------------------------------
        // checa se algum inimigo colidiu com o muro
        //----------------------------------------------------
        private bool checkInimigoCollisionWall(PictureBox pbInimigo){
            foreach (Control ctl in this.Controls){
                if (ctl.GetType() == typeof(PictureBox)){
                    PictureBox pb2 = (PictureBox)ctl;
                    if (pb2.Name.ToString() == "wall"){
                        if (Stages.checkCollision(pbInimigo, pb2) == true){
                            return true;
                        }
                    }                    
                }
            }
            return false;
        }        

        protected void setInimigoPos(PictureBox inimigo, int x, int y){            
            inimigo.Location = new Point(x * 40,y * 40);
        }

        //----------------------------------------------------
        // construtor
        //----------------------------------------------------        
		public FormGame()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
           ClassDados.resetValues();
            labelNivel.Text = Convert.ToString(ClassDados.Nivel);
            labelPontos.Text = Convert.ToString(ClassDados.Pontos);
            labelTotalChaves.Text = Convert.ToString(ClassDados.TotalChaves);
            labelVidas.Text = Convert.ToString(ClassDados.Vidas);
            labelTotalMacas.Text = Convert.ToString(ClassDados.TotalMacas);
            labelDificuldade.Text = ClassDados.Dificuldade.ToString();           
            
            labelTempo.Text = "05:00";            
            
            // apresenta na tela o nível atual
            switch (ClassDados.Nivel){
                case 1:                    
                    setInimigoPos(pictureBoxInimigo1, 8, 3);
                    setInimigoPos(pictureBoxInimigo2, 9, 7);
                    setInimigoPos(pictureBoxInimigo3, 17, 11);
                    ClassDados.PosPersonagemX = 3;
                    ClassDados.PosPersonagemY = 6;
                    snaky.Location = ClassDados.getSnakyPos();
                    inimigo1Pos = ClassDados.MonsterPosition.Down;
                    inimigo2Pos = ClassDados.MonsterPosition.Right;
                    inimigo3Pos = ClassDados.MonsterPosition.Up;
                    ClassDados.PersonagemPos = ClassDados.PersonagemPosition.Down;
                    Stages.stage1(this.Controls);                    
                    break;
                case 2:                    
                    setInimigoPos(pictureBoxInimigo1, 8, 3);
                    setInimigoPos(pictureBoxInimigo2, 9, 7);
                    setInimigoPos(pictureBoxInimigo3, 17, 11);
                    ClassDados.PosPersonagemX = 2;
                    ClassDados.PosPersonagemY = 2;
                    snaky.Location = ClassDados.getSnakyPos();
                    inimigo1Pos = ClassDados.MonsterPosition.Down;
                    inimigo2Pos = ClassDados.MonsterPosition.Right;
                    inimigo3Pos = ClassDados.MonsterPosition.Up;
                    ClassDados.PersonagemPos = ClassDados.PersonagemPosition.Down;
                    Stages.stage2(this.Controls);
                    break;
                case 3:                    
                    setInimigoPos(pictureBoxInimigo1, 8, 3);
                    setInimigoPos(pictureBoxInimigo2, 4, 12);
                    setInimigoPos(pictureBoxInimigo3, 13, 8);
                    ClassDados.PosPersonagemX = 18;
                    ClassDados.PosPersonagemY = 2;
                    snaky.Location = ClassDados.getSnakyPos();
                    inimigo1Pos = ClassDados.MonsterPosition.Down;
                    inimigo2Pos = ClassDados.MonsterPosition.Right;
                    inimigo3Pos = ClassDados.MonsterPosition.Up;
                    ClassDados.PersonagemPos = ClassDados.PersonagemPosition.Down;
                    Stages.stage3(this.Controls);
                    break;
            }

            Stages.timerSomAndando();
            Stages.timerSomAndandoAposMaca();
            timerDecrementaTempo();

            switch (ClassDados.Dificuldade){
                case ClassDados.GameDifficult.Facil:
                    timerInimigo1();
                    pictureBoxInimigo1.Visible = true;
                    setInimigoPos(pictureBoxInimigo2, 0, 0);
                    setInimigoPos(pictureBoxInimigo3, 0, 0);
                    pictureBoxInimigo2.Visible = false;
                    pictureBoxInimigo3.Visible = false;
                    break;
                case ClassDados.GameDifficult.Normal:
                    timerInimigo1();
                    timerInimigo2();
                    pictureBoxInimigo1.Visible = true;
                    pictureBoxInimigo2.Visible = true;
                    pictureBoxInimigo3.Visible = false;
                    setInimigoPos(pictureBoxInimigo3, 0, 0);
                    break;
                case ClassDados.GameDifficult.Dificil:
                    timerInimigo1();
                    timerInimigo2();
                    timerInimigo3();
                    pictureBoxInimigo1.Visible = true;
                    pictureBoxInimigo2.Visible = true;
                    pictureBoxInimigo3.Visible = true;
                    break;
            }

            // apresenta na tela o personagem selecionado
            switch (ClassDados.Personagem)
            {
                case ClassDados.GameCharacter.Snaky:
                    Stages.ImagemPersonagemUp = Comilao.Properties.Resources.snakyUp;
                    Stages.ImagemPersonagemDown = Comilao.Properties.Resources.snakyDown;
                    Stages.ImagemPersonagemLeft = Comilao.Properties.Resources.snakyLeft;
                    Stages.ImagemPersonagemRight = Comilao.Properties.Resources.snakyRight;
                    break;
                case ClassDados.GameCharacter.Punky:
                    Stages.ImagemPersonagemUp = Comilao.Properties.Resources.punkyUp;
                    Stages.ImagemPersonagemDown = Comilao.Properties.Resources.punkyDown;
                    Stages.ImagemPersonagemLeft = Comilao.Properties.Resources.punkyLeft;
                    Stages.ImagemPersonagemRight = Comilao.Properties.Resources.punkyRight;
                    break;
                case ClassDados.GameCharacter.Mario:
                    Stages.ImagemPersonagemUp = Comilao.Properties.Resources.marioUp;
                    Stages.ImagemPersonagemDown = Comilao.Properties.Resources.marioDown;
                    Stages.ImagemPersonagemLeft = Comilao.Properties.Resources.marioLeft;
                    Stages.ImagemPersonagemRight = Comilao.Properties.Resources.marioRight;
                    break;
            }
            snaky.Image = Stages.getImagemPersonagem();
            timerAnda.Enabled = true;
            decrementaTempo.Enabled = true;
		}

        public static System.Drawing.Drawing2D.GraphicsPath Transparent(Image im)
        {
            int x;
            int y;
            Bitmap bmp = new Bitmap(im);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            Color mask = bmp.GetPixel(0, 0);

            for (x = 0; x <= bmp.Width - 1; x++)
            {
                for (y = 0; y <= bmp.Height - 1; y++)
                {
                    if (!bmp.GetPixel(x, y).Equals(mask))
                    {
                        gp.AddRectangle(new Rectangle(x, y, 1, 1));
                    }
                }
            }
            bmp.Dispose();
            return gp;

        }
		
		void TimerAndaTick(object sender, EventArgs e)
		{
	        if (Stages.checkCollision(snaky, pictureBoxInimigo1) || Stages.checkCollision(snaky, pictureBoxInimigo2) || Stages.checkCollision(snaky, pictureBoxInimigo3))
            {
                perdeuJogo();
            }
            switch (ClassDados.PersonagemPos){
                case ClassDados.PersonagemPosition.Right:
                    ClassDados.incrementPosx();
                    break;
                case ClassDados.PersonagemPosition.Down:
                    ClassDados.incrementPosy();
                    break;
                case ClassDados.PersonagemPosition.Left:
                    ClassDados.decrementPosx();                    
                    break;
                case ClassDados.PersonagemPosition.Up:
                    ClassDados.decrementPosy();                    
                    break;                    
            }
            snaky.Location = ClassDados.getSnakyPos();

            checkSnakyPegaChave();
            checkSnakyEntraPorta();
            checkCollisionWall();
            checkSnakyPegaMaca();
		}
		void FormGameFormClosing(object sender, FormClosingEventArgs e)
		{
	        timerAnda.Enabled = false;
            Stages.SomAndando.Enabled = false;
            inimigo1.Enabled = false;
            inimigo2.Enabled = false;
            inimigo3.Enabled = false;
            ClassDados.Perdeu = true;  
		}
		void FormGameKeyDown(object sender, KeyEventArgs e)
		{
	        if (ClassDados.Perdeu == false){
                if (e.KeyCode == Keys.Right){
                    if (ClassDados.PersonagemPos != ClassDados.PersonagemPosition.Left && ClassDados.PersonagemPos != ClassDados.PersonagemPosition.Right)
                    {
                        ClassDados.PersonagemPos = ClassDados.PersonagemPosition.Right;                        
                    }
                }
                else if (e.KeyCode == Keys.Down){
                    if (ClassDados.PersonagemPos != ClassDados.PersonagemPosition.Up && ClassDados.PersonagemPos != ClassDados.PersonagemPosition.Down)
                    {
                        ClassDados.PersonagemPos = ClassDados.PersonagemPosition.Down;
                    }
                }
                else if (e.KeyCode == Keys.Left){
                    if (ClassDados.PersonagemPos != ClassDados.PersonagemPosition.Right && ClassDados.PersonagemPos != ClassDados.PersonagemPosition.Left)
                    {
                        ClassDados.PersonagemPos = ClassDados.PersonagemPosition.Left;                        
                    }
                }
                else if (e.KeyCode == Keys.Up){
                    if (ClassDados.PersonagemPos != ClassDados.PersonagemPosition.Down && ClassDados.PersonagemPos != ClassDados.PersonagemPosition.Up)
                    {
                        ClassDados.PersonagemPos = ClassDados.PersonagemPosition.Up;                        
                    }
                }
                snaky.Image = Stages.getImagemPersonagem();
            }
		}
		void FormGameLoad(object sender, EventArgs e)
		{
	
		}
	}
}
