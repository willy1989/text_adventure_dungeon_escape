using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Buy : Action
    {
        public GameManager gameManager;

        public Iprice iprice;

        public override void doAction()
        {
            buy();
        }

        public void buy()
        {
            // Try to handle this within the shop class.
            // Try to throw an exception withing the shop class
            if (gameManager.currentShop != null)
            {
                gameManager.currentShop.buyShop(iprice);
            }

            else
            {
                Console.WriteLine(" There is no shop in this room.");
            }
            
        }

        public Buy(GameManager _gameManager, Iprice _iprice)
        {
            gameManager = _gameManager;
            iprice = _iprice;
        }
    }
}
