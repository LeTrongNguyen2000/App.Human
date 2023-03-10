using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Human.Departments
{
    public class CreateUpdateDepartmentDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(5)]
        public string DeptCodeDto { get; set; }
        public string DeptNameDto { get; set; }
        public string AddressDto { get; set; }
        public string DescriptionDto { get; set; }
    }
}
