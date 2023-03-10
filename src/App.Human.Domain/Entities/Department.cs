using System;
using Volo.Abp.Domain.Entities;

namespace App.Human.Entities
{
    public class Department : BasicAggregateRoot<Guid>
    {
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
