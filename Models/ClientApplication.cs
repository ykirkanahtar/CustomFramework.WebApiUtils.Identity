using CustomFramework.Data.Models;
using Newtonsoft.Json;

namespace CustomFramework.WebApiUtils.Identity.Models
{
    public class ClientApplication : BaseModel<int>
    {
        public string ClientApplicationName { get; set; }
        public string ClientApplicationCode { get; set; }
        public string ClientApplicationPassword { get; set; }
        public string SecurityStamp { get; set; }
    }
}