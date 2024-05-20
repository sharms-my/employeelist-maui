using CommunityToolkit.Mvvm.ComponentModel;

namespace EmployeeList.Models.ViewModels
{
    internal partial class EmployeeDetailViewModel2 : ObservableObject
    {
        [ObservableProperty]
        private Employee employee;
    }
}
