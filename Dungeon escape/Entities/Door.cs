using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Door : Entity
    {
            public bool unlocked;

            public Room connectedRoom;


            public Door(string _name, Description _description, bool _unlocked, Room _connectedRoom)
            {
                    name = _name;
                    unlocked = _unlocked;
                    description = _description;
                    connectedRoom = _connectedRoom;
                    verbDict = new Dictionary<string, Verb>();
            }
    }
}
