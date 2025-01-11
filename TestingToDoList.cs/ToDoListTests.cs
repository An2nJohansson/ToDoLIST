using ToDoAppWPF;
using Xunit;

namespace TestingToDoList
{
    public class ToDoListTests
    {

        private ToDoClass _todoList;
        public ToDoListTests()
        {
            _todoList = new ToDoClass();
        }

        // test f�r att l�gga till en task
        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Test task";
            _todoList.AddTask(task);
            var tasks = _todoList.GetAllTasks();
            Assert.Contains(task, tasks);
        }


        //test f�r att ta bort en task
        [Fact]
        public void RemoveTask_ShouldRemoveTaskToList()
        {
            var task = "Task to remove";
            _todoList.AddTask(task);
            _todoList.RemoveTask(0);
            var tasks = _todoList.GetAllTasks();
            Assert.DoesNotContain(task, tasks);
        }

        // test f�r att ogiltiga "remove" f�rs�k inte ska krascha appen
        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotThrowException()
        {
            var task = "valid task";
            _todoList.AddTask(task);
            _todoList.RemoveTask(8); // invalid index

            var tasks = _todoList.GetAllTasks();
            Assert.Single(tasks); // den ursprungliga uppgiften ska fortfarande finnas kvar
        }

        // test f�r att kolla att listan uppdateras korrekt
        [Fact]
        public void CorrectTaskListUpdate()
        {
            var task1 = "Uppgift 1";
            var task2 = "Uppgift 2";

            _todoList.AddTask(task1);
            _todoList.AddTask(task2);

            var tasks = _todoList.GetAllTasks();

            Assert.Equal(2, tasks.Count);
            Assert.Contains(task1, tasks);
            Assert.Contains(task2, tasks);
        }
            
            
        
    }
}