# 🛡️ Abhoya (অভয়া) - Women Safety Desktop Application

A comprehensive, role-based desktop application developed in **C# (Windows Forms)** to manage, track, and monitor safety cases efficiently. This project aims to digitize crime tracking and ensure quick response management for women's safety.

## ✨ Key Features
- **🔒 Role-Based Access Control (RBAC):** - **Admin Mode:** Full access to Add, Update, and manage safety cases.
  - **Public Mode:** Read-only access to view the dashboard and case statuses securely.
- **🚨 Interactive SOS Alert:** An "Ask for Help" emergency button that triggers a 3-burst audio siren (system beep) and a visual emergency warning.
- **💾 Auto-Generating Database:** Powered by **SQLite**. The application automatically creates the database (`AbhoyaDB.sqlite`) and required tables upon the very first run—no manual SQL setup needed!
- **📊 Dynamic Dashboard:** Real-time visual counters for Total Cases, Resolved Cases, and High-Risk Zones.
- **🗂️ Smart Case Management:** Search records via Case ID, update case statuses (Pending, Investigating, Resolved), and view data in a clean, full-row-select DataGridView.

## 🛠️ Technologies Used
- **Language:** C#
- **Framework:** .NET / Windows Forms (WinForms)
- **Database:** SQLite (`System.Data.SQLite`)
- **IDE:** Visual Studio

## 🚀 How to Run the Application

### Option 1: Direct Run (No Visual Studio Required)
1. Download the zipped release file from my Google Drive / Releases.
2. Extract the folder on your PC.
3. Double-click on `Abhoya.exe` to run the app instantly!

### Option 2: For Developers (Source Code)
1. Clone this repository:
   ```bash
   git clone https://github.com/bppritomm/Abhoya-Women-Safety-Desktop-App.git
Open the Abhoya.sln file in Visual Studio.

Go to Tools > NuGet Package Manager and ensure System.Data.SQLite is installed.

Hit Start (or F5) to run the application.

📸 Screenshots
<img width="1273" height="718" alt="image" src="https://github.com/user-attachments/assets/66d8658b-b0f6-41b9-9d2a-b8b7aed3bea8" />


👨‍💻 Developed By

Pritom Halder

LinkedIn:

https://www.linkedin.com/in/pritomhalder/

Facebook:

https://www.facebook.com/bppritomm

"Building technology to make the world a safer place."



Open the Abhoya.sln file in Visual Studio.Go to Tools > NuGet Package Manager and ensure System.Data.SQLite is installed.Hit Start (or F5) to run the application.📸 Screenshots👨‍💻 Developed By$$Pritom Halder$$LinkedIn:$$https://www.linkedin.com/in/pritomhalder/$$Facebook:$$https://www.facebook.com/bppritomm$$"Building technology to make the world a safer place."
