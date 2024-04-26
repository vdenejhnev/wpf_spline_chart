using classes;
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
using static classes.V2MainCollection;

namespace wpf2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public V2MainCollection MainCollection = new V2MainCollection(2, 2);

        public MainWindow()
        {
            InitializeComponent();
            DataContext = MainCollection;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainCollection.Add(new V2DataArray("dataarray", DateTime.Now));
        }
    }

}
