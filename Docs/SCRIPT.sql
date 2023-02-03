IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aluno]') AND type in (N'U'))
DROP TABLE [dbo].[Aluno]
GO

CREATE TABLE [dbo].[Aluno](
	[IDAluno] [nvarchar](10) NOT NULL,
	[NomeAluno] [nvarchar](80) NULL,
	[DataNascimento] [datetime] NULL,
	[Telefone] [nvarchar](30) NULL,
 CONSTRAINT [PK_Aluno] PRIMARY KEY CLUSTERED 
(
	[IDAluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [dbo].[Aluno]
           ([IDAluno]
		   ,[NomeAluno]
           ,[DataNascimento]
		   ,[Telefone]
           )
     VALUES
           ('1','Aluno 1','19870315','+351 98 253423232'),
		   ('2','Aluno 2','19870315','+351 98 253423232'),
		   ('3','Aluno 3','19870315','+351 98 253423232'),
		   ('4','Aluno 4','19870315','+351 98 253423232'),
		   ('5','Aluno 5','19870315','+351 98 253423232')
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GravarAluno]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GravarAluno]
GO

CREATE Procedure [dbo].[GravarAluno]
@IDAluno nvarchar(10),
@NomeAluno nvarchar(80),
@DataNascimento datetime,
@Telefone nvarchar(30)
As 
Begin

Begin Transaction
   
 IF (Select Count(*) From Aluno Where IDAluno=@IDAluno)=0
      Begin
         Insert Into [Aluno] (IDAluno, NomeAluno, DataNascimento, [Telefone])
         Values (@IDAluno, @NomeAluno, @DataNascimento, @Telefone)
      End
 Else
     Begin
         Update Aluno
         Set NomeAluno = @NomeAluno, DataNascimento=@DataNascimento, [Telefone]=@Telefone
         Where IDAluno=@IDAluno
      End
 
      If @@error <>0
            Begin
               Rollback transaction
            End
      Else
            Begin
               Commit Transaction
            End
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObterAluno]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ObterAluno]
GO

CREATE Procedure [dbo].[ObterAluno]
@IDAluno nvarchar(10)
As 
Begin

	Select * From Aluno Where IDAluno=@IDAluno
End


GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ListarAluno]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ListarAluno]
GO

CREATE Procedure [dbo].[ListarAluno]
As 
Begin

	Select * From Aluno
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarAluno]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarAluno]
GO

CREATE Procedure [dbo].[EliminarAluno]
@IDAluno nvarchar(10)
AS
Begin

Begin Transaction
         
      If (Select Count(*) From Aluno Where IDAluno=@IDAluno)<>0
          Begin
              Delete from Aluno
              Where IDAluno=@IDAluno
            End

       If @@error <>0
               Begin 
                  Rollback TRansaction
               End
       Else
            Begin
               Commit Transaction
            End

End


GO

