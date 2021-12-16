using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;

public class RoleData : IRoleData
{
    private readonly ISqlDataAccess _db;

    public RoleData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<RoleModel>> GetRoles() =>
        _db.LoadData<RoleModel, dynamic>("dbo.spRole_GetAll", new { });

    public async Task<RoleModel?> GetRole(int id)
    {
        var results = await _db.LoadData<RoleModel, dynamic>(
            "dbo.spRole_Get",
            new { Id = id });

        return results.FirstOrDefault();
    }

    public Task InsertRole(RoleModel role) =>
        _db.SaveData("dbo.spRole_Insert", new { role.Description });

    public Task UpdateRole(RoleModel role) =>
        _db.SaveData("dbo.spRole_Update", role);

    public Task DeleteRole(int id) =>
        _db.SaveData("dbo.spRole_Delete", new { Id = id });
}
