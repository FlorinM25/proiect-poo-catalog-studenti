Student Catalog Management System
=================================

This repository contains a C# project for managing a student catalog, including adding, updating, and viewing student data. The project leverages Windows Forms for the user interface and follows a Model-View-ViewModel (MVVM) architecture.

Here is a video demonstration of the project:

![Demo Video](DemoVideo.mp4)

Table of Contents
-----------------

-   [Project Structure](#project-structure)
-   [Features](#features)
-   [Getting Started](#getting-started)
-   [Usage](#usage)
-   [Contributing](#contributing)
-   [License](#license)

Project Structure
-----------------

The project is organized into the following directories and files:

-   **.git/**: Git version control directory.
-   **CatalogStudenti/**: Main directory containing the student catalog management system.
    -   **CatalogViewModel/**: ViewModel files for managing the data and UI logic.
    -   **Model/**: Contains the model classes that represent the data structures.
    -   **Properties/**: Project properties and settings.
    -   **Resources/**: Contains resource files for localization and other static resources.
    -   **obj/**, **bin/**: Output directories for compiled binaries and object files.
    -   **.vs/**: Visual Studio-specific settings.
    -   **AdaugaDatele.cs**: Code file for the "Add Data" form.
    -   **AdaugaDatele.Designer.cs**: Designer file for the "Add Data" form.
    -   **Catalog.cs**: Code file for the "Catalog" form.
    -   **Catalog.Designer.cs**: Designer file for the "Catalog" form.
    -   **Meniu.cs**: Code file for the "Menu" form.
    -   **Meniu.Designer.cs**: Designer file for the "Menu" form.
    -   **Program.cs**: Main entry point of the application.
    -   **AdaugaDatele.resx**, **Catalog.resx**, **Meniu.resx**: Resource files for the respective forms.
    -   **CatalogStudenti.sln**: Solution file for the project.
    -   **CatalogStudenti.csproj**: Project file containing build configurations.
-   **media-utils/**: Directory for media utilities (e.g., images, icons).
-   **New folder**: Placeholder for additional content or structure (rename as needed).
-   **Demo1ProiectPOO**, **Demo2ProiectPOO**: Demo projects for Object-Oriented Programming courses.
-   **README**: Readme file for repository documentation.

Features
--------

-   **Student Data Management**: Add, update, and view student records.
-   **User-Friendly Interface**: Easy-to-use Windows Forms interface.
-   **Modular Architecture**: Follows the MVVM pattern for maintainable and testable code.
-   **Localization**: Resource files for easy localization and customization.

Getting Started
---------------

### Prerequisites

-   .NET Framework or .NET Core installed on your machine.
-   Visual Studio or any C# compatible IDE.

### Installation

1.  Clone the repository to your local machine:
    ```sh
    `git clone https://github.com/yourusername/student-catalog-management.git`

3.  Open the solution file in Visual Studio:
    `cd student-catalog-management
    ; start CatalogStudenti.sln`

5.  Restore the NuGet packages and build the solution.

Usage
-----

1.  **Running the Application**: Start the application by running the `Program.cs` file from Visual Studio.
2.  **Adding Student Data**: Use the "Add Data" form to input new student information.
3.  **Viewing and Updating Data**: Use the "Catalog" form to view and manage existing student records.
4.  **Navigating the Menu**: Use the "Menu" form for navigating between different functionalities of the application.

Contributing
------------

Contributions are welcome! If you have any suggestions or improvements, please fork the repository, create a new branch, and submit a pull request.

1.  Fork the Project
2.  Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3.  Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4.  Push to the Branch (`git push origin feature/AmazingFeature`)
5.  Open a Pull Request

License
-------

This project is licensed under the MIT License. See the LICENSE file for more details.
