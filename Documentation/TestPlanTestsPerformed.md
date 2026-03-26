StockBuddy is tested using a combination of manual testing, automated testing, and integration testing. Functional testing is performed to ensure that key features such as scanning items, adding products, completing transactions, and updating inventory operate correctly. Input validation and error handling are also tested to confirm the system behaves properly with invalid or unexpected data.

Automated testing is implemented through GitHub Actions, which runs builds and executes unit tests on every push and pull request. This continuous integration pipeline ensures that new changes do not break existing functionality and helps maintain code quality throughout development.

Integration testing is used to verify that the user interface, database operations, and business logic work together correctly during real transaction workflows. Additionally, MSTest is used to perform unit tests on checkout processes, ensuring accurate calculations and reliable transaction handling.
