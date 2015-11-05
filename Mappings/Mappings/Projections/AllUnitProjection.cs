using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappings.Projections
{
    class AllUnitProjection : IProjection
    {

        IRepositoryReader _repo;

        public AllUnitProjection(IRepositoryReader repo)
        {
            _repo = repo;
        }

        public void present()
        {
            foreach (int pos in _repo.get_data()) Console.Write(pos);
        }
    }
}
