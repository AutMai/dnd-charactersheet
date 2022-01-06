export MYSQL_PWD=root;"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe" -u root -e "DROP DATABASE dnd;CREATE DATABASE dnd;"

cd Model
rm -rf Migrations

echo 'Enter migration name:'
read migrationName

dotnet ef -s ../View migrations add "$migrationName"

dotnet ef -s ../View database update

export MYSQL_PWD=root;"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe" -u root dnd < dnd_inserts.sql