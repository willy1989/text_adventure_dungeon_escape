using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class TakeCoinStackAction : Action
    {
        public GameManager gameManager;

        public CoinStack coinStack;

        public Inventory inventory;

        public TakeCoinStackAction(GameManager _gameManager, CoinStack _coinStack, Inventory _inventory)
        {
            gameManager = _gameManager;
            coinStack = _coinStack;
            inventory = _inventory;
        }

        public override void doAction()
        {
            addMoney();
        }

        public void addMoney()
        {
            // Add money to the inventory
            inventory.money += coinStack.stackValue;

            Console.WriteLine(coinStack.stackValue+"gold coins added to your inventory.");

            // Remove the stack money from the room
            gameManager.currentRoom.entityContainer.removeEntitybyName(coinStack.name);
        }

        
    }
}
