using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class hekimadd
    {
        public hekimadd()
        {
            Console.WriteLine("Elave Edeceyiniz  Hekimin Adini Yazin");
            List<string> doc = new List<string>();
            doc.Add("1.Dr. Oktay Şamilov");
            doc.Add("2.T.e.n. Dr. Vüsal Eyvazov");
            doc.Add("3.Dr. Elxan Bəşirov");
            string input = Console.ReadLine();
            doc.Add(input);
            foreach (string i in doc)
            {
                Console.WriteLine(i);
            }
        }
    }
}
