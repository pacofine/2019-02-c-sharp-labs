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

namespace lab_504_NorthwidDB_AddCustomer
{
    public partial class MainWindow : Window
    {
        public static List<string> cities = new List<string>();
        public static SortedDictionary<string, string> cityDictionary = new SortedDictionary<string, string>();
        public static List<string> titles = new List<string>();
        public static List<string> ids = new List<string>();
        public static List<Customer> _customers = new List<Customer>();
        public static List<string> customer_list = new List<string>();

        int index;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

       
        private void Initialize()
        {
            index = 1;
            displayPanel(index);

            using (var db = new NorthwindEntities())
            {
                _customers = db.Customers.ToList();
                LS01.ItemsSource = _customers;
                LS01.DisplayMemberPath = "ContactName";
            }
        }

        private void Btn_ChangePanel_Click(object sender, RoutedEventArgs e)
        {
            index++;

            if (index == 3) index = 1;

            displayPanel(index);
        }

        void displayPanel(int index)
        {
            switch (index)
            {
                case 1:
                    SP01.Visibility = Visibility.Visible;
                    SP02.Visibility = Visibility.Collapsed;
                    break;

                case 2:
                    SP01.Visibility = Visibility.Collapsed;
                    SP02.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void Btn_AddPerson_Click(object sender, RoutedEventArgs e)
        {
            string name = TB_NameInput.Text;
            string company = TB_CompanyInput.Text;
            

            string id;

            while (true)
            {
                id = RandomID();
                if (!ids.Contains(id)) break;
            }

            ids.Add(id);
            MessageBox.Show(id);

            if (name == "" || company == "") 
            {
                MessageBox.Show("All fields mush be completed");
            }
            else
            {
                using (var db = new NorthwindEntities())
                {
                    Customer customer = new Customer()
                    {
                        CustomerID = id,
                        ContactName = name,
                        CompanyName = company
                    };

                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
            }
        }

        public string RandomID()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string finalString = new String(stringChars);
            return finalString;
        }
    }
}
