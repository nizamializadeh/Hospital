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
             sobeler.Add("1.Neyrocerahiya");
            sobeler.Add("2.kariolagiya");
            sobeler.Add("3.Sramatalogiya");
           
            foreach (string i in sobeler)
            {
                Console.WriteLine(i);
            }
        }
       
    }
}
