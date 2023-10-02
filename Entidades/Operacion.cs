namespace Entidades
{
    public class Operacion
    {
        private Numeracion PrimerOperando { get; set; }
        private Numeracion SegundoOperando { get; set; }

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            PrimerOperando = primerOperando;
            SegundoOperando = segundoOperando;
        }

        public Numeracion Operar(char operador)
        {
            switch (operador)
            {
                case '-':
                    return PrimerOperando - SegundoOperando;
                case '*':
                    return PrimerOperando * SegundoOperando;
                case '/':
                    return PrimerOperando / SegundoOperando;
                default:
                    return PrimerOperando + SegundoOperando;
            }
        }
    }
}






