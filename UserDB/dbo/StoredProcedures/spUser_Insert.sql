CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Age nvarchar(50),
	@RoleId int
AS
begin
	insert into dbo.[User] (FirstName, LastName, Age, RoleId)
	values(@FirstName, @LastName, @Age, @RoleId);
end
