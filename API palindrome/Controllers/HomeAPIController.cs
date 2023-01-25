using API_palindrome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;


namespace API_palindrome.Controllers
{
    public class HomeAPIController : ApiController
    {

        LDBContext db = new LDBContext();
        Repo s = new Repo();

        [HttpPost]
        [Route("~/api/HomeAPI/Create")]
        public IHttpActionResult Create(DBclass cl)
        {
            DBclass ms = new DBclass();
            Logic lg= new Logic();

            if (!ModelState.IsValid)
                return BadRequest("Invalid Data ");
            //ms.longestLength();
            using (var ctx = new LDBContext())
            {
                string str = cl.Inputvalue;
                List<string> list = lg.First(str);
                string strInput = "";int counts=list.Count;
                for (int i = 0; i < list.Count; i++)
                {
                    strInput += (list[i] + ",");

                }
          
                ctx.LModels.Add(new DBclass()
                {
                    Inputvalue = cl.Inputvalue,
                    Outputvalue = strInput,
                    count= counts

                });
                ctx.SaveChanges();
            }

            return Ok();
        }


        [HttpGet]
        [Route("~/api/HomeAPI/GetbyId")]
        public IHttpActionResult GetbyId(long id)
        {
            //var s = db.LModels.Find(id);
            var a = s.GetbyId(id);
            return Ok(a);
        }
    }
}
