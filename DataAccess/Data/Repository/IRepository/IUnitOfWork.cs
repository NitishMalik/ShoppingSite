using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Data.Repository
{
    public interface IUnitOfWork: IDisposable
    {
        void Save();
        ICategoryRepository Category { get; }
    }
}
