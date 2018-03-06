﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();


        void RejectChanges();


        void Dispose();


        IRepository<T> GenericRepository<T>() where T : class;
    }
}
