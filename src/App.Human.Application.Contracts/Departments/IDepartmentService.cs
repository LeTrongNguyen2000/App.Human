using App.Human.Employees;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace App.Human.Departments
{
    public interface IDepartmentService : ICrudAppService< //Defines CRUD methods
        DepartmentDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateDepartmentDto> //Used to create/update a book
    {
    }

}
