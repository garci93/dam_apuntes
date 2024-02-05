﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BDDemo2.Abstration
{
    internal interface IBaseRepository<T> : IDisposable where T : TableData, new()
    {
        void SaveItem(T item);

        void SaveItemWithChildren(T item, bool recursive=false); 
        T GetItem(int id);
        T GetItem(Expression<Func<T, bool>> predicate);
        List<T> GetItems();
        List<T> GetItems(Expression<Func<T, bool>> predicate);

        List<T> GetItemWithChildren();
        void DeleteItem(T item);


    }

}
