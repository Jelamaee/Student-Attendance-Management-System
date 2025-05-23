
ALTER USER 'root'@'localhost' IDENTIFIED BY 'mike';
CREATE DATABASE student_attendance_system;
GRANT ALL PRIVILEGES ON student_attendance_system.* TO 'root'@'localhost';
FLUSH PRIVILEGES;