﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentumApps.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IContentRepository Content { get; }
        IShiftReportRepository ShiftReport { get; }
        ICDURepository CDU { get; }
    }
}
