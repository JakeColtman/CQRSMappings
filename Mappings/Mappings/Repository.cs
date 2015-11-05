using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappings
{
    public class Repository
    {

        int[] _space;
        int _length;

        public Repository(int length)
        {
            _length = length;
            _space = new int[length];
        }

        public bool add_item(int pos, int value, bool overWrite)
        {
            if (pos < 0) throw new ArgumentOutOfRangeException("pos", "position needs to be positive");
            if (pos < _length) throw new ArgumentOutOfRangeException("pos", "position needs to be less than " + _length.ToString());
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

    }
}
