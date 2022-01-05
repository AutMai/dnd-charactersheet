cd Model

echo 'Enter migration name:'
read migrationName

dotnet ef -s ../View migrations add "$migrationName"

dotnet ef -s ../View database update