using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Employee.Models;

namespace WebAPI_Employee.Controllers
{
    public class UserAPIController : ApiController
    {
        CommodityInfoEntities cm = new CommodityInfoEntities();
        public IHttpActionResult getemp()
        {
            
            var results = cm.dbo__vUsers.ToList();
            return Ok(results);
        }

        [HttpPost]
        public IHttpActionResult empinsert(Sys_User empinsert)
        {
            var insert = cm.Sys_User.Add(empinsert);
            cm.SaveChanges();
            return Ok();
        }

        public IHttpActionResult Getempid(int id)
        {
            EmpClass empdetails = null;
            empdetails = cm.dbo__vUsers.Where(x => x.Id == id).Select(x => new EmpClass()
            {
                Id = x.Id,
                Empname = x.Empname,
                Empemail = x.Empemail,
                emplocation = x.emplocation,
                empdesignation = x.empdesignation,
                UserName = x.UserName,
                Password = x.Password,
                IsActive = x.IsActive,
                Role = x.Role,
                squad =x.squad
                
            }).FirstOrDefault<EmpClass>();
            if ( empdetails ==null)
            {
                return NotFound();
            }
            return Ok(empdetails);  
        }

     
       public IHttpActionResult Put(EmpClass ec)
        {
            var updateemp = cm.Sys_User.Where(x => x.Id == ec.Id).FirstOrDefault<Sys_User>();

            if (updateemp!=null)
            {
                updateemp.Id = ec.Id;
                updateemp.Empname = ec.Empname;
                updateemp.Empemail = ec.Empemail;
                updateemp.emplocation = ec.emplocation;
                updateemp.empdesignation = ec.empdesignation;
                updateemp.UserName = ec.UserName;
                updateemp.Password = ec.Password;
                updateemp.IsActive = ec.IsActive;
                updateemp.Role = ec.Role;
                updateemp.squad = ec.squad;
                
                cm.SaveChanges();


            }
            else
            {
                return NotFound();
            }
            return Ok();
       }
        public IHttpActionResult Delete(int id)
        {
            var empdel = cm.Sys_User.Where(x => x.Id == id).FirstOrDefault();
            cm.Entry(empdel).State = System.Data.Entity.EntityState.Deleted;
            cm.SaveChanges();
            return Ok();
        }
}
}
