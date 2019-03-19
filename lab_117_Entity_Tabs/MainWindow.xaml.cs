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

namespace lab_117_Entity_Tabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<string> customerList = new List<string>();
        Customer customer;

        public static List<Order> orders = new List<Order>();
        public static List<string> orderList = new List<string>();
        Order order;

        public static List<Order_Detail> orderDetails = new List<Order_Detail>();
        public static List<string> orderDetailsList = new List<string>();
        Order_Detail details;

        public static List<Product> product = new List<Product>();
        public static List<string> productList = new List<string>();
        

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            using (var db = new NorthwindEntities2())
            {
                customers = db.Customer.ToList();
                ListBox01.ItemsSource = customers;
                ListBox01.DisplayMemberPath = "ContactName";
            }
        }

        private void ButtonChangeTab_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl01.SelectedIndex < TabControl01.Items.Count - 1)
            {
                TabControl01.SelectedIndex++;
            }
            else
            {
                TabControl01.SelectedIndex = 0;
            }
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)ListBox01.SelectedItem; //ListBox01.SelectedItem as Customer;
            DisplayData();

            using (var db = new NorthwindEntities2())
            {
                orders = db.Orders.Where(o => o.CustomerID == customer.CustomerID).ToList<Order>();
                ListBox02.ItemsSource = orders;
                ListBox02.DisplayMemberPath = "OrderID";
            }
        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            order = (Order)ListBox02.SelectedItem;

            using (var db = new NorthwindEntities2())
            {
                orderDetails = db.Order_Details.Where(OrderDetails => OrderDetails.OrderID == order.OrderID).ToList<Order_Detail>();
                ListBox03.ItemsSource = orderDetails;
                ListBox03.DisplayMemberPath = "ProductID";
            }
        }

        private void ListBox03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            details = (Order_Detail)ListBox03.SelectedItem;

            using (var db = new NorthwindEntities2())
            {
                product = db.Products.Where(product => product.ProductID == details.ProductID).ToList<Product>();
                ListBox04.ItemsSource = product;
                ListBox04.DisplayMemberPath = "ProductName";
            }
        }

        private void DisplayData()
        {
            ListBoxData.Items.Clear();
            ListBoxData.Items.Add($"Customer ID: {customer.CustomerID}");
            ListBoxData.Items.Add($"Name: {customer.ContactName}");
            ListBoxData.Items.Add($"City: {customer.City}");
        }

        //opens new window when the button is clicked
        private void ButtonAddNewPerson_Click(object sender, RoutedEventArgs e)
        {
            Window1 newin = new Window1();
            newin.Show();
        }
    }
}
