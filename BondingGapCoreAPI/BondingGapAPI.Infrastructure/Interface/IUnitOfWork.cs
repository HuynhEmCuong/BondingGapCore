using System;
using System.Collections.Generic;
using System.Text;

namespace BondingGapCore.infrastructure.Interface
{
    public interface IUnitOfWork :IDisposable
    {
        void Commit();
    }
}
