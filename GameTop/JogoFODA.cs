using GameTop.Interface;

namespace GameTop
{
    public class JogoFODA
    {
        private readonly IJogador _jogadorA;

        private readonly IJogador _jogadorB;

        public JogoFODA(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.Write(_jogadorA.Correr());
            System.Console.Write(_jogadorA.Chutar());
            System.Console.Write(_jogadorA.Passar());
            //
            System.Console.Write("\n PRÓXIMO JOGADOR \n");
            //
            System.Console.Write(_jogadorB.Correr());
            System.Console.Write(_jogadorB.Chutar());
            System.Console.Write(_jogadorB.Passar());
        }
    }
}