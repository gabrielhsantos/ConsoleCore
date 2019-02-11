using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chutar()
        {
            return "teste Chutando \n";
        }

        public string Correr()
        {
            return "teste Correndo \n";
        }

        public string Passar()
        {
            return "teste Passando \n";
        }
    }
}