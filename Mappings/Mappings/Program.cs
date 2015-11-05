using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappings
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository(10);


            repo.add_item(1, 9, false);

            IProjection valueProjection = new Projections.AllUnitProjection(repo);
            IProjection occupiedProjection = new Projections.SpaceOccupiedProjection(repo);
            Console.WriteLine("Values");
            valueProjection.present();
            Console.WriteLine("Occupation");
            occupiedProjection.present();
            Console.Read();

        }
    }
}
