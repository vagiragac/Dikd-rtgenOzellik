using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253001HW3
{
    class Dikdörtgen
    {
        int x = 0;//x yönü
        int y = 0;//y yönü
        int a = 0;//eni
        int b = 0;//boyu

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int A
        {
            get
            {
                return a;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("hatalı giriş yaptınız:::");
                    Console.WriteLine("\n");
                }

                else
                    a = value;
            }
        }//en  kontrolü

        public int B
        {
            get
            {
                return b;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("hatalı giriş yaptınız:::");
                    Console.WriteLine("\n");
                }

                else
                    b = value;
            }
        }//boy kontrolü

        public Dikdörtgen(int x, int y, int a, int b)
        {
            this.x = x;
            this.y = y;
            A = a;
            B = b;
        }
       
        
        public void hareket(int x,int y)//x ve y hareketlerinin kontrolleri
        {
            Console.WriteLine("X VE Y İÇİN HAREKET KONTROLLERİ");
            Console.WriteLine("-------------------------------");
            x +=  this.x;
            y +=  this.y;
            Console.WriteLine("x'in hareketi=" +x +"\n"+"y'nin hareketi="+y);
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    Console.Write("*");
                }
               
                Console.WriteLine();
            }
                Console.WriteLine("\n");


        }
       
        public void DikdortgenCevre()
        {
            Console.WriteLine("DİKDÖRTGEN İÇİN ÇEVRE HESAPLAMA");
            Console.WriteLine("-------------------------------");
            int cevre = 0;
            if(a<=0||b<=0)
                Console.WriteLine("dikdörtgenin çevresi olmaz:");
            else
                 cevre = 2*(a+b);
            Console.WriteLine("dikdörgenin çevresi="+cevre);
            Console.WriteLine("\n");
        }
        
        public void DikdörtgenAlan()
        {
            Console.WriteLine("DİKDÖRTGEN İÇİN ALAN HESAPLAMA");
            Console.WriteLine("------------------------------");
            int alan = 0;
            if (a <= 0 || b <= 0)
                Console.WriteLine("dikdörtgenin alanı olmaz:");
            else
                alan = a*b;
            Console.WriteLine("dikdörtgenin alanı="+alan);
            
            }
        }
    
}
