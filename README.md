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
  4. Register for an account and create a user id and password.  There is no validation other than email format on the Registration Page.
  5. Login to the Application.
  6. Initiate all CRUD operations from the list screen ("Index")

Call-Logger contains two JavaScript Plugins:  DatePicker and DataTable.  DatePicker is used for updating the date on both the Add and Edit Screen.
DataTable provides dynamic filtering of table columns, pagination and sortable columns.
