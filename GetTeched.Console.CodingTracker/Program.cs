﻿/*
 * This application has the same requirements as the previous project, except that now you'll be logging your daily coding time.
 * To show the data on the console, you should use the "Spectre.Console" library.
 * To show the data on the console, you should use the "Spectre.Console" library.
 * You should tell the user the specific format you want the date and time to be logged and not allow any other format.
 * You'll need to create a configuration file that you'll contain your database path and connection strings.
 * You'll need to create a "CodingSession" class in a separate file. It will contain the properties of your coding session: Id, StartTime, EndTime, Duration
 * The user shouldn't input the duration of the session. It should be calculated based on the Start and End times, in a separate "CalculateDuration" method.
 * The user should be able to input the start and end times manually.
 * You need to use Dapper ORM for the data access instead of ADO.NET. (This requirement was included in Feb/2024)
 * When reading from the database, you can't use an anonymous object, you have to read your table into a List of Coding Sessions.
 * --------------------------------------------------------RESOURCES-----------------------------------------------------------------------------------------------------
 * https://spectreconsole.net/
 * https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file
 * https://stackoverflow.com/questions/3719/how-to-validate-a-datetime-in-c
 * https://www.learndapper.com/
 * https://docs.microsoft.com/en-us/troubleshoot/dotnet/csharp/store-custom-information-config-file
 * --------------------------------------------------------CHALLENGES-----------------------------------------------------------------------------------------------------
 * Add the possibility of tracking the coding time via a stopwatch so the user can track the session as it happens.
 * Let the users filter their coding records per period (weeks, days, years) and/or order ascending or descending.
 * Create reports where the users can see their total and average coding session per period.
 * Create the ability to set coding goals and show how far the users are from reaching their goal, along with how many hours a day they would have to code to reach their goal. You can do it via SQL queries or with C#.
 * ------------------------------------------------------------TODO--------------------------------------------------------------------------------------------------------
 * Creating a Configuration File
 */
using System.Configuration;
using System.Collections.Specialized;
using coding_tracker;

string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString")!;
DatabaseManager databaseManager = new();
UserInput userInput = new();

databaseManager.SqlInitialize(connectionString);
userInput.MainMenu();