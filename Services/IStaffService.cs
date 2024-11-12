using StaffClient.dto;

public interface IStaffService{
    Task<IEnumerable<Employee>> GetEmployees();
    Task<Employee> GetEmployee(int id);
}