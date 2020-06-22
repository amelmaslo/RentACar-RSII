using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.WebAPI.Database
{
    public class SetupService
    {
        public static void Init(RentACarContext context)
        {
            context.Database.Migrate();
        }
    }
}
