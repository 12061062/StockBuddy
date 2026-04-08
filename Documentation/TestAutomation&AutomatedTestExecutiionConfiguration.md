StockBuddy implements automated testing using unit tests written with MSTest to validate core application logic such as cart operations, total calculations, and item management. These tests help ensure that key functionality remains correct as new features are added or changes are made to the system.

Automated test execution is configured using GitHub Actions. A workflow is defined in the .github/workflows directory that automatically runs on every push and pull request to the repository. This workflow restores project dependencies, builds the solution using MSBuild, and executes the unit tests using the Visual Studio test runner.

This continuous integration setup ensures that code changes are automatically tested, helping to quickly identify errors and maintain overall code quality throughout development.
