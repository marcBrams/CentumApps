﻿using CentumApps.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentumApps.Application.Common.Interfaces
{
    public interface IContentRepository : IRepository<Content>
    {
        void Update(Content content);
        void Save();
    }
}
