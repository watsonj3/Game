using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
     abstract class Room
     {
          bool itemAdded = false;

          // add item to inventory
          public void addItem(Player player, Item item)
          {

          }

          // remove item from inventory.  Place item in room
          public void removeItem(Player player, Item item)
          {

          }

          // generic abstract class room description
          public void roomDescription(Player player)
          {

          }

          // change batteries in flashlight
          public static void changeBatteries()
          {

          }

          // turn on or off flashlight
          public static void turnOnOFFlashlight(Item item, Player player)
          {

          }

          // save game
          public static void saveGame(Player player, Room room)
          {

          }

          // load game
          public static void loadGame(Player player, Room room)
          {

          }

          // look at item while in room
          public static void lookAtItem(Player player, Item item)
          {

          }

          // help key that gives a list of keys
          public static void help()
          {

          }
     }

}
