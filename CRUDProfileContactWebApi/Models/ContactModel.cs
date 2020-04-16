using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDProfileContactWebApi.Models
{
    public class ContactModel
    {
        //public int Id { get; set; }
        public System.Guid ContactId { get; set; }
        public string ContactType { get; set; }
        public string ContactNumber { get; set; }
        //public System.Guid ProfileId { get; set; }
    }
}