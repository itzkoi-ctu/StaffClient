using StaffClient.dto;

public class StaffService : IStaffService{
    private readonly HttpClient httpClient;

    public StaffService(HttpClient httpClient){
        this.httpClient= httpClient;
    }

    public async Task<IEnumerable<Employee>> GetEmployees(){
        return await httpClient.GetFromJsonAsync<Employee[]>("api/employees");

    }
    public async Task<Employee> GetEmployee(int id){

        return await httpClient.GetFromJsonAsync<Employee>($"api/employees/{id}");
    }

    
}