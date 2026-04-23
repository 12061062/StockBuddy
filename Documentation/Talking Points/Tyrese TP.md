Tyrese
==================================================================
Roles Held
- Sprint 1-2 → Developer
- Sprint 3 → Scrum Master
- Sprint 4 → Product Owner
- Sprint 5-6 → Developer
- Sprint 7 → Scrum Master
- Sprint 8 → Product Owner
- Sprint 9-10 → Developer

Tasks Completed 
1. Database Schema Creation
  - Designed relational database structure for products, users, and transactions.
2. Checkout Tax and Total Calculations
  - Implemented automatic calculation of taxes and totals during checkout.
3. Add Inventory Items
  - Implemented functionality to add new products to the inventory database.
4. UI Consistency Improvements
  - Standardized UI design across all application pages.
5. Basic Sales Reporting 
  - Implemented reporting features to display sales data and trends.
6. Automated Testing Setup 
  - Configured automated testing files within the repository for CI integration.
7. Test Output Improvements 
  - Improved readability and clarity of test results for better debugging.
8. Secure Credential Handling 
  - Implemented password hashing to securely store user credentials.
9. Event-Driven Function Implementation 
  - Implemented triggering of functions based on user actions (checkout, inventory updates, transaction logging).
10. Final System Testing
  - Performed comprehensive testing to ensure all system features function correctly and reliably.

Matching User Stories 
- “As a cashier, I want the system to calculate tax, totals, and change due so that checkout is accurate.”
- “As a manager, I want to add new products so they can be sold and tracked.”
- “As a system, I want to store product and transaction data so information persists.”
- “As a developer, I want automated testing so the system is reliable and stable.”
- “As a system, I want to securely store user credentials to protect user data.”
- “As a system, I want to trigger functions based on user actions so that processes like checkout and inventory updates occur automatically.”
- “As a developer, I want to perform final system testing so that all features are verified and the system is ready for delivery.”

Lessons Learned - Product Development
- Designing the database structure early improves scalability and integration with later features.
- Maintaining UI consistency early prevents future redesign work.
- Security features such as hashing are essential for protecting sensitive data.
- Thorough testing is critical to ensuring a stable and reliable final product.
  
Lessons Learned - Scrum
- Unit testing during development helps detect errors earlier.
- Frequent commits and code reviews improve collaboration.
- CI/CD practices improve workflow efficiency and reliability.
- Iterative testing and refinement improve overall system quality.

Challenges, Issues, and Resolutions
- Challenge: Duplicate SKU values were entering the system.
- Resolution: Added validation logic to ensure SKU uniqueness in the database.
- Challenge: Issues with authentication after implementing hashing.
- Resolution: Adjusted login and credential validation logic to ensure compatibility.
- Challenge: Ensuring event-driven functions triggered correctly across workflows.
- Resolution: Tested and validated each function trigger to ensure correct execution flow.
  
Open Issues/Concerns
- Expand automated testing coverage across more system features
- Improve reporting visualization and filtering options
- Further refine performance and scalability for future enhancements
- Continue improving event-driven functionality and system responsiveness
- Enhance system monitoring and logging for better debugging
