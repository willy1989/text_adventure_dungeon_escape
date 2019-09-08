using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Sell : Action
    {
        public GameManager gameManager;

        public Iprice iprice;

        public Sell(GameManager _gameManager, Iprice _iprice)
        {
            gameManager = _gameManager;
            iprice = _iprice;
        }


        public override void doAction()
        {
            // Try to handle this within the shop class.
            // Try to throw an exception withing the shop class
            if (gameManager.currentShop != null)
            {
                gameManager.currentShop.sellShop(iprice);
            }

            else
            {
                Console.WriteLine(" There is no shop in this room.");
            }
        }
    }
}
