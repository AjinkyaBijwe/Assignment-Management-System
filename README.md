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
![message when password is successfully entered](https://cloud.githubusercontent.com/assets/8812357/12862834/29ec448c-cc24-11e5-863f-d2ef864cf244.JPG)
![loginscreen](https://cloud.githubusercontent.com/assets/8812357/12862837/29ee4de0-cc24-11e5-96ea-21ad31dea9bb.JPG)

Manager Operations
==================
![assigment recently added reflected in table highlighted](https://cloud.githubusercontent.com/assets/8812357/12863184/fae3cf3a-cc27-11e5-8cf5-ba9d203a46e4.JPG)
![textbox shown when user click on delete button](https://cloud.githubusercontent.com/assets/8812357/12863185/faf6af1a-cc27-11e5-8b1d-ce3aba0b3cc1.JPG)
![assignment deleted from table](https://cloud.githubusercontent.com/assets/8812357/12863190/fafe059e-cc27-11e5-9a3a-d716a93917ed.JPG)
![modify assignment page when user clicks on modify assignment button](https://cloud.githubusercontent.com/assets/8812357/12863189/fafda662-cc27-11e5-97c1-80ce17092f28.JPG)
![select assignment from dropdown menu](https://cloud.githubusercontent.com/assets/8812357/12863188/fafcde58-cc27-11e5-981b-20232e094f46.JPG)
![the tselected asignmment populates thes all the field](https://cloud.githubusercontent.com/assets/8812357/12863187/fafcd110-cc27-11e5-81e6-29d99efec6b1.JPG)
![error messages when all fields are not filled by user](https://cloud.githubusercontent.com/assets/8812357/12863186/fafc61d0-cc27-11e5-9372-255ef7279b80.JPG)
![assignment modified by entering proper fields](https://cloud.githubusercontent.com/assets/8812357/12863191/fb0942ba-cc27-11e5-9a2f-43a63a22d516.JPG)
![modified assignmnet shown highlighted](https://cloud.githubusercontent.com/assets/8812357/12863192/fb0f4f2a-cc27-11e5-9e77-f172bad7769a.JPG)
![authorization request to select from dropdown menu](https://cloud.githubusercontent.com/assets/8812357/12863194/fb101270-cc27-11e5-98b7-65361e9ac506.JPG)
![authorization is requested to director by clicking request authorization](https://cloud.githubusercontent.com/assets/8812357/12863195/fb1098c6-cc27-11e5-9516-43d6d3ff6084.JPG)
![authorization is set pending in highlighted row](https://cloud.githubusercontent.com/assets/8812357/12863193/fb0fadee-cc27-11e5-8e22-8bb312e5e810.JPG)
![detils button in ongoing column](https://cloud.githubusercontent.com/assets/8812357/12863196/fb11aa04-cc27-11e5-8833-8d04869c9f37.JPG)
![detaails and log entry page opns after the specific assignmernt button is clicked](https://cloud.githubusercontent.com/assets/8812357/12863197/fb1bd420-cc27-11e5-9598-b78a9adfa333.JPG)
![error message when log is left balnk](https://cloud.githubusercontent.com/assets/8812357/12863199/fb2206ba-cc27-11e5-8f74-7aca65a4248d.JPG)
![log entered](https://cloud.githubusercontent.com/assets/8812357/12863198/fb21c952-cc27-11e5-941d-b7742a5b4c5c.JPG)
![log entry confirmation message](https://cloud.githubusercontent.com/assets/8812357/12863202/fb24ca4e-cc27-11e5-9db9-b0b7924fad40.JPG)
![log entered of specific assignment entered when clicked on refresh](https://cloud.githubusercontent.com/assets/8812357/12863201/fb24889a-cc27-11e5-8260-3382e911e429.JPG)
![manager login](https://cloud.githubusercontent.com/assets/8812357/12863200/fb23b460-cc27-11e5-8cb9-f0f10c999fd7.JPG)
![manager assignment page](https://cloud.githubusercontent.com/assets/8812357/12863203/fb2e30f2-cc27-11e5-9e1a-20b6641dec34.JPG)
![pending authorization tab in assignment](https://cloud.githubusercontent.com/assets/8812357/12863205/fb346a4e-cc27-11e5-8597-82d39e9e6b50.JPG)
![completed assignment tab in assignment](https://cloud.githubusercontent.com/assets/8812357/12863204/fb339754-cc27-11e5-92af-9871ebeb819e.JPG)
![new assignment page when clicked on new assignment button](https://cloud.githubusercontent.com/assets/8812357/12863207/fb386f36-cc27-11e5-9279-dd4e5627e721.JPG)
![error message to show when blank fields not entered](https://cloud.githubusercontent.com/assets/8812357/12863208/fb398c18-cc27-11e5-85cb-6e0d6e5ad1df.JPG)
![assignment added into project](https://cloud.githubusercontent.com/assets/8812357/12863206/fb372658-cc27-11e5-81d1-e6dbec4a42ab.JPG)

Director Operations
====================
![select assignment from dropdown menu of select assignment](https://cloud.githubusercontent.com/assets/8812357/12863217/1a8c69c8-cc28-11e5-94fc-18b733929b15.JPG)
![slecetd assignment from dropdown in authorization](https://cloud.githubusercontent.com/assets/8812357/12863218/1a8e7236-cc28-11e5-8690-0d30e674bc41.JPG)
![authorization confirmation](https://cloud.githubusercontent.com/assets/8812357/12863221/1a90991c-cc28-11e5-94e0-af61198da79a.JPG)
![pending status removed from table when assignment is authorized](https://cloud.githubusercontent.com/assets/8812357/12863219/1a8ec9fc-cc28-11e5-8c07-6de9c0066ab4.JPG)
![directors detsails button click](https://cloud.githubusercontent.com/assets/8812357/12863222/1a90e818-cc28-11e5-867e-bc570057b72c.JPG)
![highlighted log enterd by director](https://cloud.githubusercontent.com/assets/8812357/12863220/1a8ff6d8-cc28-11e5-9f8c-543b112c872a.JPG)
![directorhomescreen](https://cloud.githubusercontent.com/assets/8812357/12863224/1aa030fc-cc28-11e5-9ae4-a1185269e985.JPG)
![director assignment tab with ongoing assignments](https://cloud.githubusercontent.com/assets/8812357/12863226/1aa20706-cc28-11e5-9fe3-8d4a986e30da.JPG)
![director assignment tab with pending authorization assignments](https://cloud.githubusercontent.com/assets/8812357/12863223/1a9e0aac-cc28-11e5-8f65-280a2b8dc483.JPG)
![director complted authorization tab](https://cloud.githubusercontent.com/assets/8812357/12863225/1aa1304c-cc28-11e5-9396-ecb8577d2710.JPG)
![director pending authorization screen with pending authorization assignment](https://cloud.githubusercontent.com/assets/8812357/12863227/1aa34602-cc28-11e5-9ab0-dfd55d2d22b7.JPG)

Employee operations
=====================
![employee login](https://cloud.githubusercontent.com/assets/8812357/12863241/520c049e-cc28-11e5-86bb-50095fbd6e03.JPG)
![employee ongoing assignment tab showing only specific employyes assignments contain amit](https://cloud.githubusercontent.com/assets/8812357/12863245/521079ca-cc28-11e5-8a66-18ddaf1a3f92.JPG)
![employyes pending authorization tab](https://cloud.githubusercontent.com/assets/8812357/12863242/520edee4-cc28-11e5-8b13-a0f1ab516cb6.JPG)
![employyes completed authorization assignment tab](https://cloud.githubusercontent.com/assets/8812357/12863246/5210fbe8-cc28-11e5-9d15-9f437e1bc2ec.JPG)
![employee detail button click](https://cloud.githubusercontent.com/assets/8812357/12863244/521060f2-cc28-11e5-92c8-cf9a51914b82.JPG)
![empoyee log entrt for assignment 1 highlighted](https://cloud.githubusercontent.com/assets/8812357/12863243/520fec58-cc28-11e5-9bb5-62305e0b5d31.JPG)

Logout
=======
![logout click](https://cloud.githubusercontent.com/assets/8812357/12862902/75bf12cc-cc24-11e5-949b-57c1c13f40cd.JPG)
![redirect to homescreen when logout clicked](https://cloud.githubusercontent.com/assets/8812357/12862903/75c02c8e-cc24-11e5-92f7-3078a1b4a30b.JPG)


