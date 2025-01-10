using System.Windows;
using System.Windows.Controls;

namespace ToDoAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ToDoClass _todoList;
        public MainWindow()
        {
            InitializeComponent();
            _todoList = new ToDoClass();
        }

        /// <summary>
        /// tar bort en to do task ur listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (TasksListBox.SelectedIndex >= 0)
            {
                _todoList.RemoveTask(TasksListBox.SelectedIndex);
                UpdateTaskList();
            }
            else 
            {
                MessageBox.Show("Var vänlig välj en inlagd uppgift för att kunna ta bort :)");
            }
        }
        
        /// <summary>
        /// lägger till en to do task i listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string task = TaskTextBox.Text;
            if (!string.IsNullOrEmpty(task))
            {
                _todoList.AddTask(task);
                UpdateTaskList();
                TaskTextBox.Clear();
            }

            //ifall användare försöker lägga till en blank rad
            else
            {
                MessageBox.Show("Var vänlig skapa en uppgift för att lägga till i listan :)");
            }
        }

        /// <summary>
        /// uppdaterar listan med to do tasks
        /// </summary>
        private void UpdateTaskList()
        {
            TasksListBox.Items.Clear();
            foreach (var task in _todoList.GetAllTasks())
            {
                TasksListBox.Items.Add(task);
            }

        }

    }
}