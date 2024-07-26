using Pruebalinktic.Shared.Responses;

namespace Pruebalinktic.Backend.Helpers
{
    public interface IMailHelper
    {
        ActionResponse<string> SendMail(string toName, string toEmail, string subject, string body);
    }
}
