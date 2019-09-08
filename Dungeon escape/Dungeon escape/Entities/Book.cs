using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Book : Entity, Iweight, Iprice
    {
        public Content content;

        public int weight;

        public int price;

        public int getWeightValue() { return weight; }

        public int getPriceValue()
        {
            return price;
        }

        public Book(string _name, Content _content, Description _description, int _weight, int _price)
        {
                name = _name;
                content = _content;
                description = _description;
                weight = _weight;
                price = _price;
                verbDict = new Dictionary<string, Verb>();
        }
    }
}
