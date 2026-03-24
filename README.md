# Avalonia + API Project (Beginner Guide)

This project demonstrates how to build a simple desktop application using **Avalonia UI** and connect it to a backend **ASP.NET Core API**.

---

## 📌 Requirements

Make sure you have the following installed:

* [.NET SDK 8.0](https://dotnet.microsoft.com/download)
* Git
* Linux (WSL) or Windows

---

## 🚀 Step 1: Install Avalonia Templates

Open terminal and run:

```bash
dotnet new install Avalonia.Templates
```

---

## 📁 Step 2: Create the Project

```bash
mkdir Project
cd Project

# Create Avalonia App
dotnet new avalonia.mvvm -n MyApp

# Enter project folder
cd MyApp
```

---

## ⚠️ Step 3: Fix .NET Version

Open the project file:

```bash
nano MyApp.csproj
```

Change this line:

```xml
<TargetFramework>net10.0</TargetFramework>
```

To:

```xml
<TargetFramework>net8.0</TargetFramework>
```

---

## ▶️ Step 4: Run the Application

```bash
dotnet restore
dotnet run
```

You should see a window like:

```
Welcome to Avalonia!
```

---

## 🧩 Step 5: Add ComboBox Example

### Update View (MainWindow.axaml)

```xml
<ComboBox ItemsSource="{Binding Periods}"
          SelectedItem="{Binding SelectedPeriod}" />
```

---

### Update ViewModel

```csharp
public ObservableCollection<string> Periods { get; } = new()
{
    "Daily",
    "Weekly",
    "Monthly",
    "Yearly"
};
```

---

