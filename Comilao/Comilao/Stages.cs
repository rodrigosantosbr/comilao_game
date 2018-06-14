using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Media;


namespace Comilao{
    class Stages{
        static PictureBox chave;
        static PictureBox porta;
        static PictureBox maca;        

        static int totalMacasMaximo = 10;
        static int[] posicoesValidasMacax = new int[totalMacasMaximo];
        static int[] posicoesValidasMacay = new int[totalMacasMaximo];
        static int indiceAtualPosicaoValida;

        // efeitos sonoros do jogo
        static SoundPlayer spMordida   = new SoundPlayer("mordida.wav");
        static SoundPlayer spExplosion = new SoundPlayer("explosion.wav");
        static SoundPlayer spAndando   = new SoundPlayer("andando.wav");

        // imagens dos personagens a cada movimento
        static Image imagemPersonagemUp;
        static Image imagemPersonagemDown;
        static Image imagemPersonagemLeft;
        static Image imagemPersonagemRight;
        
        // formulário do jogo
        static Control.ControlCollection controlForm;

        static int[][] stageGrade;        

        // timer para o barulho do som da movimentação do personagem
        static Timer somAndando = new Timer();
        // timer para ativar o barulho do som da movimentação após ele comer a maçã
        static Timer somAndandoAposMaca = new Timer();
        
        //----------------------------------------------------
        // efeito sonoro: movimentação do snaky
        //----------------------------------------------------
        public static void timerSomAndando(){
            somAndando.Interval = 350;
            somAndando.Enabled = true;
            somAndando.Tick += new System.EventHandler(timerSomAndando_Tick);
        }
        public static void timerSomAndando_Tick(object sender, EventArgs e){
            if (ClassDados.Sons == ClassDados.GameSoundEffects.On){
                playSoundAndando();
            }
        }
        public static Timer SomAndando{
            get{
                return somAndando;
            }
        }

        //----------------------------------------------------
        // ativa barulho da movimentação após comer a maçã
        //----------------------------------------------------
        public static void timerSomAndandoAposMaca(){
            somAndandoAposMaca.Interval = 300;
            somAndandoAposMaca.Enabled = false;
            somAndandoAposMaca.Tick += new System.EventHandler(timerSomAndandoAposMaca_Tick);
        }
        public static void timerSomAndandoAposMaca_Tick(object sender, EventArgs e){
            Stages.SomAndando.Enabled = true;
            somAndandoAposMaca.Enabled = false;
        }
        public static Timer SomAndandoAposMaca{
            get{
                return somAndandoAposMaca;
            }
        }        

        //----------------------------------------------------
        // funções para executar os efeitos sonoros do jogo
        //----------------------------------------------------
        public static void playSoundMordida(){
            spMordida.Play();
        }
        public static void playSoundExplosion(){
            spExplosion.Play();
        }
        public static void playSoundAndando(){
            spAndando.Play();
        }

        //----------------------------------------------------
        // imagens dos personagens em cada movimento
        //----------------------------------------------------      
        public static Image ImagemPersonagemUp{
            get{
                return imagemPersonagemUp;
            }
            set{
                imagemPersonagemUp = value;
            }
        }
        public static Image ImagemPersonagemDown{
            get{
                return imagemPersonagemDown;
            }
            set{
                imagemPersonagemDown = value;
            }
        }
        public static Image ImagemPersonagemLeft{
            get{
                return imagemPersonagemLeft;
            }
            set{
                imagemPersonagemLeft = value;
            }
        }
        public static Image ImagemPersonagemRight{
            get{
                return imagemPersonagemRight;
            }
            set{
                imagemPersonagemRight = value;
            }
        }        
        public static Image getImagemPersonagem(){            
            if (ClassDados.PersonagemPos == ClassDados.PersonagemPosition.Down){
                return imagemPersonagemDown;
            }
            else if (ClassDados.PersonagemPos == ClassDados.PersonagemPosition.Left){
                return imagemPersonagemLeft;
            }
            else if (ClassDados.PersonagemPos == ClassDados.PersonagemPosition.Right){
                return imagemPersonagemRight;
            }
            else if (ClassDados.PersonagemPos == ClassDados.PersonagemPosition.Up){
                return imagemPersonagemUp;
            }
            return null;
        }

        //----------------------------------------------------
        // funções de preenchimento da grade
        //----------------------------------------------------
        public static int[][] getStageGrade(){
            return stageGrade;
        }

        public static int getStageGrade(int indice1, int indice2){
            return stageGrade[indice1][indice2];
        }
        
        public static void setStageGrade(int indice1, int indice2, int val){
            stageGrade[indice1][indice2] = val;
        }

        //----------------------------------------------------
        // detecta se um objeto encontra outro (colisão)
        //----------------------------------------------------
        public static bool checkCollision(PictureBox p1, PictureBox p2){
            return p1.Bounds.IntersectsWith(p2.Bounds);
        }

        //----------------------------------------------------
        // retorna as identificações dos PictureBox chave, maçã e porta
        //----------------------------------------------------
        public static PictureBox Chave{
            get{
                return chave;
            }
            set{
                chave = value;
            }
        }
        public static PictureBox Porta{
            get{
                return porta;
            }
            set{
                porta = value;
            }
        }
        public static PictureBox Maca{
            get{
                return maca;
            }
            set{
                maca = value;
            }
        }    
        
        //----------------------------------------------------
        // insere uma maçã em um espaço disponível
        //----------------------------------------------------
        public static void criarMaca(){
            int xReal = posicoesValidasMacax[indiceAtualPosicaoValida] * ClassDados.GET_TAMANHO_IMAGENS_PIXELS;
            int yReal = posicoesValidasMacay[indiceAtualPosicaoValida] * ClassDados.GET_TAMANHO_IMAGENS_PIXELS;
            maca           = new PictureBox();
            maca.Location  = new Point(xReal, yReal);
            maca.Size      = new Size(40, 40);
            maca.Image     = Comilao.Properties.Resources.apple;
            maca.Name      = "maca";            
            controlForm.Add(maca);                      
            indiceAtualPosicaoValida++;            
        }

        //----------------------------------------------------
        // insere uma chave em uma posicao x,y
        //----------------------------------------------------
        public static void criarChave(int x, int y){
            int xReal = x * ClassDados.GET_TAMANHO_IMAGENS_PIXELS;
            int yReal = y * ClassDados.GET_TAMANHO_IMAGENS_PIXELS;
            chave          = new PictureBox();
            chave.Location = new Point(xReal, yReal);
            chave.Size     = new Size(40, 30);
            chave.Image    = Comilao.Properties.Resources.key;
            chave.Name     = "chave";
            controlForm.Add(chave);            
            setStageGrade(x, y, 1);
        }

        //----------------------------------------------------
        // insere uma chave em uma posicao aleatória
        //----------------------------------------------------
        public static void criarChave(){
            int indice1 = 0;
            int indice2 = 0;
            bool posvalida = false;
            while (posvalida == false){
                indice1 = RandomNumber.NextVal(1, 18);
                indice2 = RandomNumber.NextVal(1, 13);
                if (stageGrade[indice1][indice2] == 0){
                    posvalida = true;                    
                }                
            }
            criarChave(indice1, indice2);            
        }

        //----------------------------------------------------
        // insere um muro (bloco) em uma posicao x,y
        //----------------------------------------------------
        public static void criarMuro(int x, int y){
            int xReal = x * ClassDados.GET_TAMANHO_IMAGENS_PIXELS;
            int yReal = y * ClassDados.GET_TAMANHO_IMAGENS_PIXELS;
            PictureBox muro = new PictureBox();
            muro.Location = new Point(xReal, yReal);            
            muro.Name     = "wall";
            muro.Size     = new Size(40, 40);
            muro.Image    = Comilao.Properties.Resources.wall;            
            controlForm.Add(muro);
            setStageGrade(x, y, 1);
        }

        //----------------------------------------------------
        // insere uma porta em uma posicao x,y
        //----------------------------------------------------
        public static void criarPorta(int x, int y){
            int xReal = x * ClassDados.GET_TAMANHO_IMAGENS_PIXELS;
            int yReal = y * ClassDados.GET_TAMANHO_IMAGENS_PIXELS;
            porta = new PictureBox();
            porta.Location = new Point(xReal, yReal);
            porta.Size     = new Size(40, 33);            
            porta.Image    = Comilao.Properties.Resources.door;
            porta.Name     = "porta";
            controlForm.Add(porta);            
            setStageGrade(x, y, 1);
        }

        //----------------------------------------------------
        // insere uma porta em uma posicao aleatória
        //----------------------------------------------------
        public static void criarPorta(){
            int indice1 = 0;
            int indice2 = 0;
            bool posvalida = false;

            while (posvalida == false){
                indice1 = RandomNumber.NextVal(1, 18);
                indice2 = RandomNumber.NextVal(1, 13);
                if (stageGrade[indice1][indice2] == 0){
                    posvalida = true;
                }
            }

            criarPorta(indice1, indice2);            
        }
        

        //----------------------------------------------------
        // cria a muralha em volta da tela (bordas)
        //----------------------------------------------------
        private static void fazMuralha() {
            // lado cima e baixo
            for (int i = 0; i <= 19; i++){
                criarMuro(i, 0);
                criarMuro(i, 14);
            }
            // esquerda e direita
            for (int i = 1; i <= 13; i++){
                criarMuro(0, i);
                criarMuro(19, i);
            }           
        }        

        public static void criarPosicoesMaca(){
            int indice1 = 0;
            int indice2 = 0;           
            bool posvalida = false;

            for (int i = 0; i < totalMacasMaximo; i++){
                while (posvalida == false){
                    indice1 = RandomNumber.NextVal(1, 18);
                    indice2 = RandomNumber.NextVal(1, 13);
                    if (stageGrade[indice1][indice2] == 0){
                        posvalida = true;
                    }
                }
                posvalida = false;
                posicoesValidasMacax[i] = indice1;
                posicoesValidasMacay[i] = indice2;
            }

            indiceAtualPosicaoValida = 0;
        }

        public static void fillZeroStageGrade(){
            stageGrade = new int[20][];
            for (int i = 0; i <= 19; i++){
                stageGrade[i] = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }
        }

        //----------------------------------------------------
        // desenha a fase 1
        //----------------------------------------------------
        public static void stage1(Control.ControlCollection c2){
            fillZeroStageGrade();           

            controlForm = c2;
            fazMuralha();            

            // colunas - baixo            
            for (int i = 10; i <= 13; i++){
                criarMuro(5, i);
                criarMuro(14, i);
            }            

            // coluna - cima
            for (int i = 1; i <= 4; i ++){
                criarMuro(10, i);
            }

            switch(ClassDados.Dificuldade){
                case ClassDados.GameDifficult.Facil:
                    criarChave(17, 2);
                    criarPorta(10, 13);
                    break;
                case ClassDados.GameDifficult.Normal:
                    criarChave();
                    criarPorta(10, 13);
                    break;
                case ClassDados.GameDifficult.Dificil:
                    criarChave();
                    criarPorta();
                    break;
            }            
            criarPosicoesMaca();
            criarMaca();            
        }

        //----------------------------------------------------
        // desenha a fase 2
        //----------------------------------------------------
        public static void stage2(Control.ControlCollection c2){
            fillZeroStageGrade();

            controlForm = c2;
            fazMuralha();
           
            criarMuro(2, 12);
            criarMuro(3, 12);
            criarMuro(4, 11);
            criarMuro(5, 10);
            criarMuro(10, 13);
            criarMuro(10, 10);
            criarMuro(10, 9);
            criarMuro(10, 5);
            criarMuro(10, 4);
            criarMuro(10, 1);
            criarMuro(13, 5);
            criarMuro(14, 4);
            criarMuro(15, 3);
            criarMuro(16, 3);        
                       
            switch(ClassDados.Dificuldade){
                case ClassDados.GameDifficult.Facil:
                    criarChave(17, 2);
                    criarPorta(5, 9);
                    break;
                case ClassDados.GameDifficult.Normal:
                    criarChave();
                    criarPorta(5, 9);
                    break;
                case ClassDados.GameDifficult.Dificil:
                    criarChave();
                    criarPorta();
                    break;
            }

            criarPosicoesMaca();
            criarMaca();           
        }

        //----------------------------------------------------
        // desenha a fase 3
        //----------------------------------------------------
        public static void stage3(Control.ControlCollection c2){
            fillZeroStageGrade();

            controlForm = c2;
            fazMuralha();

            criarMuro(3, 3);
            criarMuro(3, 4);
            criarMuro(3, 5);
            criarMuro(3, 10);
            criarMuro(3, 11);
            criarMuro(3, 12);

            criarMuro(15, 3);
            criarMuro(15, 4);
            criarMuro(15, 5);
            criarMuro(15, 10);
            criarMuro(15, 11);
            criarMuro(15, 12);

            criarMuro(10, 1);
            criarMuro(10, 4);
            criarMuro(10, 7);
            criarMuro(10, 10);
            criarMuro(10, 13);

            criarMuro(9, 5);
            criarMuro(9, 9);
            criarMuro(11, 5);
            criarMuro(11, 9);

            switch(ClassDados.Dificuldade){
                case ClassDados.GameDifficult.Facil:
                    criarChave(3, 2);
                    criarPorta(14, 12);
                    break;
                case ClassDados.GameDifficult.Normal:
                    criarChave();
                    criarPorta(14, 12);
                    break;
                case ClassDados.GameDifficult.Dificil:
                    criarChave();
                    criarPorta();
                    break;
            }

            criarPosicoesMaca();
            criarMaca();           
        }
        

    }
}