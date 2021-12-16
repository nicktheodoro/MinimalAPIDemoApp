CREATE PROCEDURE [dbo].[spRole_Update]
	@Id int,
	@Description nvarchar(50)
AS
begin
	update dbo.[Role]
	set Description = @Description
	where Id = @Id;
end