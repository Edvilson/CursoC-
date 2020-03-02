using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes{

    public class Program{

        public static void Main(String[] args){

            var Nomes = new string[]{
                "Angélica",
                "Edvilson",
                "Burgos"
            };

            foreach (var nome in Nomes)
            {
                Console.WriteLine(nome);
            }

            var Cidades = new List<string>{
                "Pelotas",
                "Rio Grande",
                "Porto Alegre"
            };

            foreach (var cidade in Cidades)
            {
                Console.WriteLine(cidade);
            }

            //Filtrar Dados

 //           var Filtro = from c in Cidades
 //                        where c.startswith("s")
 //                        select c;

        }


    }

}