#  Smart Greenhouse – Monitoring System  
A .NET MAUI Application

The **Smart Greenhouse – Monitoring System** is a cross-platform .NET MAUI application that simulates real-time monitoring and control of a greenhouse environment.  
The app displays dynamic sensor values such as temperature, humidity, and soil moisture, and includes actuator controls for a fan and water pump.  
The project also demonstrates integrated MAUI native features and a basic security mechanism.


##  Features

###  Real-Time Sensor Simulation
- Automatically updating temperature, humidity, and soil moisture values  
- Simulated through a built-in timer  
- Clean dashboard layout for easy visibility

###  Actuator Control
- Toggle ON/OFF buttons for:
  - Fan  
  - Water pump  
- UI updates instantly to reflect actuator status

###  Security Feature
- The login screen restricts access to the main application  
- User credentials (or session tokens) stored using **SecureStorage**, a native MAUI feature

###  Native Feature Integration
- Uses **SecureStorage** to manage sensitive data securely  
- Demonstrates how MAUI interacts with device-level capabilities

###  Cross-Platform Support
- Runs on **Windows**, **Android**, and **macOS** (if enabled)  
- Responsive UI built with MAUI XAML pages


##  Technology Stack

- **Framework:** .NET MAUI  
- **Language:** C#  
- **UI:** XAML pages with MVVM 
- **Data:** Local in-app simulation  
- **Native Integration:** SecureStorage

---

##  How to Build and Run the Project

Follow the steps below to set up, build, and run the Smart Greenhouse application.

---

### 1. Install Required Software

You must install:

1. **Visual Studio 2022** (latest version)  
2. Required workloads:
   -  **.NET Multi-platform App UI development**
3. The correct **.NET SDK** version (e.g., .NET 8)

---

### 2. Get the Project Code

Clone the repository:

`bash
(https://github.com/Aaroies/SmartGreenhouse.git)

----

3. Open the Solution in Visual Studio
   
-Open Visual Studio 2022
-Select File → Open → Project/Solution…
-Choose the solution file: SmartGreenhouse.sln
-Let Visual Studio restore NuGet packages automatically.

---

4. Build the Application
   
-Right-click the solution → Set Startup Project → select the main MAUI app
-At the top toolbar, choose your target: Windows Machine (WinUI) — easiest for testing
-Go to Build → Build Solution
-Ensure the build completes with no errors.

----

5. Run the Application
-Click the Start button
-The Smart Greenhouse app will launch
-Navigate the app to test:

App Sections:

* Login Page:
  
-Enter username and password
-Credentials validated inside the app
-SecureStorage stores session state securely

* Dashboard:
  
-Displays dynamic simulated values:
                                   Temperature
                                   Humidity
                                   Soil Moisture
-Values update automatically on a timer

* Controls
-Toggle the Fan and Water Pump
-App updates the actuator state visually

* Project Structure (High-Level)

/SmartGreenhouse
│
├── App.xaml / App.xaml.cs             # Application root
├── MainPage.xaml / MainPage.xaml.cs   # Dashboard UI
│
├── Pages/                             # Login page, Controls page, etc.
│   ├── LoginPage.xaml
│   ├── DashboardPage.xaml
│   └── ControlsPage.xaml
│
├── Models/                            # Sensor + actuator model classes
│   ├── SensorData.cs
│   └── ActuatorState.cs
│
├── Services/                          # Timer simulation + SecureStorage
│   ├── SensorSimulationService.cs
│   └── AuthService.cs
│
└── Resources/                         # Fonts, images, raw assets

 * Authors
Eunice Shaji - A00322510
Aaron Paul - A00320233

