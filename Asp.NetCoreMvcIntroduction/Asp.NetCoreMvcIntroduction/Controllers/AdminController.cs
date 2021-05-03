using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMvc2.Introduction.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("save")]
        [Route("~/save")]
        public string Save()
        {
            return "Saved";
        }
        [Route("Delete/{id?}")]
        public string Delete(int id = 0)
        {
            return String.Format("Deleted {0}", id);
        }
        [Route("Update")]
        public string Update()
        {
            return "Updated";
        }
    }
}