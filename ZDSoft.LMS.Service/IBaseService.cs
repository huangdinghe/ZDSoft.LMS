using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZDSoft.LMS.Domain;
using ZDSoft.LMS.Manager;
using NHibernate;
using NHibernate.Criterion;

namespace ZDSoft.LMS.Service
{
    public interface IBaseService<T>where T:EntityBase,new()
    {
        
        void Create(T entity);
        void Update(T entity);
        T Get(int ID);
        T Get(IList<ICriterion> queryConditions);

        void Delete(int ID);
        void Delete(T entity);

        bool Exists(int id);
        bool Exists(IList<ICriterion> queryConditions);

        IList<T> GetAll();
        IList<T> GetAll(IList<ICriterion> queryConditions);
        
        /// <summary>
        /// 分页获取满足条件的记录
        /// </summary>
        /// <param name="queryConditions"></param>
        /// <param name="orderList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        IList<T> GetPaged(IList<ICriterion> queryConditions, IList<Order> orderList, int pageIndex, int pageSize, out int count);
        /// <summary>
        /// 获取满足条件的记录
        /// </summary>
        /// <param name="queryConditions"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        IList<T> GetPaged(IList<QueryConditions> queryConditions, int pageIndex, int pageSize, out int count);
        /// <summary>
        /// 根据查询条件查询满足条件的记录
        /// </summary>
        /// <param name="queryConditions"></param>
        /// <returns></returns>
        IList<T>Find(IList<ICriterion>queryConditions);
    }
}
