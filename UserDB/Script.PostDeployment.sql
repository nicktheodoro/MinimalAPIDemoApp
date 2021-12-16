if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[Role] (Description)
	values ('Client'),
	('Lawyer'),
	('Expert'),
	('Manager');
	
	insert into dbo.[User] (FirstName, LastName,Age, RoleId)
	values ('Tim', 'Corey', 27, 1),
	('Sue', 'Storm', 32, 1),
	('John', 'Smith', 16, 4),
	('Mary', 'Jones', 45, 3);
end
