/****
This SQL script was generated by the Configure Data Synchronization
dialog box. This script contains statements that create the
change-tracking columns, deleted-items table, and triggers on the
server database. These database objects are required by Synchronization
Services to successfully synchronize data between client and server
databases. For more information, see the
‘How to: Configure a Database Server for Synchronization’ topic in Help.
****/


IF @@TRANCOUNT > 0
set ANSI_NULLS ON 
set QUOTED_IDENTIFIER ON 

GO
BEGIN TRANSACTION;


IF @@TRANCOUNT > 0
ALTER TABLE [Barcodes] 
ADD [LastEditDate] DateTime NULL CONSTRAINT [DF_Barcodes_LastEditDate] DEFAULT (GETUTCDATE()) WITH VALUES
GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
ALTER TABLE [Barcodes] 
ADD [CreationDate] DateTime NULL CONSTRAINT [DF_Barcodes_CreationDate] DEFAULT (GETUTCDATE()) WITH VALUES
GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[Barcodes_Tombstone]')) 
BEGIN 
CREATE TABLE [Barcodes_Tombstone]( 
    [Barcode] NChar(13) NOT NULL,
    [DeletionDate] DateTime NULL
) ON [PRIMARY] 
END 

GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
ALTER TABLE [Barcodes_Tombstone] ADD CONSTRAINT [PKDEL_Barcodes_Tombstone_Barcode]
   PRIMARY KEY CLUSTERED
    ([Barcode])
    ON [PRIMARY]
GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'Barcodes_DeletionTrigger') AND type = 'TR') 
   DROP TRIGGER [Barcodes_DeletionTrigger] 

GO
CREATE TRIGGER [Barcodes_DeletionTrigger] 
    ON [Barcodes] 
    AFTER DELETE 
AS 
SET NOCOUNT ON 
UPDATE [Barcodes_Tombstone] 
    SET [DeletionDate] = GETUTCDATE() 
    FROM deleted 
    WHERE deleted.[Barcode] = [Barcodes_Tombstone].[Barcode] 
IF @@ROWCOUNT = 0 
BEGIN 
    INSERT INTO [Barcodes_Tombstone] 
    ([Barcode], DeletionDate)
    SELECT [Barcode], GETUTCDATE()
    FROM deleted 
END 

GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'Barcodes_UpdateTrigger') AND type = 'TR') 
   DROP TRIGGER [Barcodes_UpdateTrigger] 

GO
CREATE TRIGGER [Barcodes_UpdateTrigger] 
    ON [Barcodes] 
    AFTER UPDATE 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [Barcodes] 
    SET [LastEditDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[Barcode] = [Barcodes].[Barcode] 
END;
GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;


IF @@TRANCOUNT > 0
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'Barcodes_InsertTrigger') AND type = 'TR') 
   DROP TRIGGER [Barcodes_InsertTrigger] 

GO
CREATE TRIGGER [Barcodes_InsertTrigger] 
    ON [Barcodes] 
    AFTER INSERT 
AS 
BEGIN 
    SET NOCOUNT ON 
    UPDATE [Barcodes] 
    SET [CreationDate] = GETUTCDATE() 
    FROM inserted 
    WHERE inserted.[Barcode] = [Barcodes].[Barcode] 
END;
GO
IF @@ERROR <> 0 
     ROLLBACK TRANSACTION;
COMMIT TRANSACTION;