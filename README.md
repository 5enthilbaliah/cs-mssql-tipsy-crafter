# cs-mssql-tipsy-crafter

## Prerequisites
- Make sure dotnet tool ef is installed globally
```shell
dotnet tool list --global
```
- Install ef globally if not found
```shell
dotnet tool install --global dotnet-ef
```
- You should have a local instance of sql server; We recommend to docker compose up the ms-sql-foundation.

## About project

## Set up
- Clone the repository
```shell
git clone https://github.com/5enthilbaliah/cs-mssql-tipsy-crafter.git
```

- navigate in the cs-mssql-tipsy-crafter and at the solution level open command prompt and execute below command.
```shell
dotnet ef database update -p cs-mssql-tipsy-crafter-infrastructure -s cs-mssql-tipsy-crafter-host
```
