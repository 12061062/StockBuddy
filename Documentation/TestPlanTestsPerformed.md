StockBuddy was tested using a combination of manual testing, automated testing, unit testing, and integration testing to ensure the system is functional, reliable, and stable across all features.

Test Plan
==================================================================
The testing strategy focused on validating all core system components:
- POS checkout functionality
- Inventory management operations
- Database integrity and updates
- UI behavior and usability
- Security features such as authentication and input validation
  
Testing was performed continuously throughout development and expanded in later sprints with automation and CI/CD integration.

Tests Performed and Test Types
==================================================================
**1. Unit Testing**

Unit tests were created to verify individual components and logic, including:
- Tax and total calculation accuracy
- Cart functionality and checkout behavior
- Inventory updates after sales
- Prevention of negative stock levels
- Validation of SKU uniqueness
- Event-driven function execution (Sprint 9)
- Final system validation of all features (Sprint 10)
  
**2. Functional Testing**

Functional testing was performed to ensure the system behaves correctly from a user perspective:
- Scanning items and adding them to the cart
- Editing cart items and completing transactions
- Receipt generation after checkout
- Product search functionality (name/SKU fallback)
- Low-stock alert triggering
- Reporting and metrics display
  
**3. Integration Testing**

Integration testing verified that multiple system components work together correctly:
- Checkout | transaction recording | inventory update workflow
- Barcode scanning | database lookup | cart update
- Reporting features pulling correct data from the database
- UI interaction with backend logic
  
**4. Automated Testing and CI/CD**

Automated testing was implemented using GitHub Actions:
- Tests run automatically on every push and pull request
- Ensures new code does not break existing functionality
- Provides immediate feedback to developers
- Improved test result readability
- Notifications when builds/tests fail
- Expanded test coverage based on previous failures

Test Analysis/Results
==================================================================
Overall, testing results showed that the system is stable, reliable, and functionally complete:

- Core features such as checkout, inventory updates, and reporting function correctly
- Automated testing and CI significantly reduced bugs and improved development efficiency
- Integration testing confirmed that all system components work together seamlessly
- Security testing ensured proper handling of credentials and input validation

Remaining areas for improvement:

- Expanding automated test coverage for edge cases
- Improving performance testing for scalability
- Enhancing test reporting and monitoring for future development
