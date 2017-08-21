using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Sobeler
    {
        public  Sobeler()
        {
          
            List<string> sobeler = new List<string>();
             sobeler.Add("1.Neyrocerrahiye");
            sobeler.Add("2.Kardiologiya");
            sobeler.Add("3.Stomatologiya");
           
            foreach (string i in sobeler)
            {
                Console.WriteLine(i);
            }
        }
       
    }
}
