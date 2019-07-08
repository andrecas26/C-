using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Todoapp
{
    class ItemRespository
    {
        ItemContext context;

        public ItemRespository()
        {
            context = new ItemContext();
            context.Database.EnsureCreated();
        }

        //List all my ToDo itmes

        public List<ToDoItem> GetToDoItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems.;
            return list.ToList;
        }

        public void AddItem(string description, string status)
        {
            Todoitem item = new Todoitem(description, status);
            context.ToDoItems.Add(item);
            context.SaveChanges();
        }

        public void updateItem(int id, string newDescription, string newStatus)
        {
            Todoitem oldItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();

            oldItem.Description = newDescription;
            oldItem.Status = newStatus;
            context.Update(oldItem);
            context.SaveChanges();
        }

        public void UpdateItem(Todoitem item)

        public void DeleteItem(int id)
        {
            ToDoItem toDoItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            context.ToDoItem.Remove(oldItem);
            context.SaveChanges();
        }
    }
}
