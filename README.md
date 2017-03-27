# Call-Logger
Code Louisville Final Project
C# / .Net


Call-Logger is a light-weight, responsive web application with the intended use of tracking calls from registrants to the Victim Notification System Helpdesk.  Registrant calls are currently documented in an Issues/Problem Tracking System which requires the operators to log information that is not relevant to this type of call.  The Call Logger will only track the information relevant to those calls and will decrease time spent on documenting call tickets.

Call-Logger is an MVC web application built with C#/.Net Framework using Visual Studio Community Edition 2015.  The database component of the application is an instance of Microsoft MSSQL\LocalDb.

To Run:
  1. Clone Repository to a local repository:
        https://github.com/mhereford/Call-Logger.git
  2. Open Repository in Visual Studio Community Edition 2015.
  3. Select to run the application in the browser of your choice.

Call-Logger allows for the addition of new calls, editing and deleting of existing calls.  The landing screen contains a link to the Add screen and a list of all calls in the database.  Each existig call in the table cotntains links to the Edit and Delete Pages to complete those operations.  The application will validate for missing required fields and report messages to the user.  The application will also provide feedback to the user if their CRUD operation is successful.
