using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappings
{
    class UnitAdditionHandler : IHandler
    {

        Repository _repo;

        public UnitAdditionHandler(Repository repo)
        {
            _repo = repo;
        }

        public bool can_handle(Message message)
        {
            return message is ObjectCreationMessage;
        }

        public bool handle(Message message)
        {
            //TThrow if can't handle, basically to discourage sending messages indiscriminantly
            if (!can_handle(message)) throw new ArgumentException("Check can_handle first!");
            ObjectCreationMessage creationMessage = message as ObjectCreationMessage;

            return _repo.add_item(creationMessage.pos, creationMessage.value, false);

        }
    }
}
