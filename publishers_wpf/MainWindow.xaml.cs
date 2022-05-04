using System.Windows;
using System.Windows.Controls;

namespace publishers_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string geselecteerdTabblad = (tabControl.SelectedItem as TabItem).Name;
            switch (geselecteerdTabblad)
            {
                case "tabEmployee":
                    ContentWindow.Content = new EmployeesView();
                    break;

                case "tabNavigation":
                    ContentWindow.Content = new NavigationPropertiesView();
                    break;
                
                default:
                    ContentWindow.Content = new StoresView();
                    break;
            }
        }
    }
}