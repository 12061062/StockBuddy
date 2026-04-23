Timyathus
==================================================================
Roles Held
- Sprint 1 → Product Owner
- Sprint 2 → Scrum Master
- Sprint 3-4 → Developer
- Sprint 5 → Product Owner
- Sprint 6 → Scrum Master
- Sprint 7-8 → Developer
- Sprint 9 → Scrum Master
- Sprint 10 → Product Owner

Tasks Completed 
1. Basic UI Framework
  - Created the initial layout and navigation structure for the application.
2. Cart Editing Functionality
  - Implemented the ability to remove items from the POS cart for corrections.
3. Remove Inventory Items
  - Implemented the ability to remove products from the database.
4. Product Search Feature
  - Implemented manual product search by name or SKU when barcode scanning fails.
5. Sales Transaction Tracking 
  - Implemented tracking and logging of completed sales transactions.
6. Automated Testing Integration 
  - Integrated automated testing into GitHub Actions for CI workflow.
7. Build/Test Notification System 
  - Implemented notifications to alert developers when builds or tests fail.
8. Input Validation and Sanitization 
  - Implemented validation to prevent invalid or malicious user input.
9. Serverless Refactoring 
  - Refactored a feature into a standalone function to simulate a serverless (FaaS) approach.
10. User Manual Documentation 
  - Created a complete user manual describing how to use the StockBuddy system.
    
Matching User Stories 
- “As a cashier, I want to edit the cart (change quantity or remove items) so mistakes can be corrected.”
- “As a cashier, I want to search for products by name or SKU if barcode scanning fails.”
- “As a manager, I want to edit or deactivate products so inventory stays accurate.”
- “As a system, I want to validate user input to prevent errors and security issues.”
- “As a user, I want clear documentation so I can understand how to use the system.”
- “As a developer, I want to refactor features into standalone functions so that the system can support a serverless (FaaS) architecture.”
- “As a user, I want a detailed user manual so that I can effectively use all system features.”

Lessons Learned - Product Development
- Providing fallback functionality improves system reliability.
- UI frameworks should be flexible enough to scale with additional features.
- Input validation is critical for maintaining system security and stability.
- Clear documentation significantly improves usability and user experience.

Lessons Learned - Scrum
- Accurate task estimation improves sprint planning.
- Frequent communication reduces development delays.
- Automated testing improves team efficiency and reduces manual work.
- Strong coordination between roles improves final deliverable quality.

Challenges, Issues, and Resolutions
- Challenge: Ensuring the search feature returned accurate and fast results.
- Resolution: Optimized database queries and refined search logic.
- Challenge: Handling validation without breaking existing functionality.
- Resolution: Carefully tested and refined validation rules to maintain system behavior.
- Challenge: Refactoring features into standalone functions without affecting system behavior.
- Resolution: Incrementally tested and validated each component during refactoring.

Open Issues/Concerns
- Add filtering and advanced search options for better usability
- Improve validation feedback for users (clearer error messages)
- Expand documentation and user guidance for more complex features
- Further refine modular and event-driven architecture components
- Improve overall UI/UX consistency across advanced features
