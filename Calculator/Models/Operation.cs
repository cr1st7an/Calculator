using System;

namespace Calculator.Models;

public class Operation
{public bool EsMultiploDe5(int numero)
        {
            return numero % 5 == 0;
        }

        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            if (numero2 == 0)
                throw new DivideByZeroException("El divisor no puede ser 0.");
            return numero1 / numero2;
        }
}
