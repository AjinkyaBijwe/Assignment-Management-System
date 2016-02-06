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
![manager login](https://cloud.githubusercontent.com/assets/8812357/12863327/ceadce42-cc28-11e5-81a7-f10acc80ec6e.JPG)
![manager assignment page](https://cloud.githubusercontent.com/assets/8812357/12863330/ceaea952-cc28-11e5-8b57-390d94ea8327.JPG)
![pending authorization tab in assignment](https://cloud.githubusercontent.com/assets/8812357/12863331/ceaf2828-cc28-11e5-85cc-51d78fbd6d0d.JPG)
![completed assignment tab in assignment](https://cloud.githubusercontent.com/assets/8812357/12863328/ceae1afa-cc28-11e5-896e-e0c4aca58450.JPG)
![new assignment page when clicked on new assignment button](https://cloud.githubusercontent.com/assets/8812357/12863329/ceae9ade-cc28-11e5-8647-978c7b41056c.JPG)
![error message to show when blank fields not entered](https://cloud.githubusercontent.com/assets/8812357/12863326/cead98aa-cc28-11e5-82b9-0ab1212fc5df.JPG)
![assignment added into project](https://cloud.githubusercontent.com/assets/8812357/12863333/cec08a28-cc28-11e5-8099-e966dd233873.JPG)
![assigment recently added reflected in table highlighted](https://cloud.githubusercontent.com/assets/8812357/12863336/cec1abd8-cc28-11e5-834d-6b1ce90a9c63.JPG)
![textbox shown when user click on delete button](https://cloud.githubusercontent.com/assets/8812357/12863335/cec1b54c-cc28-11e5-8e5d-78db5c8afcc7.JPG)
![assignment deleted from table](https://cloud.githubusercontent.com/assets/8812357/12863332/cec02f7e-cc28-11e5-99ff-6c01967d4989.JPG)
![modify assignment page when user clicks on modify assignment button](https://cloud.githubusercontent.com/assets/8812357/12863334/cec172c6-cc28-11e5-9224-99a17a0ad333.JPG)
![select assignment from dropdown menu](https://cloud.githubusercontent.com/assets/8812357/12863337/cec21924-cc28-11e5-8b44-60708f759b67.JPG)
![the tselected asignmment populates thes all the field](https://cloud.githubusercontent.com/assets/8812357/12863339/ced3f3a6-cc28-11e5-90ad-23e2fc138366.JPG)
![error messages when all fields are not filled by user](https://cloud.githubusercontent.com/assets/8812357/12863342/ced46700-cc28-11e5-8c29-bebde1c483dd.JPG)
![assignment modified by entering proper fields](https://cloud.githubusercontent.com/assets/8812357/12863340/ced414c6-cc28-11e5-8b0e-f178a12d29cf.JPG)
![modified assignmnet shown highlighted](https://cloud.githubusercontent.com/assets/8812357/12863341/ced45d3c-cc28-11e5-93c4-7cf312a6b77e.JPG)
![authorization request to select from dropdown menu](https://cloud.githubusercontent.com/assets/8812357/12863338/ced2ead8-cc28-11e5-91ad-234e351e6751.JPG)
![authorization is requested to director by clicking request authorization](https://cloud.githubusercontent.com/assets/8812357/12863343/ced49a9a-cc28-11e5-96e8-e848e9a8e947.JPG)
![authorization is set pending in highlighted row](https://cloud.githubusercontent.com/assets/8812357/12863344/cee575a4-cc28-11e5-90a0-0cd46e924905.JPG)
![detils button in ongoing column](https://cloud.githubusercontent.com/assets/8812357/12863345/cee75694-cc28-11e5-98a2-fbbc1bb5642b.JPG)
![detaails and log entry page opns after the specific assignmernt button is clicked](https://cloud.githubusercontent.com/assets/8812357/12863346/cee7ef50-cc28-11e5-9054-35d7b914a3cf.JPG)
![error message when log is left balnk](https://cloud.githubusercontent.com/assets/8812357/12863348/cee80f30-cc28-11e5-9ac9-86912ac43de0.JPG)
![log entered](https://cloud.githubusercontent.com/assets/8812357/12863349/cee8df78-cc28-11e5-9dba-e9bfdb57eaf8.JPG)
![log entry confirmation message](https://cloud.githubusercontent.com/assets/8812357/12863347/cee81048-cc28-11e5-9101-277a9e2739e8.JPG)
![log entered of specific assignment entered when clicked on refresh](https://cloud.githubusercontent.com/assets/8812357/12863350/cef8e1d4-cc28-11e5-87cb-218ed04768c5.JPG)

Director Operations
====================
![directorhomescreen](https://cloud.githubusercontent.com/assets/8812357/12863284/adcf2c98-cc28-11e5-8695-eff20143f271.JPG)
![director assignment tab with ongoing assignments](https://cloud.githubusercontent.com/assets/8812357/12863286/ae071b26-cc28-11e5-91ef-3102e63769a9.JPG)
![director assignment tab with pending authorization assignments](https://cloud.githubusercontent.com/assets/8812357/12863289/ae07d5c0-cc28-11e5-8fda-c1ce765023bc.JPG)
![director complted authorization tab](https://cloud.githubusercontent.com/assets/8812357/12863285/ae056f38-cc28-11e5-9da0-f928329abc3d.JPG)
![director pending authorization screen with pending authorization assignment](https://cloud.githubusercontent.com/assets/8812357/12863288/ae07c26a-cc28-11e5-8a40-8a7b28591aa7.JPG)
![select assignment from dropdown menu of select assignment](https://cloud.githubusercontent.com/assets/8812357/12863290/ae1114c8-cc28-11e5-9e05-1c2604124866.JPG)
![slecetd assignment from dropdown in authorization](https://cloud.githubusercontent.com/assets/8812357/12863287/ae075b22-cc28-11e5-86e3-0188ddfa5f1e.JPG)
![authorization confirmation](https://cloud.githubusercontent.com/assets/8812357/12863291/ae184720-cc28-11e5-9b75-ecb0be07e673.JPG)
![pending status removed from table when assignment is authorized](https://cloud.githubusercontent.com/assets/8812357/12863292/ae1a4b6a-cc28-11e5-9c02-2de4c4e4937f.JPG)
![directors detsails button click](https://cloud.githubusercontent.com/assets/8812357/12863294/ae1d0a62-cc28-11e5-8a2d-12f101b1a667.JPG)
![highlighted log enterd by director](https://cloud.githubusercontent.com/assets/8812357/12863293/ae1c892a-cc28-11e5-91e0-4f05709599f4.JPG)

Employee operations
=====================
![employee login](https://cloud.githubusercontent.com/assets/8812357/12863264/8b1e3432-cc28-11e5-8555-c01a5f1b7dbf.JPG)
![employee ongoing assignment tab showing only specific employyes assignments contain amit](https://cloud.githubusercontent.com/assets/8812357/12863269/8b242630-cc28-11e5-9ce9-d2915c9e25eb.JPG)
![employyes pending authorization tab](https://cloud.githubusercontent.com/assets/8812357/12863267/8b22b232-cc28-11e5-8bd2-142957474aaf.JPG)
![employyes completed authorization assignment tab](https://cloud.githubusercontent.com/assets/8812357/12863265/8b20907e-cc28-11e5-8fb2-d090f2300c84.JPG)
![employee detail button click](https://cloud.githubusercontent.com/assets/8812357/12863268/8b2344b8-cc28-11e5-964f-91e464f30e00.JPG)
![empoyee log entrt for assignment 1 highlighted](https://cloud.githubusercontent.com/assets/8812357/12863266/8b21e686-cc28-11e5-988f-7a6abd34079c.JPG)

Logout
=======
![logout click](https://cloud.githubusercontent.com/assets/8812357/12862902/75bf12cc-cc24-11e5-949b-57c1c13f40cd.JPG)
![redirect to homescreen when logout clicked](https://cloud.githubusercontent.com/assets/8812357/12862903/75c02c8e-cc24-11e5-92f7-3078a1b4a30b.JPG)


