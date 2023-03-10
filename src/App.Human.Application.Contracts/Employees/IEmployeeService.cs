using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace App.Human.Employees
{
    public interface IEmployeeService : ICrudAppService< //Defines CRUD methods
        EmployeeDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateEmployeeDto> //Used to create/update a book
    {
    }
}
