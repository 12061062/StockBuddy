Project Goals
==================================================================
- The primary goal of StockBuddy is to design and implement a functional web-based inventory and POS system for small retail businesses. The system aims to simplify inventory tracking, improve checkout efficiency, and provide business owners with better visibility into their sales and product levels.

Specific Goals
- Develop a POS checkout system that allows users to scan barcodes or manually search for products and add them to a cart.
- Implement automatic tax and total calculations to ensure accurate checkout transactions.
- Provide inventory management capabilities, including adding, removing, and updating product information.
- Implement automatic inventory updates when products are sold to maintain accurate stock levels.
- Provide low-stock alert notifications so managers can reorder products before they run out.
- Ensure secure role-based access control so only authorized users can manage inventory and pricing.
- Maintain a reliable backend database to store product and transaction information.
- Develop a user-friendly interface that allows store employees to quickly process transactions and manage products.

==================================================================

Release Plan
==================================================================
- The StockBuddy system was developed using an iterative Scrum-based release plan over multiple sprints. Each sprint focused on delivering a set of functional features while gradually expanding the system from foundational setup to a complete POS and inventory management application.

**Sprint 1 – Project Setup**
Focus: Establish the development foundation.

Features:
- GitHub repository setup
- Database schema creation
- Basic UI framework
- Jira Scrum board configuration

**Sprint 2 – Checkout Core**
Focus: Implement basic POS checkout functionality.

Features:
- Tax and total calculations
- Cart editing functionality
- Customer receipt generation
- Role-based authentication

**Sprint 3 – Inventory Backend**
Focus: Implement core inventory database operations.

Features:
- Add products to the inventory database
- Remove products from the inventory database
- Sales transaction table
- Automatic stock level updates after sales

**Sprint 4 – Checkout Usability**
Focus: Improve checkout workflow and system usability.

Features:
- Product search by name or SKU
- Barcode scanner integration
- UI consistency improvements
- Low-stock alert notifications

**Sprint 5 – Reporting Features**
Focus: Provide insights into sales and inventory performance.

Features:
- Basic Sales Reporting
- Track Sales Transactions
- Database updates product levels based on sales transactions
- Fully implement view stock level reporting
  
**Sprint 6 – DevOps / CI Implementation**
Focus: Improve development workflow and automation.

Features:
- Update GitHub repository with automated testing file
- Add automated testing to GitHub Actions
- Improve workflow so code changes are tested immediately after development
- Reduce the number of steps required to run and test the app
  
**Sprint 7 – DevOps2 / Feedback Loops**
Focus: Improve reliability, feedback, and system stability.

Features:
- Enhance test result output to improve readability and clarity
- Implement notifications for failed builds/tests
- Improve existing test cases based on previous failures
- Identify and resolve recurring system defects
  
**Sprint 8 – Security Enhancements**
Focus: Improve system security and data protection.

Features:
- Hash and securely store user credentials
- Sanitize input fields to reduce injection risks
- Ensure sensitive data is not exposed in logs or error messages
- Reinforce role-based access control across the system
  
**Sprint 9 – Emerging Architectures**
Focus: Explore event-driven and serverless architecture concepts.

Features:
- Trigger functions based on user actions (checkout | inventory | logging)
- Refactor a feature into a standalone function (FaaS simulation)
- Identify system components for event-driven architecture
- Document transition to serverless architecture
  
**Sprint 10 – Finalization & Delivery**
Focus: Prepare the system for final delivery and demonstration.

Features:
- Perform final system testing
- Create user manual/documentation
- Display system metrics (total sales, items sold)
- Clean up and refactor code for maintainability
