USE [Baewatch]
GO
/****** Object:  StoredProcedure [dbo].[spDelete]    Script Date: 11/30/2016 3:52:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc spDelete
@Username varchar(255)
as 
begin
Delete from Users where Username= @Username
end 