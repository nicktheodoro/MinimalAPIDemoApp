CREATE PROCEDURE [dbo].[spRole_Insert]
	@Description nvarchar(50)
AS
begin
	insert into dbo.[Role] (Description)
	values(@Description);
end
