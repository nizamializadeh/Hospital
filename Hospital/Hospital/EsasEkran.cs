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
                    new Sobeler();
                   new EsasEkran();

                }
                else if (sEmeliyatsec == "2")
                {
                    new Sobeler();
                    Console.WriteLine("");
                    new soberemove();
                    new EsasEkran();
                }
                else if (sEmeliyatsec == "3")
                {
                     new SobeAdd();
                     new EsasEkran();
                }
                else if (sEmeliyatsec == "4")
                {
                     new Sobeler();
                    Console.Write("Sobe Secin:   ");
                    sobeadi = Console.ReadLine();
                    if (sobeadi== "1")
                    {
                        Console.WriteLine("1.Hekimleri goster        2.Hekim Sil        3.Hekim Elave Et");
                        hekimgoster = Console.ReadLine();
                        if (hekimgoster == "1")
                        {
                           new hekimler();
                            new EsasEkran();
                        }
                        else if (hekimgoster == "2")
                        {
                            new hekimler();
                            Console.WriteLine("");
                            new hekimremove();
                            new EsasEkran();
                        }
                        else if (hekimgoster == "3")
                        {
                           new hekimadd();
                           new EsasEkran();
                        }
                        else
                        {
                            Console.WriteLine("Duzgun Emeliyat Secin");
                            new EsasEkran();
                        }
                    }
                    else if ( sobeadi == "2")
                    {
                        Console.WriteLine("1.Hekimleri goster        2.Hekim Sil        3.Hekim Elave Et");
                        hekimgoster = Console.ReadLine();
                        if (hekimgoster == "1")
                        {
                            new hekimler();
                            new EsasEkran();
                        }
                        else if (hekimgoster == "2")
                        {
                            new hekimler();
                            Console.WriteLine("");
                            new hekimremove();
                            new EsasEkran();
                        }
                        else if (hekimgoster == "3")
                        {

                            new hekimadd();
                            new EsasEkran();
                        }
                        else
                        {
                            Console.WriteLine("Duzgun Emeliyat Secin");
                            new EsasEkran();
                        }
                    }
                    else if (sobeadi == "3")
                    {
                        Console.WriteLine("1.Hekimleri goster        2.Hekim Sil        3.Hekim Elave Et");
                        hekimgoster = Console.ReadLine();
                        if (hekimgoster == "1")
                        {
                            new hekimler();
                            new EsasEkran();
                        }
                        else if (hekimgoster == "2")
                        {
                            new hekimler();
                            Console.WriteLine("");
                            new hekimremove();
                            new EsasEkran();
                        }
                        else if (hekimgoster == "3")
                        {
                            new hekimadd();
                            new EsasEkran();
                        }
                        else
                        {
                            Console.WriteLine("Duzgun Emeliyat Secin");
                            new EsasEkran();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Duzgun Emeliyat Secin");
                        new EsasEkran();
                    }
                }
                else
                {
                    Console.WriteLine("Duzgun Emeliyat Secin");
                    new EsasEkran();
                }
             }
                else
                {
                    Console.WriteLine("Parol Sehvdir");
                    new EsasEkran();
            }
            }
    }
}
