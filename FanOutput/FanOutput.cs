using System;
using System.Dynamic;

namespace Opgave1
{
    public class FanOutput
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public int Temp
        {
            get;
            set
            {
                if (value <15|| value>25)
                {
                    throw new NotFiniteNumberException();
                }
                
            }
        }

        public int Fugt
        {
            get;
            set
            {
                if (value < 30 || value > 80)
                {
                    throw new NotFiniteNumberException();
                }
                
            }
        }
    }
}
