using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Room : Entity
    {
        public EntityContainer entityContainer;

        public bool lit;
            
            public Room(string _name, Description _description, bool _lit)
            {
                    name = _name;
                    description = _description;
                    lit = _lit;
                    entityContainer = new EntityContainer(this);
                    verbDict = new Dictionary<string, Verb>();
            }
    }
}
