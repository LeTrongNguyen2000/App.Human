using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace App.Human.Departments
{
    public class DepartmentDto : AuditedEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public string DeptCodeDto { get; set; }
        public string DeptNameDto { get; set; }
        public string AddressDto { get; set; }
        public string DescriptionDto { get; set; }
    }
}
