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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-19 23:40:59
