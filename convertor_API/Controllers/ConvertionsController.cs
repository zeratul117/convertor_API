using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using convertor_API.Models;
using System.Net.Http;
using System.Net;
using convertor_API.Repository;

namespace convertor_API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertionsController : ControllerBase
    {
        private readonly ConvertorContext _context;

        public ConvertionsController(ConvertorContext context)
        {
           _context = context;
        }

        [HttpPost]
        [Route("")]
        public async Task<HttpResponseMessage> PostConvertion(Convertion convertion)
        {

            HttpResponseMessage response = null;

            try
            {
                _context.Convertions.Add(convertion);
                await _context.SaveChangesAsync();
                response = new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                response = new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            return response;
        }

    }
}
