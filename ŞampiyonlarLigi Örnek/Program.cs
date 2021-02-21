using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ŞampiyonlarLigi_Örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer ses = new SoundPlayer();
            string yol;
            Random rastgele = new Random();
            int realMadrid, barcelona, mUntd, juventus;
            int rmPuan = 0, bcPuan = 0, manuPuan = 0, juvePuan = 0;
            
            Console.WriteLine("        Şampiyonlar Kupası        \n");
            Console.WriteLine("Turnuva Takımları : \n\n1.Real Madrid\n2.Barcelona\n3.Manchester United\n4.Juventus\n");
            Console.WriteLine("1.Hafta sonuçlarını görmek için Enter tuşuna basınız...");
            Console.ReadLine();
            Console.WriteLine("        1.Hafta Sonuçları :        \n");

            realMadrid = rastgele.Next(1, 7);
            barcelona = rastgele.Next(1, 7);
            mUntd = rastgele.Next(1, 7);
            juventus = rastgele.Next(1, 7);

            Console.WriteLine("Real Madrid       " + realMadrid + "-" + barcelona + " Barcelona\n");
            Console.WriteLine("Manchester United " + mUntd + "-" + juventus + " Juventus\n");

            if(realMadrid > barcelona)
            {
                rmPuan += 3;
            }
            else if(barcelona > realMadrid)
            {
                bcPuan += 3;
            }
            else
            {
                rmPuan += 1;
                bcPuan += 1;
            }

            if(mUntd > juventus)
            {
                manuPuan += 3;
            }
            else if(juventus > mUntd)
            {
                juvePuan += 3;
            }
            else
            {
                manuPuan += 1;
                juvePuan += 1;
            }

            Console.WriteLine("1.Hafta puan durumunu görmek için Enter tuşuna basınız...");
            Console.ReadLine();
            Console.WriteLine("        1.Hafta Puan Durumu        \n");

            Console.WriteLine("1.Real Madrid       = " + rmPuan);
            Console.WriteLine("2.Barcelona         = " + bcPuan);
            Console.WriteLine("3.Manchester United = " + manuPuan);
            Console.WriteLine("4.Juventus          = " + juvePuan);

            Console.WriteLine("\n" + "____________________________________________________________________________\n");

            Console.WriteLine("\n" + "2.Hafta sonuçlarını görmek için Enter tuşuna basınız...\n");
            Console.ReadLine();
            Console.WriteLine("        2.Hafta Sonuçları :        \n");

            Console.WriteLine("Real Madrid " + realMadrid + "-" + mUntd + " Manchester United\n");
            Console.WriteLine("Barcelona   " + barcelona + "-" + juventus + " Juventus\n");

            if (realMadrid > mUntd)
            {
                rmPuan += 3;
            }
            else if (mUntd > realMadrid)
            {
                manuPuan += 3;
            }
            else
            {
                rmPuan += 1;
                manuPuan += 1;
            }

            if (barcelona > juventus)
            {
                bcPuan += 3;
            }
            else if (juventus > barcelona)
            {
                juvePuan += 3;
            }
            else
            {
                bcPuan += 1;
                juvePuan += 1;
            }

            Console.WriteLine("2.Hafta puan durumunu görmek için Enter tuşuna basınız...");
            Console.ReadLine();
            Console.WriteLine("        2.Hafta Puan Durumu        \n");

            Console.WriteLine("1.Real Madrid       = " + rmPuan);
            Console.WriteLine("2.Barcelona         = " + bcPuan);
            Console.WriteLine("3.Manchester United = " + manuPuan);
            Console.WriteLine("4.Juventus          = " + juvePuan);

            Console.WriteLine("\n" + "____________________________________________________________________________\n");

            Console.WriteLine("\n3.Hafta sonuçlarını görmek için Enter tuşuna basınız...\n");
            Console.ReadLine();
            Console.WriteLine("        3.Hafta Sonuçları :        \n");

            Console.WriteLine("Real Madrid " +       realMadrid +      "-" + juventus + " Juventus\n");
            Console.WriteLine("Barcelona   " + barcelona + "-" + mUntd + " Manchester United\n");

            if (realMadrid > juventus)
            {
                rmPuan += 3;
            }
            else if (juventus > realMadrid)
            {
                juvePuan += 3;
            }
            else
            {
                rmPuan += 1;
                juvePuan += 1;
            }

            if (barcelona > mUntd)
            {
                bcPuan += 3;
            }
            else if (mUntd > barcelona)
            {
                manuPuan += 3;
            }
            else
            {
                bcPuan += 1;
                manuPuan += 1;
            }

            Console.WriteLine("3.Hafta puan durumunu görmek için Enter tuşuna basınız...");
            Console.ReadLine();
            Console.WriteLine("        3.Hafta Puan Durumu        \n");

            Console.WriteLine("1.Real Madrid       = " + rmPuan);
            Console.WriteLine("2.Barcelona         = " + bcPuan);
            Console.WriteLine("3.Manchester United = " + manuPuan);
            Console.WriteLine("4.Juventus          = " + juvePuan);

            Console.WriteLine("\n" + "____________________________________________________________________________\n");

            if (rmPuan > bcPuan && rmPuan > manuPuan && rmPuan > juvePuan)
            {
                Console.WriteLine("TEBRİKLER... ŞAMPİYON REAL MADRİD!!!\n");
                yol = 
                ses.SoundLocation = yol;
                ses.Play();
            }
            else if (bcPuan > rmPuan && bcPuan > manuPuan && bcPuan > juvePuan)
            {
                Console.WriteLine("TEBRİKLER... ŞAMPİYON BARCELONA!!!\n");
                yol = 
                ses.SoundLocation = yol;
                ses.Play();
            }
            else if (manuPuan > rmPuan && manuPuan > bcPuan && manuPuan > juvePuan)
            {
                Console.WriteLine("TEBRİKLER... ŞAMPİYON MANCHESTER UNITED!!!\n");
                yol = 
                ses.SoundLocation = yol;
                ses.Play();
            }
            else
            {
                Console.WriteLine("TEBRİKLER... ŞAMPİYON JUVENTUS!!!\n");
                yol = 
                ses.SoundLocation = yol;
                ses.Play();
            }

            Console.Read();
        }
    }
}
//System.Diagnostics.Process.Start(@"C:\Users\Lenovo\Desktop\1.mp3");
