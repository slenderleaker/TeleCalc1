using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.ConCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc Calculator = new Calc();
            int x;
            int y;
           // bool comp = int.TryParse(args[1], out x) && int.TryParse(args[2], out y);
            
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                switch (args[0].ToLower())
                {
                    case "sum":
                        Console.WriteLine((Double)Calculator.Sum(x, y));
                        break;
                    case "sub":
                        Console.WriteLine((Double)Calculator.Sub(x, y));
                        break;
                    case "mul":
                        Console.WriteLine((Double)Calculator.Mul(x, y));
                        break;
                    case "div":
                        Console.WriteLine((Double)Calculator.Div(x, y));
                        break;
                    case "mod":
                        Console.WriteLine((Double)Calculator.Mod(x, y));
                        break;
                    case "exp":
                        Console.WriteLine((Double)Calculator.Exp(x, y));
                        break;
                    default:
                        Console.WriteLine("Операция не существует в данном контексте");
                        break;
                 }
            } else
            {
                Console.WriteLine("Операция не существует в данном контексте");
            }
            Console.ReadLine();
        }
    }
}
