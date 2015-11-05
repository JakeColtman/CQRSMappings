using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappings
{
    public class Message
    {
    }

    public class ObjectCreationMessage : Message
    {
        public int pos { get; set; }
        public int value { get; set; }
    }

}
