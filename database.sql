-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.6.21 - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for project
CREATE DATABASE IF NOT EXISTS `project` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `project`;

projectuseruser
-- Dumping structure for table project.assignments
CREATE TABLE IF NOT EXISTS `assignments` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Assignment` longtext,
  `UserAssigned` longtext,
  `DueDate` longtext,
  `Details` longtext,
  `SetAuthorization` longtext,
  `Assignor` longtext,
  `Department` longtext,
  PRIMARY KEY (`ID`),
  FULLTEXT KEY `UserAssigned` (`UserAssigned`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

-- Dumping data for table project.assignments: ~15 rows (approximately)
DELETE FROM `assignments`;
/*!40000 ALTER TABLE `assignments` DISABLE KEYS */;
INSERT INTO `assignments` (`ID`, `Assignment`, `UserAssigned`, `DueDate`, `Details`, `SetAuthorization`, `Assignor`, `Department`) VALUES
	(1, 'Recruitment of Employees', 'Amit Larry ', 'Friday, December 19, 2014', 'Recruit The Employee', 'Complete', 'Ajinkya', 'Human Resources'),
	(2, 'Details of Recruitment', 'Kieth ', 'Wednesday, January 07, 2015', 'Details of recruited employees', 'Pending', 'Ajinkya', 'Human Resources'),
	(3, 'Salary Information', 'Mack ', 'Thursday, December 25, 2014', 'Salary Information of Recruited Employees', 'Pending', 'Ajinkya', 'Human Resources'),
	(4, 'Create Joining Letters', 'Mack Kieth ', 'Wednesday, January 21, 2015', 'Create Joining Letters for New Recruits and dispatch them via Email or Post Services', 'Complete', 'Ajinkya', 'Human Resources'),
	(5, 'Create Application', 'Bill Rick Andrew ', 'Thursday, January 29, 2015', 'Create Application For Managing Organisational Assignments', 'Complete', 'Leslie', 'Technical'),
	(6, 'Module Development ', 'Andrew ', 'Wednesday, January 21, 2015', 'Create the First module for Organizational Assignment Application ', 'Pending', 'Leslie', 'Technical'),
	(7, 'Documentation', 'Rick ', 'Tuesday, February 17, 2015', 'Create Documentation  for Oraganizational Assignment  Application  with all particular fields ', 'Null', 'Leslie', 'Technical'),
	(8, 'Grocery Shop System', 'Bill Rick Andrew ', 'Friday, May 22, 2015', 'Create Grocery Shop Application ', 'Null', 'Leslie', 'Technical'),
	(9, 'Documentation', 'Andrew ', 'Friday, May 22, 2015', 'Create Documentation and Support for Grocery Shop App', 'Pending', 'Leslie', 'Technical'),
	(10, 'Submit Prototype', 'Bill Rick Andrew ', 'Friday, May 01, 2015', 'Submit Working prototype for project', 'Null', 'Leslie', 'Technical'),
	(11, 'Employee Information ', 'Larry', 'Wednesday, December 31, 2014', 'Create Employee Information Sheet', 'Null', 'Ajinkya', 'Human Resources'),
	(12, 'Recruitment Fair', 'Amit Larry ', 'Wednesday, April 15, 2015', 'Attend the recruitment fair at CSUF', 'Null', 'Ajinkya', 'Human Resources'),
	(13, 'Create List ', 'Mack ', 'Thursday, April 16, 2015', 'Create list of selected Resumes from CSUF', 'Null', 'Ajinkya', 'Human Resources'),
	(14, 'Send Selection Letter', 'Kieth ', 'Monday, May 25, 2015', 'Send Letter to Selected Students', 'Null', 'Ajinkya', 'Human Resources');
/*!40000 ALTER TABLE `assignments` ENABLE KEYS */;


-- Dumping structure for table project.log
CREATE TABLE IF NOT EXISTS `log` (
  `LogID` int(255) NOT NULL AUTO_INCREMENT,
  `Assignment` longtext,
  `Logger` longtext,
  `Designation` longtext,
  `Log` longtext,
  `Time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`LogID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COMMENT='Log Entry Database';

-- Dumping data for table project.log: ~11 rows (approximately)
DELETE FROM `log`;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
INSERT INTO `log` (`LogID`, `Assignment`, `Logger`, `Designation`, `Log`, `Time`) VALUES
	(1, 'Recruitment of Employees', 'Ajinkya', '(Project Manager)', 'Assignment Created ', '2014-12-06 22:04:16'),
	(2, 'Create Joining Letters', 'Ajinkya', '(Project Manager)', 'Assignment Created ', '2014-12-06 22:06:42'),
	(3, 'Details of Recruitment', 'Ajinkya', '(Project Manager)', 'Assignment Created ', '2014-12-06 22:06:49'),
	(4, 'Salary Information', 'Ajinkya', '(Project Manager)', 'Assignment Created ', '2014-12-06 22:06:54'),
	(5, 'Recruitment of Employees', 'Amit', '(Employee)', 'Waiting For Authorization', '2014-12-06 22:24:25'),
	(6, 'Create Joining Letters', 'Kieth', '(Employee)', 'Waiting For Authorization', '2014-12-06 22:25:27'),
	(7, 'Details of Recruitment', 'Kieth', '(Employee)', 'Waiting For Authorization', '2014-12-06 22:25:42'),
	(8, 'Create Application', 'Leslie', '(Project Manager)', 'Assignment Created Take a Look', '2014-12-06 23:14:49'),
	(9, 'Module Development ', 'Leslie', '(Project Manager)', 'Assignment Created Take a Look', '2014-12-06 23:14:59'),
	(10, 'Documentation', 'Leslie', '(Project Manager)', 'Assignment Created Take a Look', '2014-12-06 23:15:04'),
	(11, 'Grocery Shop System', 'Leslie', '(Project Manager)', 'Assignment Created Take a Look', '2014-12-06 23:15:10'),
	(12, 'Submit Prototype', 'Leslie', '(Project Manager)', 'Assignment Created Take a Look', '2014-12-06 23:15:48'),
	(13, 'Recruitment of Employees', 'Gary', '(Director)', 'Assignment Authorized', '2014-12-07 23:02:00'),
	(14, 'Create Application', 'Sharan', '(Director)', 'Assignment Created', '2014-12-07 23:05:13');
/*!40000 ALTER TABLE `log` ENABLE KEYS */;


-- Dumping structure for table project.user
CREATE TABLE IF NOT EXISTS `user` (
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `ID` varchar(45) DEFAULT NULL,
  `Designation` longtext,
  `Department` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Dumping data for table project.user: ~12 rows (approximately)
DELETE FROM `user`;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` (`username`, `password`, `ID`, `Designation`, `Department`) VALUES
	('Ajinkya', 'Ajinkya123', 'ABM2236', 'Manager', 'Human Resources'),
	('Gary', 'Gary111', 'GTD8964', 'Director', 'Human Resources'),
	('Amit', 'Amit111', 'ACE4564', 'Employee', 'Human Resources'),
	('Leslie', 'Leslie111', 'LSM8988', 'Manager', 'Technical'),
	('Sharan', 'Sharan111', 'SMD8965', 'Director', 'Technical'),
	('Mack', 'Mack111', 'MSE9877', 'Employee', 'Human Resources'),
	('Steve', 'Steve111', 'STDM8988', 'Manager', 'Technical'),
	('Kieth', 'Kieth111', 'KTE9878', 'Employee', 'Human Resources'),
	('Larry', 'Larry111', 'LPE9879', 'Employee', 'Human Resources'),
	('Bill', 'Bill111', 'BDE9880', 'Employee', 'Technical'),
	('Rick', 'Rick111', 'RHE9881', 'Employee', 'Technical'),
	('Andrew', 'Andrew111', 'ATE9876', 'Employee', 'Technical');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
