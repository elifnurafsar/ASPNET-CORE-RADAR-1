## Description

Basic [ASP.NET](http://asp.net/) Core Model-View-Controller (MVC) app built on C# with Aspect Oriented Programming (AOP).

## Features

- User authentication
- User authorization with predefined roles and user specific permissions
- Session controls using cookies

All of the features above are implemented in AOP without using any third-party APIs or services (such as Identity).

## Pages

- UserLogin works by asking user for mail and password. If an entry is found with the given mail address and the password matches the one in the database, user is redirected to the profile page. Otherwise, a corresponding error is displayed on the page.
- UserRegister asks  for username, mail and password.
- UserProfile is a restricted page. When user clicks on profile menu on the home page, isAuthenticated Aspect checks whether the current user is logged in. If there is an active cookie, user is admitted. Otherwise, an exception is thrown out.
- UserList requires both isAuthenticated and isAuthorization aspects. Former checks whether the user is logged in while the latter requires admin type user rule. If the requirements are fulfilled, name, mail address and session information for each of users are displayed.

## Necessary Programs/Libraries

Program was written in C#, therefore, a special environment for the aforementioned language is needed (Visual Studio 2019 was used for the project). Net Core 5.0 was used for the application and no prior version was tested. Finally, in order to store user data, a local SQL server is needed. SQL Server Management Studio (Version 18.8) was used to initialize the database. For the Aspect side, PostSharp was used. 

## How to Install

1. Download the project and open it in Visual Studio 
2. Create a new database, named as AccountDb, in your local SQL Server (Microsoft SQL Server Managment Studio is recommended)
3. Execute the following queries to create necessary tables

    ```java
    CREATE TABLE AccountRoles (
    	Roleid INT IDENTITY PRIMARY KEY,
    	Rolename nvarchar(100) NOT NULL,
    	Roleallow nvarchar(100), 
    	Roledeny nvarchar(100)
    );

    CREATE TABLE AccountInfo(
    	UserID INT IDENTITY PRIMARY KEY,
    	Username nvarchar(100),
    	Usermail nvarchar(100) NOT NULL, 
    	Userpassword nvarchar(100) NOT NULL,
    	Userallow nvarchar(100),
    	Userdeny nvarchar(100)
    );

    CREATE TABLE UserRoles(
    	ID INT IDENTITY PRIMARY KEY,
    	UserID INT FOREIGN KEY REFERENCES AccountInfo(UserID),
    	Roleid INT FOREIGN KEY REFERENCES AccountRoles(Roleid)
    );

    CREATE TABLE AccountSessions (
    	ID INT IDENTITY PRIMARY KEY,
    	Usermail nvarchar(100),
    	LoginDate nvarchar(100),
    	IsLoggedIn INT
    );

    INSERT INTO AccountInfo(Username, Usermail, Userpassword) VALUES ('admin', 'admin@admin.com', 'admin');

    INSERT INTO UserRoles(UserID, Roleid) VALUES (1,1);

    INSERT INTO AccountRoles(Rolename, Roleallow) VALUES ('Admin', '45EADA4A-CFB8-46A9-8DDB-5A1ACCC89D2A');
    INSERT INTO AccountRoles(Rolename, Roledeny) VALUES ('RegularUser', '45EADA4A-CFB8-46A9-8DDB-5A1ACCC89D2A');
    ```

4. Select "Add Connection" after right clicking on "Data Connections" in "Server Explorer" from the view panel of the Visual Studio 
5. Fill the necessary boxes as shown below and select the database created in step 2

    Data Source: Microsoft SQL Server (SqlClient)

    Server Name: Your local SQL Server's name 

6. Copy the connection string from the "properties" for the server added in the previous step in "Data Connections" & paste it to localDatabase in appsettings.json
7. Install Postgres from Package Manager Console under the Tools menu of the Visual Studio
8. Install [ASPNETAOP-WebServer](https://github.com/cenkgokturk/ASPNET-CORE-MVC-WEB-SERVER) and open it in a seperate Visual Studio window 
9. Click "Start without debugging" for the ASPNETAOP-WebServer project
10. Do the same thing for ASPNETAOP
11. Both projects will be opened in your default browser. Unless you want to debug, you don't have to interact with the WebServer