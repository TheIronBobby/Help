using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main()
        {
            int numAlbumsEurope = int.Parse(Console.ReadLine());
            decimal priceEuro = decimal.Parse(Console.ReadLine()) * 1.94m;
            int numAlbumsNAmerica = int.Parse(Console.ReadLine());
            decimal priceDolars = decimal.Parse(Console.ReadLine()) * 1.72m;
            int numAlbumsSAmerica = int.Parse(Console.ReadLine());
            decimal pricePesos = decimal.Parse(Console.ReadLine()) / 332.74m;
            int numOfKoncert = int.Parse(Console.ReadLine());
            decimal priceConcert = decimal.Parse(Console.ReadLine()) * 1.94m;
            decimal resultA = (numAlbumsEurope * priceEuro) + (numAlbumsNAmerica * priceDolars) + (numAlbumsSAmerica * pricePesos);
            resultA -= resultA * 0.35m;
            resultA -= resultA * 0.2m;
            decimal resultB = numOfKoncert*priceConcert;
            if (resultB > 100000)
            {
                resultB -= resultB * 0.15m;
            }
            if (resultA > resultB)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.",resultA);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.",resultB);
            }
            

        }
    }
}
