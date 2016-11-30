create proc spUpdateDescription
@ID int,
@Description varchar(255)
as
begin
Update Users
Set Description = @Description
Where ID=@ID
end 
