using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.Core.Operations
{
    internal class Sqrt : IOperation
    {

        public string Name => "sqrt";

        public double[] Args
        {
            set
            {
                var sqrt = 0d;
                foreach (var item in value)
                {
                    sqrt = Math.Sqrt(sqrt);

                }
                Result = sqrt;
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