using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class hekimler
    {
       public hekimler()
        {
            List<string> hekimler = new List<string>();
            hekimler.Add("1.Dr. Oktay samilov");
            hekimler.Add("2.T.e.n. Dr. Vusal Eyvazov");
            hekimler.Add("3.Dr. Elxan Besirov");
            foreach (string i in hekimler)
            {
                Console.WriteLine(i);
            }
        }
    }
}
