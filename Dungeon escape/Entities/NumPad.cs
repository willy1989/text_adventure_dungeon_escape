using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class NumPad:Entity
    {
        public string password;

        public NumPad(string _name, string _password, Description _description)
        {
            name = _name;
            description = _description;
            password = _password;
            verbDict = new Dictionary<string, Verb>();
        }

    }
}
