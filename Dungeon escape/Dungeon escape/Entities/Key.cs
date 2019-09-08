using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Key : Entity, Iweight, Iprice
    {
        public GameManager gameManager;

        public int weight;

        public int price;

        public int getWeightValue() { return weight; }

        public int getPriceValue(){return price; }

        public Key(string _name, Description _description, int _weight, int _price)
        {
                name = _name;
                description = _description;
                weight = _weight;
                price = _price;
                verbDict = new Dictionary<string, Verb>();
        }
    }
}
