# CPW219-MVC-Core-CRUD-WithBugs
We have a project with errors that must be fixed! This is supposed to be a simple CRUD
application for Student data. Unfortunately, we did not use source control before and
a former employee messed up some code and left us with an app that doesn't compile. Your
task is to debug this application and fix the errors. Do not start the project over from scratch,
do not scaffold a new controller over the existing one. We must learn to fix bugs like this

## Requirements
- .NET 9 and VS 2022

## Your tasks
- First task is to fix the compile time issues so the project will build
- Run the code first migrations to create the database (the migrations are already present and the database will be seeded with data)
- Ensure that the navigation links work
    - The home link should go to the default page in the Home controller
    - The students link should go to the Index of the Students controller
- Ensure all CRUD pages work and data is saved correctly to the database
  - [ ] Ensure the index page shows a paginated list of students
  - [ ] Ensure the edit page updates the existing student records
  - [ ] Ensure details show the correct information for the selected record
  - [ ] Ensure delete removes the student from the database correctly
