CREATE PROCEDURE [dbo].[spRole_GetAll]
AS
begin
	select Id, Description
	from dbo.[Role]
end
