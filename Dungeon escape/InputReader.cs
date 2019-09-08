using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Text_adventure
{
    public class InputReader
    {
        // Get input from the player and looks for the verb and entity

            public Dictionary<string, Entity> entityDic;
            public void doInput(string verbName, string entityName)
            {

            Entity entityToFind;
            Verb verbToFind;

            // Check if entity is in Dictionary
            bool foundEntity = entityDic.TryGetValue(entityName, out Entity entity);

                    if (foundEntity == true)
                    {
                            entityToFind = entityDic[entityName];

                            // Check if verb is in dictionary
                            bool foundVerb = entityToFind.verbDict.TryGetValue(verbName, out Verb verb);
                            if(foundVerb == true)
                            {
                                    verbToFind = entityToFind.verbDict[verbName];
                                    verbToFind.execute();
                            }

                            else
                            {
                                    Console.WriteLine("You can't "+ "'"+verbName+"'" +"a " + entityName);
                            }
                    }

                    else
                    {
                            Console.WriteLine(entityName  +" not found. Did you spell it correctly?");
                    }
            }

            public string[] getInput()
            {
                    string action = Console.ReadLine();

                    Regex regex = new Regex(@"(^\w+(?=\s))\s+(\w+)");

                    Match matches = regex.Match(action);

                    if (matches.Success == true)
                    {
                            string verb = matches.Groups[1].ToString();

                            string item = matches.Groups[2].ToString();

                            return new string[] { verb, item };
                    }

                    else
                    {
                            Console.WriteLine("Input incorrect. Please follow this format: 'verb' 'item'.");
                            return null;
                    }
            }

            public void readInput()
            {
                string[] input = getInput();

                if (input == null)
                {
                        return;
                }

                doInput(input[0], input[1]);
            }

            public InputReader(Dictionary<string, Entity> _entityDic)
            {
                entityDic = _entityDic;
            }

    }
}
