//VELİ AĞIRAĞAÇ 
//14253001
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253001HW3
{
    class DikdörtgenTest
    {
        static void Main(string[] args)
        {
            Dikdörtgen[] array = new Dikdörtgen[9];
            array[1] = new Dikdörtgen(1, 1,1,1);
            array[1].hareket(4,5);
            array[1].DikdortgenCevre();
            array[1].DikdörtgenAlan();
           
          
           
            
        }
    }
}
