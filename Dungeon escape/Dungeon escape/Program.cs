using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventure
{
    public class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager(new Inventory("inventory", new Description("A leather bag containing your equipment."), 15));

            gameManager.entityManager = new EntityManager(gameManager);

            InputReader inputReader = new InputReader(gameManager.entityManager.entityDic);

            gameManager.inputReader = inputReader;


            // ITEMS
            Book mobyDick = new Book("moby_dick", new Content("Call me Ishmael, perhaps the most famous opening line in literary history..."), new Description("A book about a big murderous whale."), 2, 5);
            Book Monte_Cristo = new Book("monte_cristo", new Content("On the 24th of February, 1815, the look–out at Notre–Dame de la Garde signalled the three–master, the Pharaon from Smyrna, Trieste, and Naples..."), new Description("A book about revenge."), 3, 25);
            Book bible = new Book("bible", new Content("In the beginning God created the heaven and the earth..."), new Description("The holy bible."), 1, 5);
            Book masterDoom = new Book("masters_of_doom", new Content("Lorem ipsum."), new Description("A book about two Johns."), 1, 5);
            Lighter lighter1 = new Lighter("lighter", new Description("A lighter."), 1, 5);
            Purse purse = new Purse("purse", new Description("A small bag containing gold coins"));
            CoinStack coinStack = new CoinStack("coins", new Description("A stack of gold coins"), 10);
            Key key1 = new Key("key", new Description("A key."), 1, 5);
            




            // ROOMS
            Room room1 = new Room("room", new Description("Room 1"), true);
            Room room2 = new Room("room", new Description("Room 2"), true);
            Room room3 = new Room("room", new Description("The room is dark. If there are items lying around you can't see them."), false);
            Room room4 = new Room("room", new Description("Room 4"), true);
            Room room5 = new Room("room", new Description("Room 5"), true);
            Room room6 = new Room("room", new Description("Room 6"), true);
            Room room7 = new Room("room", new Description("Room 7"), true);
            Room room8 = new Room("room", new Description("Room 8"), true);
            Room room9 = new Room("room", new Description("Room 9"), true);
            Room room10 = new Room("room", new Description("Room 10"), true);
            Room room11 = new Room("room", new Description("You reached the exit! Well done! Thanks for playing my game!" ), true);




            // DOORS
            Door EDoorRoom1 = new Door("east_door", new Description("A door heading east."), true, room2);

            Door WDoorRoom2 = new Door("west_door", new Description("A door heading west."), true, room1);
            Door EDoorRoom2 = new Door("east_door", new Description("A door heading east."), true, room3);
            Door SDoorRoom2 = new Door("south_door", new Description("A door heading south."), true, room5);

            Door WDoorRoom3 = new Door("west_door", new Description("A door heading west."), true, room2);
            Door EDoorRoom3 = new Door("east_door", new Description("A door heading east."), true, room4);

            Door WDoorRoom4 = new Door("west_door", new Description("A door heading west."), true, room3);
            Door SDoorRoom4 = new Door("south_door", new Description("A door heading south."), true, room6);

            Door NDoorRoom5 = new Door("north_door", new Description("A door heading west."), true, room2);
            Door SDoorRoom5 = new Door("south_door", new Description("A door heading south."), false, room8);

            Door NDoorRoom6 = new Door("north_door", new Description("A door heading west."), true, room4);

            Door EDoorRoom7 = new Door("east_door", new Description("A door heading east."), true, room8);

            Door NDoorRoom8 = new Door("north_door", new Description("A door heading west."), false, room5);
            Door SDoorRoom8 = new Door("south_door", new Description("A door heading south."), true, room10);
            Door WDoorRoom8 = new Door("west_door", new Description("A door heading west."), true, room7);
            Door EDoorRoom8 = new Door("east_door", new Description("A door heading east."), false, room9);

            Door WDoorRoom9 = new Door("west_door", new Description("A door heading west."), true, room8);
            Door SDoorRoom9 = new Door("south_door", new Description("A door heading south."), true, room11);

            Door NDoorRoom10 = new Door("north_door", new Description("A door heading west."), true, room8);

            Door NDoorRoom11 = new Door("north_door", new Description("A door heading west."), true, room9);




            NumPad numPad1 = new NumPad("terminal", "Monte Cristo", new Description("This terminal can open the east_door. You need to input the right password."));

            // SHOPS
            Shop shop1 = new Shop("shop", new Description("A basic shop"), gameManager.inventory);

            // ACTIONS

            // Rooms
            ActionReadDescription readDescriptionRoom1 = new ActionReadDescription(room1.description);
            ActionReadDescription readDescriptionRoom2 = new ActionReadDescription(room2.description);
            ActionReadDescription readDescriptionRoom3 = new ActionReadDescription(room3.description);
            ActionReadDescription readDescriptionRoom4 = new ActionReadDescription(room4.description);
            ActionReadDescription readDescriptionRoom5 = new ActionReadDescription(room5.description);
            ActionReadDescription readDescriptionRoom6 = new ActionReadDescription(room6.description);
            ActionReadDescription readDescriptionRoom7 = new ActionReadDescription(room7.description);
            ActionReadDescription readDescriptionRoom8 = new ActionReadDescription(room8.description);
            ActionReadDescription readDescriptionRoom9 = new ActionReadDescription(room9.description);
            ActionReadDescription readDescriptionRoom10 = new ActionReadDescription(room10.description);
            ActionReadDescription readDescriptionRoom11 = new ActionReadDescription(room11.description);


            ReadListEntities readListEntitiesRoom1 = new ReadListEntities(room1, room1.entityContainer.entities);
            ReadListEntities readListEntitiesRoom2 = new ReadListEntities(room2, room2.entityContainer.entities);
            ReadListEntities readListEntitiesRoom4 = new ReadListEntities(room4, room4.entityContainer.entities);
            ReadListEntities readListEntitiesRoom5 = new ReadListEntities(room5, room5.entityContainer.entities);
            ReadListEntities readListEntitiesRoom6 = new ReadListEntities(room6, room6.entityContainer.entities);
            ReadListEntities readListEntitiesRoom7 = new ReadListEntities(room7, room7.entityContainer.entities);
            ReadListEntities readListEntitiesRoom8 = new ReadListEntities(room8, room8.entityContainer.entities);
            ReadListEntities readListEntitiesRoom9 = new ReadListEntities(room9, room9.entityContainer.entities);
            ReadListEntities readListEntitiesRoom10 = new ReadListEntities(room10, room10.entityContainer.entities);
            ReadListEntities readListEntitiesRoom11 = new ReadListEntities(room11, room11.entityContainer.entities);


            ReadListItems readListItemsAction_shop1 = new ReadListItems(shop1, shop1.entityContainer);
            ReadListItems readListItemsAction_Inventory = new ReadListItems(gameManager.inventory, gameManager.inventory.entityContainer);
            UnlockDoorNumPadAction unlockDoorNumPadAction = new UnlockDoorNumPadAction(numPad1, EDoorRoom8);

            LightAction lightActionLighter1 = new LightAction(gameManager, lighter1, gameManager.inventory);
            Take takelighterAction = new Take(lighter1, gameManager.inventory, gameManager);
            Buy buylighterAction = new Buy(gameManager, lighter1);
            Sell sellLighterAction = new Sell(gameManager, lighter1);
            ActionReadDescription readLighterAction = new ActionReadDescription(lighter1.description);
            ActionReadDescription readNumpadAction = new ActionReadDescription(numPad1.description);

            CheckPurseAction checkPurseAction = new CheckPurseAction(gameManager.inventory);
            TakeCoinStackAction takeCoinStackAction = new TakeCoinStackAction(gameManager, coinStack, gameManager.inventory);
            UnlockDoorAction unlockDoorAction_room8_northDoor = new UnlockDoorAction(NDoorRoom8, gameManager.inventory);

            // Doors
            // Room1
            GoRoom goRoom1EDoorAction = new GoRoom(EDoorRoom1, gameManager);

            // Room2
            GoRoom goRoom2WDoorAction = new GoRoom(WDoorRoom2, gameManager);
            GoRoom goRoom2EDoorAction = new GoRoom(EDoorRoom2, gameManager);
            GoRoom goRoom2SDoorAction = new GoRoom(SDoorRoom2, gameManager);

            // Room3
            GoRoom goRoom3WDoorAction = new GoRoom(WDoorRoom3, gameManager);
            GoRoom goRoom3EDoorAction = new GoRoom(EDoorRoom3, gameManager);

            // Room4
            GoRoom goRoom4WDoorAction = new GoRoom(WDoorRoom4, gameManager);
            GoRoom goRoom4SDoorAction = new GoRoom(SDoorRoom4, gameManager);

            // Room5
            GoRoom goRoom5NDoorAction = new GoRoom(NDoorRoom5, gameManager);
            GoRoom goRoom5SDoorAction = new GoRoom(SDoorRoom5, gameManager);

            // Room6
            GoRoom goRoom6NDoorAction = new GoRoom(NDoorRoom6, gameManager);

            // Room7
            GoRoom goRoom7EDoorAction = new GoRoom(EDoorRoom7, gameManager);

            // Room8
            GoRoom goRoom8NDoorAction = new GoRoom(NDoorRoom8, gameManager);
            GoRoom goRoom8EDoorAction = new GoRoom(EDoorRoom8, gameManager);
            GoRoom goRoom8WDoorAction = new GoRoom(WDoorRoom8, gameManager);
            GoRoom goRoom8SDoorAction = new GoRoom(SDoorRoom8, gameManager);

            // Room9
            GoRoom goRoom9WDoorAction = new GoRoom(WDoorRoom9, gameManager);
            GoRoom goRoom9SDoorAction = new GoRoom(SDoorRoom9, gameManager);

            // Room10
            GoRoom goRoom10NDoorAction = new GoRoom(NDoorRoom10, gameManager);

            // Room11
            GoRoom goRoom11NDoorAction = new GoRoom(NDoorRoom11, gameManager);

            // Key

            Take takeKeyAction = new Take(key1, gameManager.inventory, gameManager);

            Take takeMobyDickAction = new Take(mobyDick, gameManager.inventory, gameManager);
            ActionReadDescription readMobyDickDescription = new ActionReadDescription(mobyDick.description);
            ActionReadDescription readBibleDescription = new ActionReadDescription(bible.description);
            ActionReadDescription readMonteCristoDescription = new ActionReadDescription(Monte_Cristo.description);

            Take takeMonteCristoAction = new Take(Monte_Cristo, gameManager.inventory, gameManager);
            Take takeBibleAction = new Take(bible, gameManager.inventory, gameManager);
            Buy buyBibleAction = new Buy(gameManager, bible);
            Sell sellBibleAction = new Sell(gameManager, bible);
            Buy buyMobyDickeAction = new Buy(gameManager, mobyDick);
            Sell sellMobyDickAction = new Sell(gameManager, mobyDick);
            Buy buyMonteCristoAction = new Buy(gameManager, Monte_Cristo);
            Sell sellMonteCristoAction = new Sell(gameManager, Monte_Cristo);

            Take takeMastersOfDoomAction = new Take(masterDoom, gameManager.inventory, gameManager);
            Buy buyMastersOfDoomAction = new Buy(gameManager, masterDoom);
            Sell sellMastersOfDoomAction = new Sell(gameManager, masterDoom);
            ActionReadDescription readMastersOfDoomAction = new ActionReadDescription(masterDoom.description);

            ReadContentAction readContentActionMobyDick = new ReadContentAction(mobyDick.content);
            ReadContentAction readContentActionBible = new ReadContentAction(bible.content);
            ReadContentAction readContentActionMonteCristo = new ReadContentAction(Monte_Cristo.content);
            ReadContentAction readContentActionLittleCookBook = new ReadContentAction(masterDoom.content);

            SortAlphabetically sortinventoryAlphabeticallyAction = new SortAlphabetically(gameManager.inventory);
            SortWeight sortWeightInventoryAction = new SortWeight(gameManager.inventory.entityContainer.entities);
            SortPrice sortPriceInventoryAction = new SortPrice(gameManager.inventory.entityContainer.entities);

            ActionReadDescription readDescriptionActionKey1 = new ActionReadDescription(key1.description);

            // VERBS
            Verb room1Check = new Verb(new List<Action> { readDescriptionRoom1, readListEntitiesRoom1 });
            Verb room2Check = new Verb(new List<Action> { readDescriptionRoom2, readListEntitiesRoom2 });
            Verb room3Check = new Verb(new List<Action> { readDescriptionRoom3 });
            Verb room4Check = new Verb(new List<Action> { readDescriptionRoom4, readListEntitiesRoom4 });
            Verb room5Check = new Verb(new List<Action> { readDescriptionRoom5, readListEntitiesRoom5 });
            Verb room6Check = new Verb(new List<Action> { readDescriptionRoom6, readListEntitiesRoom6 });
            Verb room7Check = new Verb(new List<Action> { readDescriptionRoom7, readListEntitiesRoom7 });
            Verb room8Check = new Verb(new List<Action> { readDescriptionRoom8, readListEntitiesRoom8 });
            Verb room9Check = new Verb(new List<Action> { readDescriptionRoom9, readListEntitiesRoom9 });
            Verb room10Check = new Verb(new List<Action> { readDescriptionRoom10, readListEntitiesRoom10 });
            Verb room11Check = new Verb(new List<Action> { readDescriptionRoom11, readListEntitiesRoom11 });

            Verb inventoryCheck = new Verb(new List<Action> { sortinventoryAlphabeticallyAction, readListItemsAction_Inventory });


            // Doors

            //Room 1
            Verb goEDoorRoom1 = new Verb(new List<Action> { goRoom1EDoorAction });

            //Room 2
            Verb goWDoorRoom2 = new Verb(new List<Action> { goRoom2WDoorAction });
            Verb goEDoorRoom2 = new Verb(new List<Action> { goRoom2EDoorAction});
            
            Verb goSDoorRoom2 = new Verb(new List<Action> { goRoom2SDoorAction });

            //Room 3
            Verb goWDoorRoom3 = new Verb(new List<Action> { goRoom3WDoorAction });
            Verb goEDoorRoom3 = new Verb(new List<Action> { goRoom3EDoorAction });

            //Room 4
            Verb goWDoorRoom4 = new Verb(new List<Action> { goRoom4WDoorAction });
            Verb goSDoorRoom4 = new Verb(new List<Action> { goRoom4SDoorAction });

            //Room 5
            Verb goNDoorRoom5 = new Verb(new List<Action> { goRoom5NDoorAction });
            Verb goSDoorRoom5 = new Verb(new List<Action> { goRoom5SDoorAction });

            //Room 6
            Verb goNDoorRoom6 = new Verb(new List<Action> { goRoom6NDoorAction });

            //Room 7
            Verb goEDoorRoom7 = new Verb(new List<Action> { goRoom7EDoorAction });

            //Room 8
            Verb goNDoorRoom8 = new Verb(new List<Action> { goRoom8NDoorAction });
            Verb goEDoorRoom8 = new Verb(new List<Action> { goRoom8EDoorAction });
            Verb unlockRoom8Ndoor = new Verb(new List<Action> { unlockDoorAction_room8_northDoor });
            Verb goWDoorRoom8 = new Verb(new List<Action> { goRoom8WDoorAction });
            Verb goSDoorRoom8 = new Verb(new List<Action> { goRoom8SDoorAction });
            

            //Room 9
            Verb goWDoorRoom9 = new Verb(new List<Action> { goRoom9WDoorAction });
            Verb goSDoorRoom9 = new Verb(new List<Action> { goRoom9SDoorAction });

            //Room 10
            Verb goNDoorRoom10 = new Verb(new List<Action> { goRoom10NDoorAction });

            //Room 11
            Verb goNDoorRoom11 = new Verb(new List<Action> { goRoom11NDoorAction });
            


            //Books
            Verb takeMobyDick = new Verb(new List<Action> { takeMobyDickAction });
            Verb checkMobyDick = new Verb(new List<Action> { readMobyDickDescription, readContentActionMobyDick });
            Verb buyMobyDick = new Verb(new List<Action> { buyMobyDickeAction });
            Verb sellMobyDick = new Verb(new List<Action> { sellMobyDickAction });

            Verb takeMonteCristo = new Verb(new List<Action> { takeMonteCristoAction });
            Verb checkMonteCristo = new Verb(new List<Action> { readMonteCristoDescription, readContentActionMonteCristo });
            Verb buyMonteCristo = new Verb(new List<Action> { buyMonteCristoAction });
            Verb sellMonteCristo = new Verb(new List<Action> { sellMonteCristoAction });

            Verb takeBible = new Verb(new List<Action> { takeBibleAction });
            Verb checkBible = new Verb(new List<Action> { readBibleDescription, readContentActionBible });
            Verb buyBible = new Verb(new List<Action> { buyBibleAction });
            Verb sellBible = new Verb(new List<Action> { sellBibleAction });
            
            Verb takeMastersOfDoom = new Verb(new List<Action> { takeMastersOfDoomAction });
            Verb checkMastersOfDoom = new Verb(new List<Action> { readMastersOfDoomAction, readContentActionLittleCookBook });
            Verb buyMastersOfDoom = new Verb(new List<Action> { buyMastersOfDoomAction });
            Verb sellMastersOfDoom = new Verb(new List<Action> { sellMastersOfDoomAction });

                // Inventory
            Verb sortWeightInventory = new Verb(new List<Action> { sortWeightInventoryAction, readListItemsAction_Inventory });
            Verb sortPriceInventory = new Verb(new List<Action> { sortPriceInventoryAction, readListItemsAction_Inventory });

            // Shop
            Verb checkShop = new Verb(new List<Action> { readListItemsAction_shop1 });
            
            // Purse
            Verb checkPurse = new Verb(new List<Action> { checkPurseAction });

            //Coin Stack
            Verb takeCoinStack = new Verb(new List<Action> { takeCoinStackAction });
            
            // Key
            Verb checkKey1 = new Verb(new List<Action> { readDescriptionActionKey1 });
            Verb takeKey1 = new Verb(new List<Action> { takeKeyAction });

            // Lighter
            Verb lighter1Light = new Verb(new List<Action> { lightActionLighter1 });
            Verb takeLighter = new Verb(new List<Action> { takelighterAction });
            Verb buyLighter = new Verb(new List<Action> { buylighterAction });
            Verb sellLighter = new Verb(new List<Action> { sellLighterAction });
            Verb checkLighter = new Verb(new List<Action> { readLighterAction });

            // Numpad
            Verb checkNumpad = new Verb(new List<Action> { readNumpadAction });

            Verb unlockEdoorRoom8NumPad = new Verb(new List<Action> { unlockDoorNumPadAction });
            
            


            // Adding verbs to entity dictionaries
            room1.verbDict.Add("check", room1Check);
            room2.verbDict.Add("check", room2Check);
            room3.verbDict.Add("check", room3Check);
            room4.verbDict.Add("check", room4Check);
            room5.verbDict.Add("check", room5Check);
            room6.verbDict.Add("check", room6Check);
            room7.verbDict.Add("check", room7Check);
            room8.verbDict.Add("check", room8Check);
            room9.verbDict.Add("check", room9Check);
            room10.verbDict.Add("check", room10Check);
            room11.verbDict.Add("check", room11Check);


            // Doors
            EDoorRoom1.verbDict.Add("go", goEDoorRoom1);
            WDoorRoom2.verbDict.Add("go", goWDoorRoom2);
            EDoorRoom2.verbDict.Add("go", goEDoorRoom2);
            SDoorRoom2.verbDict.Add("go", goSDoorRoom2);
            WDoorRoom3.verbDict.Add("go", goWDoorRoom3);
            EDoorRoom3.verbDict.Add("go", goEDoorRoom3);
            WDoorRoom4.verbDict.Add("go", goWDoorRoom4);
            SDoorRoom4.verbDict.Add("go", goSDoorRoom4);
            NDoorRoom5.verbDict.Add("go", goNDoorRoom5);
            SDoorRoom5.verbDict.Add("go", goSDoorRoom5);
            NDoorRoom6.verbDict.Add("go", goNDoorRoom6);
            EDoorRoom7.verbDict.Add("go", goEDoorRoom7);
            NDoorRoom8.verbDict.Add("go", goNDoorRoom8);
            SDoorRoom8.verbDict.Add("go", goSDoorRoom8);
            WDoorRoom8.verbDict.Add("go", goWDoorRoom8);
            EDoorRoom8.verbDict.Add("go", goEDoorRoom8);
            NDoorRoom8.verbDict.Add("unlock", unlockRoom8Ndoor);
            WDoorRoom9.verbDict.Add("go", goWDoorRoom9);
            SDoorRoom9.verbDict.Add("go", goSDoorRoom9);
            NDoorRoom10.verbDict.Add("go", goNDoorRoom10);
            NDoorRoom11.verbDict.Add("go", goNDoorRoom11);


            mobyDick.verbDict.Add("take", takeMobyDick);
            mobyDick.verbDict.Add("buy", buyMobyDick);
            mobyDick.verbDict.Add("sell", sellMobyDick);
            mobyDick.verbDict.Add("check", checkMobyDick);

            bible.verbDict.Add("take", takeBible);
            bible.verbDict.Add("buy", buyBible);
            bible.verbDict.Add("sell", sellBible);
            bible.verbDict.Add("check", checkBible);
            Monte_Cristo.verbDict.Add("take", takeMonteCristo);
            Monte_Cristo.verbDict.Add("buy", buyMonteCristo);
            Monte_Cristo.verbDict.Add("sell", sellMonteCristo);
            Monte_Cristo.verbDict.Add("check", checkMonteCristo);

            masterDoom.verbDict.Add("take",takeMastersOfDoom);
            masterDoom.verbDict.Add("sell", sellMastersOfDoom); 
            masterDoom.verbDict.Add("check", checkMastersOfDoom); 
            masterDoom.verbDict.Add("buy", buyMastersOfDoom);

            lighter1.verbDict.Add("use", lighter1Light);
            lighter1.verbDict.Add("take", takeLighter);
            lighter1.verbDict.Add("check", checkLighter);
            lighter1.verbDict.Add("buy", buyLighter);
            lighter1.verbDict.Add("sell", sellLighter);
            

            shop1.verbDict.Add("check", checkShop);
            

            // numpad1
            numPad1.verbDict.Add("use", unlockEdoorRoom8NumPad);
            numPad1.verbDict.Add("check", checkNumpad);


            gameManager.inventory.verbDict.Add("check", inventoryCheck);
            gameManager.inventory.verbDict.Add("sort_weight",sortWeightInventory);
            gameManager.inventory.verbDict.Add("sort_price", sortPriceInventory);
            purse.verbDict.Add("check", checkPurse);
            coinStack.verbDict.Add("take", takeCoinStack);

            key1.verbDict.Add("check", checkKey1);
            key1.verbDict.Add("take", takeKey1);


            // Adding entities to entities
            room1.entityContainer.AddEntity(EDoorRoom1);
            room1.entityContainer.AddEntity(lighter1);
            room2.entityContainer.AddEntity(WDoorRoom2);
            room2.entityContainer.AddEntity(EDoorRoom2);
            room2.entityContainer.AddEntity(SDoorRoom2);
            room2.entityContainer.AddEntity(mobyDick);
            room3.entityContainer.AddEntity(WDoorRoom3);
            room3.entityContainer.AddEntity(EDoorRoom3);
            room3.entityContainer.AddEntity(coinStack);
            room4.entityContainer.AddEntity(WDoorRoom4);
            room4.entityContainer.AddEntity(SDoorRoom4);
            room4.entityContainer.AddEntity(shop1);
            room5.entityContainer.AddEntity(NDoorRoom5);
            room5.entityContainer.AddEntity(SDoorRoom5);
            room5.entityContainer.AddEntity(bible);
            room6.entityContainer.AddEntity(NDoorRoom6);
            room6.entityContainer.AddEntity(masterDoom);
            room7.entityContainer.AddEntity(EDoorRoom7);
            room8.entityContainer.AddEntity(NDoorRoom8);
            room8.entityContainer.AddEntity(SDoorRoom8);
            room8.entityContainer.AddEntity(WDoorRoom8);
            room8.entityContainer.AddEntity(EDoorRoom8);
            room8.entityContainer.AddEntity(numPad1);
            room9.entityContainer.AddEntity(WDoorRoom9);
            room9.entityContainer.AddEntity(SDoorRoom9);
            room10.entityContainer.AddEntity(NDoorRoom10);
            room10.entityContainer.AddEntity(key1);
            room11.entityContainer.AddEntity(NDoorRoom11);

            shop1.entityContainer.AddEntity(Monte_Cristo);


            /*room1.entityContainer.AddEntity(shop1);
            room1.entityContainer.AddEntity(mobyDick);
           
            room1.entityContainer.AddEntity(numPad1);
            room1.entityContainer.AddEntity(coinStack);
            room2.entityContainer.AddEntity(Monte_Cristo);

            shop1.entityContainer.AddEntity(bible);
            */
            gameManager.inventory.entityContainer.AddEntity(purse);

            

            // Adding entities to entity manager

            // Add starting room to entity manager
            gameManager.entityManager.addToDicItem(room7);

            // Intro
            Console.WriteLine("Dungeon Escape");
            Console.WriteLine("");

            Console.WriteLine("Willy Mercier. 2019.");
            Console.WriteLine("");
            Console.WriteLine("Welcome! Escape dungeon is a short text adventure game. The goal is to find your way out of a maze.");
            Console.WriteLine("To interact with the environment, you have to use commands based on this format:'verb' thing'.");
            Console.WriteLine("For instance: go east_door, check inventory");
            Console.WriteLine("");
            Console.WriteLine("Good luck!");
            Console.WriteLine("");
            Console.WriteLine("The game starts now!");
            Console.WriteLine("");
            Console.WriteLine("");
            // Starting game
            gameManager.RoomChange(room7);

            gameManager.gameLoop();
        }
    }
}
