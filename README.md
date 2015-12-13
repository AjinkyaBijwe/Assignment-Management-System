# Assignement-Management-System
management app in c#

A) Database Installation Instructions (also included into project report)
The Database in Assignment Management System consist of MySQL version 5.6.21.
First the system administrator should install the MySQL database into the system in which the project is going to be executed. The Steps to install the database
1. Download the MySQL Installer 5.6.21 from Link
“http://dev.mysql.com/downloads/windows/installer/” of 282.5 MB either 32bit or 64bit version
For specific version of windows or from “https://www.dropbox.com/s/jxluqiqhuzvnk6w/mysql-installer-community-5.6.19.0.msi?dl=0”
2. Run the Installer.
3. Proceed through steps by software, in server configuration step provide the Port: 3306, Username: root, Password: admin in
MySQL server setup.
4. Complete the setup.
5. Next install HeidiSQL from the folder.
6. After Installation create the new connection and give Port: 3306 , Username : root, Password: admin.
7. Double click the query given with the software named “database.sql” 
Again open existing connection with given credentials of database and click execute or press F9 in Heidi sql. (Can show warnings but database will be fully functional)
8. Click refresh or F5. The query should create a database named “Project” and tables named “Assignment”, “User” and “Log”.
9. After Creating database select table "assignment" or "log" or "users" from project database from left hand column.
10. Click "Data" from the tabs of the selected table in HeidiSql to view or edit data of database.

B) Application Execution
1. Install application from “AppSetup” folder or just execute application from “AssignmentManagementSystem(Group4)\AssignmentManagementSystem(group4)\462_ManagementApp\462_ManagementApp\bin\Debug\assignex.exe”
2. Login into Application from Given Login and Password Credentials from Database in “user” table.
