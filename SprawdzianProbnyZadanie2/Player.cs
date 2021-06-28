using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprawdzianProbnyZadanie2
{
    public class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { 
                
                if(value.Length > 3)
                    name = value; 
            
                for(int i = 0;i<value.Length;i++)
                {
                    if()
                }
            }
        }

    }
}
