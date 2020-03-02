using System;

namespace Loops{

    public class Program{

        public static void Main(String[] args){

            var Numeros = new int[]{1, 2, 3, 4, 5};

            for (int i = 1; i <= Numeros.Length; i++)
            {
                Console.WriteLine(i);
            }

            foreach (var item in Numeros)
            {
                Console.WriteLine(item);
            }

            var temp=0;

            while (temp < numeros.length)
            {
                Console.WriteLine(temp);
                temp++;
            }

        }

    }

}