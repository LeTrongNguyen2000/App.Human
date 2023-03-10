using App.Human.Departments;
using App.Human.Employees;
using App.Human.Entities;
using AutoMapper;

namespace App.Human;

public class HumanApplicationAutoMapperProfile : Profile
{
    public HumanApplicationAutoMapperProfile()
    {
        CreateMap<Employee, EmployeeDto>()
             .ForMember(des => des.Name, act => act.MapFrom(src => src.FullName))
             .ForMember(des => des.DeptCodeDto, act => act.MapFrom(src => src.ObjDepartment.DeptCode))
             .ForMember(des => des.DeptNameDto, act => act.MapFrom(src => src.ObjDepartment.DeptName))
             .ForMember(des => des.AddressDto, act => act.MapFrom(src => src.ObjDepartment.Address))
             .ForMember(des => des.DescriptionDto, act => act.MapFrom(src => src.ObjDepartment.Description));

        CreateMap<Department, DepartmentDto>()
            .ForMember(des => des.DeptCodeDto, act => act.MapFrom(src => src.DeptCode))
            .ForMember(des => des.DeptNameDto, act => act.MapFrom(src => src.DeptName))
            .ForMember(des => des.AddressDto, act => act.MapFrom(src => src.Address))
            .ForMember(des => des.DescriptionDto, act => act.MapFrom(src => src.Description));

        CreateMap<CreateUpdateEmployeeDto, Employee>();
        CreateMap<CreateUpdateDepartmentDto, Department>();
    }
}
