using Riganti.Utils.Infrastructure.Core;
using System;

namespace BL.AppInfrastructure
{
    public class AppDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
