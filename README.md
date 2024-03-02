#  How to create a .NET8 WebAPI for sending messages to AWS SNS

See the source code for this sample in this github repo: https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer

## 1. Create AWS SNS (topic)



## 2. Create a .NET8 WebAPI with VSCode

Creating a .NET 8 Web API using Visual Studio Code (VSCode) and the .NET CLI is a straightforward process

This guide assumes you have .NET 8 SDK, VSCode, and the C# extension for VSCode installed. If not, you'll need to install these first

**Step 1: Install .NET 8 SDK**

Ensure you have the .NET 8 SDK installed on your machine: https://dotnet.microsoft.com/es-es/download/dotnet/8.0

You can check your installed .NET versions by opening a terminal and running:

```
dotnet --list-sdks
```

If you don't have .NET 8 SDK installed, download and install it from the official .NET download page

**Step 2: Create a New Web API Project**

Open a terminal or command prompt

Navigate to the directory where you want to create your new project

Run the following command to create a new Web API project:

```
dotnet new webapi -n ServiceBusSenderApi
```

This command creates a new directory with the project name, sets up a basic Web API project structure, and restores any necessary packages

**Step 3: Open the Project in VSCode**

Once the project is created, you can open it in VSCode by navigating into the project directory and running:

```
code .
```

This command opens VSCode in the current directory, where . represents the current directory

## 3. Load project dependencies

We run this command to add the Azure Service Bus library

```
dotnet add package 
```

We also have to add the Swagger and OpenAPI libraries to access the API Docs

This is the csproj file including the project dependencies



## 4. Create the project structure


## 5. Create the Controller

```csharp

```

## 6. Modify the application middleware(program.cs)

```csharp

```

## 7. Run and Test the application

We execute this command to run the application

```
dotnet run
```

We navigate to the application endpoint: 


After executing the above request we get this response



We confirm in the AWS SNS we recevied the message



We navigate to the subscription and see the received message



See also the custom message property we added to the message
