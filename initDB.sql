CREATE DATABASE  IF NOT EXISTS `db_clinicreservation` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `db_clinicreservation`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: db_clinicreservation
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `tbl_appointments`
--

DROP TABLE IF EXISTS `tbl_appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_appointments` (
  `appointment_id` int NOT NULL AUTO_INCREMENT,
  `patient_id` int NOT NULL,
  `doctor_id` int NOT NULL,
  `appointment_date` datetime DEFAULT NULL,
  `appointment_status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`appointment_id`),
  KEY `fk_patient_id_idx` (`patient_id`),
  KEY `fk_doctor_id_idx` (`doctor_id`),
  CONSTRAINT `fk_doctor_id` FOREIGN KEY (`doctor_id`) REFERENCES `tbl_doctors` (`doctor_id`),
  CONSTRAINT `fk_patient_id` FOREIGN KEY (`patient_id`) REFERENCES `tbl_patients` (`patient_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_appointments`
--

LOCK TABLES `tbl_appointments` WRITE;
/*!40000 ALTER TABLE `tbl_appointments` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_appointments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_doctors`
--

DROP TABLE IF EXISTS `tbl_doctors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_doctors` (
  `doctor_id` int NOT NULL AUTO_INCREMENT,
  `doctor_firstName` varchar(45) DEFAULT NULL,
  `doctor_lastName` varchar(45) DEFAULT NULL,
  `doctor_middleInitial` varchar(45) DEFAULT NULL,
  `doctor_age` int DEFAULT NULL,
  `doctor_gender` varchar(45) DEFAULT NULL,
  `doctor_dateOfBirth` datetime DEFAULT NULL,
  `doctor_civilStatus` varchar(45) DEFAULT NULL,
  `doctor_address` varchar(45) DEFAULT NULL,
  `doctor_contactNumber` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`doctor_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_doctors`
--

LOCK TABLES `tbl_doctors` WRITE;
/*!40000 ALTER TABLE `tbl_doctors` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_doctors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_patients`
--

DROP TABLE IF EXISTS `tbl_patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_patients` (
  `patient_id` int NOT NULL AUTO_INCREMENT,
  `patient_firstName` varchar(45) DEFAULT NULL,
  `patient_lastName` varchar(45) DEFAULT NULL,
  `patient_middleInitial` varchar(45) DEFAULT NULL,
  `patient_age` int DEFAULT NULL,
  `patient_gender` varchar(45) DEFAULT NULL,
  `patient_dateOfBirth` datetime DEFAULT NULL,
  `patient_civilStatus` varchar(45) DEFAULT NULL,
  `patient_address` varchar(45) DEFAULT NULL,
  `patient_contactNumber` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`patient_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_patients`
--

LOCK TABLES `tbl_patients` WRITE;
/*!40000 ALTER TABLE `tbl_patients` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_patients` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-25 17:44:10
