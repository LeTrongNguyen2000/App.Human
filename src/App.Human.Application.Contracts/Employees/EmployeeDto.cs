using App.Human.Departments;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace App.Human.Employees
{
    public class EmployeeDto : AuditedEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public string Address { get; set; }
        public EmployeePosition Position { get; set; }
        public string DeptCodeDto { get; set; }
        public string DeptNameDto { get; set; }
        public string AddressDto { get; set; }
        public string DescriptionDto { get; set; }
    }
}
