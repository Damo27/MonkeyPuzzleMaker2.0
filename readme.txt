Welcome to Monkey Puzzle Maker. Please read this before testing this application.
----------------------------------------------------------------Beta 1.3 Change-log---------------------------------------------------------------
1. Added a Web-Application to the solution to allow the students to log in from anywhere to view their results along with a memorandum for tests
	which they have taken. 

2. Moved the storage of data from MS Access to a SQL Server .mdf file located in the App_Data folder of the Web Application. 
	NOTE: Both applications run off a single server for data synchronization. Both Applications should function immediately when transferred to
	another instance of windows, but for the sake of safety a backup of the database can be found in the Solution folder.
	
3. Started migration of initial application to the Web-App with the long term goal of having a single fully functional web-application to remove
	the need of a local instance of the Monkey Puzzle application.
	
4. Testers please note to select the correct Project for startup depending on which application you are testing.
----------------------------------------------------------------Beta 1.2 Change-log---------------------------------------------------------------
1. Moved all stored information from flat file storage system to Access Database storage system. Please note this may cause longer load periods 
	for different functions.
	
2. Added functionality to the NewTest form(Lecturers utility) for saving the final question as the current button configuration is not intuitive
	enough to encourage end users to save each question before saving the test.

----------------------------------------------------------------Beta 1.1 Change-log---------------------------------------------------------------
1. This application is designed to allow Lecturers to create multiple choice tests(Monkey puzzles), 
	and allow students to take the test only once. It also allows Lecturers to view or save a Mark Sheet
	of a single test for all students who have taken the test. Students may also view a list of all the Marks
	for tests which they have taken.
	
2. Access is Granted according to different access groups assigned to the user. The login control will differentiate between 
	Lecturers, Students and Administrators and direct you to the appropriate form. All user info is stored in a single file "users.txt".
	However if you would like to add a user or modify a users details please use the admin utility and do not modify the file directly 
	as this can cause errors.
	
3. 3 default accounts have been loaded for testing:

				Administrator - User ID: 101 Password: Password
				Lecturer	  - User ID: 102 Password: Password
				Student	      - User ID: 103 Password: Password
				
4. Administrator access - Allows you to add users. Delete users and Delete tests.
   Lecturer Access      - Allows you to create tests, and print or save Mark Sheets. Unfortunately Editing an Existing Test is still in development.
   Student Access		- Allows you to take each test once, view the memo immediately afterwards, and view a list of all your marks.
   
5. The application functions on 4 files which have been structured like a database to accommodate for the eventual move of the information to a 
   database. You will notice all files are related, in that the tests file contains the userID, each question in the questions file contains the 
   testID to which it is associated and each mark in the marks file contains both a userID and a testID. The format in which these files are 
   structured is extremely important and altering them will impede the functionality of the program. Which is why I have made it possible to alter
   any information from within the program.
   
Thank you for reading. If you wish to no longer see this file on startup please delete the readme.txt file from the debug bin.