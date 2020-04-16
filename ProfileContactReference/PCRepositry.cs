using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileContactReference
{
    public class PCRepositry
    {
        public IQueryable<profile> GetAllProfile()
        {
            PCDBContext ctx = new PCDBContext();
            return ctx.profiles;
        }
        public IQueryable<profile> GetAllProfile( int id)
        {
            PCDBContext ctx = new PCDBContext();
            return ctx.profiles.Where(c=>c.Id==id).Select(e=>e);
        }
    }
}
