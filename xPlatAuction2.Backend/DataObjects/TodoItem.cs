using Microsoft.Azure.Mobile.Server;

namespace xPlatAuction2.Backend.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}