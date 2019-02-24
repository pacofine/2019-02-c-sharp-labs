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

namespace lab_11_Entity_GUI2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>();
        List<string> customerList = new List<string>();
        Customer customer1;
        List<String> cities = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using (var db = new NorthwindEntities())
            {

                customers = db.Customers.ToList<Customer>();

                foreach (var c in customers)    
                {
                    customerList.Add($"{c.ContactName} has ID {c.CustomerID}");
                }

                ListBox01.ItemsSource = customerList;
            }

            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                ListBox02.ItemsSource = customers;
            }

            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                ListBox03.ItemsSource = customers;
                ListBox03.DisplayMemberPath = "ContactName";
            }

            //populate static combobox 
            ComboBoxStaticCity.Items.Add("New York");
            ComboBoxStaticCity.Items.Add("Paris");
            ComboBoxStaticCity.Items.Add("Milan");

            using (var db = new NorthwindEntities())
            {
                cities =
                    (from c in db.Customers
                     select c.City).Distinct().OrderBy(city=>city).ToList<string>();
                ComboBoxBoundCity.ItemsSource = cities;
            }

        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            customer1 = (Customer)ListBox03.SelectedItem;
            TextBoxName.Text = customer1.ContactName;
        }
        
        private void ComboBoxStaticCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             MessageBox.Show($"you choose {ComboBoxStaticCity.SelectedItem}");
        }

        private void ComboBoxBoundCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ListBox03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer1 = (Customer)ListBox03.SelectedItem;
            TextBoxName.Text = customer1.ContactName;
        }
        
    }
}
