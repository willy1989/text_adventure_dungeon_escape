using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Content
    {
        public string contentToRead;

        public void readContent()
        {
                Console.WriteLine(contentToRead);
        }

        public Content(string _contentToRead)
        {
                contentToRead = _contentToRead;
        }
    }
}
