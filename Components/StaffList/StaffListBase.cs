using Microsoft.AspNetCore.Components;
using StaffClient.dto;

public class StaffListBase : ComponentBase{

    [Inject]

    public IStaffService StaffService{get;set;}
    public IEnumerable<Employee> Employees{get; set;}

    protected override async Task OnInitializedAsync(){
        Employees = await StaffService.GetEmployees();
    }
}