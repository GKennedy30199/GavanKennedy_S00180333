using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GavanKennedy_S00180333
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        List<PhoneData> dbL = new List<PhoneData>();
        List<Phone> opsystem = new List<Phone>();
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = from P in db.Phones
                        where P.PhoneID == 1
                        select P;
            Phone P1 = new Phone() { OsImage = "/Images/android.png" };
            Phone P2 = new Phone() { OsImage = "/Images/apple.png" };
            opsystem.Add(P1);
            opsystem.Add(P2);
            LBXPhones.ItemsSource = opsystem;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var query = from P in db.Phones                      
                        select P.Name
                        ;
            var query1 = from p1 in db.Phones
                         select p1.PhoneImage;
            LBXPhones.ItemsSource = query.ToList();
        }
    }
}
