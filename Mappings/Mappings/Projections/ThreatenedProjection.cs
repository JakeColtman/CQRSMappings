using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappings.Projections
{
    class ThreatenedProjection : IProjection
    {

        IRepositoryReader _repo;

        public void present()
        {
            int[] repoData = _repo.get_data();
            int[] output = new int[repoData.Length];
            for( int ii = 0; ii < repoData.Length; ii++)
            {
                if (repoData[Math.Max(0, ii - 1)] > 0 || repoData[Math.Min(ii + 1, repoData.Length - 1)] > 0) Console.Write(1);
                else Console.Write(0);
            }
            
        }

        public ThreatenedProjection(IRepositoryReader repo)
        {
            _repo = repo;
        }
    }
}
