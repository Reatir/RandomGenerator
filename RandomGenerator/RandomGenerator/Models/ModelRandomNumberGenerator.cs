using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator.Models
{

    //Code metier
    public class ModelRandomNumberGenerator
    {
      

        public int _TopLimit { get; set; }
        public int _BotLimit { get; set; }
        public int _Result { get; private set; }

        public List<string> ListResult { get; private set ; }

        public ModelRandomNumberGenerator()
        {
            ListResult = new List<string>();
        }

        public void GenerateRandomNumber()
        {
            var rnd = new Random();
            _Result = rnd.Next(_BotLimit, _TopLimit);
            ListResult.Add(_Result.ToString()); 
        }
       
    }
}
