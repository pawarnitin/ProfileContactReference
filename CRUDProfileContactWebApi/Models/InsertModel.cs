using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDProfileContactWebApi.Models
{
    public class InsertModel
    {
        public System.Guid ProfileId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public System.DateTime DOB { get; set; }
        public System.Guid ContactId { get; set; }
        public string ContactType { get; set; }
        public string ContactNumber { get; set; }
    }
    public class UPdateModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public System.DateTime DOB { get; set; }
        public System.Guid ContactId { get; set; }
        public string ContactType { get; set; }
        public string ContactNumber { get; set; }
    }
    public class DeleteModel
    {
        public int Id { get; set; }
    }
}