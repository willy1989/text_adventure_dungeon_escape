using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Verb
    {
            public List<Action> actions;
            public void execute()
            {
                foreach(Action action in actions)
                {
                    action.doAction();
                }
            }

        public Verb(List<Action> _actions)
        {
            actions = _actions;
        }
    }
}
