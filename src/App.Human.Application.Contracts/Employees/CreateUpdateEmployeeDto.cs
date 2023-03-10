using App.Human.Departments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Human.Employees
{
    public class CreateUpdateEmployeeDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public float Salary { get; set; }
        public string Address { get; set; }
        public EmployeePosition Position { get; set; } = EmployeePosition.DotNET;
        public DepartmentDto DestinationDepartment { get; set; }
    }
}
