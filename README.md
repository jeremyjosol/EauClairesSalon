# Eau Claire's Salon

## About
This web application provides our new client Claire a platform to create, edit, delete, and view details of new or existing stylists and clients at her salon. Claire can book appointments for future clientle and easily find stylists with a search feature that populates results based on query of a stylist name. 

Eau Claire's Salon, at its core, represents an ongoing commitment to the development of a fullstack project. It places a significant emphasis on the implementation of the MVC architectural pattern using C# to establish a modularized codebase. Simultaneously, it places a strong emphasis on frontend design, striving to practice the craft of an intuitive and aesthetically pleasing user interface.

![EauClairesSalon](https://github.com/jeremyjosol/EauClairesSalon/blob/main/HairSalon/wwwroot/img/HairSalon.jpg?raw=true)

## Technologies Used
* _Github_
* _VSCode_
* _C#_
* _.NET_
* _CSHTML_
* _CSS_
* _JSON_
* _Bootstrap_
* _MySQL Workbench_

## Setup Instructions

1. Clone this repo.

## Database Setup

1. Launch MySQL Workbench and access the Administration section in the Navigator.
2. Within the Administration window, select Data Import/Restore.
3. In the Import Options, choose "Import from Self-Contained File."
4. Locate the SQL file, named `jeremy_josol.sql`, within the project's root directory.
5. Under "Default Schema to be Imported To," create a new schema.
6. Assign a suitable name for your database or simply use `jeremy_josol.sql` as the schema name.
7. Confirm your selection by clicking "OK".
8. Proceed to the "Import Progress" tab and initiate the import process by selecting "Start Import" located at the bottom right corner of the window.
9. Once the import is completed, reopen the Navigator, navigate to the "Schemas" tab, and perform a right-click action. Choose "Refresh All" to ensure the changes are reflected.

## Application Setup

1. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called `HairSalon`. 
2. Within the production directory `HairSalon`, create a new file entitled `appsettings.json`.
3. Within `appsettings.json`, enter the following code:
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database={DATABASE};uid={USERNAME};pwd={PASSWORD};",
  }
}
```
  > Be sure to replace the `{DATABASE}`, `{USERNAME}` and `{PASSWORD}` fields with your own relevant information. Do not include the curly brackets.
4. In the production directory, you can enter the following command `dotnet watch run`.
  > This command will start the project in development mode with a watcher.

## Known Bugs

Currently no known bugs. If any issues are identified, please kindly address the issue to the owner of this repository.

## MIT License

Copyright (c) 2023 Jeremy Josol

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.