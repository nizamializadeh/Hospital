using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class EsasEkran
    {
        string sifre;
        string sEmeliyatsec;
        string sobeadi;
        string hekimgoster;
        public EsasEkran()
        {
            Console.WriteLine("Parolu Daxil Edin");
            sifre = Console.ReadLine();
            if (sifre == "admin")
            {
                Console.WriteLine("1.Sobeleri goster        2.Sobe Sil         3.Sobe Elave Et         4.Sobe Sec");
                sEmeliyatsec = Console.ReadLine();
                if (sEmeliyatsec == "1")
                {
                    Sobeler yenecagir = new Sobeler();
                    EsasEkran cagir = new EsasEkran();

                }
                else if (sEmeliyatsec == "2")
                {
                    soberemove nese2 = new soberemove();
                    EsasEkran cagir = new EsasEkran();
                }
                else if (sEmeliyatsec == "3")
                {
                    SobeAdd nese = new SobeAdd();
                    EsasEkran cagir = new EsasEkran();
                }
                else if (sEmeliyatsec == "4")
                {
                    Sobeler yenecagir = new Sobeler();
                    Console.Write("Sobe Adi Yazin:   ");
                    sobeadi = Console.ReadLine();
                    if (sobeadi== "1")
                    {
                        Console.WriteLine("1.Hekimleri goster        2.Hekim Sil        3.Hekim Elave Et");
                        hekimgoster = Console.ReadLine();
                        if (hekimgoster == "1")
                        {
                            hekimler nes3 = new hekimler();
                            EsasEkran cagir = new EsasEkran();
                        }
                        else if (hekimgoster == "2")
                        {
                            hekimremove n = new hekimremove();
                            EsasEkran cagir = new EsasEkran();
                        }
                        else if (hekimgoster == "3")
                        {
                            hekimadd nese44 = new hekimadd();
                            EsasEkran cagir = new EsasEkran();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Duzgun Emeliyat Secin");
                    EsasEkran cagir = new EsasEkran();
                }
             }
                else
                {
                    Console.WriteLine("Parol Sehvdir");
                    EsasEkran cagir = new EsasEkran();
            }
            }
    }
}
