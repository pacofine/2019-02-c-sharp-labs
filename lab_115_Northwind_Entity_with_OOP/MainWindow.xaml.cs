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
using System.Diagnostics;

namespace lab_115_Northwind_Entity_with_OOP
{

    public partial class MainWindow : Window
    {
        static List<Customer> customers = new List<Customer>();
        static List<ActiveCustomer> activeCustomers = new List<ActiveCustomer>();
        static List<ActiveCustomer> InActiveCustomers = new List<ActiveCustomer>();
        ActiveCustomer EachCustomer;


        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            DisplayData();

            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
            }

            //foreach (var item in customers)
            //{
            //    activeCustomers.Add(new ActiveCustomer(item));
            //}

            ListBoxActiveCustomers.ItemsSource = customers;
            ListBoxActiveCustomers.DisplayMemberPath = "ContactName";

            ListBoxInActiveCustomers.ItemsSource = customers;
            ListBoxInActiveCustomers.DisplayMemberPath = "ContactName";

        }

        private void DisplayData()
        {
            ListBoxData.Items.Clear();
            //ListBoxData.Items.Add($"Is active:{EachCustomer.IsActive}");
            ListBoxData.Items.Add($"Customer ID: {EachCustomer.CustomerID}");
        }
    }

    //Interface is like a tool you can use/implement 
    interface IDoThis
    {
        void DoThis();
    }

    interface IDoThat
    {
        void DoThat();
    }

    //class customer
    //class active which inherits from customer
    class ActiveCustomer : Customer, IDoThis, IDoThat
    {
        public bool IsActive;

        public void DoThis()
        {

        }

        public void DoThat()
        {

        }
    }
}


/// <summary>
/// Interaction
/// 
/// lab_115
/// 
/// read customers and cast to active customers and 
/// set is active to true for all customers 
/// 
/// create 2 list boxes and a radio button to anable or disable our active customer 
/// 
/// click on customer and display all the details on th the scree (textbox, stackpanel, listbox2)
/// 
/// when you click on enable/disable radio/toggle button the IsActive changes (toggles) state
/// 
/// the first list is only for active customers so if the state becomes InActive, remove from this listbox
/// 
/// the second list box is only for inactive customers, remove from first listbox and add to second listbox
/// 
/// reverse the process ie when you click an InActive customer (second listbox) you can toggle the stage back to anabled
/// when this happens it becomes removed from the incative and add back to the active.
/// 
/// </summary>