# Assignment-Management-System
Management App in C#
---------------------

A) Database Installation Instructions
The Database in Assignment Management System consist of MySQL version 5.6.21.
First the system administrator should install the MySQL database into the system in which the project is going to be executed. The Steps to install the database

1. Download the MySQL Installer 5.6.21 from Link
“http://dev.mysql.com/downloads/windows/installer/” of 282.5 MB either 32bit or 64bit version
For specific version of windows

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
 
Screenshots
============

Login
========
![firsttime login screen form to change password](https://cloud.githubusercontent.com/assets/8812357/12862835/29ec3410-cc24-11e5-83d5-bc72f4492542.JPG)
![error message when password in both textbox did not match](https://cloud.githubusercontent.com/assets/8812357/12862833/29ebc70a-cc24-11e5-97ee-d097296712d3.JPG)
![error message when password is entered less than 6 characters](https://cloud.githubusercontent.com/assets/8812357/12862836/29ed3a7c-cc24-11e5-846a-39681df27c58.JPG)
![loginscreen](https://cloud.githubusercontent.com/assets/8812357/12862837/29ee4de0-cc24-11e5-96ea-21ad31dea9bb.JPG)



Manager Operations
==================
![manager login](https://cloud.githubusercontent.com/assets/8812357/12862858/37669fae-cc24-11e5-86d9-cf429e47ed3f.JPG)
![manager assignment page](https://cloud.githubusercontent.com/assets/8812357/12862857/3764bf90-cc24-11e5-8d33-16f07caeff92.JPG)

![assignment added into project](https://cloud.githubusercontent.com/assets/8812357/12862845/373db0b2-cc24-11e5-8cc0-dc0b7f38a34d.JPG)
![assignment deleted from table](https://cloud.githubusercontent.com/assets/8812357/12862844/373d6634-cc24-11e5-8a03-6af47d5eebe5.JPG)
![assignment modified by entering proper fields](https://cloud.githubusercontent.com/assets/8812357/12862846/373f011a-cc24-11e5-8e63-1ce71f9ad3d8.JPG)
![completed assignment tab in assignment](https://cloud.githubusercontent.com/assets/8812357/12862849/374ef304-cc24-11e5-94a2-ab37fdc68a3b.JPG)
![detaails and log entry page opns after the specific assignmernt button is clicked](https://cloud.githubusercontent.com/assets/8812357/12862852/3752b6e2-cc24-11e5-9b4a-0e18f8f2170f.JPG)
![detils button in ongoing column](https://cloud.githubusercontent.com/assets/8812357/12862850/374fed40-cc24-11e5-8162-b0617c3c9189.JPG)
![error message to show when blank fields not entered](https://cloud.githubusercontent.com/assets/8812357/12862847/374d261e-cc24-11e5-9388-da49efd7477a.JPG)
![error message when log is left balnk](https://cloud.githubusercontent.com/assets/8812357/12862851/3751e03c-cc24-11e5-9618-3ebf8c69fe7e.JPG)
![error messages when all fields are not filled by user](https://cloud.githubusercontent.com/assets/8812357/12862853/375c2236-cc24-11e5-9910-98bc67678351.JPG)
![log entered of specific assignment entered when clicked on refresh](https://cloud.githubusercontent.com/assets/8812357/12862854/37602624-cc24-11e5-9fcb-a7850f40abe0.JPG)
![log entered](https://cloud.githubusercontent.com/assets/8812357/12862855/37618000-cc24-11e5-8b0f-58f34b0efe53.JPG)
![log entry confirmation message](https://cloud.githubusercontent.com/assets/8812357/12862856/37633468-cc24-11e5-9f77-925fe8a42bf6.JPG)
![modified assignmnet shown highlighted](https://cloud.githubusercontent.com/assets/8812357/12862859/376db776-cc24-11e5-9c02-5034d6001299.JPG)
![modify assignment page when user clicks on modify assignment button](https://cloud.githubusercontent.com/assets/8812357/12862861/3774c688-cc24-11e5-97e5-ceb445cae7b8.JPG)
![new assignment page when clicked on new assignment button](https://cloud.githubusercontent.com/assets/8812357/12862860/377340e2-cc24-11e5-88fd-7f689e6ed66f.JPG)
![select assignment from dropdown menu](https://cloud.githubusercontent.com/assets/8812357/12862863/3776a66a-cc24-11e5-8140-7b2ac7439129.JPG)
![assigment recently added reflected in table highlighted](https://cloud.githubusercontent.com/assets/8812357/12862841/373aa782-cc24-11e5-9430-7709a1b50e0b.JPG)
![pending authorization tab in assignment](https://cloud.githubusercontent.com/assets/8812357/12862862/37760796-cc24-11e5-937f-66ff186b53cc.JPG)
![authorization is requested to director by clicking request authorization](https://cloud.githubusercontent.com/assets/8812357/12862843/373d0e1e-cc24-11e5-8953-3a3a33900028.JPG)
![authorization request to select from dropdown menu](https://cloud.githubusercontent.com/assets/8812357/12862848/374d6f52-cc24-11e5-83a1-ae4b9bffa15
![authorization is set pending in highlighted row](https://cloud.githubusercontent.com/assets/8812357/12862842/373c95ba-cc24-11e5-9003-c8551990bd99.JPG)
c.JPG)
![textbox shown when user click on delete button](https://cloud.githubusercontent.com/assets/8812357/12862864/377b6d80-cc24-11e5-8865-f8ce2fb113c5.JPG)
![the tselected asignmment populates thes all the field](https://cloud.githubusercontent.com/assets/8812357/12862865/3782d098-cc24-11e5-8852-3d698fe11623.JPG)


Director Operations
====================
![directorhomescreen](https://cloud.githubusercontent.com/assets/8812357/12862875/51152f06-cc24-11e5-9dcd-cd51d0814a36.JPG)
![directors detsails button click](https://cloud.githubusercontent.com/assets/8812357/12862878/51249680-cc24-11e5-85e7-bedd98596413.JPG)
![select assignment from dropdown menu of select assignment](https://cloud.githubusercontent.com/assets/8812357/12862880/51275014-cc24-11e5-8624-7316c8587027.JPG)
![director pending authorization screen with pending authorization assignment](https://cloud.githubusercontent.com/assets/8812357/12862874/5114ffcc-cc24-11e5-856b-ef299d9b55b7.JPG)
![slecetd assignment from dropdown in authorization](https://cloud.githubusercontent.com/assets/8812357/12862881/5127ec2c-cc24-11e5-9c9a-32a51c757105.JPG)
![authorization confirmation](https://cloud.githubusercontent.com/assets/8812357/12862872/51126cd0-cc24-11e5-92d9-e6c32eb5decd.JPG)
![director assignment tab with ongoing assignments](https://cloud.githubusercontent.com/assets/8812357/12862876/5115f01c-cc24-11e5-9b95-b6fb033eb76f.JPG)
![director assignment tab with pending authorization assignments](https://cloud.githubusercontent.com/assets/8812357/12862877/51179462-cc24-11e5-9cf3-d9b8cf75d5e3.JPG)
![director complted authorization tab](https://cloud.githubusercontent.com/assets/8812357/12862873/5114857e-cc24-11e5-9b65-68054d9411f8.JPG)
![highlighted log enterd by director](https://cloud.githubusercontent.com/assets/8812357/12862879/5126806c-cc24-11e5-9b3c-01458084cb32.JPG)
![pending status removed from table when assignment is authorized](https://cloud.githubusercontent.com/assets/8812357/12862882/51288b1e-cc24-11e5-94b6-cbdce5a36c8a.JPG)

Employee Operations
====================
![employee login](https://cloud.githubusercontent.com/assets/8812357/12862897/6583670a-cc24-11e5-895c-9116a9ef00e4.JPG)
![employee detail button click](https://cloud.githubusercontent.com/assets/8812357/12862895/6580496c-cc24-11e5-9b57-60c4921e87f4.JPG)
![employee ongoing assignment tab showing only specific employyes assignments contain amit](https://cloud.githubusercontent.com/assets/8812357/12862892/657d1ada-cc24-11e5-97e5-4e9a18968786.JPG)
![employyes completed authorization assignment tab](https://cloud.githubusercontent.com/assets/8812357/12862894/657f8d74-cc24-11e5-98b3-bbff3acf5448.JPG)
![employyes pending authorization tab](https://cloud.githubusercontent.com/assets/8812357/12862896/658065be-cc24-11e5-9d52-ce55deab8ffb.JPG)
![empoyee log entrt for assignment 1 highlighted](https://cloud.githubusercontent.com/assets/8812357/12862893/657edf8c-cc24-11e5-8779-670f8315b993.JPG)

Logout
=======
![logout click](https://cloud.githubusercontent.com/assets/8812357/12862902/75bf12cc-cc24-11e5-949b-57c1c13f40cd.JPG)
![redirect to homescreen when logout clicked](https://cloud.githubusercontent.com/assets/8812357/12862903/75c02c8e-cc24-11e5-92f7-3078a1b4a30b.JPG)


