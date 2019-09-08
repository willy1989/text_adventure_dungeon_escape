using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class SortAlphabetically:Action
    {
        Inventory inventory;

        public override void doAction()
        {
            sortAlphab(inventory.entityContainer.entities);
        }

        public List<Entity> sortAlphab(List<Entity> entitiesToSort)
        {
            bool switchedAtAll = true;

            if (entitiesToSort.Count == 0 || entitiesToSort.Count == 1)
            {
                return entitiesToSort;
            }

            while (switchedAtAll == true)
            {
                //Console.WriteLine("iterating while");

                for (int i = 0; i < entitiesToSort.Count - 1; i++)
                {
                    //Console.WriteLine("iterating outter loop");

                    switchedAtAll = false;

                    // iterate through the words letters until finding a different letter

                    int letterCount;

                    if (entitiesToSort[i].name.Length <= entitiesToSort[i + 1].name.Length)
                    {
                        letterCount = entitiesToSort[i].name.Length;
                    }

                    else
                    {
                        letterCount = entitiesToSort[i+1].name.Length;
                    }

                    //Console.WriteLine("Letter count =" + letterCount);


                    bool noActions = true;

                    for (int x = 0; x < letterCount; x++)
                    {
                        //Console.WriteLine("iterating inner loop");

                        // // If word1 and word2 are identical skip this iteration. The words are the same, no need to change their order.
                        if (entitiesToSort[i].name == entitiesToSort[i + 1].name)
                        {
                            //Console.WriteLine("Same");
                            noActions = false;
                            break;
                        }

                        // If word2's current letter is smaller in value than that of word's 1, reverse their order and break the loop.

                        else if ((int)entitiesToSort[i].name[x] > (int)entitiesToSort[i + 1].name[x])
                        {
                            Entity temp = entitiesToSort[i];

                            entitiesToSort[i] = entitiesToSort[i + 1];
                            entitiesToSort[i + 1] = temp;

                            switchedAtAll = true;
                            noActions = false;

                            //Console.WriteLine("Switching positions");

                            break;
                        }

                        // If word1's current letter is a smaller than that of word1, just break the loop.
                        else if ((int)entitiesToSort[i].name[x] < (int)entitiesToSort[i + 1].name[x])
                        {
                            noActions = false;
                            break;
                        }

                        // If the letters are the same just keep iterating until finding a different letter.

                    }
                    // If the shorter word is identical to the begginning of the longer word. Then the shorter word should come first.
                    if (noActions == true)
                    {
                        if (entitiesToSort[i].name.Length > entitiesToSort[i+1].name.Length)
                        {
                            Entity temp = entitiesToSort[i];

                            entitiesToSort[i] = entitiesToSort[i+1];
                            entitiesToSort[i+1] = temp;
                        }
                    }
                }
            }

            
            return entitiesToSort;
        }

        public SortAlphabetically(Inventory _inventory)
        {
            inventory = _inventory;
        }

    }
}
