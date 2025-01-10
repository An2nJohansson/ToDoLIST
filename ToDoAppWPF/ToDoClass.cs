using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppWPF
{
    //summary
    // hanterar logik för att ta bort och lägga till To-Do tasks
    //summary
    public class ToDoClass
    {
        //lista för tasks
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(int index) 
        {
            if (index >= 0 && index < tasks.Count)
            {
               tasks.RemoveAt(index);
            }
            
        }

        public List<string> GetAllTasks() 
        {
            return tasks;
        }
    }
}
