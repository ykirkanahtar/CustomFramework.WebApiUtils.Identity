using CustomFramework.Authorization.Utils;
using CustomFramework.EmailProvider;

namespace CustomFramework.WebApiUtils.Identity.Extensions
{
    public interface IIdentityModel
    {
        bool EmailConfirmationViaUrl { get; set; }
        string SenderEmailAddress { get; set; }
        string AppName { get; set; }
        Token Token { get; set; }
        EmailConfig EmailConfig { get; set; }
        int GeneratedPasswordLength { get; set; }
    }
}