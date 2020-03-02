using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionarios{

    public class Program{

        public static void Main(String[] args){

            var d = new Dictionary<string, string>();

            d.Add("RS", "Pelotas");
            d.Add("SP", "Barueri");
            d.Add("SC", "Floripa");

            Console.WriteLine(d["RS"]);

            var cidade = d.Keys.Where(x => x.StartsWith("S"));

            foreach (var item in cidade)
            {
                Console.WriteLine(item);
            }
        }


    }

}