using System.Configuration;
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
using CramignonApp.Pages;

namespace CramignonApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StartPage startPage;
        PeoplePage peoplePage;

        public string TestName = "testing for binding";
        public MainWindow(StartPage spage, PeoplePage ppage)
        {
            InitializeComponent();
            startPage = spage;
            peoplePage = ppage;

            MainFrame.Content = peoplePage;
        }

        private void couplesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content == startPage)
                return;

            MainFrame.Content = startPage;
        }

        private void peopleBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.Content == peoplePage)
                return;

            MainFrame.Content = peoplePage;
        }
    }
}