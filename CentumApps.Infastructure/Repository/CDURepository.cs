using CentumApps.Application.Common.Interfaces;
using CentumApps.Domain.Entities;
using CentumApps.Infastructure.Data;
using CentumApps.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentumApps.Infastructure.Repository
{
    public class CDURepository : Repository<CDU_100>, ICDURepository
    {

        private readonly ApplicationDbContext _db;
        public CDURepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(CDU_100 CDU)
        {
            _db.CDU.Update(CDU);
        }
    }
}
