# Pierre's Sweets

#### By Caleb Coughenour

## This is a MVC webpage that allows users to create an account and add flavors and/or treats to a database.

## Technologies Used

* C#
* HTML
* CSS
* SQL Workbench
* ASP.NET
* Entity Framework
* REPL
* MVC
* Identity

## Description

 This webpage utilizes Identity and was programmed using C#, ASP.NET & Entity. The homepage will display treats and flavors in separate lists on the splash page that are clickable to view details. The database uses a many-to-many relationship that allows the user to add flavors to treats and treats to flavors. If you click on the details of a flavor/treat the page will also display the linked treat/flavor. The user must create an account if they want to create, edit or delete any stored treats/flavors.

## Required

* [REPL](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.401-windows-x64-installer) - restart terminal after install
* .NET (install using "dotnet tool install -g dotnet-script" in console)
    - Configure Bash environment variables by running "echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.bash_profile" in your gitbash terminal
* [SQL Workbench](https://downloads.mysql.com/archives/get/p/25/file/mysql-installer-web-community-8.0.19.0.msi)
    - You will need to include your password in the appsettings.json file

## Setup/Installation

* Copy the git repository url from the "code" drop down on this github page
* Open a shell program & navigate to your desktop
* Clone the repository using the copied URL and the "git clone" command
* In the shell program, navigate to the root directory of the newly created file called "PierresSweets.Solution"
* From the root directory, navigate to the directory named "PierresSweets"
* In this directory create a file named "appsettings.json"
* Add the following code to the newly created .json file
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=caleb_coughenour;uid=root;pwd=[YOUR-PASSWORD];"
  }
}
```
* Replace "[YOUR-PASSWORD]" with your SQL password
* Once your .json file is set up, run the command "dotnet ef migrations add Initial"
* After this command finishes, run the command "dotnet ef database update"
* Next, in the PierresSweets directory type "dotnet run" to start the program
* Open a web browser and plug "http://localhost:5000/" into the URL bar

## Known Bugs

* No known issues

## License

[MIT](LICENSE)

Copyright (c) 6/3/22 Caleb Coughenour