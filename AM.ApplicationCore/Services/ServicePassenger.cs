using AM.ApplicationCore.domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServicePassenger : Service<Passenger>, IServicePassenger
    {
        public ServicePassenger(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
