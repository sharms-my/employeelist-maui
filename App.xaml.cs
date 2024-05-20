using EmployeeList.Pages;

namespace EmployeeList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EmployeeListPage());
        }
    }
}
