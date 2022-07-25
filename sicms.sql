-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 17, 2020 at 02:58 PM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sicms`
--

-- --------------------------------------------------------

--
-- Table structure for table `appointment`
--

CREATE TABLE `appointment` (
  `oppointment_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `inspector_id` int(11) NOT NULL,
  `title` text NOT NULL,
  `content` text NOT NULL,
  `date_of_appointment` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `bank_service`
--

CREATE TABLE `bank_service` (
  `bank_id` int(11) NOT NULL,
  `bank_name` varchar(100) NOT NULL,
  `account_number` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bank_service`
--

INSERT INTO `bank_service` (`bank_id`, `bank_name`, `account_number`) VALUES
(1, 'National Bank', '100234656'),
(2, 'FDH Bank', '560234656');

-- --------------------------------------------------------

--
-- Table structure for table `certification_number`
--

CREATE TABLE `certification_number` (
  `certification_id` int(11) NOT NULL,
  `certification_no` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

CREATE TABLE `class` (
  `class_id` int(11) NOT NULL,
  `class_name` varchar(100) NOT NULL,
  `genetic_purity` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `class`
--

INSERT INTO `class` (`class_id`, `class_name`, `genetic_purity`) VALUES
(2, 'Breeder Seeds', '100%'),
(3, 'Foundation Seeds', '95.5%'),
(4, 'Certified Seeds', '99%');

-- --------------------------------------------------------

--
-- Table structure for table `crop`
--

CREATE TABLE `crop` (
  `crop_id` int(11) NOT NULL,
  `crop_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `crop`
--

INSERT INTO `crop` (`crop_id`, `crop_name`) VALUES
(1, 'Maize - Zea mays'),
(2, 'Rice'),
(3, 'Sorghum'),
(4, 'Potato'),
(5, 'Tomato'),
(6, 'Peas');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `customer_id` int(11) NOT NULL,
  `Firstname` varchar(30) NOT NULL,
  `Lastname` varchar(30) NOT NULL,
  `Contact` varchar(15) NOT NULL,
  `Email` varchar(150) DEFAULT NULL,
  `Address` text,
  `Joined` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`customer_id`, `Firstname`, `Lastname`, `Contact`, `Email`, `Address`, `Joined`) VALUES
(6, 'Jairos', 'Nyirenda', '(099)-197-7104', 'jairos.pemphonyirenda@gmail.com', '', '2020-01-14 18:18:37'),
(11, 'Glory', 'Sibale', '(099)-197-7104', 'abc@domain.com', '', '2020-01-17 11:55:49'),
(13, 'Moses', 'Majiya', '(099)-577-9510', 'mosesm@gmail.com', 'NACIT', '2020-03-02 14:58:29');

-- --------------------------------------------------------

--
-- Table structure for table `customer_account`
--

CREATE TABLE `customer_account` (
  `user_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` text NOT NULL,
  `salt` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_account`
--

INSERT INTO `customer_account` (`user_id`, `customer_id`, `username`, `password`, `salt`) VALUES
(1, 6, 'Pemphero', '310f8be968ea08680ac851071cddef020796de600595904af4ee6d953e4b416a', 'c16c96a782863fb91bf4cf78d4c2f012c6990a6f'),
(5, 10, 'Jay-2607', '3501e6f911d74fcf29669a40e2d29d527f724f6570ebb5479f84fa27dc2e94f8', '6d2f3d109d6bc80ef9df41b7d0717fbc8286df12'),
(6, 11, 'Jay', '1a507b389e08a89d95886b8698f558739cc6ec0e8891a4f30a17f0e242b24575', '6b1e0a50c0398766e2fb44058696bb27779043a2'),
(7, 12, 'Jay-26079', '2423f60e9e15b98e20a11aea77e8d20ee1100853cc7c0d24ad2530aa49ee79b3', '70029e90e775396324346eb23d3f733b4c642f5d'),
(8, 13, 'mosesm', '1b7b5967a6dd715bf8e69e6759f3cc0e2fb569cc9fffb5e0709a778b88354caa', '6011bc641f9a76aa1ba9510c205fed84dc63269f');

-- --------------------------------------------------------

--
-- Table structure for table `customer_sessions`
--

CREATE TABLE `customer_sessions` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `hash` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_sessions`
--

INSERT INTO `customer_sessions` (`id`, `user_id`, `hash`) VALUES
(1, 1, '109f8c1e2538f59b5a5aed195d84620075bb9872e2c8edb1822b1b5f25c8d81d'),
(2, 6, '5acd68030e1c061d6e0df834babe3a37520a19f3dff266f7e9a386e26c97f6c1');

-- --------------------------------------------------------

--
-- Table structure for table `flowering_inspection`
--

CREATE TABLE `flowering_inspection` (
  `inspection_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `sowing_id` int(11) NOT NULL,
  `isolation_maintain` varchar(20) NOT NULL,
  `off_type_removal` varchar(20) DEFAULT NULL,
  `remarks` text,
  `date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `flowering_inspection`
--

INSERT INTO `flowering_inspection` (`inspection_id`, `user_id`, `sowing_id`, `isolation_maintain`, `off_type_removal`, `remarks`, `date`) VALUES
(3, 1, 2, 'Verified', 'Verified', 'glory 2', '2020-03-24 00:25:01');

-- --------------------------------------------------------

--
-- Table structure for table `harvest_inspection`
--

CREATE TABLE `harvest_inspection` (
  `inspection_id` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `sowing_id` int(11) DEFAULT NULL,
  `maturity` varchar(20) DEFAULT NULL,
  `remarks` text,
  `date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `harvest_inspection`
--

INSERT INTO `harvest_inspection` (`inspection_id`, `user_id`, `sowing_id`, `maturity`, `remarks`, `date`) VALUES
(8, 1, 2, 'Verified', 'yewsss', '2020-03-24 00:25:24');

-- --------------------------------------------------------

--
-- Table structure for table `inspector_on_sowingreport`
--

CREATE TABLE `inspector_on_sowingreport` (
  `assign_id` int(11) NOT NULL,
  `employee_id` int(11) DEFAULT NULL,
  `sowing_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `mobile_service`
--

CREATE TABLE `mobile_service` (
  `service_id` int(11) NOT NULL,
  `service_name` varchar(50) NOT NULL,
  `contact` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mobile_service`
--

INSERT INTO `mobile_service` (`service_id`, `service_name`, `contact`) VALUES
(1, 'Airtel Money', '099-000-0000'),
(2, 'TNM Mpamba', '088-000-0000');

-- --------------------------------------------------------

--
-- Table structure for table `payment_details`
--

CREATE TABLE `payment_details` (
  `payment_id` int(11) NOT NULL,
  `method_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `service_id` int(11) DEFAULT NULL,
  `bank_id` int(11) DEFAULT NULL,
  `transaction_id` varchar(100) DEFAULT NULL,
  `bank_deposit_slip` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment_details`
--

INSERT INTO `payment_details` (`payment_id`, `method_id`, `customer_id`, `service_id`, `bank_id`, `transaction_id`, `bank_deposit_slip`) VALUES
(1, 1, 6, NULL, 1, NULL, 'files/images/deposit_slip/GBWA-20180414094925.jpg'),
(2, 1, 6, NULL, 1, NULL, 'files/images/deposit_slip/GBWA-20180414094925.jpg'),
(3, 2, 6, 1, NULL, '235345/45667/DWR', NULL),
(4, 2, 6, 1, NULL, '235345/45667/GGT', NULL),
(5, 1, 6, NULL, 2, NULL, 'files/images/deposit_slip/GBWA-20180419194725.jpg'),
(6, 1, 13, NULL, 1, NULL, 'files/images/deposit_slip/user2-960x960.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `payment_method`
--

CREATE TABLE `payment_method` (
  `method_id` int(11) NOT NULL,
  `Method` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `payment_method`
--

INSERT INTO `payment_method` (`method_id`, `Method`) VALUES
(1, 'Bank'),
(2, 'Mobile Wallet Services');

-- --------------------------------------------------------

--
-- Table structure for table `post_flowering_inspection`
--

CREATE TABLE `post_flowering_inspection` (
  `inspection_id` int(11) NOT NULL,
  `user_id` int(11),
  `sowing_id` int(11),
  `issues_taken_care` varchar(20) DEFAULT NULL,
  `remarks` text,
  `date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `post_flowering_inspection`
--

INSERT INTO `post_flowering_inspection` (`inspection_id`, `user_id`, `sowing_id`, `issues_taken_care`, `remarks`, `date`) VALUES
(8, 1, 2, 'Verified', 'glory', '2020-03-24 00:25:13');

-- --------------------------------------------------------

--
-- Table structure for table `pre_flowering_inspection`
--

CREATE TABLE `pre_flowering_inspection` (
  `inspection_Id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `sowing_id` int(11) NOT NULL,
  `isolation_distance` double,
  `source` varchar(20) DEFAULT NULL,
  `acreage` varchar(20) DEFAULT NULL,
  `uniformity` varchar(20) DEFAULT NULL,
  `rouging` varchar(20) DEFAULT NULL,
  `off_type` varchar(20) DEFAULT NULL,
  `removal` varchar(20) DEFAULT NULL,
  `remarks` text,
  `date` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pre_flowering_inspection`
--

INSERT INTO `pre_flowering_inspection` (`inspection_Id`, `user_id`, `sowing_id`, `isolation_distance`, `source`, `acreage`, `uniformity`, `rouging`, `off_type`, `removal`, `remarks`, `date`) VALUES
(4, 1, 2, 25, 'Verified', 'Verified', 'Verified', 'Verified', 'Verified', 'Verified', 'glory', '2020-03-24 00:26:43');

-- --------------------------------------------------------

--
-- Table structure for table `propagation_grass_standard`
--

CREATE TABLE `propagation_grass_standard` (
  `grassStd_id` int(11) NOT NULL,
  `propagation_type_id` int(11) NOT NULL,
  `class_id` int(11) DEFAULT NULL,
  `crop_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `propagation_seed_field_standard`
--

CREATE TABLE `propagation_seed_field_standard` (
  `fieldStd_id` int(11) NOT NULL,
  `seedStd_id` int(11) NOT NULL,
  `isolation_distance` double NOT NULL DEFAULT '0' COMMENT 'In Meters',
  `other_crop_plants` float NOT NULL,
  `other_varities` float NOT NULL,
  `weed_plants` float NOT NULL,
  `plant_infected` float NOT NULL,
  `general_condition` float NOT NULL,
  `moisture_content` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `propagation_seed_field_standard`
--

INSERT INTO `propagation_seed_field_standard` (`fieldStd_id`, `seedStd_id`, `isolation_distance`, `other_crop_plants`, `other_varities`, `weed_plants`, `plant_infected`, `general_condition`, `moisture_content`) VALUES
(1, 1, 100, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `propagation_seed_standard`
--

CREATE TABLE `propagation_seed_standard` (
  `seedStd_id` int(11) NOT NULL,
  `class_id` int(11) NOT NULL,
  `crop_id` int(11) NOT NULL,
  `propagation_type_id` int(11) NOT NULL,
  `standard_name` varchar(100) NOT NULL,
  `pure_seed` float DEFAULT NULL,
  `inert_matter` float DEFAULT NULL,
  `other_crop_seed` float DEFAULT NULL,
  `total_weed_seed` float DEFAULT NULL,
  `gemination_rate` float DEFAULT NULL,
  `moisture_content` float DEFAULT NULL,
  `moisture_content_vapour` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `propagation_seed_standard`
--

INSERT INTO `propagation_seed_standard` (`seedStd_id`, `class_id`, `crop_id`, `propagation_type_id`, `standard_name`, `pure_seed`, `inert_matter`, `other_crop_seed`, `total_weed_seed`, `gemination_rate`, `moisture_content`, `moisture_content_vapour`) VALUES
(1, 4, 1, 1, 'Maize - Zea mays Certified', 2, 2, 2, 2, 80, 2, 2),
(2, 2, 1, 1, 'Maize - Zea mays Breeder', 98, 2, 2, 2, 80, 8, 8);

-- --------------------------------------------------------

--
-- Table structure for table `propagation_tuber_standard`
--

CREATE TABLE `propagation_tuber_standard` (
  `tuberStd_id` int(11) NOT NULL,
  `propagation_type_id` int(11) NOT NULL,
  `crop_id` int(11) DEFAULT NULL,
  `class_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `requested_inspection`
--

CREATE TABLE `requested_inspection` (
  `request_id` int(11) NOT NULL,
  `sowing_id` int(11) DEFAULT NULL,
  `payment_id` int(11) DEFAULT NULL,
  `inspection_type` varchar(50) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  `date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `requested_inspection`
--

INSERT INTO `requested_inspection` (`request_id`, `sowing_id`, `payment_id`, `inspection_type`, `status`, `date`) VALUES
(1, 2, 1, 'Pre Flowering Inspection', 'declined', '2020-03-28'),
(2, 6, 4, 'Flowering Inspection', 'accepted', '2020-03-28');

-- --------------------------------------------------------

--
-- Table structure for table `sowing_report`
--

CREATE TABLE `sowing_report` (
  `sowing_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `certification_id` int(11) DEFAULT NULL,
  `crop_id` int(11) NOT NULL,
  `variety_id` int(11) NOT NULL,
  `class_id` int(11) NOT NULL,
  `payment_id` int(11) NOT NULL,
  `seed_source` text NOT NULL,
  `tag_number` text NOT NULL,
  `purchase_bill_no` text NOT NULL,
  `date_of_purchase` date NOT NULL,
  `quantity_per_acrea` double NOT NULL,
  `acreage` double NOT NULL,
  `date_of_sowing` date NOT NULL,
  `tagSrc` text NOT NULL,
  `purchaseBill` text NOT NULL,
  `status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sowing_report`
--

INSERT INTO `sowing_report` (`sowing_id`, `customer_id`, `certification_id`, `crop_id`, `variety_id`, `class_id`, `payment_id`, `seed_source`, `tag_number`, `purchase_bill_no`, `date_of_purchase`, `quantity_per_acrea`, `acreage`, `date_of_sowing`, `tagSrc`, `purchaseBill`, `status`) VALUES
(2, 6, NULL, 1, 4, 4, 2, 'Agro Dealers - Mzuzu', '1234/909/899', 'QWER23437846', '2020-01-12', 2, 25, '2020-01-15', 'files/images/enclosures/GBWA-20180417184412.jpg', 'files/images/enclosures/GBWA-20180420184824.jpg', 'Pending'),
(4, 6, NULL, 1, 3, 2, 4, 'Agro Dealers - Limbe', '1234/909/DFT', 'DKLGG47845690', '2020-01-08', 3, 25, '2020-01-15', 'files/images/enclosures/GBWA-20180419194249.jpg', 'files/images/enclosures/GBWA-20180414153615.jpg', 'Pending'),
(6, 13, NULL, 1, 5, 3, 6, 'Agro Dealers - Limbe', '1234/909/899', 'QWER23437846', '2020-03-01', 2, 25, '2020-03-02', 'files/images/enclosures/mbr-1624x1080.jpg', 'files/images/enclosures/8987890-1000x800.jpg', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `standard`
--

CREATE TABLE `standard` (
  `std_id` int(11) NOT NULL,
  `Standard_Name` text NOT NULL,
  `ApprovedBy` text,
  `Description` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `standard`
--

INSERT INTO `standard` (`std_id`, `Standard_Name`, `ApprovedBy`, `Description`) VALUES
(1, 'SEED CERTIFICATION AGENCY (SCA)', NULL, ''),
(2, 'SCA', 'NSB', 'Notified and Non-Notified');

-- --------------------------------------------------------

--
-- Table structure for table `standard_propagation_type`
--

CREATE TABLE `standard_propagation_type` (
  `propagation_type_id` int(11) NOT NULL,
  `std_id` int(11) NOT NULL,
  `type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `standard_propagation_type`
--

INSERT INTO `standard_propagation_type` (`propagation_type_id`, `std_id`, `type`) VALUES
(1, 1, 'Seed Propagation'),
(2, 1, 'Tuber Propagation'),
(3, 1, 'Grass Propagation');

-- --------------------------------------------------------

--
-- Table structure for table `status`
--

CREATE TABLE `status` (
  `status_id` int(11) NOT NULL,
  `sowing_id` int(11) NOT NULL DEFAULT '0',
  `state` varchar(50) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `timeline`
--

CREATE TABLE `timeline` (
  `timeline_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL DEFAULT '0',
  `content` text NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `timeline`
--

INSERT INTO `timeline` (`timeline_id`, `customer_id`, `content`, `date`) VALUES
(1, 6, 'Your request for an inspection, Pre Flowering Inspection, has been denied. REASON(S) being :: The deposit slip is not clearly stating its purpose', '2020-01-13'),
(2, 6, 'Your request for an inspection, Pre Flowering Inspection, has been denied. REASON(S) being :: /knjlk', '2020-02-07'),
(3, 6, 'Your request for an inspection, Pre Flowering Inspection, has been denied. REASON(S) being :: cvbvcnvbnb', '2020-03-13'),
(4, 6, 'Your request for an inspection, Pre Flowering Inspection, has been denied. REASON(S) being :: knk', '2020-03-16'),
(5, 6, 'Your request for an inspection, Pre Flowering Inspection, has been denied. REASON(S) being :: /klnklnkl', '2020-04-09');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `employee_id` int(11) NOT NULL,
  `firstname` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `email` text,
  `contact` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`employee_id`, `firstname`, `last_name`, `email`, `contact`) VALUES
(1, 'Jairos', 'Nyirenda', NULL, NULL),
(2, 'Glory', 'Sibale', '', '099123433');

-- --------------------------------------------------------

--
-- Table structure for table `user_account`
--

CREATE TABLE `user_account` (
  `user_id` int(11) NOT NULL,
  `employee_id` int(11) DEFAULT NULL,
  `username` varchar(50) NOT NULL,
  `password` text NOT NULL,
  `salt` text NOT NULL,
  `account_type` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_account`
--

INSERT INTO `user_account` (`user_id`, `employee_id`, `username`, `password`, `salt`, `account_type`) VALUES
(1, 1, 'Jay_2607', '310f8be968ea08680ac851071cddef020796de600595904af4ee6d953e4b416a', 'c16c96a782863fb91bf4cf78d4c2f012c6990a6f', 'Inspection Officer'),
(2, 2, 'Glo2020', 'cfe76836d5a8628685dc932bc177a6301a21e51f45183e977b91c19242fcee12', 'NzQay41xoALrwHhWRCNUwjUNX4sbp3GgSpxQMuBh6/Q=', 'Inspection Director');

-- --------------------------------------------------------

--
-- Table structure for table `user_sessions`
--

CREATE TABLE `user_sessions` (
  `user_session_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `hash` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_sessions`
--

INSERT INTO `user_sessions` (`user_session_id`, `user_id`, `hash`) VALUES
(1, 1, '941117097858a0002808b0ca3d2c8d191a998e712d9e61e93c4bfb2e76d58d6a');

-- --------------------------------------------------------

--
-- Table structure for table `variety`
--

CREATE TABLE `variety` (
  `variety_id` int(11) NOT NULL,
  `crop_id` int(11) NOT NULL,
  `variety_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `variety`
--

INSERT INTO `variety` (`variety_id`, `crop_id`, `variety_name`) VALUES
(1, 1, 'Dent Corn - Zea mays indenata'),
(2, 1, 'Flint Corn - Zea mays indurata'),
(3, 1, 'Sweet Corn - Zea mays saccharata'),
(4, 1, 'Flour Corn - Zea mays amylacea'),
(5, 1, 'Popcorn - Zea mays everta'),
(6, 1, 'Waxy Corn - Zea mays ceratina'),
(7, 6, 'Beans');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `appointment`
--
ALTER TABLE `appointment`
  ADD PRIMARY KEY (`oppointment_id`),
  ADD KEY `id_customer` (`customer_id`);

--
-- Indexes for table `bank_service`
--
ALTER TABLE `bank_service`
  ADD PRIMARY KEY (`bank_id`),
  ADD UNIQUE KEY `account_number` (`account_number`);

--
-- Indexes for table `certification_number`
--
ALTER TABLE `certification_number`
  ADD PRIMARY KEY (`certification_id`);

--
-- Indexes for table `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`class_id`);

--
-- Indexes for table `crop`
--
ALTER TABLE `crop`
  ADD PRIMARY KEY (`crop_id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `customer_account`
--
ALTER TABLE `customer_account`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Indexes for table `customer_sessions`
--
ALTER TABLE `customer_sessions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `flowering_inspection`
--
ALTER TABLE `flowering_inspection`
  ADD PRIMARY KEY (`inspection_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `sowing_id` (`sowing_id`);

--
-- Indexes for table `harvest_inspection`
--
ALTER TABLE `harvest_inspection`
  ADD PRIMARY KEY (`inspection_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `sowing_id` (`sowing_id`);

--
-- Indexes for table `inspector_on_sowingreport`
--
ALTER TABLE `inspector_on_sowingreport`
  ADD PRIMARY KEY (`assign_id`),
  ADD KEY `employee_id` (`employee_id`),
  ADD KEY `FK_inspector_on_sowingreport_sowing_report` (`sowing_id`);

--
-- Indexes for table `mobile_service`
--
ALTER TABLE `mobile_service`
  ADD PRIMARY KEY (`service_id`);

--
-- Indexes for table `payment_details`
--
ALTER TABLE `payment_details`
  ADD PRIMARY KEY (`payment_id`),
  ADD KEY `method_id` (`method_id`),
  ADD KEY `service_id` (`service_id`),
  ADD KEY `customer_id` (`customer_id`),
  ADD KEY `bank_id` (`bank_id`);

--
-- Indexes for table `payment_method`
--
ALTER TABLE `payment_method`
  ADD PRIMARY KEY (`method_id`);

--
-- Indexes for table `post_flowering_inspection`
--
ALTER TABLE `post_flowering_inspection`
  ADD PRIMARY KEY (`inspection_id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `sowing_id` (`sowing_id`);

--
-- Indexes for table `pre_flowering_inspection`
--
ALTER TABLE `pre_flowering_inspection`
  ADD PRIMARY KEY (`inspection_Id`),
  ADD KEY `sowing_id` (`sowing_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `propagation_grass_standard`
--
ALTER TABLE `propagation_grass_standard`
  ADD PRIMARY KEY (`grassStd_id`),
  ADD KEY `FK_propagation_grass_standard_standard_propagation_type` (`propagation_type_id`);

--
-- Indexes for table `propagation_seed_field_standard`
--
ALTER TABLE `propagation_seed_field_standard`
  ADD PRIMARY KEY (`fieldStd_id`),
  ADD KEY `class_id` (`seedStd_id`);

--
-- Indexes for table `propagation_seed_standard`
--
ALTER TABLE `propagation_seed_standard`
  ADD PRIMARY KEY (`seedStd_id`),
  ADD KEY `class_id` (`class_id`),
  ADD KEY `crop_id` (`crop_id`),
  ADD KEY `FK_propagation_seed_standard_standard_progation_type` (`propagation_type_id`);

--
-- Indexes for table `propagation_tuber_standard`
--
ALTER TABLE `propagation_tuber_standard`
  ADD PRIMARY KEY (`tuberStd_id`),
  ADD KEY `FK_propagation_tuber_standard_standard_propagation_type` (`propagation_type_id`);

--
-- Indexes for table `requested_inspection`
--
ALTER TABLE `requested_inspection`
  ADD PRIMARY KEY (`request_id`),
  ADD KEY `sowing_id` (`sowing_id`),
  ADD KEY `payment_id` (`payment_id`);

--
-- Indexes for table `sowing_report`
--
ALTER TABLE `sowing_report`
  ADD PRIMARY KEY (`sowing_id`),
  ADD KEY `certification_id` (`certification_id`),
  ADD KEY `crop_id` (`crop_id`),
  ADD KEY `variety_id` (`variety_id`),
  ADD KEY `class_id` (`class_id`),
  ADD KEY `payment_id` (`payment_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- Indexes for table `standard`
--
ALTER TABLE `standard`
  ADD PRIMARY KEY (`std_id`);

--
-- Indexes for table `standard_propagation_type`
--
ALTER TABLE `standard_propagation_type`
  ADD PRIMARY KEY (`propagation_type_id`),
  ADD KEY `FK_Standard_Progation_Type_standard` (`std_id`);

--
-- Indexes for table `status`
--
ALTER TABLE `status`
  ADD PRIMARY KEY (`status_id`),
  ADD KEY `sowing_id` (`sowing_id`);

--
-- Indexes for table `timeline`
--
ALTER TABLE `timeline`
  ADD PRIMARY KEY (`timeline_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `user_account`
--
ALTER TABLE `user_account`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `user_id` (`employee_id`);

--
-- Indexes for table `user_sessions`
--
ALTER TABLE `user_sessions`
  ADD PRIMARY KEY (`user_session_id`),
  ADD KEY `user_account_id` (`user_id`);

--
-- Indexes for table `variety`
--
ALTER TABLE `variety`
  ADD PRIMARY KEY (`variety_id`),
  ADD KEY `FK_variety_crop` (`crop_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `appointment`
--
ALTER TABLE `appointment`
  MODIFY `oppointment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `bank_service`
--
ALTER TABLE `bank_service`
  MODIFY `bank_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `certification_number`
--
ALTER TABLE `certification_number`
  MODIFY `certification_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `class`
--
ALTER TABLE `class`
  MODIFY `class_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `crop`
--
ALTER TABLE `crop`
  MODIFY `crop_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `customer_account`
--
ALTER TABLE `customer_account`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `customer_sessions`
--
ALTER TABLE `customer_sessions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `flowering_inspection`
--
ALTER TABLE `flowering_inspection`
  MODIFY `inspection_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `harvest_inspection`
--
ALTER TABLE `harvest_inspection`
  MODIFY `inspection_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `inspector_on_sowingreport`
--
ALTER TABLE `inspector_on_sowingreport`
  MODIFY `assign_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `mobile_service`
--
ALTER TABLE `mobile_service`
  MODIFY `service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `payment_details`
--
ALTER TABLE `payment_details`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `payment_method`
--
ALTER TABLE `payment_method`
  MODIFY `method_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `post_flowering_inspection`
--
ALTER TABLE `post_flowering_inspection`
  MODIFY `inspection_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `pre_flowering_inspection`
--
ALTER TABLE `pre_flowering_inspection`
  MODIFY `inspection_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `propagation_grass_standard`
--
ALTER TABLE `propagation_grass_standard`
  MODIFY `grassStd_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `propagation_seed_field_standard`
--
ALTER TABLE `propagation_seed_field_standard`
  MODIFY `fieldStd_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `propagation_seed_standard`
--
ALTER TABLE `propagation_seed_standard`
  MODIFY `seedStd_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `propagation_tuber_standard`
--
ALTER TABLE `propagation_tuber_standard`
  MODIFY `tuberStd_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `requested_inspection`
--
ALTER TABLE `requested_inspection`
  MODIFY `request_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `sowing_report`
--
ALTER TABLE `sowing_report`
  MODIFY `sowing_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `standard`
--
ALTER TABLE `standard`
  MODIFY `std_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `standard_propagation_type`
--
ALTER TABLE `standard_propagation_type`
  MODIFY `propagation_type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `status`
--
ALTER TABLE `status`
  MODIFY `status_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `timeline`
--
ALTER TABLE `timeline`
  MODIFY `timeline_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `user_account`
--
ALTER TABLE `user_account`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `user_sessions`
--
ALTER TABLE `user_sessions`
  MODIFY `user_session_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `variety`
--
ALTER TABLE `variety`
  MODIFY `variety_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `appointment`
--
ALTER TABLE `appointment`
  ADD CONSTRAINT `FK_oppointment_customer` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`);

--
-- Constraints for table `customer_account`
--
ALTER TABLE `customer_account`
  ADD CONSTRAINT `FK__customer` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`);

--
-- Constraints for table `customer_sessions`
--
ALTER TABLE `customer_sessions`
  ADD CONSTRAINT `FK_customer_sessions_customer_account` FOREIGN KEY (`user_id`) REFERENCES `customer_account` (`user_id`);

--
-- Constraints for table `flowering_inspection`
--
ALTER TABLE `flowering_inspection`
  ADD CONSTRAINT `FK_flowering_inspection_sowing_report` FOREIGN KEY (`sowing_id`) REFERENCES `sowing_report` (`sowing_id`),
  ADD CONSTRAINT `FK_flowering_inspection_user_account` FOREIGN KEY (`user_id`) REFERENCES `user_account` (`user_id`);

--
-- Constraints for table `harvest_inspection`
--
ALTER TABLE `harvest_inspection`
  ADD CONSTRAINT `harvest_inspection_ibfk_1` FOREIGN KEY (`sowing_id`) REFERENCES `sowing_report` (`sowing_id`),
  ADD CONSTRAINT `harvest_inspection_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `user_account` (`user_id`);

--
-- Constraints for table `inspector_on_sowingreport`
--
ALTER TABLE `inspector_on_sowingreport`
  ADD CONSTRAINT `FK_inspector_on_sowingreport_sowing_report` FOREIGN KEY (`sowing_id`) REFERENCES `sowing_report` (`sowing_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_inspector_on_sowingreport_user` FOREIGN KEY (`employee_id`) REFERENCES `user` (`employee_id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `payment_details`
--
ALTER TABLE `payment_details`
  ADD CONSTRAINT `FK_mobile_wallet_payment_payment_method` FOREIGN KEY (`method_id`) REFERENCES `payment_method` (`method_id`),
  ADD CONSTRAINT `FK_payment_details_bank_service` FOREIGN KEY (`bank_id`) REFERENCES `bank_service` (`bank_id`),
  ADD CONSTRAINT `FK_payment_details_customer` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`),
  ADD CONSTRAINT `FK_payment_details_mobile_service` FOREIGN KEY (`service_id`) REFERENCES `mobile_service` (`service_id`);

--
-- Constraints for table `post_flowering_inspection`
--
ALTER TABLE `post_flowering_inspection`
  ADD CONSTRAINT `FK_post_flowering_inspection_sowing_report` FOREIGN KEY (`sowing_id`) REFERENCES `sowing_report` (`sowing_id`),
  ADD CONSTRAINT `FK_post_flowering_inspection_user_account` FOREIGN KEY (`user_id`) REFERENCES `user_account` (`user_id`);

--
-- Constraints for table `pre_flowering_inspection`
--
ALTER TABLE `pre_flowering_inspection`
  ADD CONSTRAINT `FK__sowing_report` FOREIGN KEY (`sowing_id`) REFERENCES `sowing_report` (`sowing_id`),
  ADD CONSTRAINT `FK_pre_flowering_insepection_user_account` FOREIGN KEY (`user_id`) REFERENCES `user_account` (`user_id`);

--
-- Constraints for table `propagation_grass_standard`
--
ALTER TABLE `propagation_grass_standard`
  ADD CONSTRAINT `FK_propagation_grass_standard_standard_propagation_type` FOREIGN KEY (`propagation_type_id`) REFERENCES `standard_propagation_type` (`propagation_type_id`);

--
-- Constraints for table `propagation_seed_field_standard`
--
ALTER TABLE `propagation_seed_field_standard`
  ADD CONSTRAINT `FK_propagation_seed_field_standard_propagation_seed_standard` FOREIGN KEY (`seedStd_id`) REFERENCES `propagation_seed_standard` (`seedStd_id`);

--
-- Constraints for table `propagation_seed_standard`
--
ALTER TABLE `propagation_seed_standard`
  ADD CONSTRAINT `FK_Propagation_Seed_Standard_class` FOREIGN KEY (`class_id`) REFERENCES `class` (`class_id`),
  ADD CONSTRAINT `FK_Propagation_Seed_Standard_crop` FOREIGN KEY (`crop_id`) REFERENCES `crop` (`crop_id`),
  ADD CONSTRAINT `FK_propagation_seed_standard_standard_progation_type` FOREIGN KEY (`propagation_type_id`) REFERENCES `standard_propagation_type` (`propagation_type_id`);

--
-- Constraints for table `propagation_tuber_standard`
--
ALTER TABLE `propagation_tuber_standard`
  ADD CONSTRAINT `FK_propagation_tuber_standard_standard_propagation_type` FOREIGN KEY (`propagation_type_id`) REFERENCES `standard_propagation_type` (`propagation_type_id`);

--
-- Constraints for table `requested_inspection`
--
ALTER TABLE `requested_inspection`
  ADD CONSTRAINT `FK_requested_inspection_payment_details` FOREIGN KEY (`payment_id`) REFERENCES `payment_details` (`payment_id`) ON DELETE SET NULL ON UPDATE SET NULL,
  ADD CONSTRAINT `FK_requested_inspection_sowing_report` FOREIGN KEY (`sowing_id`) REFERENCES `sowing_report` (`sowing_id`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Constraints for table `sowing_report`
--
ALTER TABLE `sowing_report`
  ADD CONSTRAINT `FK__class` FOREIGN KEY (`class_id`) REFERENCES `class` (`class_id`),
  ADD CONSTRAINT `FK__crop` FOREIGN KEY (`crop_id`) REFERENCES `crop` (`crop_id`),
  ADD CONSTRAINT `FK__payment_details` FOREIGN KEY (`payment_id`) REFERENCES `payment_details` (`payment_id`),
  ADD CONSTRAINT `FK__variety` FOREIGN KEY (`variety_id`) REFERENCES `variety` (`variety_id`),
  ADD CONSTRAINT `FK_sowing_report_certification_number` FOREIGN KEY (`certification_id`) REFERENCES `certification_number` (`certification_id`),
  ADD CONSTRAINT `FK_sowing_report_customer` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`);

--
-- Constraints for table `standard_propagation_type`
--
ALTER TABLE `standard_propagation_type`
  ADD CONSTRAINT `FK_Standard_Progation_Type_standard` FOREIGN KEY (`std_id`) REFERENCES `standard` (`std_id`);

--
-- Constraints for table `status`
--
ALTER TABLE `status`
  ADD CONSTRAINT `FK_status_sowing_report` FOREIGN KEY (`sowing_id`) REFERENCES `sowing_report` (`sowing_id`);

--
-- Constraints for table `user_account`
--
ALTER TABLE `user_account`
  ADD CONSTRAINT `FK__user` FOREIGN KEY (`employee_id`) REFERENCES `user` (`employee_id`);

--
-- Constraints for table `user_sessions`
--
ALTER TABLE `user_sessions`
  ADD CONSTRAINT `FK__user_account` FOREIGN KEY (`user_id`) REFERENCES `user_account` (`user_id`);

--
-- Constraints for table `variety`
--
ALTER TABLE `variety`
  ADD CONSTRAINT `FK_variety_crop` FOREIGN KEY (`crop_id`) REFERENCES `crop` (`crop_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
