using App.Human.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace App.Human.Permissions;

public class HumanPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var group = context.AddGroup(HumanPermissions.GroupName, L("Permission:Human"));

        var employeesPermission = group.AddPermission(HumanPermissions.Employees.Default, L("Permission:Employees"));
        employeesPermission.AddChild(HumanPermissions.Employees.Create, L("Permission:Employee.Create"));
        employeesPermission.AddChild(HumanPermissions.Employees.Edit, L("Permission:Employee.Edit"));
        employeesPermission.AddChild(HumanPermissions.Employees.Delete, L("Permission:Employee.Delete"));

        var departmentsPermission = group.AddPermission(HumanPermissions.Departments.Default, L("Permission:Departments"));
        departmentsPermission.AddChild(HumanPermissions.Departments.Create, L("Permission:Department.Create"));
        departmentsPermission.AddChild(HumanPermissions.Departments.Edit, L("Permission:Department.Edit"));
        departmentsPermission.AddChild(HumanPermissions.Departments.Delete, L("Permission:Department.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HumanResource>(name);
    }
}
