USE [Baewatch]
GO
/****** Object:  StoredProcedure [dbo].[spGetProfileByName]    Script Date: 11/30/2016 3:54:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc spGetProfileByName
@Username varchar(255)
as
begin
Select * from Users where Username = @Username

end 