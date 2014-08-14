using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ElTavo.RepositoryPattern.Apis.Models;

namespace ElTavo.RepositoryPattern.Apis.Controllers
{
    public class DatosContactoController : ApiController
    {
        public DatosContacto Get(string id)
        {
            return new DatosContacto
            {
                FaceBook = "http://www.facebook.com/user",
                Twitter = "https://www.twitter.com/user",
                LinkedIn = "https://co.linkedin.com/user",
                SitioWeb = "http://www.user.com"
            };
        }
    }
}
