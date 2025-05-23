
@echo off
REM -- MySQL Configuration Script After Unattended Install --
REM Assumes MySQL is installed in the default location and added to PATH

set MYSQL_PATH="C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe"

echo Setting root password and user privileges...
%MYSQL_PATH% -u root --connect-expired-password < "%~dp0init_db.sql"

echo Restoring student_attendance_system.sql into student_attendance_system...
%MYSQL_PATH% -u root -pmike student_attendance_system < "%~dp0student_attendance_system.sql"

echo MySQL setup and database restoration complete.
pause