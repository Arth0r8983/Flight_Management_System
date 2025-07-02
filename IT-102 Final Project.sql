-- --------------------------------------------------------------------------------
-- Name: Ryan Ellers 
 
-- Abstract: FlyMe2theMoon
-- --------------------------------------------------------------------------------
-- IT-102 Final Project 
-- --------------------------------------------------------------------------------
-- Options
-- --------------------------------------------------------------------------------
USE dbFlyMe2theMoon     
SET NOCOUNT ON;  

-- --------------------------------------------------------------------------------
--						IT-102 Final Project
-- --------------------------------------------------------------------------------

-- Drop Table Statements
IF OBJECT_ID ('TPilotFlights')			IS NOT NULL DROP TABLE TPilotFlights
IF OBJECT_ID ('TAttendantFlights')		IS NOT NULL DROP TABLE TAttendantFlights
IF OBJECT_ID ('TFlightPassengers')		IS NOT NULL DROP TABLE TFlightPassengers
IF OBJECT_ID ('TMaintenanceMaintenanceWorkers')			IS NOT NULL DROP TABLE TMaintenanceMaintenanceWorkers

IF OBJECT_ID ('TPassengers')			IS NOT NULL DROP TABLE TPassengers
IF OBJECT_ID ('TPilots')				IS NOT NULL DROP TABLE TPilots
IF OBJECT_ID ('TAttendants')			IS NOT NULL DROP TABLE TAttendants
IF OBJECT_ID ('TMaintenanceWorkers')	IS NOT NULL DROP TABLE TMaintenanceWorkers

IF OBJECT_ID ('TEmployees')				IS NOT NULL DROP TABLE TEmployees
IF OBJECT_ID ('TEmployeeRoles')			IS NOT NULL DROP TABLE TEmployeeRoles
IF OBJECT_ID ('TFlights')				IS NOT NULL DROP TABLE TFlights
IF OBJECT_ID ('TMaintenances')			IS NOT NULL DROP TABLE TMaintenances
IF OBJECT_ID ('TPlanes')				IS NOT NULL DROP TABLE TPlanes
IF OBJECT_ID ('TPlaneTypes')			IS NOT NULL DROP TABLE TPlaneTypes
IF OBJECT_ID ('TPilotRoles')			IS NOT NULL DROP TABLE TPilotRoles
IF OBJECT_ID ('TAirports')				IS NOT NULL DROP TABLE TAirports
IF OBJECT_ID ('TStates')				IS NOT NULL DROP TABLE TStates

-- --------------------------------------------------------------------------------
--	Step #1 : Create table 
-- --------------------------------------------------------------------------------

CREATE TABLE TPassengers
(
	 intPassengerID				INTEGER			NOT NULL
	,strFirstName				VARCHAR(255)	NOT NULL
	,strLastName				VARCHAR(255)	NOT NULL
	,strAddress					VARCHAR(255)	NOT NULL
	,strCity					VARCHAR(255)	NOT NULL
	,intStateID					INTEGER			NOT NULL
	,strZip						VARCHAR(255)	NOT NULL
	,strPhoneNumber				VARCHAR(255)	NOT NULL
	,strEmail					VARCHAR(255)	NOT NULL
	,strPassengerLoginID		VARCHAR(255)	NOT NULL
	,strPassengerPassword		VARCHAR(255)	NOT NULL
	,dtmPassengerDateofBirth	DATE			NOT NULL
	,CONSTRAINT TPassengers_PK PRIMARY KEY ( intPassengerID )
)

CREATE TABLE TEmployeeRoles
(
	intEmployeeRoleID			INTEGER			NOT NULL
	,strEmployeeRole			VARCHAR(255)    NOT NULL
	,CONSTRAINT TEmployeeRoles_PK PRIMARY KEY ( intEmployeeRoleID )

)

CREATE TABLE TEmployees
(
	intEmployeeID				INTEGER			NOT NULL
	,strEmployeeLoginID			VARCHAR(255)	NOT NULL
	,strEmployeePassword		VARCHAR(255)	NOT NULL
	,intEmployeeRoleID			INTEGER			NOT NULL
	,intEmployeeForeignKey		INTEGER		    NULL
	,CONSTRAINT TEmployees_PK PRIMARY KEY ( intEmployeeID )
	,CONSTRAINT TEmployees_TEmployeeRoles_FK FOREIGN KEY ( intEmployeeRoleID ) REFERENCES TEmployeeRoles ( intEmployeeRoleID )

)




CREATE TABLE TPilots
(
	 intPilotID				INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strEmployeeID			VARCHAR(255)	NOT NULL
	,dtmDateOfHire			DATETIME		NOT NULL
	,dtmDateOfTermination	DATETIME		NOT NULL
	,dtmDateOfLicense		DATETIME		NOT NULL
	,intPilotRoleID			INTEGER			NOT NULL

	,CONSTRAINT TPilots_PK PRIMARY KEY ( intPilotID )
)


CREATE TABLE TAttendants
(
	 intAttendantID			INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strEmployeeID			VARCHAR(255)	NOT NULL
	,dtmDateOfHire			DATETIME		NOT NULL
	,dtmDateOfTermination	DATETIME		NOT NULL
	,CONSTRAINT TAttendants_PK PRIMARY KEY ( intAttendantID )
)


CREATE TABLE TMaintenanceWorkers
(
	 intMaintenanceWorkerID	INTEGER			NOT NULL
	,strFirstName			VARCHAR(255)	NOT NULL
	,strLastName			VARCHAR(255)	NOT NULL
	,strEmployeeID			VARCHAR(255)	NOT NULL
	,dtmDateOfHire			DATETIME		NOT NULL
	,dtmDateOfTermination	DATETIME		NOT NULL
	,dtmDateOfCertification	DATETIME		NOT NULL
	,CONSTRAINT TMaintenanceWorkers_PK PRIMARY KEY ( intMaintenanceWorkerID )
)


CREATE TABLE TStates
(
	 intStateID			INTEGER			NOT NULL
	,strState			VARCHAR(255)	NOT NULL
	,CONSTRAINT TStates_PK PRIMARY KEY ( intStateID )
)


CREATE TABLE TFlights
(
	 intFlightID			INTEGER			NOT NULL
	,strFlightNumber		VARCHAR(255)	NOT NULL
	,dtmFlightDate			DATETIME		NOT NULL
	,dtmTimeofDeparture		TIME			NOT NULL
	,dtmTimeOfLanding		TIME			NOT NULL
	,intFromAirportID		INTEGER			NOT NULL
	,intToAirportID			INTEGER			NOT NULL
	,intMilesFlown			INTEGER			NOT NULL
	,intPlaneID				INTEGER			NOT NULL
	,CONSTRAINT TFlights_PK PRIMARY KEY ( intFlightID )
)


CREATE TABLE TMaintenances
(
	 intMaintenanceID		INTEGER			NOT NULL
	,strWorkCompleted		VARCHAR(8000)	NOT NULL
	,dtmMaintenanceDate		DATETIME		NOT NULL
	,intPlaneID				INTEGER			NOT NULL
	,CONSTRAINT TMaintenances_PK PRIMARY KEY ( intMaintenanceID )
)


CREATE TABLE TPlanes
(
	 intPlaneID				INTEGER			NOT NULL
	,strPlaneNumber			VARCHAR(255)	NOT NULL
	,intPlaneTypeID			INTEGER			NOT NULL
	,CONSTRAINT TPlanes_PK PRIMARY KEY ( intPlaneID )
)


CREATE TABLE TPlaneTypes	
(
	 intPlaneTypeID			INTEGER			NOT NULL
	,strPlaneType			VARCHAR(255)	NOT NULL
	,CONSTRAINT TPlaneTypes_PK PRIMARY KEY ( intPlaneTypeID )
)


CREATE TABLE TPilotRoles	
(
	 intPilotRoleID			INTEGER			NOT NULL
	,strPilotRole			VARCHAR(255)	NOT NULL
	,CONSTRAINT TPilotRoles_PK PRIMARY KEY ( intPilotRoleID )
)


CREATE TABLE TAirports
(
	 intAirportID			INTEGER			NOT NULL
	,strAirportCity			VARCHAR(255)	NOT NULL
	,strAirportCode			VARCHAR(255)	NOT NULL
	,CONSTRAINT TAirports_PK PRIMARY KEY ( intAirportID )
)


CREATE TABLE TPilotFlights
(
	 intPilotFlightID		INTEGER			NOT NULL
	,intPilotID				INTEGER			NOT NULL
	,intFlightID			INTEGER			NOT NULL
	,CONSTRAINT TPilotFlights_PK PRIMARY KEY ( intPilotFlightID )
)


CREATE TABLE TAttendantFlights
(
	 intAttendantFlightID		INTEGER			NOT NULL
	,intAttendantID				INTEGER			NOT NULL
	,intFlightID				INTEGER			NOT NULL
	,CONSTRAINT TAttendantFlights_PK PRIMARY KEY ( intAttendantFlightID )
)


CREATE TABLE TFlightPassengers
(
	 intFlightPassengerID		INTEGER			NOT NULL
	,intFlightID				INTEGER			NOT NULL
	,intPassengerID				INTEGER			NOT NULL
	,strSeat					VARCHAR(255)	NOT NULL
	,monFlightCosts				MONEY		    NULL
	,CONSTRAINT TFlightPassengers_PK PRIMARY KEY ( intFlightPassengerID )
)


CREATE TABLE TMaintenanceMaintenanceWorkers
(
	 intMaintenanceMaintenanceWorkerID		INTEGER			NOT NULL
	,intMaintenanceID						INTEGER			NOT NULL
	,intMaintenanceWorkerID					INTEGER			NOT NULL
	,intHours								INTEGER			NOT NULL
	,CONSTRAINT TMaintenanceMaintenanceWorkers_PK PRIMARY KEY ( intMaintenanceMaintenanceWorkerID )
)

-- --------------------------------------------------------------------------------
--	Step #2 : Establish Referential Integrity 
-- --------------------------------------------------------------------------------
--
-- #	Child							Parent						Column
-- -	-----							------						---------
-- 1	TPassengers						TStates						intStateID	
-- 2	TFlightPassenger				TPassengers					intPassengerID
-- 3	TFlights						TPlanes						intPlaneID
-- 4	TFlights						TAirports					intFromAiportID
-- 5	TFlights						TAirports					intToAiportID
-- 6	TPilotFlights					TFlights					intFlightID
-- 7	TAttendantFlights				TFlights					intFlightID
-- 8	TPilotFlights					TPilots						intPilotID
-- 9	TAttendantFlights				TAttendants					intAttendantID
-- 10	TPilots							TPilotRoles					intPilotRoleID
-- 11	TPlanes							TPlaneTypes					intPlaneTypeID
-- 12	TMaintenances					TPlanes						intPlaneID
-- 13	TMaintenanceMaintenanceWorkers	TMaintenance				intMaintenanceID
-- 14	TMaintenanceMaintenanceWorkers	TMaintenanceWorker			intMaintenanceWorkerID
-- 15	TFlightPassenger				TFlights					intFlightID

--1
ALTER TABLE TPassengers ADD CONSTRAINT TPassengers_TStates_FK 
FOREIGN KEY ( intStateID ) REFERENCES TStates ( intStateID ) 

--2
ALTER TABLE TFlightPassengers ADD CONSTRAINT TPFlightPassengers_TPassengers_FK 
FOREIGN KEY ( intPassengerID ) REFERENCES TPassengers ( intPassengerID )

--3
ALTER TABLE TFlights	 ADD CONSTRAINT TFlights_TPlanes_FK 
FOREIGN KEY ( intPlaneID ) REFERENCES TPlanes ( intPlaneID )

--4
ALTER TABLE TFlights	 ADD CONSTRAINT TFlights_TFromAirports_FK 
FOREIGN KEY ( intFromAirportID ) REFERENCES TAirports ( intAirportID )

--5
ALTER TABLE TFlights	 ADD CONSTRAINT TFlights_TToAirports_FK 
FOREIGN KEY ( intToAirportID ) REFERENCES TAirports ( intAirportID )

--6
ALTER TABLE TPilotFlights	 ADD CONSTRAINT TPilotFlights_TFlights_FK 
FOREIGN KEY ( intFlightID ) REFERENCES TFlights (intFlightID )  

--7
ALTER TABLE TAttendantFlights	 ADD CONSTRAINT TAttendantFlights_TFlights_FK 
FOREIGN KEY ( intFlightID ) REFERENCES TFlights (intFlightID ) 

--8
ALTER TABLE TPilotFlights	 ADD CONSTRAINT TPilotFlights_TPilots_FK 
FOREIGN KEY ( intPilotID ) REFERENCES TPilots (intPilotID ) 

--9
ALTER TABLE TAttendantFlights	 ADD CONSTRAINT TAttendantFlights_TAttendants_FK 
FOREIGN KEY ( intAttendantID ) REFERENCES TAttendants (intAttendantID )

--10
ALTER TABLE TPilots	 ADD CONSTRAINT TPilots_TPilotRoles_FK 
FOREIGN KEY ( intPilotRoleID ) REFERENCES TPilotRoles (intPilotRoleID )  

--11
ALTER TABLE TPlanes	 ADD CONSTRAINT TPlanes_TPlaneTypes_FK 
FOREIGN KEY ( intPlaneTypeID ) REFERENCES TPlaneTypes (intPlaneTypeID )  

--12
ALTER TABLE TMaintenances	 ADD CONSTRAINT TMaintenances_TPlanes_FK 
FOREIGN KEY ( intPlaneID ) REFERENCES TPlanes (intPlaneID )  

--13
ALTER TABLE TMaintenanceMaintenanceWorkers	 ADD CONSTRAINT TMaintenanceMaintenanceWorkers_TMaintenances_FK 
FOREIGN KEY ( intMaintenanceID ) REFERENCES TMaintenances (intMaintenanceID ) 

--14
ALTER TABLE TMaintenanceMaintenanceWorkers	 ADD CONSTRAINT TMaintenanceMaintenanceWorkers_TMaintenanceWorkers_FK 
FOREIGN KEY ( intMaintenanceWorkerID ) REFERENCES TMaintenanceWorkers (intMaintenanceWorkerID ) 

--15
ALTER TABLE TFlightPassengers	 ADD CONSTRAINT TFlightPassengers_TFlights_FK 
FOREIGN KEY ( intFlightID ) REFERENCES TFlights (intFlightID ) 

-- --------------------------------------------------------------------------------
--	Step #3 : Add Data - INSERTS
-- --------------------------------------------------------------------------------
INSERT INTO TStates( intStateID, strState)
VALUES				(1, 'Ohio')
				   ,(2, 'Kentucky')
				   ,(3, 'Indiana')


INSERT INTO TPilotRoles( intPilotRoleID, strPilotRole)
VALUES				(1, 'Co-Pilot')
				   ,(2, 'Captain')


INSERT INTO TEmployeeRoles( intEmployeeRoleID, strEmployeeRole)
VALUES				(1, 'Admin')
				   ,(2, 'Attendant')
				   ,(3, 'Pilot')

				   
INSERT INTO TEmployees( intEmployeeID, strEmployeeLoginID, strEmployeePassword, intEmployeeRoleID, intEmployeeForeignKey)
VALUES				(1, 'SeeNow123', 'TipSeeN0w%', 3, 1)
				   ,(2, 'Soring321', 'Ima75#@', 3, 2)
				   ,(3, 'Hugh324', 'Hugh59*', 3, 3)
				   ,(4, 'Knapp56', 'Knapp123&', 3, 4)
				   ,(5, 'RSinclair4', 'Rose80@', 3, 5)
				   ,(6, 'MleTyme', 'Tyme76*', 2, 1)
				   ,(7, 'Sherley4', 'Sherley78$', 2, 2)
				   ,(8, 'Buhh65', 'BuhhBiy43!', 2, 3)
				   ,(9, 'MylesAmanie3', 'Amanie387$', 2, 4)
				   ,(10, 'Walker31', 'Walker543&', 2, 5)
				   ,(11, 'Jones45', 'James56&', 1, null)
				   ,(12, 'Winston32', 'Winst78%', 1, null)
				   ,(13, 'Arthur21', 'Arth65!', 1, null)

				
INSERT INTO TPlaneTypes( intPlaneTypeID, strPlaneType)
VALUES				(1, 'Airbus A350')
				   ,(2, 'Boeing 747-8')
				   ,(3, 'Boeing 767-300F')


INSERT INTO TPlanes( intPlaneID, strPlaneNumber, intPlaneTypeID)
VALUES				(1, '4X887G', 1)
				   ,(2, '5HT78F', 2)
				   ,(3, '5TYY65', 2)
				   ,(4, '4UR522', 1)
				   ,(5, '6OP3PK', 3)
				   ,(6, '67TYHH', 3)


INSERT INTO TAirports( intAirportID, strAirportCity, strAirportCode)
VALUES				(1, 'Cincinnati', 'CVG')
				   ,(2, 'Miami', 'MIA')
				   ,(3, 'Ft. Meyer', 'RSW')
				   ,(4, 'Louisville',  'SDF')
				   ,(5, 'Denver', 'DEN')
				   ,(6, 'Orlando', 'MCO' )


INSERT INTO TPassengers (intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail, strPassengerLoginID, strPassengerPassword, dtmPassengerDateofBirth)
VALUES				  (1, 'Knelly', 'Nervious', '321 Elm St.', 'Cincinnati', 1, '45201', '5135553333', 'nnelly@gmail.com', 'KnellNervious', 'Passenger123@', '2/3/1998')
					 ,(2, 'Orville', 'Waite', '987 Oak St.', 'Cleveland', 1, '45218', '5135556333', 'owright@gmail.com', 'OWaite', 'Orville@#43', '3/12/1978')
					 ,(3, 'Eileen', 'Awnewe', '1569 Windisch Rd.', 'Dayton', 1, '45069', '5135555333', 'eonewe1@yahoo.com', 'EiAwnewe', '4343Dayt0n$', '7/8/1999')
					 ,(4, 'Bob', 'Eninocean', '44561 Oak Ave.', 'Florence', 2, '45246', '8596663333', 'bobenocean@gmail.com', 'Beninocean', 'B0B74!', '10/20/2000')
					 ,(5, 'Ware', 'Hyjeked', '44881 Pine Ave.', 'Aurora', 3, '45546', '2825553333', 'Hyjekedohmy@gmail.com', 'WHyjeked', 'WareAurora43@', '4/12/1990')
					 ,(6, 'Kay', 'Oss', '4484 Bushfield Ave.', 'Lawrenceburg', 3, '45546', '2825553333', 'wehavekayoss@gmail.com', 'KyOss', 'Kay554*', '3/27/1997')


INSERT INTO TPilots (intPilotID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateofLicense, intPilotRoleID)
VALUES				  (1, 'Tip', 'Seenow', '12121', '1/1/2015', '1/1/2099', '12/1/2014', 1)
					 ,(2, 'Ima', 'Soring', '13322', '1/1/2016', '1/1/2099', '12/1/2015', 1)
					 ,(3, 'Hugh', 'Encharge', '16666', '1/1/2017', '1/1/2099', '12/1/2016', 2)
					 ,(4, 'Iwanna', 'Knapp', '17676', '1/1/2014', '1/1/2015', '12/1/2013', 1)
					 ,(5, 'Rose', 'Ennair', '19909', '1/1/2012', '1/1/2099', '12/1/2011', 2)


INSERT INTO TAttendants (intAttendantID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination)
VALUES				  (1, 'Miller', 'Tyme', '22121', '1/1/2015', '1/1/2099')
					 ,(2, 'Sherley', 'Ujest', '23322', '1/1/2016', '1/1/2099')
					 ,(3, 'Buhh', 'Biy', '26666', '1/1/2017', '1/1/2099')
					 ,(4, 'Myles', 'Amanie', '27676', '1/1/2014', '1/1/2015')
					 ,(5, 'Walker', 'Toexet', '29909', '1/1/2012', '1/1/2099')


INSERT INTO TMaintenanceWorkers (intMaintenanceWorkerID, strFirstName, strLastName, strEmployeeID, dtmDateofHire, dtmDateofTermination, dtmDateOfCertification)
VALUES				  (1, 'Gressy', 'Nuckles', '32121', '1/1/2015', '1/1/2099', '12/1/2014')
					 ,(2, 'Bolt', 'Izamiss', '33322', '1/1/2016', '1/1/2099', '12/1/2015')
					 ,(3, 'Sharon', 'Urphood', '36666', '1/1/2017', '1/1/2099','12/1/2016')
					 ,(4, 'Ides', 'Racrozed', '37676', '1/1/2014', '1/1/2015','12/1/2013')
					

INSERT INTO TMaintenances (intMaintenanceID, strWorkCompleted, dtmMaintenanceDate, intPlaneID)
VALUES				  (1, 'Fixed Wing', '1/1/2022', 1)
					 ,(2, 'Repaired Flat Tire', '3/1/2022', 2)
					 ,(3, 'Added Wiper Fluid', '4/1/2022', 3)
					 ,(4, 'Tightened Engine to Wing', '5/1/2022', 2)
					 ,(5, '100,000 mile checkup', '3/10/2022', 4)
					 ,(6, 'Replaced Loose Door', '4/10/2022', 6)
					 ,(7, 'Trapped Raccoon in Cargo Hold', '5/1/2022', 6)


INSERT INTO TFlights (intFlightID, dtmFlightDate, strFlightNumber,  dtmTimeofDeparture, dtmTimeOfLanding, intFromAirportID, intToAirportID, intMilesFlown, intPlaneID)
VALUES				  (1, '4/1/2022', '111', '10:00:00', '12:00:00', 1, 2, 1200, 2)
					 ,(2, '4/4/2022', '222','13:00:00', '15:00:00', 1, 3, 1000, 2)
					 ,(3, '4/5/2022', '333','15:00:00', '17:00:00', 1, 5, 1200, 3)
					 ,(4, '4/16/2022','444', '10:00:00', '12:00:00', 4, 6, 1100, 3)
					 ,(5, '3/14/2022','555', '18:00:00', '20:00:00', 2, 1, 1200, 3)
					 ,(6, '3/21/2022','666', '19:00:00', '21:00:00', 3, 1, 1000, 1)
					 ,(7, '3/11/2022', '777','20:00:00', '22:00:00', 3, 6, 1400, 4)
					 ,(8, '3/17/2022', '888','09:00:00', '11:00:00', 6, 4, 1100, 5)
					 ,(9, '4/19/2022', '999','08:00:00', '10:00:00', 4, 2, 1000, 6)
					 ,(10, '4/22/2022', '091','10:00:00', '12:00:00', 2, 1, 1200, 6)
					 ,(11, '9/23/2025', '092', '14:00:00', '16:00:00', 4, 1, 1200, 1)
					 ,(12, '2/09/2025', '093', '12:00:00', '14:00:00', 3, 4, 1000, 2)
					 ,(13, '10/23/24', '094', '7:00:00', '9:00:00', 2, 3, 1100, 4)
					 ,(14, '11/14/24', '095', '4:00:00', '6:00:00', 5, 2, 1200, 5)


INSERT INTO TPilotFlights ( intPilotFlightID, intPilotID, intFlightID)
VALUES				 ( 1, 1, 2 )
					,( 2, 1, 3 )
					,( 3, 3, 3 )
					,( 4, 3, 2 )
					,( 5, 5, 1 )
					,( 6, 2, 1 )
					,( 7, 3, 4 )
					,( 8, 2, 4 )
					,( 9, 2, 5 )
					,( 10, 3, 5 )
					,( 11, 5, 6 )
					,( 12, 1, 6 )


INSERT INTO TAttendantFlights ( intAttendantFlightID, intAttendantID, intFlightID)
VALUES				( 1, 1, 2 )
					,( 2, 2, 3 )
					,( 3, 3, 3 )
					,( 4, 4, 2 )
					,( 5, 5, 1 )
					,( 6, 1, 1 )
					,( 7, 2, 4 )
					,( 8, 3, 4 )
					,( 9, 4, 5 )
					,( 10, 5, 5 )
					,( 11, 5, 6 )
					,( 12, 1, 6 )
					

INSERT INTO TFlightPassengers ( intFlightPassengerID, intFlightID, intPassengerID, strSeat, monFlightCosts)
VALUES				 ( 1, 1, 1, '1A', null)
					,( 2, 1, 2, '2A', null )
					,( 3, 1, 3, '1B', null)
					,( 4, 1, 4, '1C', null)
					,( 5, 1, 5, '1D', null )
					,( 6, 2, 5, '1A', null )
					,( 7, 2, 4, '2A', null )
					,( 8, 2, 3, '1B', null )
					,( 9, 3, 1, '1B', null )
					,( 10, 3, 2, '2A', null )
					,( 11, 3, 3, '1B', null )
					,( 12, 3, 4, '1C', null )
					,( 13, 3, 5, '1D', null )
					,( 14, 4, 2, '1A', null )
					,( 15, 4, 3, '1B', null )
					,( 16, 4, 4, '1C', null )
					,( 17, 4, 5, '1D', null )
					,( 18, 5, 1, '1A', null )
					,( 19, 5, 2, '2A', null )
					,( 20, 5, 3, '1B', null )
					,( 21, 5, 4, '2B', null )
					,( 22, 6, 1, '1A', null )
					,( 23, 6, 2, '2A', null )
					,( 24, 6, 3, '3A', null )
					

INSERT INTO TMaintenanceMaintenanceWorkers ( intMaintenanceMaintenanceWorkerID, intMaintenanceID, intMaintenanceWorkerID, intHours)
VALUES				 ( 1, 2, 1, 2 )
					,( 2, 4, 1, 3 )
					,( 3, 2, 3, 4 )
					,( 4, 1, 4, 2 )
					,( 5, 3, 4, 2 )
					,( 6, 4, 3, 5 )
					,( 7, 5, 1, 7 )
					,( 8, 6, 1, 2 )
					,( 9, 7, 3, 4 )
					,( 10, 4, 4, 1 )
					,( 11, 3, 3, 4 )
					,( 12, 7, 3, 8 )

-------------------------------------------
------ Test Queries
-------------------------------------------
--GO 

--CREATE PROCEDURE uspListPassengerPastFlights(
--@Passenger_ID as Integer
--)
--AS
--BEGIN
--	SELECT TF.dtmFlightDate, TF.strFlightNumber,  TF.dtmTimeofDeparture, TF.dtmTimeOfLanding, TF.intFromAirportID, TF.intToAirportID, TF.intMilesFlown, TPT.strPlaneType
--	From TFlights As TF Join TPlanes As TP
--		 On TF.intPlaneID = TP.intPlaneID

--		Join TPlaneTypes as TPT
--		 On TP.intPlaneTypeID = TPT.intPlaneTypeID

--		 Join TFlightPassengers as TFP
--	     On TFP.intFlightID = TF.intFlightID
--	WHERE TFP.intPassengerID = @Passenger_ID 
--      and TF.dtmFlightDate < GETDATE()
--END 

--GO 

--CREATE PROCEDURE uspPassengerMilesFlown(
--@Passenger_ID as Integer
--)
--AS 
--BEGIN 
--	SELECT SUM(TF.intMilesFlown) as TotalMilesFlown
--    From TFlights As TF Join TFlightPassengers As TFP
--         On TFP.intFlightID = TF.intFlightID
--    Where TFP.intPassengerID = @Passenger_ID
--          and TF.dtmFlightDate < GETDATE()
--END 

--GO

--CREATE PROCEDURE uspListPassengerFutureFlights(
--@Passenger_ID as Integer
--)
--AS 
--BEGIN
--SELECT TF.dtmFlightDate, TF.strFlightNumber,  TF.dtmTimeofDeparture, TF.dtmTimeOfLanding, TF.intFromAirportID, TF.intToAirportID, TF.intMilesFlown, TPT.strPlaneType
--From TFlights As TF Join TPlanes As TP
--     On TF.intPlaneID = TP.intPlaneID

--     Join TPlaneTypes as TPT
--     On TP.intPlaneTypeID = TPT.intPlaneTypeID

--     Join TFlightPassengers as TFP
--     On TFP.intFlightID = TF.intFlightID
--     WHERE TFP.intPassengerID = @Passenger_ID
--     and TF.dtmFlightDate > GETDATE()
--END 

--GO

--CREATE PROCEDURE uspFuturePassengerFlightMiles(
--@Passenger_ID as Integer
--)
--AS
--BEGIN
--	SELECT SUM(TF.intMilesFlown) as TotalMilesFlown
--	From TFlights As TF Join TFlightPassengers As TFP
--         On TFP.intFlightID = TF.intFlightID
--	Where TFP.intPassengerID = @Passenger_ID
--          and TF.dtmFlightDate > GETDATE()
--END

--GO

--CREATE PROCEDURE uspCustomerNames
--AS
--BEGIN
--	SELECT intPassengerID, strFirstName + ' ' + strLastName as PassengerName
--	FROM TPassengers
--END 

--GO

--CREATE PROCEDURE uspListPilotPastFlights(
--@Pilot_ID as Integer
--)
--AS
--BEGIN
--	SELECT TF.strFlightNumber, TF.dtmFlightDate, TF.dtmTimeofDeparture, TF.dtmTimeOfLanding, TF.intFromAirportID, TF.intToAirportID, TF.intMilesFlown, TPT.strPlaneType
--    From TPilots As TP Join TPilotRoles As TPR
--         On TP.intPilotRoleID = TPR.intPilotRoleID

--         Join TPilotFlights as TPF
--         On TPF.intPilotID = TP.intPilotID

--         Join TFlights as TF
--         On TPF.intFlightID = TF.intFlightID

--         Join TPlanes as TPL
--         On TF.intPlaneID = TPL.intPlaneID

--         Join TPlaneTypes as TPT
--         On TPL.intPlaneTypeID = TPT.intPlaneTypeID
--     WHERE TPF.intPilotID = @Pilot_ID
--          And TF.dtmFlightDate < GETDATE()
--END

--GO

--CREATE PROCEDURE uspAddPassengers
--     @intPassengerID			AS INTEGER OUTPUT
--    ,@strFirstName				AS VARCHAR(255)
--    ,@strLastName				AS VARCHAR(255)
--    ,@strAddress				AS VARCHAR(255)
--    ,@strCity					AS VARCHAR(255) 
--    ,@intState					AS INTEGER 
--    ,@strZip					AS VARCHAR(255)
--    ,@strPhoneNumber			AS VARCHAR(255)
--    ,@strEmail					AS VARCHAR(255) 
--	,@strLoginID				AS VARCHAR(255)
--	,@strPassword				AS VARCHAR(255)
--	,@dtmDateofBirth			AS DATE
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION
--    SELECT @intPassengerID = MAX(intPassengerID) + 1 
--    FROM TPassengers (TABLOCKX) -- lock table until end of transaction
--    -- default to 1 if table is empty
--    SELECT @intPassengerID = COALESCE(@intPassengerID, 1)
--    INSERT INTO TPassengers(intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail, strPassengerLoginID, strPassengerPassword, dtmPassengerDateofBirth)
--    VALUES (@intPassengerID, @strFirstName, @strLastName, @strAddress, @strCity, @intState, @strZip, @strPhoneNumber, @strEmail, @strLoginID, @strPassword, @dtmDateofBirth)

--COMMIT TRANSACTION

--GO 
--CREATE PROCEDURE uspUpdatePassengers
--    @intPassengerID				AS INTEGER 
--    ,@strFirstName				AS VARCHAR(255)
--    ,@strLastName				AS VARCHAR(255)
--    ,@strAddress				AS VARCHAR(255)
--    ,@strCity					AS VARCHAR(255) 
--    ,@intState					AS INTEGER 
--    ,@strZip					AS VARCHAR(255)
--    ,@strPhoneNumber			AS VARCHAR(255)
--    ,@strEmail					AS VARCHAR(255) 
--	,@strLoginID				AS VARCHAR(255)
--	,@strPassword				AS VARCHAR(255)
--	,@dtmDateofBirth			AS DATE
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION
  
--    Update  TPassengers 
--			SET strFirstName =	@strFirstName, 
--			    strLastName =	@strLastName,
--				strAddress =	@strAddress, 
--				strCity =		@strCity, 
--				intStateID =	@intState,
--				strZip =		@strZip,
--				strPhoneNumber = @strPhoneNumber,
--				strEmail =		@strEmail,
--				strPassengerLoginID = @strLoginID,
--				strPassengerPassword = @strPassword,
--				dtmPassengerDateofBirth = @dtmDateofBirth
			
--	WHERE  intPassengerID = @intPassengerID
--COMMIT TRANSACTION

--GO 

--CREATE PROCEDURE uspDeletePilots
--     @intPilotID				AS INTEGER  
    
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION
--    DELETE FROM TPilotFlights
--	WHERE intPilotID = @intPilotID
--    Delete  FROM TPilots 
--	WHERE  intPilotID = @intPilotID

--COMMIT TRANSACTION

--GO

--CREATE PROCEDURE uspAddFutureFlights
--     @intFlightID			    AS INTEGER OUTPUT
--    ,@dtmFlightDate				AS DATE
--    ,@strFlightNumber			AS VARCHAR(255)
--    ,@dtmTimeofDeparture		AS TIME
--    ,@dtmTimeofLanding			AS TIME 
--    ,@intFromAirportID			AS INTEGER 
--    ,@intToAirportID			AS INTEGER
--    ,@intMilesFlown				AS INTEGER
--    ,@intPlaneID			    AS INTEGER 
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION
--    SELECT @intFlightID = MAX(intFlightID) + 1 
--    FROM TFlights (TABLOCKX) -- lock table until end of transaction
--    -- default to 1 if table is empty
--    SELECT @intFlightID = COALESCE(@intFlightID, 1)
--    INSERT INTO TFlights(intFlightID, dtmFlightDate, strFlightNumber, dtmTimeofDeparture, dtmTimeOfLanding, intFromAirportID, intToAirportID, intMilesFlown, intPlaneID)
--    VALUES (@intFlightID, @dtmFlightDate, @strFlightNumber, @dtmTimeofDeparture, @dtmTimeofLanding, @intFromAirportID, @intToAirportID, @intMilesFlown, @intPlaneID)

--COMMIT TRANSACTION


--GO 

--CREATE PROCEDURE uspPassengerLogins(
--@PassengerLoginID as VARCHAR(255)
--,@PassengerPassword as VARCHAR(255)
--)
--AS
--BEGIN
--	SELECT TP.intPassengerID, TP.strPassengerLoginID, TP.strPassengerPassword
--	FROM TPassengers as TP
--	WHERE @PassengerLoginID = strPassengerLoginID
--		 and @PassengerPassword = strPassengerPassword
--END 

--GO 

--CREATE PROCEDURE uspPilotEmployeesLogin(
--@EmployeeLoginID as VARCHAR(255)
--,@EmployeePassword as VARCHAR(255)
--)
--AS
--BEGIN
--	SELECT TP.intPilotID, TE.intEmployeeForeignKey, TE.strEmployeeLoginID, TE.strEmployeePassword, TE.intEmployeeRoleID
--	FROM TPilots as TP JOIN TEmployees as TE
--		ON TP.intPilotID = TE.intEmployeeForeignKey
--	WHERE TE.intEmployeeRoleID = 3
--		 and @EmployeeLoginID = strEmployeeLoginID
--		 and @EmployeePassword = strEmployeePassword
		 
--END 



--GO 

--CREATE PROCEDURE uspAttendantEmployeesLogin(
--@EmployeeLoginID as VARCHAR(255)
--,@EmployeePassword as VARCHAR(255)
--)
--AS
--BEGIN
--	SELECT TA.intAttendantID, TE.intEmployeeForeignKey, TE.strEmployeeLoginID, TE.strEmployeePassword, TE.intEmployeeRoleID
--	FROM TAttendants as TA JOIN TEmployees as TE
--		ON TA.intAttendantID = TE.intEmployeeForeignKey
--	WHERE TE.intEmployeeRoleID = 2
--		 and @EmployeeLoginID = strEmployeeLoginID
--		 and @EmployeePassword = strEmployeePassword
--END 

--GO 

--CREATE PROCEDURE uspAdminEmployeeLogin(
--@EmployeeLoginID as VARCHAR(255)
--,@EmployeePassword as VARCHAR(255)
--)
--AS
--BEGIN
--	SELECT TE.strEmployeeLoginID, TE.strEmployeePassword, TE.intEmployeeRoleID
--	FROM TEmployees as TE
--	WHERE TE.intEmployeeRoleID = 1
--		 and @EmployeeLoginID = strEmployeeLoginID
--		 and @EmployeePassword = strEmployeePassword
--END 

--GO

--CREATE PROCEDURE uspAddPilots
--     @intPilotID			    AS INTEGER OUTPUT
--	,@intEmployeeID				AS INTEGER OUTPUT
--    ,@strFirstName				AS VARCHAR(255)
--    ,@strLastName				AS VARCHAR(255)
--    ,@strEmployeeID				AS VARCHAR(255)
--    ,@DateofHire				AS DATE 
--    ,@DateofTermination			AS DATE 
--    ,@DateofLicense				AS DATE
--    ,@intPilotRole				AS INTEGER
--	,@strLoginID				AS VARCHAR(255)
--	,@strPassword				AS VARCHAR(255)
--	,@intEmployeeForeignKey		AS INTEGER OUTPUT
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION

--	SELECT @intEmployeeForeignKey = MAX(TE.intEmployeeForeignKey) + 1
--	FROM TPilots as TP JOIN TEmployees as TE
--		 ON TP.intPilotID = TE.intEmployeeForeignKey
--	WHERE TE.intEmployeeRoleID = 3

--    SELECT @intPilotID = MAX(intPilotID) + 1 
--    FROM TPilots (TABLOCKX) -- lock table until end of transaction
--    -- default to 1 if table is empty
--    SELECT @intPilotID = COALESCE(@intPilotID, 1)
--    INSERT INTO TPilots(intPilotID, strFirstName, strLastName, strEmployeeID, dtmDateOfHire, dtmDateOfTermination, dtmDateOfLicense, intPilotRoleID)
--    VALUES (@intPilotID, @strFirstName, @strLastName, @strEmployeeID, @DateofHire, @DateofTermination, @DateofLicense, @intPilotRole)

--	SELECT @intEmployeeID = MAX(intEmployeeID) + 1 
--    FROM TEmployees (TABLOCKX) -- lock table until end of transaction
--    -- default to 1 if table is empty
--    SELECT @intEmployeeID = COALESCE(@intEmployeeID, 1)
--    INSERT INTO TEmployees(intEmployeeID, strEmployeeLoginID, strEmployeePassword, intEmployeeRoleID, intEmployeeForeignKey)
--    VALUES (@intEmployeeID, @strLoginID, @strPassword, 3, @intEmployeeForeignKey)

--COMMIT TRANSACTION


--GO 

--CREATE PROCEDURE uspUpdatePilot
--    @intPilotID					AS INTEGER 
--    ,@strFirstName				AS VARCHAR(255)
--    ,@strLastName				AS VARCHAR(255)
--    ,@strEmployeeID				AS VARCHAR(255)
--    ,@dtmHireDate				AS DATE 
--    ,@dtmTerminationDate		AS DATE 
--    ,@dtmLicenseDate			AS DATE
--    ,@intPilotRole				AS INTEGER
--	,@strLoginID				AS VARCHAR(255)
--	,@strPassword				AS VARCHAR(255)
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION
  
--    Update  TPilots 
--			SET strFirstName =	@strFirstName, 
--			    strLastName =	@strLastName,
--				strEmployeeID =	@strEmployeeID, 
--				dtmDateOfHire =		@dtmHireDate, 
--				dtmDateOfTermination =	@dtmTerminationDate,
--				dtmDateOfLicense =		@dtmLicenseDate,
--				intPilotRoleID = @intPilotRole
			
--			WHERE  intPilotID = @intPilotID

--	UPDATE TEmployees
--			SET strEmployeeLoginID = @strLoginID,
--				strEmployeePassword = @strPassword
--			WHERE intEmployeeForeignKey = @intPilotID
--			and intEmployeeRoleID = 3
--COMMIT TRANSACTION

--GO

--CREATE PROCEDURE uspAddAttendants
--     @intAttendantID		    AS INTEGER OUTPUT
--	,@intEmployeeID				AS INTEGER OUTPUT
--    ,@strFirstName				AS VARCHAR(255)
--    ,@strLastName				AS VARCHAR(255)
--    ,@strEmployeeID				AS VARCHAR(255)
--    ,@dtmDateofHire				AS DATE 
--    ,@dtmDateofTermination		AS DATE 
--	,@strLoginID				AS VARCHAR(255)
--	,@strPassword				AS VARCHAR(255)
--	,@intEmployeeForeignKey		AS INTEGER OUTPUT
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION

--	SELECT @intEmployeeForeignKey = MAX(TE.intEmployeeForeignKey) + 1
--	FROM TAttendants as TA JOIN TEmployees as TE
--		 ON TA.intAttendantID = TE.intEmployeeForeignKey
--	WHERE TE.intEmployeeRoleID = 2

--    SELECT @intAttendantID = MAX(intAttendantID) + 1 
--    FROM TAttendants (TABLOCKX) -- lock table until end of transaction
--    -- default to 1 if table is empty
--    SELECT @intAttendantID = COALESCE(@intAttendantID, 1)
--    INSERT INTO TAttendants(intAttendantID, strFirstName, strLastName, strEmployeeID, dtmDateOfHire, dtmDateOfTermination)
--    VALUES (@intAttendantID, @strFirstName, @strLastName, @strEmployeeID, @dtmDateofHire, @dtmDateofTermination)

--	SELECT @intEmployeeID = MAX(intEmployeeID) + 1 
--    FROM TEmployees (TABLOCKX) -- lock table until end of transaction
--    -- default to 1 if table is empty
--    SELECT @intEmployeeID = COALESCE(@intEmployeeID, 1)
--    INSERT INTO TEmployees(intEmployeeID, strEmployeeLoginID, strEmployeePassword, intEmployeeRoleID, intEmployeeForeignKey)
--    VALUES (@intEmployeeID, @strLoginID, @strPassword, 2, @intEmployeeForeignKey)

--COMMIT TRANSACTION

--GO 

--CREATE PROCEDURE uspUpdateAttendant
--    @intAttendantID				AS INTEGER 
--    ,@strFirstName				AS VARCHAR(255)
--    ,@strLastName				AS VARCHAR(255)
--    ,@strEmployeeID				AS VARCHAR(255)
--    ,@dtmHireDate				AS DATE 
--    ,@dtmTerminationDate		AS DATE 
--	,@strLoginID				AS VARCHAR(255)
--	,@strPassword				AS VARCHAR(255)
       
--AS
--SET XACT_ABORT ON --terminate and rollback if any errors
--BEGIN TRANSACTION
  
--    Update  TAttendants 
--			SET strFirstName =	@strFirstName, 
--			    strLastName =	@strLastName,
--				strEmployeeID =	@strEmployeeID, 
--				dtmDateOfHire =		@dtmHireDate, 
--				dtmDateOfTermination =	@dtmTerminationDate
			
--			WHERE  intAttendantID = @intAttendantID

--	UPDATE TEmployees
--			SET strEmployeeLoginID = @strLoginID,
--				strEmployeePassword = @strPassword
--			WHERE intEmployeeForeignKey = @intAttendantID
--			and intEmployeeRoleID = 2
--COMMIT TRANSACTION
