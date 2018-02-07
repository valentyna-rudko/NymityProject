using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NymityProject.Models;


namespace NymityProject.Controllers
{
    [Authorize] // Require authenticated requests.
    public class ProductController : ApiController
    {
        private northwndEntities1 db = new northwndEntities1();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }
            base.Dispose(disposing);
        }
        // GET api/<controller>
        public IEnumerable<Category> GetAllCategories()
        {
            return db.Categories.AsEnumerable();
        }
    }
}
