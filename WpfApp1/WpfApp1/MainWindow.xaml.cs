using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public class Person
    {
        public string Name { get; set; }
        public string Sname { get; set; }
        public string PESEL { get; set; }
        
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Person item = new Person();
            item.Name = "Michal";
            item.Sname = "Gawron";
            item.PESEL = "12432543623";
            var rnd = new Random();

            listview.Items.Add(new { m_nID = rnd.Next(), m_strName = item.Name });
            
        }
    }
}