# CSV Validator App

This app is developed with .Net Core 3.0.101 to demonstrate crud operations using Entity Framework Core 3.0 with Sql Server as backend.

## Prerequisites

In order to run this app, you need .Net Core SDK that includes .Net CLI tools and .Net Core Runtime installed on our machine.
So download and install the latest version of .Net Core SDK available from this link https://dotnet.microsoft.com/download

### Installing

After downloading the .Net Core SDK installer file, just double click on it and follow the instructions with default settings.
After installation is complete, open the command window and run the following command.

```
dotnet --version
```

It will return the version number of the .Net Core.

## Getting Started

Clone or Download the zip file of this repository.

### Entity Framework Core tools

Also you will require Entity Framework Core tools that includes “dotnet ef” tool and the EF designer installed in order to create EF Migrations.

So open the command window in the folder where you have cloned or unzipped the repository.
Now run following commands.

```
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
```

### Create the database

- First, we need to add migrations that will create the database schema of our model entities.
  So run following commands to create the database.

```
dotnet ef migrations add InitialCreate
```

- Second, we need to apply “initialCreate” migration on the database so it will create new database.
  So run following command to apply the migration to the database.

```
dotnet ef database update
```

### Running the App

Run the following command to run the app in the command window.

```
dotnet run
```

## Built With

- [.Net Core SDK 3.0](https://dotnet.microsoft.com/download/dotnet-core/3.0) - The .Net Core framework used
- [VS Code](https://code.visualstudio.com/download) - The Code editor used
