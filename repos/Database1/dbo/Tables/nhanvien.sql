CREATE TABLE [dbo].[nhanvien] (
    [manv]     NVARCHAR (50) NOT NULL,
    [hoten]    NVARCHAR (50) NULL,
    [gioitinh] BIT           NULL,
    [ngaysinh] DATE          NULL,
    [hsl]      FLOAT (53)    NULL,
    [madv]     NVARCHAR (50) NULL,
    CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED ([manv] ASC),
    CONSTRAINT [FK_nhanvien_donvi] FOREIGN KEY ([madv]) REFERENCES [dbo].[donvi] ([madv])
);

