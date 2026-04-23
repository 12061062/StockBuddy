Jason
==================================================================
Roles Held
- Sprint 1-2 → Developer
- Sprint 3 → Product Owner
- Sprint 4 → Scrum Master
- Sprint 5-6 → Developer
- Sprint 7 → Product Owner
- Sprint 8 → Scrum Master
- Sprint 9-10 → Developer

Tasks Completed 
1. GitHub Repository Setup
  - Configured version control structure for collaboration.
2. Receipt Generation
  - Implemented system functionality to send a customer receipt after checkout.
3. Sales Transaction Table
  - Implemented a database structure to store completed sales transactions.
4. Barcode Scanner Integration
  - Implemented barcode scanning so scanned products automatically populate the cart.
5. Inventory Updates After Sales 
  - Ensured database correctly updates product levels after completed transactions.
6. CI Workflow Improvements 
  - Improved workflow so code changes are automatically tested after development.
7. Test Case Improvements 
  - Enhanced existing test cases based on previous failures to reduce recurring bugs.
8. Sensitive Data Protection 
  - Ensured sensitive data is not exposed in logs or error messages.
9. Event-Driven Architecture Identification
  - Identified parts of the system that could be converted into event-driven functions.
10. System Metrics Implementation 
- Implemented system metrics such as total sales and items sold within the application.

Matching User Stories 
- “As a cashier, I want to receive a printed or digital receipt after checkout.”
- “As a cashier, I want to scan product barcodes so items are added to the cart automatically.”
- “As a cashier, I want to complete a sale so the transaction is recorded in the system.”
- “As a manager, I want to view system metrics so I can monitor business performance.”
- “As a system, I want to securely handle and protect sensitive data.”
- “As a developer, I want to identify parts of the system that can be converted into event-driven functions so that the system can be more scalable and modular.”
- “As a manager, I want to view basic system metrics (total sales, items sold) so that I can monitor business performance.”

Lessons Learned - Product Development
- Hardware integrations such as barcode scanners require additional testing to ensure accurate product identification.
- Database transaction tracking is important for maintaining accurate sales records.
- Protecting sensitive data is critical for system security and reliability.
- Implementing system metrics provides valuable insights into system performance and business operations.

Lessons Learned - Scrum
- Role rotation (Product Owner / Scrum Master) helps all team members understand project coordination responsibilities.
- Continuous integration improves development speed and feedback cycles.
- Improving tests over time reduces recurring system defects.
- Iterative improvements across sprints help refine both system features and development processes.

Challenges, Issues, and Resolutions
- Challenge: Ensuring scanned barcodes correctly matched the database records.
- Resolution: Performed additional testing and validation for barcode input to correctly match product IDs.
- Challenge: Ensuring accurate inventory updates after transactions.
- Resolution: Improved database transaction handling and validation logic.
- Challenge: Identifying appropriate components for event-driven architecture.
- Resolution: Analyzed system workflows and separated key functional components for modular design.

Open Issues/Concerns
- Improve reporting and analytics features for better business insights.
- Expand monitoring/logging for debugging and performance tracking.
- Improve scalability for future system growth.
- Further refine event-driven architecture implementation
- Enhance performance optimization for handling larger datasets
