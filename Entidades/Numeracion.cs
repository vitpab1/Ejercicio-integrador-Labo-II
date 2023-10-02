using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class Numeracion
    {
        public enum ESistema
        {
            Decimal,
            Binario
        };

        private ESistema sistema;
        private double valorNumerico;

        private ESistema Sistema => sistema;
        private string Valor => ConvertirA(sistema);

        public Numeracion(double valor, ESistema sistema)
        {
            InicializarValores(valor.ToString(), sistema);
        }

        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        private void InicializarValores(string valor, ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                if (!double.TryParse(valor, out valorNumerico))
                {
                    valorNumerico = double.MinValue;
                }
            }
            else if (sistema == ESistema.Binario && EsBinario(valor))
            {
                valorNumerico = BinarioDecimal(valor);
            }
            else
            {
                valorNumerico = double.MinValue;
            }

            this.sistema = sistema;
        }

        public string ConvertirA(ESistema sistema)
        {
            if (sistema == this.sistema)
            {
                return valorNumerico.ToString();
            }
            else if (sistema == ESistema.Binario)
            {
                return DecimalABinario(Valor);
            }
            else
            {
                return BinarioDecimal(Valor).ToString();
            }
        }

        private bool EsBinario(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private string DecimalABinario(int valor)
        {
            return Convert.ToString(valor, 2);
        }

        private string DecimalABinario(string valor)
        {
            if (!int.TryParse(valor, out int decimalNumero))
            {
                return "Numero invalido";
            }
            return DecimalABinario(decimalNumero);
        }

        private double BinarioDecimal(string valor)
        {
            return Convert.ToInt32(valor, 2);
        }

        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            double suma = n1.valorNumerico + n2.valorNumerico;
            return new Numeracion(suma, ESistema.Decimal);
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            double resta = n1.valorNumerico - n2.valorNumerico;
            return new Numeracion(resta, ESistema.Decimal);
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            double multiplicacion = n1.valorNumerico * n2.valorNumerico;
            return new Numeracion(multiplicacion, ESistema.Decimal);
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            if (n2.valorNumerico == 0)
            {
                return new Numeracion(double.MinValue, ESistema.Decimal);
            }
            double division = n1.valorNumerico / n2.valorNumerico;
            return new Numeracion(division, ESistema.Decimal);
        }

        public static bool operator ==(Numeracion numeroUno, Numeracion numeroDos)
        {
            return numeroUno.Sistema == numeroDos.Sistema;
        }

        public static bool operator !=(Numeracion numeroUno, Numeracion numeroDos)
        {
            return !(numeroUno == numeroDos);
        }

        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }

    }
}