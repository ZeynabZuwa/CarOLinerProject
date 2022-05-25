# CarOLinerProject

#### Introduction
Hello everybody! :smile: \
I made a Blazor Project with Entity Framework Core

#### Prerequisities
If you want to clone this repository you will need to have 2 things installed on your computer first:
* Visual Studio or Visual Studio Code
* SQL Server 


#### How to Run the Project

1. Clone the project to Visual Studio
2. Right click on the Soulution 'CarOLinerProject' and click on Set Startup Projects
3. Choose Multiple startup projects and set CarOLiner.Api and CarOLiner.UI to Start and press OK.
4. Go to CarOliner.Api and go to appsettings.json
5. On DefaultConnection check the Data Source and see if it is the same as your local computer. Mine is .\\SQLEXPRESS so if yours is different then change it to yours.
6. Go to Package Manager Console. Choose CarOLiner.Api as your Default project and right in the command: update-database
7. Start the project and two windows will open, one with Swagger UI and another with UI Grid.
8. Use the Swagger UI window and click on Post/api/Seed 
9. Press the 'Try it out' button and after that press the blue 'Execute' button. You should now have products in the database.
10. Go to the other window with UI Grid and press on Products to show all the Products on the grid that are now in the database.

## License
[MIT](https://choosealicense.com/licenses/mit/)

