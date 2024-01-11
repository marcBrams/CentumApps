using CentumApps.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentumApps.Application.Common.Interfaces
{
    public interface ICDURepository : IRepository<CDU_100>
    {
        void Update(CDU_100 CDU);
        void Save();
    }
}
