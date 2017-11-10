using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.Birthday
{
    class Birthday
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentageOccupied = double.Parse(Console.ReadLine());

            double aquariumVolume = (length * width * height) / 1000.0;
            double aquariumVolumeCapacity = 
                aquariumVolume - (aquariumVolume * percentageOccupied / 100);

            Console.WriteLine("{0:f3}", aquariumVolumeCapacity);
        }
    }
}
