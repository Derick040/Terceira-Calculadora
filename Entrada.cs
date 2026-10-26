using System;

namespace CalculadoraArquivo
{
    class MinhaCalculadora
    {
        public static double Calculadora(double n1, double n2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return n1 + n2;

                case "-":
                    return n1 - n2;

                case "*":
                    return n1 * n2;

                case "/":
                    return n1 / n2;

                default:
                    return 0;
            }
        }
    }
}