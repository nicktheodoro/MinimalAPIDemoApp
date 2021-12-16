CREATE PROCEDURE [dbo].[spRole_Delete]
	@Id int
AS
begin
	delete
	from dbo.[Role]
	where Id = @Id;
end
