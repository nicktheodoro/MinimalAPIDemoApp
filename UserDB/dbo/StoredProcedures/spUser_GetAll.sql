CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
begin
	select Id, FirstName, LastName, Age, RoleId
	from dbo.[User];
end
	
