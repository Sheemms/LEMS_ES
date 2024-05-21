CREATE DATABASE  IF NOT EXISTS `lems_es` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `lems_es`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: lems_es
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `audittrail`
--

DROP TABLE IF EXISTS `audittrail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `audittrail` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `UserID` int NOT NULL,
  `Description` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `audittrail`
--

LOCK TABLES `audittrail` WRITE;
/*!40000 ALTER TABLE `audittrail` DISABLE KEYS */;
INSERT INTO `audittrail` VALUES (1,0,'Added User Admin | Shem Mardie Bonbon','2024-05-19 14:01:42'),(2,1,'Logged in','2024-05-19 14:01:45'),(3,1,'Added School Year |2024 - 2025','2024-05-19 14:02:05'),(4,1,'Added Department | ','2024-05-19 14:02:11'),(5,1,'Added Grade Level |Elementary, 1','2024-05-19 14:02:48'),(6,1,'Added Subject | 1, ENG - ENGLISH','2024-05-19 14:03:04'),(7,1,'Added Room |001','2024-05-19 14:03:12'),(8,1,'Added Section | 1 - Apple - Sample Sam ','2024-05-19 14:03:26'),(9,1,'Added Requirements |New, Good Moral','2024-05-19 14:03:39'),(10,1,'Added Tuition Fee | 1 - 10000','2024-05-19 14:03:51'),(11,1,'Added Miscellaneous Fee | ','2024-05-19 14:03:58'),(12,1,'Added Other Fee | ID - 150','2024-05-19 14:04:12'),(13,1,'has been logged out','2024-05-19 14:06:17'),(14,1,'Logged in','2024-05-19 14:25:36'),(15,1,'Added Subject | 1, FIL - FILIPINO','2024-05-19 14:26:32'),(16,1,'has been logged out','2024-05-19 14:27:00'),(17,1,'Logged in','2024-05-19 14:30:11'),(18,1,'Logged in','2024-05-19 15:06:25'),(19,1,'has been logged out','2024-05-19 15:06:45'),(20,1,'Logged in','2024-05-19 15:10:03'),(21,1,'has been logged out','2024-05-19 15:11:59'),(22,1,'Logged in','2024-05-19 15:18:58'),(23,1,'has been logged out','2024-05-19 15:19:16'),(24,1,'Logged in','2024-05-19 15:19:47'),(25,2,'has been logged out','2024-05-19 15:20:19'),(26,1,'Logged in','2024-05-19 15:21:13'),(27,1,'Enrolled Student |111 - Bonbon Shem C','2024-05-19 15:21:52'),(28,1,'has been logged out','2024-05-19 15:22:20'),(29,1,'Logged in','2024-05-19 15:30:40'),(30,1,'has been logged out','2024-05-19 15:30:54'),(31,1,'Logged in','2024-05-19 15:31:18'),(32,1,'Added Payment |Bonbon Shem C, 11150','2024-05-19 15:32:12'),(33,1,'has been logged out','2024-05-19 15:32:29');
/*!40000 ALTER TABLE `audittrail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `days`
--

DROP TABLE IF EXISTS `days`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `days` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Days` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `days`
--

LOCK TABLES `days` WRITE;
/*!40000 ALTER TABLE `days` DISABLE KEYS */;
INSERT INTO `days` VALUES (1,'Monday'),(2,'Tuesday'),(3,'Wednesday'),(4,'Thursday'),(5,'Friday');
/*!40000 ALTER TABLE `days` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Department` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Department` (`Department`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'Elementary');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enrolled_sched`
--

DROP TABLE IF EXISTS `enrolled_sched`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `enrolled_sched` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `SYID` int NOT NULL,
  `EID` varchar(45) NOT NULL,
  `LRN` varchar(45) NOT NULL,
  `ScheduleID` int NOT NULL,
  `FirstGrd` varchar(45) DEFAULT NULL,
  `SecondGrd` varchar(45) DEFAULT NULL,
  `ThirdGrd` varchar(45) DEFAULT NULL,
  `FourthGrd` varchar(45) DEFAULT NULL,
  `Average` varchar(45) DEFAULT NULL,
  `Remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `SYID` (`SYID`,`EID`,`LRN`,`ScheduleID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enrolled_sched`
--

LOCK TABLES `enrolled_sched` WRITE;
/*!40000 ALTER TABLE `enrolled_sched` DISABLE KEYS */;
INSERT INTO `enrolled_sched` VALUES (1,1,'EID20240519001','111',1,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `enrolled_sched` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enrollment`
--

DROP TABLE IF EXISTS `enrollment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `enrollment` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `EID` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `SchoolYear` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `LRN` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `SectionID` int NOT NULL,
  `Enrollment_Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Status` varchar(50) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Not Enrolled',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `LRN` (`LRN`),
  UNIQUE KEY `enrollmenNumber_UNIQUE` (`EID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enrollment`
--

LOCK TABLES `enrollment` WRITE;
/*!40000 ALTER TABLE `enrollment` DISABLE KEYS */;
INSERT INTO `enrollment` VALUES (1,'EID20240519001','1','111',1,'2024-05-19 23:21:51','Enrolled');
/*!40000 ALTER TABLE `enrollment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fee_changes`
--

DROP TABLE IF EXISTS `fee_changes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fee_changes` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ORID` varchar(45) NOT NULL,
  `Description` varchar(45) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Amount` decimal(7,2) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ORID` (`ORID`,`Description`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fee_changes`
--

LOCK TABLES `fee_changes` WRITE;
/*!40000 ALTER TABLE `fee_changes` DISABLE KEYS */;
INSERT INTO `fee_changes` VALUES (1,'ORNO20240519001','Discount',500.00);
/*!40000 ALTER TABLE `fee_changes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `feeor`
--

DROP TABLE IF EXISTS `feeor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `feeor` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ORID` varchar(45) NOT NULL,
  `OFID` int NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `feeor`
--

LOCK TABLES `feeor` WRITE;
/*!40000 ALTER TABLE `feeor` DISABLE KEYS */;
INSERT INTO `feeor` VALUES (1,'ORNO20240519001',1);
/*!40000 ALTER TABLE `feeor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fees`
--

DROP TABLE IF EXISTS `fees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fees` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `EID` varchar(45) NOT NULL,
  `LRN` varchar(45) NOT NULL,
  `Amount` decimal(7,2) NOT NULL,
  `ORDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fees`
--

LOCK TABLES `fees` WRITE;
/*!40000 ALTER TABLE `fees` DISABLE KEYS */;
/*!40000 ALTER TABLE `fees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gradelevel`
--

DROP TABLE IF EXISTS `gradelevel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gradelevel` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Department_ID` int NOT NULL,
  `GradeLevel` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `GradeLevel` (`GradeLevel`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gradelevel`
--

LOCK TABLES `gradelevel` WRITE;
/*!40000 ALTER TABLE `gradelevel` DISABLE KEYS */;
INSERT INTO `gradelevel` VALUES (1,1,'1');
/*!40000 ALTER TABLE `gradelevel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `miscellaneous`
--

DROP TABLE IF EXISTS `miscellaneous`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `miscellaneous` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `miscellaneous`
--

LOCK TABLES `miscellaneous` WRITE;
/*!40000 ALTER TABLE `miscellaneous` DISABLE KEYS */;
INSERT INTO `miscellaneous` VALUES (1,1500.00);
/*!40000 ALTER TABLE `miscellaneous` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mop`
--

DROP TABLE IF EXISTS `mop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mop` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Mode` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Mode` (`Mode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mop`
--

LOCK TABLES `mop` WRITE;
/*!40000 ALTER TABLE `mop` DISABLE KEYS */;
/*!40000 ALTER TABLE `mop` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `otherfee`
--

DROP TABLE IF EXISTS `otherfee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `otherfee` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Description` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  `Amount` decimal(7,2) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Description_UNIQUE` (`Description`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `otherfee`
--

LOCK TABLES `otherfee` WRITE;
/*!40000 ALTER TABLE `otherfee` DISABLE KEYS */;
INSERT INTO `otherfee` VALUES (1,'ID',150.00);
/*!40000 ALTER TABLE `otherfee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ORID` varchar(45) NOT NULL,
  `ORDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `EID` varchar(45) NOT NULL,
  `LRN` varchar(45) NOT NULL,
  `Tuition` varchar(45) NOT NULL,
  `Miscellaneous` varchar(45) NOT NULL,
  `Mode` varchar(45) NOT NULL,
  `Terms` varchar(45) NOT NULL,
  `Amount` decimal(7,2) NOT NULL,
  `EncodedBy` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ORNo_UNIQUE` (`ORID`),
  UNIQUE KEY `EID_UNIQUE` (`EID`,`LRN`) /*!80000 INVISIBLE */
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (1,'ORNO20240519001','2024-05-19 23:32:12','EID20240519001','111','10000.00','1500.00','Cash','0',11150.00,'Shem Mardie Bonbon');
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `req_classification`
--

DROP TABLE IF EXISTS `req_classification`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `req_classification` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Classification` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Classification` (`Classification`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `req_classification`
--

LOCK TABLES `req_classification` WRITE;
/*!40000 ALTER TABLE `req_classification` DISABLE KEYS */;
INSERT INTO `req_classification` VALUES (1,'New'),(2,'Old'),(3,'Transferee');
/*!40000 ALTER TABLE `req_classification` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `requirements`
--

DROP TABLE IF EXISTS `requirements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `requirements` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Classification_ID` int NOT NULL,
  `Requirement` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Requirement` (`Requirement`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `requirements`
--

LOCK TABLES `requirements` WRITE;
/*!40000 ALTER TABLE `requirements` DISABLE KEYS */;
INSERT INTO `requirements` VALUES (1,1,'Good Moral');
/*!40000 ALTER TABLE `requirements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room`
--

DROP TABLE IF EXISTS `room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `room` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Room` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Room_UNIQUE` (`Room`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room`
--

LOCK TABLES `room` WRITE;
/*!40000 ALTER TABLE `room` DISABLE KEYS */;
INSERT INTO `room` VALUES (1,'001');
/*!40000 ALTER TABLE `room` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `schedule` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `SYID` int NOT NULL,
  `SectionID` int NOT NULL,
  `Room` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `SubjectID` int NOT NULL,
  `Days` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Time_From` time NOT NULL,
  `Time_To` time NOT NULL,
  `TeacherID` int NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Days and Time` (`SYID`,`Days`,`Time_From`,`Time_To`,`TeacherID`) /*!80000 INVISIBLE */,
  UNIQUE KEY `Section, Subject and Days` (`SYID`,`SectionID`,`SubjectID`,`Days`) /*!80000 INVISIBLE */,
  UNIQUE KEY `Section, Room, Days and Time` (`SYID`,`SectionID`,`Room`,`Days`,`Time_From`,`Time_To`),
  UNIQUE KEY `Room, Days and Time` (`Room`,`Days`,`Time_From`,`Time_To`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedule`
--

LOCK TABLES `schedule` WRITE;
/*!40000 ALTER TABLE `schedule` DISABLE KEYS */;
INSERT INTO `schedule` VALUES (1,1,1,'1',1,'1,2,3,4,5','08:00:00','09:00:00',1);
/*!40000 ALTER TABLE `schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schoolyear`
--

DROP TABLE IF EXISTS `schoolyear`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `schoolyear` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Start_Year` year NOT NULL DEFAULT (curdate()),
  `End_Year` int NOT NULL,
  `Status` varchar(50) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `UNIQUE` (`Start_Year`,`End_Year`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schoolyear`
--

LOCK TABLES `schoolyear` WRITE;
/*!40000 ALTER TABLE `schoolyear` DISABLE KEYS */;
INSERT INTO `schoolyear` VALUES (1,2024,2025,'Active');
/*!40000 ALTER TABLE `schoolyear` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `section`
--

DROP TABLE IF EXISTS `section`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `section` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `GradeLevel_ID` int NOT NULL,
  `SectionRoom` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `AdviserID` int NOT NULL,
  `Capacity` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  `CurCapacity` varchar(45) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `SectionRoom` (`SectionRoom`,`AdviserID`) /*!80000 INVISIBLE */,
  UNIQUE KEY `GradeLevel and Adviser` (`GradeLevel_ID`,`AdviserID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `section`
--

LOCK TABLES `section` WRITE;
/*!40000 ALTER TABLE `section` DISABLE KEYS */;
INSERT INTO `section` VALUES (1,1,'Apple',1,'2',NULL);
/*!40000 ALTER TABLE `section` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `StudType` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `LRN` bigint NOT NULL,
  `Lastname` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Firstname` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `MiddleInitial` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Suffix` varchar(25) COLLATE utf8mb4_general_ci NOT NULL,
  `Gender` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Age` int NOT NULL,
  `Birthday` date NOT NULL,
  `Address` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `MotherName` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `MothersMaiden` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Mother_Occupation` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `FatherName` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Father_Occupation` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `GuardianName` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `GuardianRelation` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `GuardianContact` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Citizenship` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Status` varchar(50) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `StudentNo` (`LRN`),
  UNIQUE KEY `LRN` (`LRN`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (1,'1',111,'Bonbon','Shem','C','None','Male',24,'2000-05-19','#1234','','','','','','Sample','Sample','09123455656','','Active');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subject` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `GradeLevel_ID` int NOT NULL,
  `SubjectCode` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `SubjectName` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Units` int NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `SubjectCode` (`SubjectCode`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES (1,1,'ENG','ENGLISH',1),(2,1,'FIL','FILIPINO',1);
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `submitted_requirements`
--

DROP TABLE IF EXISTS `submitted_requirements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `submitted_requirements` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `StudentID` int NOT NULL,
  `RequirementID` int NOT NULL,
  `DateSubmitted` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `UNIQUE` (`StudentID`,`RequirementID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `submitted_requirements`
--

LOCK TABLES `submitted_requirements` WRITE;
/*!40000 ALTER TABLE `submitted_requirements` DISABLE KEYS */;
INSERT INTO `submitted_requirements` VALUES (1,1,1,'2024-05-19 15:11:33');
/*!40000 ALTER TABLE `submitted_requirements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teacher`
--

DROP TABLE IF EXISTS `teacher`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teacher` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `EmpID` int NOT NULL,
  `Department_ID` int NOT NULL,
  `Lastname` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Firstname` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `MiddleInitial` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `Contact` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Address` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `UserID` int NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `EmpID` (`EmpID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teacher`
--

LOCK TABLES `teacher` WRITE;
/*!40000 ALTER TABLE `teacher` DISABLE KEYS */;
INSERT INTO `teacher` VALUES (1,123,1,'Sample','Sam','','09123456123','#qwedk',2);
/*!40000 ALTER TABLE `teacher` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `top`
--

DROP TABLE IF EXISTS `top`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `top` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Terms` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Terms` (`Terms`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `top`
--

LOCK TABLES `top` WRITE;
/*!40000 ALTER TABLE `top` DISABLE KEYS */;
/*!40000 ALTER TABLE `top` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tuition`
--

DROP TABLE IF EXISTS `tuition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tuition` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `GradeLevel_ID` int NOT NULL,
  `Amount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `GradeLevel_ID_UNIQUE` (`GradeLevel_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tuition`
--

LOCK TABLES `tuition` WRITE;
/*!40000 ALTER TABLE `tuition` DISABLE KEYS */;
INSERT INTO `tuition` VALUES (1,1,10000.00);
/*!40000 ALTER TABLE `tuition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Password` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Fullname` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Contact` varchar(45) COLLATE utf8mb4_general_ci NOT NULL,
  `UserLevel` varchar(13) COLLATE utf8mb4_general_ci NOT NULL,
  `Status` varchar(50) COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Active',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Username` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Admin','123','Shem Mardie Bonbon','09123456789','Administrator','Active'),(2,'Sam','123','Sample Sam','09123456123','Instructor','Active');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userlevel`
--

DROP TABLE IF EXISTS `userlevel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userlevel` (
  `userlevel` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  UNIQUE KEY `userlevel_UNIQUE` (`userlevel`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userlevel`
--

LOCK TABLES `userlevel` WRITE;
/*!40000 ALTER TABLE `userlevel` DISABLE KEYS */;
INSERT INTO `userlevel` VALUES ('Instructor'),('Office Staff');
/*!40000 ALTER TABLE `userlevel` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-21 21:28:31
