using System;

namespace Metodos{

    public class Program{

        public static void Main(String[] args){
            var Numeros =  ColecaoNumeros();
            Iteracao(Numeros);
        }

        private static void Iteracao(int[] numeros){
             foreach (var item in Numeros)
            {
                Console.WriteLine(item);
            }

        }
        private static int[] ColecaoNumeros(){
            return new int[]{1, 2, 3, 4, 5};
        }

    }

}