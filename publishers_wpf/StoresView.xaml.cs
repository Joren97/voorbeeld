using publishers_dal;
using publishers_models;
using System.Windows;
using System.Windows.Controls;

namespace publishers_wpf
{
    /// <summary>
    /// Interaction logic for StoresView.xaml
    /// </summary>
    public partial class StoresView : UserControl
    {
        public StoresView()
        {
            InitializeComponent();
        }

        private IStoresRepository storesRepository = new StoresRepository();

        private void btnZoekWinkels_Click(object sender, RoutedEventArgs e)
        {
            datagridStores.ItemsSource = storesRepository.OphalenStoresViaStorName(txtNaam.Text);
        }

        private void btnZoekWinkelsViaState_Click(object sender, RoutedEventArgs e)
        {
            datagridStores.ItemsSource = storesRepository.OphalenStoresViaState(txtState.Text);
        }

        private void btnZoekWinkelsViaNaamEnState_Click(object sender, RoutedEventArgs e)
        {
            datagridStores.ItemsSource = storesRepository.OphalenStoresViaStorNameEnState(txtNaam.Text, txtState.Text);
        }

        private void btnZoekWinkelsViaPK_Click(object sender, RoutedEventArgs e)
        {
            Store s = storesRepository.OphalenStoreViaPK(txtID.Text);
            if (s != null)
            {
                MessageBox.Show(s.stor_name);
            }
            else
            {
                MessageBox.Show("niet gevonden");
            }
        }
    }
}