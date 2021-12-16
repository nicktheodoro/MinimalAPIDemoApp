CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Age nvarchar(50),
	@RoleId int
AS
begin
	update dbo.[User]
	set FirstName = @FirstName, LastName = @LastName, Age = @Age, RoleId = @RoleId
	where Id = @Id;
end
