﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IRepository<T>
    {
        List<T> List();
        void Add(T item);
        T Get(Expression<Func<T, bool>> filter);
        void Delete(T item);
        void Update(T item);
        List<T> ConditionalList(Expression<Func<T, bool>> filter);
    }
}
