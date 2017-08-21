using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class hekimremove
    {
        public hekimremove()
        {
            Console.WriteLine("Sileceyiniz Hekimin Adini Yazin");
            List<string> doc = new List<string>();
            doc.Add("1.Dr. Oktay Şamilov");
            doc.Add("2.T.e.n. Dr. Vüsal Eyvazov");
            doc.Add("3.Dr. Elxan Bəşirov");
            string input = Console.ReadLine();
            doc.Remove(input);
            foreach (string i in doc)
            {
                Console.WriteLine(i);
            }
        }
    }
}
