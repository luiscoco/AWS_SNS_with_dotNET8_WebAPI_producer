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
        private static string accessKey = "AKIA54SNDJKIJ5AGIBWQ";
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
