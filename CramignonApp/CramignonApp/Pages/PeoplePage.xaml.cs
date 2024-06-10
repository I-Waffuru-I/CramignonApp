using CramignonApp.Models;
using CramignonApp.Services;
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

namespace CramignonApp.Pages
{
    /// <summary>
    /// Interaction logic for PeoplePage.xaml
    /// </summary>
    public partial class PeoplePage : Page
    {
        IPeopleService _peopleService;

        public IList<Person> People { get; set; }


        public PeoplePage(IPeopleService serv)
        {
            InitializeComponent();
            _peopleService = serv;
            People = [];

            Loaded += PeoplePage_Loaded;

        }

        private void PeoplePage_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }

        private async void UpdateList()
        {
            People = await _peopleService.GetAll();
            peopleListView.ItemsSource = People;
        }
    }
}
