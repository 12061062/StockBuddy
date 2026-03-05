# StockBuddy

StockBuddy is a desktop point-of-sale (POS) and inventory management system designed for small businesses. The application allows users to scan products using a barcode scanner, manage inventory, and complete customer transactions from a single platform.

The goal of StockBuddy is to provide a simple and affordable solution for small retail environments that need basic checkout and inventory management functionality.

# Features

Barcode scanning for fast checkout

Automatic transaction total calculation

Inventory tracking and stock management

Product management (add, edit, remove items)

Receipt generation and email delivery

Low stock reorder alerts

# Technology Stack

Language: C#

Framework: .NET Windows Forms

Database: SQLite

Version Control: Git / GitHub

Development Environment: Visual Studio

# Deployment Environment

StockBuddy runs as a Windows desktop application using a local SQLite database. The database is stored as a single file, allowing the system to run on a single machine without requiring a separate database server.

More details are available in:

Documentation/DeploymentEnvironment.md

# Repository Structure
The repository is organized into several main sections:

StockBuddy/ – Contains the main application source code for the Windows Forms POS and inventory system.

StockBuddy.Tests/ – Contains unit tests used to validate important application logic and functionality.

Documentation/ – Contains all project documentation, including coding standards, deployment environment, version management, UI/UX design, test plans, and diagrams such as the database design, system architecture, and process flow diagrams.

Documentation/Sprints/ – Contains sprint artifacts related to the Agile Scrum development process, including sprint reports and the SCRUM board.

README.md – Provides an overview of the project, features, technology stack, and links to relevant documentation.

# Testing

Unit tests are located in the StockBuddy.Tests project and are used to validate important application logic. The project also includes manual testing and planned integration testing to verify that the user interface, database operations, and business logic work together correctly.

More information can be found in:

Documentation/TestPlanTestsPerformed.md

# Agile Development

StockBuddy is developed using an Agile Scrum process with iterative sprints. Sprint artifacts, reports, and SCRUM boards are stored in:

Documentation/Sprints/

# Additional Documentation

Additional project documentation, including system architecture, database design, process flow diagrams, and UI/UX design materials, can be found in the Documentation folder of this repository.
