using App.Human.Employees;
using App.Human.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace App.Human.Departments
{
    public class DepartmentService : ApplicationService
    {
        private readonly IRepository<Department, Guid> _repository;
        public DepartmentService(IRepository<Department, Guid> repository)
        {
            _repository = repository;
        }
        public async Task<List<DepartmentDto>> GetListAsync()
        {
            var items = await _repository.GetListAsync();
            return items
                .Select(item => new DepartmentDto
                {
                    Id = item.Id,
                    DeptNameDto = item.DeptName,
                    AddressDto = item.Address,
                    DescriptionDto = item.Description,
                }).ToList();
        }

        public async Task<DepartmentDto> CreateAsync(string deptCode, string deptName, string address, string description)
        {
            var todoItem = await _repository.InsertAsync(
                new Department
                {
                    DeptCode = deptCode,
                    DeptName = deptName,
                    Address = address,
                    Description = description,
                }
            );
            return new DepartmentDto
            {
                Id = todoItem.Id,
                DeptCodeDto = todoItem.DeptCode,
                DeptNameDto = todoItem.DeptName,
                AddressDto = todoItem.Address,
                DescriptionDto = todoItem.Description,
            };
        }

        public async Task<DepartmentDto> UpdateAsync(string depCode, string deptName, string deptAddress)
        {
            //IQueryable<TodoItem> queryable = await _todoItemRepository.GetQueryableAsync();
            var item = await _repository.GetAsync(x => x.DeptCode == depCode);
            if (item == null)
            {
                return null;
            }
            if (deptName != null) item.DeptName = deptName;
            if (deptAddress != null) item.Address = deptAddress;
            await _repository.UpdateAsync(item);
            return new DepartmentDto
            {
                DeptNameDto = item.DeptName,
                AddressDto = item.Address,
            };
        }

        public async Task DeleteAsync(string code)
        {
            await _repository.DeleteAsync(x => x.DeptCode == code);
        }
    }
}
