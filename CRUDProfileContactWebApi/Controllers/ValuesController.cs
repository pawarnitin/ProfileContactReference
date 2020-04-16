using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProfileContactReference;
using CRUDProfileContactWebApi.Models;

namespace CRUDProfileContactWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        ModelFactory modelFactory;
        PCDBContext pCDBContext;        
        public ValuesController()
        {
            modelFactory = new ModelFactory();
            pCDBContext = new PCDBContext();
        }

        [HttpGet]
        // GET api/values
        public IEnumerable<ProfileModel> GetProfile()
        {
            PCRepositry pcRepositry = new PCRepositry();
            return pcRepositry.GetAllProfile().ToList().Select(p=>modelFactory.Create(p)); 
        }

        // GET api/values/5
        public IEnumerable<ProfileModel> Get(int id)
        {
            PCRepositry pcRepositry = new PCRepositry();
            return pcRepositry.GetAllProfile().Where(p=>p.Id==id).ToList().Select(p=>modelFactory.Create(p));
        }

        public IHttpActionResult CreateProfile(InsertModel insertModel)
        {           
            pCDBContext.AddProfileContact(insertModel.ProfileId, insertModel.Firstname, insertModel.Lastname, insertModel.DOB,
                insertModel.ContactId, insertModel.ContactType, insertModel.ContactNumber);
            pCDBContext.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult PutProfile(int? id, UPdateModel uPdateModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != uPdateModel.Id)
            {
                return BadRequest(ModelState);
            }
            pCDBContext.UpdateProfileContact(uPdateModel.Id, uPdateModel.Firstname, uPdateModel.Lastname, uPdateModel.DOB,
                uPdateModel.ContactId, uPdateModel.ContactType, uPdateModel.ContactNumber); ;
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult UPdateProfile(UPdateModel uPdateModel)        {
            
            pCDBContext.UpdateProfileContact(uPdateModel.Id, uPdateModel.Firstname, uPdateModel.Lastname, uPdateModel.DOB,
                uPdateModel.ContactId, uPdateModel.ContactType, uPdateModel.ContactNumber);
            pCDBContext.SaveChanges();
            return Ok();
        }
        [HttpGet]
        public IHttpActionResult Delete(int? id, DeleteModel deleteModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != deleteModel.Id)
            {
                return BadRequest(ModelState);
            }
            pCDBContext.DeleteProfileContact(deleteModel.Id);            
            return Ok();
        }

        [HttpPost, ActionName("Delete")]
        public IHttpActionResult DeleteProfile(DeleteModel deleteModel)
        {            
            pCDBContext.DeleteProfileContact(deleteModel.Id);
            pCDBContext.SaveChanges();
            return Ok();
        }

        
        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
