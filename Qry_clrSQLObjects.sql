EXEC sp_configure 'show advanced options' , 1;
RECONFIGURE;


EXEC sp_configure 'clr enable' ,1;
    RECONFIGURE;

 EXEC sp_configure 'clr strict security', 0;
    RECONFIGURE;

use FactE
go

create ASSEMBLY SQLCLRDemoTaller2
from 'D:\vidapogosoft\cursos\2023\SINERGIASS\SQL-ADVANCED\code\CLRDemo1\bin\Debug\CLRDemo1.dll'


use FactE
go
CREATE FUNCTION GetFirstCharacterOccurence(@str nvarchar(255)) RETURNS INT
EXTERNAL NAME SQLCLRDemoTaller2.Class1.FirstCharacterOccurence;
GO


/*

CREATE FUNCTION GetFirstCharacterOccurence(<input parameters>) RETURNS <output data type>
    EXTERNAL NAME <clr assembly>.<class name>.<Function name>;
                GO

*/


SELECT dbo.GetFirstCharacterOccurence('sinergiass')
