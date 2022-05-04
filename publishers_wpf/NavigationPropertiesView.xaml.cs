using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using publishers_dal;
using publishers_models ;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;

namespace publishers_wpf
{
    /// <summary>
    /// Interaction logic for NavigationPropertiesView.xaml
    /// </summary>
    public partial class NavigationPropertiesView : UserControl
    {
        private IPublishersRepository publishersRepository = new PublishersRepository();
        private ITitlesRepository titleRepository = new TitlesRepository();
        private IEmployeesRepository employeeRepository = new EmployeesRepository();
        private ISalesRepository salesRepository = new SalesRepository();

        public NavigationPropertiesView()
        {
            InitializeComponent();
        }

        private void btnEmployees_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "Werknemers";
            lbData.ItemsSource = employeeRepository.OphalenEmployeesPublishersJobs(txtPublisher.Text);
        }

        private void btnPublishers_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "Uitgevers";
            lbData.ItemsSource = publishersRepository.OphalenPublishers(txtPublisher.Text);
        }

        private void btnTitles_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "Boeken";
            lbData.ItemsSource = titleRepository.OphalenTitlesPublisher(txtPublisher.Text, txtTitle.Text);
        }

        private void btnSalesTitle_Click(object sender, RoutedEventArgs e)
        {
            if (lbData.SelectedItem is Title title && title != null)
            {
                txtInfo.Text = $"Verkoop voor {title.title_name}";
                lbData.ItemsSource = salesRepository.OphalenSalesVoorTitle(title.title_id);
            }
            else
            {
                MessageBox.Show("Selecteer eerst een boek via de knop \"Boeken ophalen\"", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSalesPublisher_Click(object sender, RoutedEventArgs e)
        {
            if (lbData.SelectedItem is Publisher publisher && publisher != null)
            {
                txtInfo.Text = $"Verkoop voor {publisher.pub_name}";
                lbData.ItemsSource = salesRepository.OphalenSalesVoorPublisher(publisher.pub_id);
            }
            else
            {
                MessageBox.Show("Selecteer eerst een uitgever via de knop \"Uitgever ophalen\"", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
