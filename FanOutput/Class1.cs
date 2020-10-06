using System;

namespace Opgave1
{
    public class Class1
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
                else
                {
                    value = Temp;
                }
            }
        }

        public int Fugt { get; set; }
    }
}
