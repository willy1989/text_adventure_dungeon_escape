using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{ 
    public class Shop:Entity
    {
        public EntityContainer entityContainer;

        public Inventory inventory;
        public Shop(string _name, Description _description, Inventory _inventory)
        {
            name = _name;
            description = _description;
            entityContainer = new EntityContainer(this);
            verbDict = new Dictionary<string, Verb>();
            inventory = _inventory;
        }

        public void buyShop(Iprice iprice)
        {
            // Check if item is in shop
            Entity itemToBuy = (Entity)iprice;

            bool isInShop = entityContainer.checkIfInList(itemToBuy.name);

            // Add to inventory
            if (isInShop == true)
            {
                //Console.WriteLine(itemToBuy.name + " is in shop.");

                // Check if enough money
                if (inventory.money >= iprice.getPriceValue() && inventory.checkWeightLimit((Iweight)itemToBuy) == true)
                {
                    Console.WriteLine(itemToBuy.name + " bought from shop for " + iprice.getPriceValue() + " gold coins.");

                    inventory.add(itemToBuy);
                    // Remove from shop
                    entityContainer.removeEntitybyName(itemToBuy.name);
                    inventory.money -= iprice.getPriceValue();
                }

                else
                {
                    Console.WriteLine("You don't have enough money to buy" + itemToBuy.name);

                    return;
                }
            }

            else
            {
                Console.WriteLine(itemToBuy.name + " not in shop.");
            }
        }

        public void sellShop(Iprice iprice)
        {
            // Check if item is in shop
            Entity itemToSell = (Entity)iprice;

            bool isInInventory = inventory.entityContainer.checkIfInList(itemToSell.name);

            if (isInInventory == true)
            {
                Console.WriteLine(itemToSell.name + " sold to shop for " + iprice.getPriceValue() + " gold coins.");

                // remove from inventory
                inventory.removeFromInventory(itemToSell);

                // Add to shop
                entityContainer.AddEntity(itemToSell);

                // Give to money to the player
                inventory.money += iprice.getPriceValue();  
            }
        }
    }

    
}
