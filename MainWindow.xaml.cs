using System.Collections.ObjectModel;
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

        public int m_nID { get; set; }
        public string m_strName { get; set; }
        public string m_strSname { get; set; }
        public string m_strPESEL { get; set; }
        public string m_strSurname { get; internal set; }
        public string m_strSecName { get; internal set; }
    }

    public partial class MainWindow : Window
    {

        public ObservableCollection<Person> People { get; set; }

        public MainWindow()
        {
            InitializeComponent();


            People = new ObservableCollection<Person>();
            listView.ItemsSource = People;
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person newPerson = new Person
            {
                
            };


            People.Add(newPerson);
        }
        private void NewRecord_Click(object sender, RoutedEventArgs e)
        {
            
            var dodajOsobeWindow = new DodajOsobe(); 
            if (dodajOsobeWindow.ShowDialog() == true)
            {
                People.Add(dodajOsobeWindow.Person); 
            }
        }
    }
}
