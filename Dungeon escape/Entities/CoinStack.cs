using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class CoinStack : Entity
    {
        public int stackValue;

        public CoinStack(string _name, Description _description, int _stackValue)
        {
            name = _name;
            description = _description;
            stackValue = _stackValue;
            verbDict = new Dictionary<string, Verb>();
        }
    }
}
