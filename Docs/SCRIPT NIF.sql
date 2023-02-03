           
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nif]') AND type in (N'U'))
DROP TABLE [dbo].[Nif]
GO

CREATE TABLE [dbo].[Nif](
	[Nome] [nvarchar](80) NOT NULL,
	[Morada] [nvarchar](80) NULL,
	[Sexo] [int] NULL,
	[DataNascimento] [datetime] NULL,
	[Profissao] [nvarchar](80) NULL,
	[Email] [nvarchar](80) NULL,
	[Telefone] [nvarchar](15) NULL,
    [Nif] [varchar] (9) NOT NULL
 CONSTRAINT [PK_Nif] PRIMARY KEY CLUSTERED 
(
	[Nome] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

INSERT INTO [dbo].[Nif]
            ([Nome]
		   ,[Morada]
           ,[Sexo]          
           ,[DataNascimento]
           ,[Profissao]
           ,[Email]
		   ,[Telefone]
           ,[Nif]
           )
     VALUES
           ('Geraldo Nogueira','Rua Pinto Cardoso','1', '19591231', 'Engenheiro Cívil', 'geraldo.nogueira@gerno.com','912345678','453215985'),
           ('Sandra Rosa','Rua Maracá','2', '19980714', 'Engenheira Mecânica', 'sandra.rosa@gerno.com','985324785','548621751')
		   
		  
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GravarNif]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GravarNif]
GO

CREATE Procedure [dbo].[GravarNif]
@Nome nvarchar(80),
@Morada nvarchar(80),
@Sexo int,
@DataNascimento datetime,
@Profissao nvarchar(80),
@Email nvarchar(80),
@Telefone nvarchar(15),
@Nif int
As 
Begin

Begin Transaction
   
 IF (Select Count(*) From Nif Where Nome=@Nome)=0
      Begin
         Insert Into Nif (Nome,Morada,Sexo,DataNascimento,Profissao,Email,Telefone,Nif)
         Values (@Nome,@Morada,@Sexo,@DataNascimento,@Profissao,@Email,@Telefone,@Nif)
	  End
 Else
     Begin
         Update Nif
         Set Nome=@Nome,Morada=@Morada,Sexo=@Sexo,DataNascimento=@DataNascimento,
             Profissao=@Profissao,Email=@Email,Telefone=@Telefone, Nif=@Nif
		 Where Nome=@Nome
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

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ObterNif]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ObterNif]
GO

CREATE Procedure [dbo].[ObterNif]
@Nome int
As 
Begin
	Select * From Nif Where Nome=@Nome
End


GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ListarNif]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ListarNif]
GO

CREATE Procedure [dbo].[ListarNif]
As 
Begin
	Select * From Nif
End

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EliminarNif]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EliminarNif]
GO

CREATE Procedure [dbo].[EliminarNif]
@Nome int
AS
Begin

Begin Transaction
         
      If (Select Count(*) From Nif Where Nome=@Nome)<>0
          Begin
              Delete from Nif
              Where Nome=@Nome
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