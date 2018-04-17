using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITUniver.TeleCalc.Core;

namespace ITUniver.TeleCalc.ConCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var acc = new Calc();
            
            if (args.Length != 3)
            {
                var spisok = acc.operationPub();
                foreach (var item in spisok)
                {
                    Console.WriteLine(item.Name + "\n");
                }
                
                Console.ReadKey();
                return;
            }

            string opName = args[0].ToLower();
            double x = double.Parse(args[1]);
            double y = double.Parse(args[2]);
            double? con = acc.Exec(opName, x, y);

            Console.WriteLine(string.Format("{0}{1}{2} = {3}", x, opName, y, con));
            Console.ReadKey();

        }
    }
}
