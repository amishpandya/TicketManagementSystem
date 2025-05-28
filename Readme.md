## 🚀 Getting Started with TicketManagementUI

Follow these steps to set up and run the project in Visual Studio:

### ✅ Setup Instructions

1. **Open the Solution**  
   Open the `.sln` file of `TicketManagementSystem` in Visual Studio.

2. **Set the Startup Project**  
   In the **Solution Explorer**, right-click on `TicketManagementUI` →  
   **Set as Startup Project** (make sure `Domain` is not selected as startup).

3. **Configure the Database Connection**  
   Open `appsettings.json` and update the database connection string with your SQL Server credentials.

4. **Apply Migrations to Database**  
   - Go to **Tools** → **NuGet Package Manager** → **Package Manager Console**  
   - Run the following command:  
     ```
     Update-Database
     ```

5. **Run the Application**  
   Press `F5` or click **Start** to run the project.

---

### 🔐 Test Login Credentials

Use the following credentials to log in:

- **Email:** `Test@gmail.com`  
- **Password:** `NeedReset%123`
