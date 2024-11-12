using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StaffClient.dto;

public partial class Gender
{
    public int GenderId { get; set; }

    public string GenderDescription { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
