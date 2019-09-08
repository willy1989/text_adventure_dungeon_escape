using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class ReadContentAction : Action
    {
        public Content content;

        public ReadContentAction(Content _content)
        {
            content = _content;
        }

        public override void doAction()
        {
            readContent();
        }

        public void readContent()
        {
            content.readContent();

        }
    }
}
