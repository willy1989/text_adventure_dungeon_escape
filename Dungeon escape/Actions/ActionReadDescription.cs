using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class ActionReadDescription:Action
    {
        public Description description;

        public override void doAction()
        {
            description.readDescription();
        }

        public ActionReadDescription(Description _description)
        {
                description = _description;
        }

    }
}
