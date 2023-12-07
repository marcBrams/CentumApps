using CentumApps.Application.Common.Interfaces;
using CentumApps.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentumApps.Infastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        // add more interface
        public IContentRepository Content { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            // add more interface
            Content = new ContentRepository(db);
        }
    }
}
