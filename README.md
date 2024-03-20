How to do migration?

In Visual Studio go to **Tools** -> **Nuget Package Manager** -> **Package Manager Console**

in the terminal enter:

`add-migration <name_of_migration>`

after it is executed enter:

`update-database`
