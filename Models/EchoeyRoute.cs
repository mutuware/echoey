
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Echoey.Models
{
    public class EchoeyRoute
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Verb { get; set; }

        [NotMapped] // json response, not mapped to DB
        public dynamic Response { get; set; }

        [JsonIgnore] // mapped to DB, not shown to client
        public string StringResponse { get { return this.Response.ToString(); } }
    }
}