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

namespace WpfApp1
{


    /// <summary>
    /// Logika interakcji dla klasy DodajOsobe.xaml
    /// </summary>
    public partial class DodajOsobe : Window
    {
        public Person Person { get; private set; }
        public DodajOsobe(Person person) { 
            InitializeComponent();
            Person = new Person();
            if (person != null)
            {
                txtPESEL.Text = person.m_strPESEL;
                txtName.Text = person.m_strName;
                txtSecName.Text = person.m_strSecName;
                txtSurname.Text = person.m_strSurname;
            }    
        }
    }
}
