using App.Human.Employees;
using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities;

namespace App.Human.Entities
{
    public class Employee : BasicAggregateRoot<Guid>
    {
        public string Code { get; set; }
        public string FullName { get; set; }
        public float Salary { get; set; }
        public string Address { get; set; }
        public EmployeePosition Position { get; set; }
        public Department ObjDepartment { get; set; }
    }
}
