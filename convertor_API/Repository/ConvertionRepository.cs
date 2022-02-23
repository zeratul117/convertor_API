using convertor_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace convertor_API.Repository
{
    public class ConvertionRepository : IDisposable
    {

        public void Dispose()
        {

        }

        public void CreateConvertionRecord(Convertion convertion)
        {
            using (ConvertorContext ctx = new ConvertorContext())
            {
                ctx.Add(convertion);
                ctx.SaveChanges();
            }
     
        }
    }
}
