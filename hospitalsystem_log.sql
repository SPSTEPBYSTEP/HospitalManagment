-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: hospitalsystem
-- ------------------------------------------------------
-- Server version	5.7.11-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `log`
--

DROP TABLE IF EXISTS `log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `log` (
  `log_ID` int(11) NOT NULL AUTO_INCREMENT,
  `log_event` varchar(255) DEFAULT NULL,
  `log_date` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log`
--

LOCK TABLES `log` WRITE;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
INSERT INTO `log` VALUES (1,'doctor Updated Appointment','2016-04-28 21:19:18'),(2,'doctor Updated Appointment','2016-04-28 21:19:26'),(3,'doctor Updated Appointment','2016-04-28 21:19:34'),(4,'doctor Updated Appointment','2016-04-28 21:19:45'),(5,'doctor Updated Appointment','2016-04-28 21:20:01'),(6,'doctor Updated Appointment','2016-04-28 21:20:28'),(7,'doctor Updated Appointment','2016-04-28 21:20:43'),(8,'doctor Updated Appointment','2016-04-28 21:21:00'),(9,'doctor Updated Appointment','2016-04-28 22:23:13'),(10,'doctor Updated Appointment','2016-04-28 22:29:14'),(11,'doctor Updated Appointment','2016-04-29 10:55:44'),(12,'doctor Updated Appointment','2016-04-29 10:59:09'),(13,'doctor Updated Appointment','2016-04-29 10:59:30'),(14,'doctor Details were updated','2016-04-29 11:44:20'),(15,'doctor Details were updated','2016-04-29 11:44:36'),(16,'doctor Details were updated','2016-04-29 11:47:15'),(17,'New Patient is added','2016-04-29 14:41:50'),(18,'New Patient is added','2016-04-29 14:42:05'),(19,'New Patient is added','2016-04-29 14:42:15'),(20,'New Patient is added','2016-04-29 14:42:30'),(21,'Checking if the appointment exists','2016-04-29 14:43:16'),(22,'Checking for exsisting doc','2016-04-29 14:43:16'),(23,'Checking for exsisting Patient ','2016-04-29 14:43:16'),(24,'Checking if the appointment exists','2016-04-29 14:46:04'),(25,'Checking for exsisting doc','2016-04-29 14:46:04'),(26,'Checking for exsisting Patient ','2016-04-29 14:46:04'),(27,'New Appointment is added','2016-04-29 14:46:04'),(28,'New Patient is added','2016-04-29 15:33:07'),(29,'Checking for duplicate doctor assignment','2016-04-29 15:44:30'),(30,'Checking for duplicate doctor assignment','2016-04-29 15:44:30'),(31,'doctor Updated Appointment','2016-04-29 15:44:30'),(32,'Checking for duplicate doctor assignment','2016-04-29 15:46:25'),(33,'Checking for duplicate doctor assignment','2016-04-29 15:46:25'),(34,'Checking for duplicate doctor assignment','2016-04-29 15:46:35'),(35,'Checking for duplicate doctor assignment','2016-04-29 15:46:35'),(36,'Checking for duplicate doctor assignment','2016-04-29 15:46:43'),(37,'Checking for duplicate doctor assignment','2016-04-29 15:46:43'),(38,'doctor Updated Appointment','2016-04-29 15:46:43');
/*!40000 ALTER TABLE `log` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-04-29 16:01:09
