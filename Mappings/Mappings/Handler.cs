using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappings
{
    public interface IHandler
    {
        bool can_handle(Message message);
        bool handle(Message message);
    }
}
