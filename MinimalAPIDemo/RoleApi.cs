namespace MinimalAPIDemo;

public static class RoleApi
{
    public static void ConfigureRoleApi(this WebApplication app)
    {
        // All of my API endpoint mapping

        app.MapGet("/Roles", GetRoles);
        app.MapGet("/Roles/{id}", GetRole);
        app.MapPost("/Roles", InsertRole);
        app.MapPut("/Roles", UpdateRole);
        app.MapDelete("/Roles", DeleteRole);
    }

    private static async Task<IResult> GetRoles(IRoleData data)
    {
        try
        {
            return Results.Ok(await data.GetRoles());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetRole(int id, IRoleData data)
    {
        try
        {
            var results = await data.GetRole(id);

            if (results == null) return Results.NotFound();

            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertRole(RoleModel role, IRoleData data)
    {
        try
        {
            await data.InsertRole(role);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateRole(RoleModel role, IRoleData data)
    {
        try
        {
            await data.UpdateRole(role);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteRole(int id, IRoleData data)
    {
        try
        {
            await data.DeleteRole(id);

            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
