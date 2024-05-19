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
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `schedule_BEFORE_INSERT` BEFORE INSERT ON `schedule` FOR EACH ROW BEGIN
    IF EXISTS (
        SELECT 1
        FROM schedule
        WHERE
            TeacherID = NEW.TeacherID
            AND Days = NEW.Days
            AND (
                (NEW.Time_From < Time_To AND NEW.Time_From >= Time_From) OR
                (NEW.Time_To <= Time_To AND NEW.Time_To > Time_From) OR
                (NEW.Time_From <= Time_From AND NEW.Time_To >= Time_To)
            )
    ) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Time overlaps with an existing schedule for this teacher';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `schedule_BEFORE_UPDATE` BEFORE UPDATE ON `schedule` FOR EACH ROW BEGIN
    IF EXISTS (
        SELECT 1
        FROM schedule
        WHERE
            TeacherID = NEW.TeacherID
            AND Days = NEW.Days
            AND ID != NEW.ID
            AND (
                (NEW.Time_From < Time_To AND NEW.Time_From >= Time_From) OR
                (NEW.Time_To <= Time_To AND NEW.Time_To > Time_From) OR
                (NEW.Time_From <= Time_From AND NEW.Time_To >= Time_To)
            )
    ) THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Time overlaps with an existing schedule for this teacher';
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-19 23:40:58
