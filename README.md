# WrapPagesExample

Before building, delete contents in Models directory, then create new database in SSMS using this query:

```sql
CREATE TABLE MaterialType (
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(MAX) NOT NULL
);
CREATE TABLE ProductType (
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(MAX) NOT NULL
);

----------------------------------------

CREATE TABLE Material (
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(MAX) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	Cost INT NOT NULL,
	[Image] NVARCHAR(MAX) NOT NULL,
	MaterialTypeId INT FOREIGN KEY REFERENCES MaterialType(Id)
);
CREATE TABLE Product (
	Id INT PRIMARY KEY IDENTITY,
	Title NVARCHAR(MAX) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	ArticleNumber INT NOT NULL,
	MinCost INT NOT NULL,
	ProductTypeId INT FOREIGN KEY REFERENCES ProductType(Id)
);

----------------------------------------

CREATE TABLE ProductMaterial (
	ProductId INT FOREIGN KEY REFERENCES Product(Id),
	MaterialId INT FOREIGN KEY REFERENCES Material(Id),
	[Count] INT NOT NULL
);
```

Then, if not installed, install through nuget these packages: EntityFrameworkCore, EntityFrameworkCore.Design, EntityFrameworkCore.Tools, EntityFrameworkCore.SqlServer.

After this, open package manager console, and enter this command(change all in [ ] quotes to your preferences):
```powershell
PM> Scaffold-DbContext "Server=[NAME OF YOUR DESKTOP]; Database=[NAME OF YOUR DATABASE]; Trusted_Connection=true;" Microsoft.EntityFrameworkCore.SqlServer -d -OutputDir Models
```

Then you can enjoy!
