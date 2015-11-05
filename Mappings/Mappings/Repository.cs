using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappings
{
    public class Repository : IRepositoryReader
    {

        int[] _space;
        int _length;
        IDictionary<int, int[]> _savedVersions;
        int _version;

        public Repository(int length)
        {
            _length = length;
            _space = new int[length];
            _version = 1;
        }

        public bool add_item(int pos, int value, bool overWrite)
        {
            if (pos < 0) throw new ArgumentOutOfRangeException("pos", "position needs to be positive");
            if (pos > _length) throw new ArgumentOutOfRangeException("pos", "position needs to be less than " + _length.ToString());
            if (overWrite || _space[pos] == 0)
            {
                _space[pos] = value;
                return true;
            }
            else
            {
                Console.WriteLine("Space occupied");
                return false;
            }
            
        }

        public int save_and_return_id()
        {
            _savedVersions[_version] = _space;
            _version += 1;
            return _version;
        }

        public bool load_from_version_id(int version)
        {
            save_and_return_id();
            _space = _savedVersions[version];
            return true;
        }

        public int[] get_data()
        {
            return _space;
        }
    }
}
