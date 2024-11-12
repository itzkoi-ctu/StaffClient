using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StaffClient.dto;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public int? GenderId { get; set; }

    public int? DepartmentId { get; set; }
    [JsonIgnore]
    public virtual Department? Department { get; set; }
    [JsonIgnore]
    public virtual Gender? Gender { get; set; }
}
    