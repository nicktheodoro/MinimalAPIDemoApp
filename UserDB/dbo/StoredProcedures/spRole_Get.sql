CREATE PROCEDURE [dbo].[spRole_Get]
	@Id int
AS
begin
	select Id, Description
	from dbo.[Role]
	where Id = @Id;
end
