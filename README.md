#  How to create a .NET8 WebAPI for sending messages to AWS SNS

See the source code for this sample in this github repo: https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer

## 1. Create AWS SNS (topic)

To set up Amazon Simple Notification Service (SNS) for use with your application, follow these steps. This guide assumes you have an AWS account and basic familiarity with AWS services

**Step 1: Sign in to AWS Management Console**

Go to the AWS Management Console and sign in

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/c8103e96-d172-4ad4-a6c3-f5119af528ea)

**Step 2: Create an SNS Topic**

Navigate to the **SNS** Dashboard within the AWS Management Console

Choose Topics from the sidebar and then click Create topic

Select the **Standard** type for immediate, “at least once” delivery

Enter a Name for your topic, such as **mytopic**, and optionally provide a display name

Click Create topic. This action creates your SNS topic and displays the topic's details page

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/6e0b3d63-ec74-4b4c-95ca-58093fef0323)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/3a7b5c40-26b0-4893-bcb5-9af35516a91e)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/815db1de-bc4a-4c23-9bf6-5f82f558ad46)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/134caa95-450c-4cff-902c-49f70c7012b4)

**Step 3: Note the Topic ARN**

After creating your topic, you'll be directed to its details page

Here, note the **ARN (Amazon Resource Name)**; you'll need this to publish messages to the topic from your application

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/c369f935-e09f-457e-a159-7b552c143db8)

**Step 4: Set Up Permissions (Optional)**

In the topic details page, click on the Access policy tab

You can edit the policy directly in JSON or use the **Basic** view to add permissions via the interface

For most applications, the default policy allows all AWS account users to publish and subscribe. Adjust this according to your security requirements

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/45cb4891-028e-4be8-a6e4-d5b0ec76b8e1)

**Step 5: Create an IAM User (for Programmatic Access)**

If you don't already have an IAM user with permissions to access SNS, follow these steps:

Navigate to the **IAM** Dashboard within the AWS Management Console

Select Users from the sidebar and then click **Add user**

Enter a **user name** and select Programmatic access as the access type

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/dba165d2-e931-4da7-bb0a-ee209ec8200e)

Click Next: Permissions and choose Attach existing policies directly

Search for **AmazonSNSFullAccess (for full access)** or create a custom policy based on your security requirements and attach it

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/55568a3f-66cd-47f0-8ae7-f36d0facb0ce)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/7ccd339d-d267-4982-b545-aab9186923bd)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/424cd1ca-36a7-40fb-a9e0-cd1b24ba3b20)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/4f023eaf-8fe7-4fe6-93bd-4ee1c85c99c6)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/612b58b4-44e7-4644-b250-20bee6cfde5c)

Click Next: **Tags** (optional step) and Next: Review

Review your settings and click Create user

**Important**: Note down the Access key ID and Secret access key on the final page. You'll use these in your application to interact with AWS services

**Step 6: Update Your Application**

Update your application with the SNS topic ARN, and the IAM user's **access key ID** and **secret access key**, ensuring they are securely stored and not hard-coded into your application

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/2e294411-bf9e-4a05-9412-3f4560518792)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/8ef3c199-9525-41ff-a6da-e369fab70059)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/7c82a832-7d5b-4c33-9192-ec6274aa52b1)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/3f9dbb27-d034-4633-a160-970899b3e76d)

![image](https://github.com/luiscoco/AWS_ServiceBus_with_dotNET8_WebAPI_producer/assets/32194879/122d5508-be6d-41c2-9e8f-71ffbd903020)

**Step 7: Install AWS SDK for .NET**

If not already done, install the AWS SDK for .NET in your project to interact with SNS

**Step 8: Test Your Application**

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
dotnet new webapi -n SNSSenderApi
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
dotnet add package AWSSDK.SimpleNotificationService
```

We also have to add the Swagger and OpenAPI libraries to access the API Docs

This is the **csproj** file including the project dependencies

![image](https://github.com/luiscoco/AWS_SNS_with_dotNET8_WebAPI_producer/assets/32194879/0ad5c6b2-1ddd-4dc9-9e37-937c83875bbd)

## 4. Create the project structure

![image](https://github.com/luiscoco/AWS_SNS_with_dotNET8_WebAPI_producer/assets/32194879/e80159e9-a5d0-4ca8-b125-fab56b0bebf8)

## 5. Create the Controller

**SenderController.cs**

```csharp
using System.Threading.Tasks;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Microsoft.AspNetCore.Mvc;

namespace AwsSnsSenderApi.Controllers
{
    public class MessageDto
    {
        public string? Body { get; set; }
        public string? Priority { get; set; }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class SnsController : ControllerBase
    {
        private static string accessKey = "AKIA54SNDJKIETHXVI6S";
        private static string secretKey = "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";
        private static string topicArn = "arn:aws:sns:eu-west-3:954718177936:mytopic";
        private static AmazonSimpleNotificationServiceClient client;

        static SnsController()
        {
            // It's better to use IAM roles or environment credentials for production applications
            client = new AmazonSimpleNotificationServiceClient(accessKey, secretKey, Amazon.RegionEndpoint.EUWest3);
        }

        [HttpPost("send")]
        public async Task<ActionResult> SendMessage([FromBody] MessageDto messageDto)
        {
            var request = new PublishRequest
            {
                TopicArn = topicArn,
                Message = messageDto.Body,
                MessageAttributes = new Dictionary<string, MessageAttributeValue>
                {
                    { "priority", new MessageAttributeValue { DataType = "String", StringValue = messageDto.Priority } }
                }
            };

            var response = await client.PublishAsync(request);

            return Ok($"Sent message: {messageDto.Body}, Priority: {messageDto.Priority}, MessageId: {response.MessageId}");
        }
    }
}
```

## 6. Modify the application middleware(program.cs)

**Program.cs**

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ServiceBusSenderApi", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();

// Enable middleware to serve generated Swagger as a JSON endpoint.
app.UseSwagger();

// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ServiceBusSenderApi v1");
});

app.UseAuthorization();

app.MapControllers();

app.Run();
```

## 7. Run and Test the application

We execute this command to run the application

```
dotnet run
```

![image](https://github.com/luiscoco/AWS_SNS_with_dotNET8_WebAPI_producer/assets/32194879/22ae9c15-ea6d-47ed-a8a9-a34d985a09ed)

We navigate to the application endpoint: http://localhost:5031/swagger/index.html

```
curl -X 'POST' \
  'http://localhost:5031/api/Sns/send' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "body": "my first AWS message",
  "priority": "high"
}'
```

![image](https://github.com/luiscoco/AWS_SNS_with_dotNET8_WebAPI_producer/assets/32194879/54fe5327-d2dd-4223-86e3-bab8354192f3)

After executing the above request we get this response

![image](https://github.com/luiscoco/AWS_SNS_with_dotNET8_WebAPI_producer/assets/32194879/8411e64a-adcb-4231-b008-4dfeef84b556)
