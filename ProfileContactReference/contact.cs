//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProfileContactReference
{
    using System;
    using System.Collections.Generic;
    
    public partial class contact
    {
        public int Id { get; set; }
        public System.Guid ProfileId { get; set; }
        public System.Guid ContactId { get; set; }
        public string ContactType { get; set; }
        public string ContactNumber { get; set; }
    
        public virtual profile profile { get; set; }
    }
}
