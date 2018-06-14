using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace Comilao
{
    class ClassDados
    {
        // estrutura que define as dificuldades do jogo
        public enum GameDifficult{
            Facil,Normal,Dificil
        }

        // estrutura que define os personagem do jogo
        public enum GameCharacter{
            Snaky,Punky,Mario
        }
        
        // estrutura que define os efeitos sonoros do jogo (ligado, desligado)
        public enum GameSoundEffects{
            On, Off
        }
        
        // estrutura que define as possíveis movimentações do personagem
        public enum PersonagemPosition{
            Left,Right,Up,Down
        }
        
        // estrutura que define as possíveis movimentações dos monstros
        public enum MonsterPosition{
            Left,Right,Up,Down
        }     
        
        // define quantos pontos valem cada maçã comida
        private const int PONTOS_ACRESCENTAR = 5;
        
        // define quantos passos o personagem anda na tela
        private const int PASSOS_ANDAR = 20;

        // define o tamanho dos picture box
        const int TAMANHO_IMAGENS_PIXELS = 40;
        
        // define a dificuldade do jogo (padrão: Média)
        static GameDifficult dificuldade = GameDifficult.Normal;
        
        // define o personagem do jogo (padrão: Snaky)
        static GameCharacter personagem = GameCharacter.Snaky;
        
        // define se o jogo vai ter ou não efeitos sonoros
        static GameSoundEffects sons = GameSoundEffects.On;
        
        // define a quantidade de pontos no jogo
        static int pontos = 0;

        // define a quantidade de pontos na fase
        static int pontosFase = 0;
        
        // define o nível (fase) do jogo
        static int nivel = 1;

        // define a quantidade de vidas do personagem
        static int vidas = 3;
        
        // define a quantidade de maçãs pegas no jogo
        static int totalMacas;
        
        // define a quantidade de chaves pegas no jogo
        static int totalChaves;
        
        // define se o personagem bateu no muro ou em um monstro
        static bool perdeu = false;

        // define se o personagem Mario está disponível (habilitado)
        static bool personagemMario = false;
        
        // define o posicionamento do personagem na tela
        static int posPersonagemX;
        static int posPersonagemY;

        // posicionamento do personagem
        static PersonagemPosition personagemPos = PersonagemPosition.Down;

        // tempo decorrido
        static int minutos = 5;
        static int segundos = 0;

        //----------------------------------------------------
        // retorna os minutos decorridos do jogo
        //----------------------------------------------------
        public static int Minutos {
            get{
                return minutos;
            }
            set{
                minutos = value;
            }
        }
        //----------------------------------------------------
        // retorna os segundos decorridos do jogo
        //----------------------------------------------------
        public static int Segundos{
            get{
                return segundos;
            }
            set{
                segundos = value;
            }
        }
        

        public static void resetValues(){            
            perdeu = false;
            TotalChaves = 1;
            TotalMacas = 10;
            minutos = 5;
            segundos = 0;
        }

        //----------------------------------------------------
        // retorna o tamanho das imagens em pixels
        //----------------------------------------------------
        public static int GET_TAMANHO_IMAGENS_PIXELS{
            get{
                return TAMANHO_IMAGENS_PIXELS;
            }
        }
        //----------------------------------------------------
        // retorna a quantidade de espaços em pixels que o personagem anda
        //----------------------------------------------------
        public static int GET_PASSOS_ANDAR{
            get{
                return PASSOS_ANDAR;
            }
        }
        //----------------------------------------------------
        // retorna a quantidade de pontos que se ganha ao comer uma maça
        //----------------------------------------------------
        public static int GET_PONTOS_ACRESCENTAR{
            get{
                return PONTOS_ACRESCENTAR;
            }
        }

        //----------------------------------------------------
        // define a quantidade de vidas do personagem
        //----------------------------------------------------
        public static PersonagemPosition PersonagemPos
        {
            get{
                return personagemPos;
            }
            set{
                personagemPos = value;
            }
        }

        //----------------------------------------------------
        // define a quantidade de vidas do personagem
        //----------------------------------------------------
        public static bool PersonagemMario{
            get{
                return personagemMario;
            }
            set{
                personagemMario = value;
            }
        }

        //----------------------------------------------------
        // define a quantidade de vidas do personagem
        //----------------------------------------------------
        public static int Vidas{
            get{
                return vidas;
            }
            set{
                vidas = value;
            }
        }

        //----------------------------------------------------
        // define o nível (fase) do jogo
        //----------------------------------------------------
        public static int Nivel{
            get{
                return nivel;
            }
            set{
                nivel = value;
            }
        }
        
        //----------------------------------------------------
        // define se o snaky foi destruido ou nao
        //----------------------------------------------------
        public static bool Perdeu{
            get{
                return perdeu;
            }
            set{
                perdeu = value;
            }
        }        

        //----------------------------------------------------
        // define se o jogo vai ter sons ou não
        //----------------------------------------------------
        public static GameSoundEffects Sons{
            get{
                return sons;
            }
            set{
                sons = value;
            }
        }

        //----------------------------------------------------
        // define o personagem do jogo
        //----------------------------------------------------
        public static GameCharacter Personagem{
            get{
                return personagem;
            }
            set{
                personagem = value;
            }
        }


        //----------------------------------------------------
        // define a dificuldade do jogo
        //----------------------------------------------------
        public static GameDifficult Dificuldade{
            get{
                return dificuldade;
            }
            set{
                dificuldade = value;
            }
        }

        //----------------------------------------------------
        // define a quantidade de chaves a ser pega nas fases
        //----------------------------------------------------
        public static int TotalChaves{
            get {
                return totalChaves;
            }
            set{
                totalChaves = value;
            }
        }

        //----------------------------------------------------
        // define a quantidade de maçãs a ser pega nas fases
        //----------------------------------------------------
        public static int TotalMacas{
            get{
                return totalMacas;
            }
            set{
                totalMacas = value;
            }
        }        

        //----------------------------------------------------
        // define a quantidade de pontos no jogo
        //----------------------------------------------------
        public static int Pontos{
            get{
                return pontos;
            }
            set{
                pontos = value;
            }
        }        

        //----------------------------------------------------
        // define a quantidade de pontos na fase
        //----------------------------------------------------
        public static int PontosFase {
            get{
                return pontosFase;
            }
            set{
                pontosFase = value;
            }
        }

        public static void setMaisPontosFase(){
            pontosFase += GET_PONTOS_ACRESCENTAR;
        }

        //----------------------------------------------------
        // define o posicionamento da cobra
        //----------------------------------------------------
        public static int PosPersonagemX{
            get{
                return posPersonagemX;
            }
            set{
                posPersonagemX = value * GET_TAMANHO_IMAGENS_PIXELS;
            }
        }
        public static int PosPersonagemY{
            get{
                return posPersonagemY;
            }
            set{
                posPersonagemY = value * GET_TAMANHO_IMAGENS_PIXELS;
            }
        }
        public static void incrementPosx(){
            posPersonagemX += GET_PASSOS_ANDAR;
        }
        public static void decrementPosx(){
            posPersonagemX -= GET_PASSOS_ANDAR;
        }
        public static void incrementPosy(){
            posPersonagemY += GET_PASSOS_ANDAR;
        }
        public static void decrementPosy(){
            posPersonagemY -= GET_PASSOS_ANDAR;
        }
        public static Point getSnakyPos(){
            return new Point(posPersonagemX, posPersonagemY);
        }     
    }
}
