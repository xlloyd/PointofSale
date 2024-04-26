CREATE TABLE [dbo].[tblMain] (
    [MainID]     INT          IDENTITY (1, 1) NOT NULL,
    [aDate]      DATE         NULL,
    [Time]       VARCHAR (15) NULL,
    [TableName]  VARCHAR (10) NULL,
    [WaiterName] VARCHAR (15) NULL,
    [status]     VARCHAR (15) NULL,
    [orderType]  NVARCHAR (15) NULL,
    [total]      FLOAT (53)   NULL,
    [received]   FLOAT (53)   NULL,
    [change]     FLOAT (53)   NULL,
    PRIMARY KEY CLUSTERED ([MainID] ASC)
);

