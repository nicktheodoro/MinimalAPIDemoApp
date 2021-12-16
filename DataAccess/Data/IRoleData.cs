using DataAccess.Models;

namespace DataAccess.Data;

public interface IRoleData
{
    Task DeleteRole(int id);
    Task<RoleModel?> GetRole(int id);
    Task<IEnumerable<RoleModel>> GetRoles();
    Task InsertRole(RoleModel role);
    Task UpdateRole(RoleModel role);
}