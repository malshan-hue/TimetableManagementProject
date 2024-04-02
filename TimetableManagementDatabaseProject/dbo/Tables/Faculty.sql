CREATE TABLE [dbo].[Faculty] (
    [FacultyId]             INT           IDENTITY (1, 1) NOT NULL,
    [FacultyGlobalIdentity] NVARCHAR (50) NOT NULL,
    [FacultyName]           NVARCHAR (50) NOT NULL,
    [IsDeleted]             BIT           DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Faculty_FacultyId] PRIMARY KEY CLUSTERED ([FacultyId] ASC)
);

