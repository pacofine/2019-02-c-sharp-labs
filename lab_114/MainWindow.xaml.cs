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

namespace lab_114
{
    
    public partial class MainWindow : Window
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<string> customerList = new List<string>();
        public static List<string> cities = new List<string>();
        public static Customer customer1 = new Customer();
        public static SortedDictionary<string, string> cityDictionary = new SortedDictionary<string, string>();


        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        public void Initialise()
        {

            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                ListBoxName.ItemsSource = customers;
                ListBoxName.DisplayMemberPath = "ContactName";

                foreach (var customer in customers)
                {
                    if (!cityDictionary.ContainsKey(customer.City)) 
                    {
                        cityDictionary.Add(customer.City, customer.Country);
                    }
                }

                foreach (var element in cityDictionary)
                {
                    ComboBoxCity.Items.Add(element.Key);
                }

            }
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            ListBoxName.SelectionChanged -= ListBoxName_SelectionChanged;

            using (var db = new NorthwindEntities())
            {
                Customer customerToUpDate = db.Customers.Where(C => C.ContactName == customer1.ContactName).FirstOrDefault();

                if (!TextBoxName.Text.Equals(""))
                {
                    customerToUpDate.ContactName = TextBoxName.Text;
                    db.SaveChanges();
                }
            }

            if (!TextBoxName.Text.Equals(""))
            {
                customer1.ContactName = TextBoxName.Text;
                customer1.City = ComboBoxCity.SelectedItem.ToString();
                customer1.Country = cityDictionary[ComboBoxCity.SelectedItem.ToString()];
                Initialise();
                ListBoxName.SelectedItem = customer1;
                Update();
                ListBoxName.SelectionChanged += ListBoxName_SelectionChanged;
            }
        }

        private void ListBoxName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer1 = ListBoxName.SelectedItem as Customer;
            TextBoxName.Text = customer1.ContactName.ToString();
            ListBoxData.SelectedItem = customer1.City;
            Update();
        }
        
        private void ListBoxData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer1 = ListBoxName.SelectedItem as Customer;
            TextBoxName.Text = customer1.ContactName.ToString();
            ListBoxData.SelectedItem = customer1.City;
            Update();
        }

        private void Update()
        {
            ListBoxData.Items.Clear();
            ListBoxData.Items.Add($"ID: {customer1.CustomerID}");
            ListBoxData.Items.Add($"Name: {customer1.ContactName}");
            ListBoxData.Items.Add($"City: {customer1.City}");
        }
    }
}
