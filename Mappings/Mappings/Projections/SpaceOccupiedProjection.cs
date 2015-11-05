using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappings.Projections
{
    class SpaceOccupiedProjection : IProjection
    {

        IRepositoryReader _repo;

        public SpaceOccupiedProjection(IRepositoryReader repo)
        {
            _repo = repo;
        }

        public void present()
        {
            foreach(int pos in _repo.get_data())
            {
                if (pos > 0) Console.Write(1);
                else if (pos < 1) Console.Write(0);
            }
        }
    }
}
