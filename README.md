# CarOLinerProject

#### Introduction
Hello everybody! :smile: \
I made a Blazor Project with Entity Framework Core

#### Prerequisities
If you want to clone this repository you will need to have 2 things installed on your computer first:
* Visual Studio 
* SQL Server 


#### How to Run the Project

1. Clone the project to Visual Studio
2. Go to CarOliner.Api and go to appsettings.json
3. On DefaultConnection check the Data Source and see if it is the same as your local computer. Mine is .\\SQLEXPRESS so if yours is different then change it to yours.
4. Choose CarOliner.Api as your Startup Project
5. Go to Package Manager Console. Choose CarOLiner.Data as your Default project and write in the command: update-database
6. Start the project and two windows will open, one with Swagger UI and another with UI Grid.
7. Use the Swagger UI window and click on Post/api/Seed 
8. Press the 'Try it out' button and after that press the blue 'Execute' button. You should now have products in the database.
9. Right click on the Soulution 'CarOLinerProject' and click on Set Startup Projects
10. Choose Multiple startup projects and set CarOLiner.Api and CarOLiner.UI to Start and press OK.
11. Go to the other window with UI Grid and press on Products to show all the Products on the grid that are now in the database.

## License
[MIT](https://choosealicense.com/licenses/mit/)

