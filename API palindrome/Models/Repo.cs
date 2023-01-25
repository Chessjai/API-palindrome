using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_palindrome.Models
{
    public class Repo
    {
        LDBContext db = new LDBContext();
        DBclass ms = new DBclass();

        public bool Create(DBclass cl)
        {
            db.LModels.Add(new DBclass()
            {
                Inputvalue = cl.Inputvalue,
                Outputvalue = cl.Outputvalue,
                count= cl.count
            });
            return true;
        }


        public DBclass GetbyId(long id)
        {
            var s = db.LModels.Find(id);
            db.SaveChanges();
            return s;
        }
    }
}