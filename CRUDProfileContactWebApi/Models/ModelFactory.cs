using ProfileContactReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDProfileContactWebApi.Models
{
    public class ModelFactory
    {
        public ProfileModel Create(profile profile)
        {
            return new ProfileModel()
            {
                Id = profile.Id,
                ProfileId = profile.ProfileId, 
                Firstname = profile.Firstname,
                Lastname = profile.Lastname,
                DOB = profile.DOB,
                Contact = profile.contacts.Select(C=>Create(C))
        };
    }
    public ContactModel Create(contact contact)
    {
        return new ContactModel()
        {
            //Id = contact.Id,
            //ProfileId = contact.ProfileId,
            ContactId = contact.ContactId,
            ContactType = contact.ContactType,
            ContactNumber = contact.ContactNumber
        };
    }   
        

}
}