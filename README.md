#  How to create a .NET8 WebAPI for sending messages to AWS SNS

See the source code for this sample in this github repo: https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer

## 1. Create AWS SNS (topic)

To set up Amazon Simple Notification Service (SNS) for use with your application, follow these steps. This guide assumes you have an AWS account and basic familiarity with AWS services

**Step 1**: Sign in to AWS Management Console

Go to the AWS Management Console and sign in

**Step 2**: Create an SNS Topic

Navigate to the SNS Dashboard within the AWS Management Console

Choose Topics from the sidebar and then click Create topic

Select the Standard type for immediate, “at least once” delivery

Enter a Name for your topic, such as mytopic, and optionally provide a display name

Click Create topic. This action creates your SNS topic and displays the topic's details page

**Step 3**: Note the Topic ARN

After creating your topic, you'll be directed to its details page

Here, note the ARN (Amazon Resource Name); you'll need this to publish messages to the topic from your application

**Step 4**: Set Up Permissions (Optional)

In the topic details page, click on the Access policy tab

You can edit the policy directly in JSON or use the Basic view to add permissions via the interface

For most applications, the default policy allows all AWS account users to publish and subscribe. Adjust this according to your security requirements

**Step 5**: Create an IAM User (For Programmatic Access)

If you don't already have an IAM user with permissions to access SNS, follow these steps:

Navigate to the IAM Dashboard within the AWS Management Console

Select Users from the sidebar and then click Add user

Enter a user name and select Programmatic access as the access type

Click Next: Permissions and choose Attach existing policies directly

Search for AmazonSNSFullAccess (for full access) or create a custom policy based on your security requirements and attach it

Click Next: Tags (optional step) and Next: Review

Review your settings and click Create user

Important: Note down the Access key ID and Secret access key on the final page. You'll use these in your application to interact with AWS services

**Step 6**: Update Your Application

Update your application with the SNS topic ARN, and the IAM user's access key ID and secret access key, ensuring they are securely stored and not hard-coded into your application

**Step 7**: Install AWS SDK for .NET

If not already done, install the AWS SDK for .NET in your project to interact with SNS

**Step 8**: Test Your Application

Test your application by sending a message to your SNS topic and verifying that it's received by any subscribers or logging the response to ensure it's sent successfully

**Best Practices**

**Security**: Always follow AWS best practices for security. Use IAM roles where possible and avoid using the root account for programmatic access

**Secrets Management**: Use AWS Secrets Manager or environment variables for managing access keys and secrets

**Monitor and Log**: Utilize AWS CloudWatch to monitor and log SNS usage and operations

Following these steps will get your .NET application integrated with AWS SNS for messaging capabilities

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
