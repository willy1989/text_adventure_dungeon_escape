using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class SortWeight : Action
    {
        public List<Entity> entityList;

        public override void doAction()
        {

            // Convert the items in the player's inventory to Iweights, so that they can be sorted. 
            // This is because, the Entity base class doesn't have a weight variable.
            List<Iweight> iweights = new List<Iweight>();

            foreach (Iweight iweight in entityList)
            {
                iweights.Add(iweight);
            }

            entityList.Clear();

            // Sort by weight
            iweights = mergeSplit(iweights);


            // Convert the items back to Entities and store them back in the inventory.
            foreach (Iweight iweight in iweights)
            {
                entityList.Add((Entity)iweight);
                Console.WriteLine("Book weight = "+iweight.getWeightValue());
            }

        }

        public static List<Iweight> sort2Lists(List<Iweight> list1, List<Iweight> list2)
        {
            List<Iweight> sortedList = new List<Iweight>();

            while (list1.Count > 0 || list2.Count > 0)
            {

                Console.WriteLine("Iterating sort2List");
                if (list1.Count > 0 && list2.Count > 0)
                {
                    if (list1[0].getWeightValue() >= list2[0].getWeightValue())
                    {
                        sortedList.Add(list1[0]);
                        list1.RemoveAt(0);
                    }

                    else if (list1[0].getWeightValue() < list2[0].getWeightValue())
                    {
                        sortedList.Add(list2[0]);
                        list2.RemoveAt(0);
                    }
                }

                else if (list1.Count > 0)
                {
                    sortedList.Add(list1[0]);
                    list1.RemoveAt(0);
                }

                else if (list2.Count > 0)
                {
                    sortedList.Add(list2[0]);
                    list2.RemoveAt(0);
                }
            }

            return sortedList;
        }

        public static List<Iweight> mergeSplit(List<Iweight> numList)
        {
            Console.WriteLine("Merge sort");

            if (numList.Count == 1)
            {
                //Console.WriteLine("Array of length 1");
                return numList;
            }

            List<Iweight> left = new List<Iweight>();

            List<Iweight> right = new List<Iweight>();

            bool leftListBool = true;

            while (numList.Count > 0)
            {
                if (leftListBool == true)
                {
                    left.Add(numList[0]);
                }

                else
                {
                    right.Add(numList[0]);
                }

                numList.RemoveAt(0);
                leftListBool = !leftListBool;
            }


            left = mergeSplit(left);

            right = mergeSplit(right);


            return sort2Lists(left, right);
        }

        public SortWeight(List<Entity> _entityList)
        {
            entityList = _entityList;
        }
    }
}
