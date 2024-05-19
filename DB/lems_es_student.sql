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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-19 23:40:56
