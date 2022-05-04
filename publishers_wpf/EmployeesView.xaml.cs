using System;
using System.Windows;
using System.Windows.Controls;
using publishers_models;
using publishers_dal ;

namespace publishers_wpf
{
    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : UserControl
    {
        private IEmployeesRepository EmployeeRepository = new EmployeesRepository();
        private IJobsRepository JobsRepository = new JobsRepository();
        private IPublishersRepository PublishersRepository = new PublishersRepository();

        public EmployeesView()
        {
            InitializeComponent();
            cmbJobs.ItemsSource = JobsRepository.OphalenJobs();
            cmbPublishers.ItemsSource = PublishersRepository.OphalenPublishers();
        }

        private void btnZoekWerknemers_Click(object sender, RoutedEventArgs e)
        {
            datagridEmployees.ItemsSource = EmployeeRepository.OphalenEmployees();
        }

        private void btnZoekEmployeesViaJob_Click(object sender, RoutedEventArgs e)
        {
            if (cmbJobs.SelectedItem is Job job)
            {
                datagridEmployees.ItemsSource = EmployeeRepository.OphalenEmployeesViaJob_id(job.job_id);
            }
        }

        private void btnZoekWerknemersViaPubid_Click(object sender, RoutedEventArgs e)
        {
            if (cmbPublishers.SelectedItem is Publisher publisher)
            {
                datagridEmployees.ItemsSource = EmployeeRepository.OphalenEmployeesViaPub_id(publisher.pub_id);
            }
        }

        private void btnZoekWerknemersViaPubidEnJob_id_Click(object sender, RoutedEventArgs e)
        {
            int job_id = 0;
            string pub_id = "";
            if (cmbJobs.SelectedItem is Job job)
            {
                job_id = job.job_id;
            }
            if (cmbPublishers.SelectedItem is Publisher publisher)
            {
                pub_id = publisher.pub_id;
            }
            datagridEmployees.ItemsSource = EmployeeRepository.OphalenEmployeesViaPub_idEnJob_id(pub_id, job_id);
        }

        private void btnZoekWerknemersViaHireDate_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtHireDate.Text))
            {
                DateTime hiredate = Convert.ToDateTime(txtHireDate.Text);
                datagridEmployees.ItemsSource = EmployeeRepository.OphalenEmployeesViaHireDate(hiredate);
            }
        }

        private void btnZoekWerknemerviaPK_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = EmployeeRepository.OphalenEmployeeViaPK(txtEmp_id.Text);
            if (employee != null)
            {
                MessageBox.Show(employee.ToString());
            }
            else
            {
                MessageBox.Show("niet gevonden");
            }
        }
    }
}