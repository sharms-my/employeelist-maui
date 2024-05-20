using EmployeeList.Models.ViewModels;

namespace EmployeeList.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void employeeButton1_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailViewModel = new EmployeeDetailViewModel2
        //{
        //    EmployeeId = "1001",
        //    EmployeeName = "John Doe",
        //    Email = "johndoe@test.com",
        //    IsPartTimer = true
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailViewModel;
        //Navigation.PushAsync(employeeDetailPage);
    }

    private void employeeButton2_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailViewModel = new EmployeeDetailViewModel2
        //{
        //    EmployeeId = "1002",
        //    EmployeeName = "Jane Smith",
        //    Email = "janesmith@test.com",
        //    IsPartTimer = false
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailViewModel;
        //Navigation.PushAsync(employeeDetailPage);
    }

    private void employeeButton3_Clicked(object sender, EventArgs e)
    {
        //var employeeDetailViewModel = new EmployeeDetailViewModel2
        //{
        //    EmployeeId = "1003",
        //    EmployeeName = "Pop Eye",
        //    Email = "popeye@test.com",
        //    IsPartTimer = true
        //};
        //var employeeDetailPage = new EmployeeDetailPage();
        //employeeDetailPage.BindingContext = employeeDetailViewModel;
        //Navigation.PushAsync(employeeDetailPage);
    }
}