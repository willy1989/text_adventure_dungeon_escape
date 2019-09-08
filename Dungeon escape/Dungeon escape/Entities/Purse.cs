using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Purse:Entity
    {
        public Purse(string _name, Description _description)
        {
            name = _name;
            description = _description;
            verbDict = new Dictionary<string, Verb>();
        }


    }
}
