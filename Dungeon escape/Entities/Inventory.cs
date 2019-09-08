using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Text_adventure
{
    public class Inventory : Entity
    {
        public EntityContainer entityContainer;

        public int money = 0;

        public int weightLimit;

        public int currentWeight = 0;

        public bool checkWeightLimit(Iweight iweight)
        {
            //Console.WriteLine("Check weight limit");

            if (currentWeight < weightLimit + iweight.getWeightValue())
            {
                //Console.WriteLine("Weight limit OK");
                return true;
            }

            else
            {
                Console.WriteLine("You've exceeded your inventory's weight limit. It is currently at " + currentWeight + ". Please bring it under " + weightLimit + ".");
                return false;
            }
        }

        public void add(Entity entity)
        {
            entityContainer.AddEntity(entity);

            Iweight iweight = (Iweight)entity;

            // Updating inventory's current weight
            currentWeight += iweight.getWeightValue();

            Console.WriteLine(entity.name + " added to inventory.");
        }



        public void removeFromInventory(Entity entity)
        {
            entityContainer.removeEntitybyName(entity.name);
            
            // Updating inventory's current weight
            Iweight iweight = (Iweight)entity;
            currentWeight -= iweight.getWeightValue();
        }



        public Inventory(string _name, Description _description, int _weightLimit)
        {
                description = _description;
                name = _name;
                weightLimit = _weightLimit;
                verbDict = new Dictionary<string, Verb>();
                entityContainer = new EntityContainer(this);
        }
    }
}
