using System.Configuration;
using Microsoft.AspNetCore.Components;
using StaffClient.dto;

public class StaffDetailBase : ComponentBase{
    
    public Employee employee{get; set;}

    [Inject]

    public IStaffService staffService{get; set;}

    [Parameter]

    public string Id {get ; set;}

    protected async override Task OnInitializedAsync(){
        Id= Id ?? "1"; 
        employee = await staffService.GetEmployee(int.Parse(Id));
    }
}