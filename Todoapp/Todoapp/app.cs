using System;
using System.Collections.Generic;
using System.Text;

namespace Todoapp
{
    class App
    {
        ItemRespository repo;
        public App()
        {
            repo = new ItemRespository();
        }
        public void start()
        {
            // 1. Display Menu
            string ConsoleUtils.PrintMenu();

            // 2. Process user actions
            while (Action != "9")
            {
                // use switch or if
                //If action == 
                // Ask ItmeRespository to return a list of ToDoItem objects
                // ask consoleUtils to display the list
                // break
                if (Action == "1")
                {
                    List<ToDoItem> list = repo.GetToDoItems();
                    ConsoleUtils.PrintToDoItems(list);
                    break;
                }
                if (Action == "2")
                {
                    List<Todoitem> list2 = repo.GetToDoItems();
                    ConsoleUtils.PrintToDoItems(list2);
                    break;
                if (Action == "3")
                    {
                        List<Todoitem> list3 = repo.GetToDoItems();
                        ConsoleUtils.PrintToDoItems(list3);
                        break;
                    }
                if (Action == "3")
                    {
                        List<Todoitem> list4 = repo.GetToDoItems();
                        ConsoleUtils.PrintToDoItems(list4);
                        break;
                    }
                if (Action == "4" )
                    {

                    }
                }
                // if action is to create a new iem 
                // ask consoleutils to get the item infro from the user
                // ask itemrepository to create a new todoItem
                // ask consoleutils to display the current list

            }
        }
    }
}
