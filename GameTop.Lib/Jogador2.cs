using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chutar()
        {
            return "Maradona estas Pateando \n";
        }

        public string Correr()
        {
            return "Maradona estas Corriendo \n";
        }

        public string Passar()
        {
            return "Maradona estas Pasando \n";
        }
    }
}