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
Public Login:
<img width="1268" height="730" alt="Screenshot 2026-03-09 070510" src="https://github.com/user-attachments/assets/bbdbedde-62fe-45d7-b639-d99d2ace388d" />
Admin Login:
<img width="1271" height="723" alt="Screenshot 2026-03-09 070555" src="https://github.com/user-attachments/assets/995331d5-6208-4a1c-9105-ffb02b8befc3" />
<img width="1278" height="709" alt="Screenshot 2026-03-09 070623" src="https://github.com/user-attachments/assets/980a5086-b954-46c4-bc06-33a63b106e78" />

<img width="1267" height="707" alt="Screenshot 2026-03-09 070648" src="https://github.com/user-attachments/assets/9ef6d664-d138-4618-9071-dd30334741eb" />



👨‍💻 Developed By

Pritom Halder

LinkedIn:

https://www.linkedin.com/in/pritomhalder/

Facebook:

https://www.facebook.com/bppritomm

"Building technology to make the world a safer place."



