using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.Core.Operations
{
    internal class Exp : IOperation
    {

        public string Name => "exp";

        public double[] Args
        {
            set
            {
                var exp = 0d;
                foreach (var item in value)
                {
                    exp = Math.Pow(exp, item);

                }
                Result = exp;
            }
            get
            {
                return new double[0];
            }
        }
        public string Error { get; }

        public double? Result { get; private set; }

    }


}