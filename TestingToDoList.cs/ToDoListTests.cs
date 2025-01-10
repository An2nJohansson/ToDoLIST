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

        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Test task";
            _todoList.AddTask(task);
            var tasks = _todoList.GetAllTasks();
            Assert.Contains(task, tasks);
        }

        [Fact]
        public void RemoveTask_ShouldRemoveTaskToList() 
        {
            var task = "Task to remove";
            _todoList.AddTask(task);
            _todoList.RemoveTask(0);
            var tasks = _todoList.GetAllTasks();
            Assert.DoesNotContain(task, tasks);
        }

        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotThrowException()
        {
            var task = "valid task";
            _todoList.AddTask(task);
            _todoList.RemoveTask(8); // invalid index
            
            var tasks = _todoList.GetAllTasks();
            Assert.Single(tasks); // den ursprungliga uppgiften ska fortfarande finnas kvar
        }
    }
}