Daniel
==================================================================
Roles Held
- Sprint 1 → Scrum Master
- Sprint 2 → Product Owner
- Sprint 3-4 → Developer
- Sprint 5 → Scrum Master
- Sprint 6 → Product Owner
- Sprint 7-8 → Developer
- Sprint 9 → Product Owner
- Sprint 10 → Scrum Master

Tasks Completed 
1. Jira Board Creation and Configuration
  - Set up the SCRUM board to manage backlog, sprint tasks, and workflow tracking.
2. Role-Based Authentication
  - Implemented system permissions so only authorized roles can manage their role’s functionalities.
3. Inventory Stock Level Management
  - Implemented backend logic to update inventory quantities automatically after transactions.
4. Low Stock Alert System
  - Implemented notifications when the inventory falls below a threshold.
5. Stock Level Reporting 
  - Implemented UI and logic to display inventory stock levels for reporting purposes.
6. Workflow Optimization 
  - Reduced the number of steps required to run and test the application, improving development efficiency.
7. Bug Identification and Resolution 
  - Identified and resolved recurring system defects to improve stability.
8. Security – Role-Based Access Reinforcement 
  - Strengthened role-based access control across all system features.
9. Serverless Architecture Documentation 
  - Documented how the system could transition to a serverless architecture and identified opportunities for event-driven design.
10. Code Refactoring and Cleanup
  - Cleaned up and refactored the codebase to improve readability, maintainability, and final system quality.

Matching User Stories 
- “As a manager, I want role-based access so only authorized users can manage inventory and pricing.”
- “As a manager, I want inventory to automatically update when a sale is completed.”
- “As a manager, I want to receive low-stock alerts so I can reorder items in time.”
- “As a system, I want to store and manage transaction and product data so the system functions reliably.”
- “As a manager, I want to view stock levels so I can monitor inventory.”
- “As a developer, I want to improve system reliability and maintainability so the system is stable and efficient.”
- “As a developer, I want to document how the system can transition to a serverless architecture so that it can scale and adapt to modern deployment models.”
- “As a developer, I want to refactor and clean up code so that the system is maintainable, readable, and ready for final delivery.”
- “As a system, I want to ensure all features are stable and fully tested so that the application is reliable for end users.”

Lessons Learned - Product Development
- Alert systems must balance usefulness without overwhelming users with notifications.
- Inventory logic must handle edge cases such as rapid repeated checkout actions.
- Clean and well-structured code improves long-term maintainability.
- Proper documentation is important for understanding architectural changes such as transitioning to serverless systems.

Lessons Learned - Scrum
- Having a properly configured Jira board improves sprint tracking and task clarity.
- Clear backlog organization improves development efficiency.
- Reducing manual workflow steps improves team productivity.

Challenges, Issues, and Resolutions
- Challenge: Stock levels were not updating correctly when checkout was triggered repeatedly.
- Resolution: Adjusted transaction logic to make sure inventory updates only occur after confirmed sales transactions.
- Challenge: Difficulty formatting stock/reporting data clearly in the UI.
- Resolution: Improved layout and data presentation for readability.

Open Issues/Concerns
- Improve visualization and formatting of reporting features.
- Expand monitoring/logging for better debugging and system insight.
- Further refine performance and scalability (especially for future architecture changes).
- Continue improving event-driven functionality for better system responsiveness
- Explore scalability of serverless architecture for real-world deployment
