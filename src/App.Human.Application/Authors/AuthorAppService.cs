using App.Human.Permissions;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace App.Human.Authors
{
    [Authorize(HumanPermissions.Employees.Default)]
    public class AuthorAppService : HumanAppService, IAuthorAppService
    {
        public AuthorAppService()
        {
        }
        public Task<AuthorDto> CreateAsync(CreateAuthorDto input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, UpdateAuthorDto input)
        {
            throw new NotImplementedException();
        }
    }
}
