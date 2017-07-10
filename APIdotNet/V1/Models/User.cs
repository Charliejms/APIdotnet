using System;
using Newtonsoft.Json;
namespace APIdotNet.RoutePrefix
{
    public class User
    {
       
        public new string Id { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string TenantId { get; set; }
    }
}
