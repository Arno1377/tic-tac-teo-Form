using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_teo_Form
{
    class Player
    {
        private char playersighn;
        private int playermoves;
        private int playerwins;
        private int playergames;
        //constructor
        public Player(char XO, int Moves, int Wins, int Games)
        {
            playersighn = XO;
            playermoves = Moves;
            playerwins = Wins;
            playergames = Games;
        }
        //destructor
        ~Player() 
        {

        }
        public int getmoves()
        {
            return playermoves;
        }
        public int getgames()
        {
            return playergames;
        }
        public int getwins()
        {
            return playerwins;
        }

        public void increaseMoves()
        {
            playermoves++;
        }
        public void increasegames()
        {
            playergames++;
        }
        public void increaseWins()
        {
            playerwins++;
        }
    };
}
