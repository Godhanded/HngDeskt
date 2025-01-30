# Project Name

A **C# .NET MAUI** application for **desktop and mobile development**.

## 📌 Repository Overview
This repository contains all the necessary files for building and running a **.NET MAUI** application across multiple platforms. Follow the setup instructions below to clone, configure, and run the project successfully.

## 📂 Project Structure
```
📂 HngDeskt.Maui/
├── 📁 Models/
├── 📁 Pages/
├── 📁 PageModels/
├── 📁 Services/
├── MauiApp.csproj
├── README.md          # You're here!
└── ...                # Other project files
```

---

## 🚀 Getting Started
### 🔹 Prerequisites
Before cloning and running the project, ensure you have the following installed:
- .NET SDK (latest version) [Download .NET](https://dotnet.microsoft.com/en-us/download/dotnet/)
- Visual Studio 2022 (with .NET MAUI workload) [Download VS](https://visualstudio.microsoft.com/)
- Git (for version control) [Download Git](https://git-scm.com/)

### 📥 Clone the Repository
To get the latest version of this project, run the following command:
```sh
git clone https://github.com/Godhanded/HngDesktop.git
cd HngDesktop
```

### ⚙️ Setup & Dependencies
Restore all necessary dependencies using:
```sh
dotnet restore
```

### 🏗️ Build the Application
To build the application for **all platforms**, use:
```sh
dotnet build
```
For a **specific target platform**, you can run:
```sh
# Windows
dotnet build -t:Run -f net8.0-windows

# Android
dotnet build -t:Run -f net8.0-android

# iOS (Mac required)
dotnet build -t:Run -f net8.0-ios
```

### ▶️ Run the Application
To run the app on your development machine, use:
```sh
dotnet maui run
```
For **Android Emulators** or **iOS Simulators**, ensure a device is running and specify the platform:
```sh
dotnet maui run android

dotnet maui run ios
```

---

## 🔗 Links & References
- 📂 **GitHub Directory**: [View Source Code](https://github.com/Godhanded/HngDesktop)
- 📱 **Mobile App**: [Project Info](https://hng.tech/hire)
- 🛠 **HNG Hire**: Connect with top developers [HNG Hire](https://hng.tech/hire)
- [Telex](https://delve.fun/), 
- [Delve](https://delve.fun/) 
- [Mobile Developers](http://hng.tech/hire/mobile-ui-ux-developers) 
- [Android Developers](http://hng.tech/hire/mobile-ui-ux-developers), 
- [iOS Developers](http://hng.tech/hire/mobile-ui-ux-developers))

---

## 🤝 Contributing
If you’d like to contribute to this project, please check out our **[CONTRIBUTING.md](./CONTRIBUTING.md)** guide for best practices and setup instructions.

For any inquiries or discussions, feel free to open an **[issue](https://github.com/Godhanded/HngDesktop/issues)** or contribute via a **pull request**.

🎉 *Happy Coding!* 🎉
