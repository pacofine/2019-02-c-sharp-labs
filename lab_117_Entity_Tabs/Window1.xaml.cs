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
using System.Windows.Shapes;

namespace lab_117_Entity_Tabs
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public static List<string> cities = new List<string>();
        public static SortedDictionary<string, string> cityDictionary = new SortedDictionary<string, string>();
        public static List<Customer> customers = new List<Customer>();
        public static List<string> titles = new List<string>();
        public static List<string> ids = new List<string>();

        public Window1()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            using (var db = new NorthwindEntities2())
            {
                customers = db.Customer.ToList();
                foreach (var customer in customers)
                {
                    if (!cityDictionary.ContainsKey(customer.City))
                    {
                        cityDictionary.Add(customer.City, customer.Country);
                    }

                    if (!titles.Contains(customer.ContactTitle))
                    {
                        titles.Add(customer.ContactTitle);
                        ids.Add(customer.CustomerID);
                    }

                    foreach (var element in cityDictionary)
                    {
                        City.Items.Add(element.Key);
                    }

                    foreach (var element in titles)
                    {
                        Title.Items.Add(element);
                    }
                }
            }
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string company = Company.Text;
            string contactTitle;

            try
            {
                contactTitle = Title.SelectedItem.ToString();
            }
            catch
            {
                contactTitle = "";
            }

            string address = Address.Text;
            string postCode = PostCode.Text;
            string region = Region.Text;
            string city;
            string country;

            try
            {
                city = City.SelectedItem.ToString();
                country = cityDictionary[city];
            }
            catch
            {
                city = "";
                country = "";
            }

            string id;

            while (true)
            {
                id = RandomID();
                if (!ids.Contains(id)) break;
            }

            ids.Add(id);
            int.TryParse(ContactNo.Text, out int contactNo);
            int.TryParse(FaxNo.Text, out int faxNo);
            MessageBox.Show(contactNo.ToString() + " " + faxNo);
            MessageBox.Show(id);

            if (name == "" || 
                company == "" || 
                contactTitle == "" || 
                address == "" || 
                postCode == "" || 
                region == "" || 
                city == "")
            {
                MessageBox.Show("All fields mush be completed");
            }
            else
            {
                using (var db = new NorthwindEntities2())
                {
                    Customer customer = new Customer()
                    {
                        CustomerID = id,
                        ContactName = name,
                        CompanyName = company,
                        ContactTitle = contactTitle,
                        Phone = contactNo.ToString(),
                        Fax = faxNo.ToString(),
                        Address = address,
                        PostalCode = postCode,
                        Region = region,
                        City = city,
                        Country = country
                    };

                    db.Customer.Add(customer);
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
