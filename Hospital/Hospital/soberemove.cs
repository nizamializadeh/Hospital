﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class soberemove
    {
        public soberemove()
        {
            Console.WriteLine("Sileceyiniz Sobenin Adini Yazin");
            List<string> sobeler = new List<string>();
            sobeler.Add("Neyrocerrahiye");
            sobeler.Add("Kardiologiya");
            sobeler.Add("Stomatologiya");
            string input = Console.ReadLine();
           
            sobeler.Remove(input);
            Console.WriteLine("");
            foreach (string i in sobeler)
            {
                Console.WriteLine(i);
            }
        }
    }
}
