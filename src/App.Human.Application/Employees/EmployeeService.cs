using App.Human.Departments;
using App.Human.Entities;
using App.Human.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Authorization;
using Volo.Abp.Domain.Repositories;

namespace App.Human.Employees
{
    public class EmployeeService : ApplicationService
    {
        private readonly IRepository<Employee, Guid> _repositoryEmployee;
        private readonly IRepository<Department, Guid> _repositoryDepartment;
        public EmployeeService(IRepository<Employee, Guid> repositoryEmployee, IRepository<Department, Guid> repositoryDepartment)
        {
            _repositoryEmployee = repositoryEmployee;
            _repositoryDepartment = repositoryDepartment;
        }
        [Authorize(HumanPermissions.Employees.Default)]
        public async Task<List<EmployeeDto>> GetListAsync()
        {
            var lstEmployee = await _repositoryEmployee.GetListAsync();
            var lstDepartment = await _repositoryDepartment.GetListAsync();
            var result = from employee in lstEmployee
                         join department in lstDepartment on employee.ObjDepartment.DeptCode equals department.DeptCode
                         select new Employee
                         {
                             FullName = employee.FullName,
                             Salary = employee.Salary,
                             Address = employee.Address,
                             ObjDepartment = department
                         };
            return result
                .Select(item => new EmployeeDto
                {
                    Id = item.Id,
                    Name = item.FullName,
                    Salary = item.Salary,
                    Address = item.Address,
                    DeptCodeDto = item.ObjDepartment.DeptCode,
                    DeptNameDto = item.ObjDepartment.DeptName,
                    AddressDto = item.ObjDepartment.Address,
                    DescriptionDto = item.ObjDepartment.Description,
                }).ToList();
        }
        public async Task<EmployeeDto> CreateAsync(string code, string fullName, float salary, string address, string deptCode)
        {
            //        var result = await AuthorizationService
            //.AuthorizeAsync(HumanPermissions.Employees.Create);
            //        if (result.Succeeded == false)
            //        {
            //            //throw exception
            //            throw new AbpAuthorizationException("Ban khong co quyen them nhan vien!!!");
            //        }
            var departmentItem = await _repositoryDepartment.GetAsync(x => x.DeptCode == deptCode);
            var departmentDtoItem = new DepartmentDto
            {
                DeptCodeDto = departmentItem.DeptCode,
                DeptNameDto = departmentItem.DeptName,
                AddressDto = departmentItem.Address,
                DescriptionDto = departmentItem.Description,
            };
            var employeeItem = await _repositoryEmployee.InsertAsync(
                new Employee
                {
                    Code = code,
                    FullName = fullName,
                    Salary = salary,
                    Address = address,
                    ObjDepartment = departmentItem
                }
            );

            return new EmployeeDto
            {
                Id = employeeItem.Id,
                Code = employeeItem.Code,
                Name = employeeItem.FullName,
                Salary = employeeItem.Salary,
                Address = employeeItem.Address,
                DeptCodeDto = employeeItem.ObjDepartment.DeptCode,
                DeptNameDto = employeeItem.ObjDepartment.DeptName,
                AddressDto = employeeItem.ObjDepartment.Address,
                DescriptionDto = employeeItem.ObjDepartment.Description,
            };
        }

        public async Task<EmployeeDto> UpdateAsync(string code, string fullName, float salary, string address)
        {
            //IQueryable<TodoItem> queryable = await _todoItemRepository.GetQueryableAsync();
            var item = await _repositoryEmployee.GetAsync(x => x.Code == code);
            if (item == null)
            {
                return null;
            }
            if (fullName != null)
                item.FullName = fullName;
            if (salary != 0)
                item.Salary = salary;
            if (address != null)
                item.Address = address;
            await _repositoryEmployee.UpdateAsync(item);
            return new EmployeeDto
            {
                Name = item.FullName,
                Salary = item.Salary,
                Address = item.Address,
            };
        }

        public async Task DeleteAsync(string code)
        {
            await _repositoryEmployee.DeleteAsync(x => x.Code == code);
        }
    }
}
