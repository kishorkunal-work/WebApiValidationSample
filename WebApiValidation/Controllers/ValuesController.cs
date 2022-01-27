using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using WebApiValidation.Helper;
using WebApiValidation.Models;

namespace WebApiValidation.Controllers
{
	public class ValuesController : ApiController
	{
        [HttpPost]
        [ValidateModel]
        public HttpResponseMessage UserRegistration(User userModel)
        {
            // Note: since we have annotated model with respective validation,
            // no need to check for ModelState here as that will be taken care by [ValidateModel]
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage IsGuid(string guid)
        {
            // Note: since we have premitive parameter here ,
            // we need to check for ModelState here
            if (!Guid.TryParse(guid , out Guid g))
			{
                ModelState.AddModelError("Parameter guid", "Invalid value for guid");
                return Request.CreateErrorResponse(
                    HttpStatusCode.BadRequest, ModelState);
            }
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
