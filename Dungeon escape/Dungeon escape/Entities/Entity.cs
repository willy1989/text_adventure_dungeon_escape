using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public abstract class Entity
    {
            public string name;

            public Description description;

            public Dictionary<string, Verb> verbDict;
    }
}
