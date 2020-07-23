using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator.Models
{
    public class ModelRandomStringGenerator
    {
        public int Nb { get; private set; }

        public ModelRandomStringGenerator()
        {
            Nb = 0;
        }

        public void Add()
        {
            Nb++;
        }

        public void Subtract()
        {
            Nb--;
        }
    }
}
