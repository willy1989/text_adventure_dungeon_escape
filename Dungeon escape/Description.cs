using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Description
    {
        public string descriptionContent;

        public void readDescription()
        {
            Console.WriteLine(" ");
            Console.WriteLine(descriptionContent);
        }

        public Description(string _descriptionContent)
        {
            descriptionContent = _descriptionContent;
        }
    }
}
