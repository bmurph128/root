Using command line argument for uploading file

Utilizing OOP principles - Data classes Driver and Trips reflect the Driver and Trip data uploaded; each Driver has their Name and Trips, each Trip has a Driver (Name), TripStartTime, TripEndTime and MilesDriven.

The Logic classes are DriverDto and CustomerFileUploadService. CustomerFileUploadService is called in Program.cs and takes in the file as a command line argument; it reads the file, adds to either a list of Drivers or a list of Trips (which belong to each driver), then creates a list of DriverDto, which has Name, Miles and Mph for properties. Before returning the list of DriverDto, it's sorted by miles driven.

Once this method has been called in Program.cs, the results are printed to the console.

Unit Tests - using a TestData.txt resource in the RootInsuranceKataTest project, the first test DidFileLoad() is called and is only checked to see that one name is in the list of DriverDto, to verify the file loaded. The other test IsLogicCorrect() is called and checks against what the list should be, including verifying that the filtering for trips and sorting by miles was done correctly by hardcoding what data the list should contain. For the unit tests, there are two methods in the CustomerFileUploadService class that are only for these tests (with a comment indicating they are for tests only). This was necessary to be able to access the test file. The methods for the tests and methods for the logic are the exact same except for how they read the data - the methods for the tests utilize StringReader which allows access to the TestData.txt resource.
