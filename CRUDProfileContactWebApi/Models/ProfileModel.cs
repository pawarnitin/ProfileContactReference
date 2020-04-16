using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDProfileContactWebApi.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public System.Guid ProfileId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public System.DateTime DOB { get; set; }
        public IEnumerable<ContactModel> Contact { get; set; }
    }
}