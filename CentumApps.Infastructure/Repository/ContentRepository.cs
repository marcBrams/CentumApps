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
    public class ContentRepository : Repository<Content>, IContentRepository
    {

        private readonly ApplicationDbContext _db;
        public ContentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Content content)
        {
            _db.Contents.Update(content);
        }
    }
}
