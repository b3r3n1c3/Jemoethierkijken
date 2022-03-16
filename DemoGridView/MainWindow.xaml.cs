using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoGridView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            // Create a new Person Record 
            // Instatiate a new Person Record and give it information
            Person Person1 = new Person();

            // Add Some Details about Person 
            Person1.Name = "Ryan";
            Person1.PersonId = 1;
            Person1.LastName = "Richards";
            Person1.Profession = "Profession 1";



            Person Person2 = new Person();

            // Add Some Details about Person 
            Person2.Name = "Sally";
            Person2.PersonId = 2;
            Person2.LastName = "Mae";
            Person2.Profession = "Profession 2";

            DataGrid1.Items.Add(Person1);
            DataGrid1.Items.Add(Person2);

        }

        public class Person
        {
            public int PersonId { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Profession { get; set; }

        }


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        // Add new Person button was clicked
        private void AddNewPersonButton_Clicked(object sender, RoutedEventArgs e)
        {
            Person tempPerson = new Person();
            tempPerson.PersonId =  int.Parse(AddPersonId.Text);
            tempPerson.Name = AddPersonName.Text;
            tempPerson.LastName = AddPersonLastName.Text;
            tempPerson.Profession = AddPersonProfession.Text;

            DataGrid1.Items.Add(tempPerson);

            Console.WriteLine("Testing");


        }
    }
}
