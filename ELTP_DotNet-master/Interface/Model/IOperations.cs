using Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Model;

namespace Interface.Model
{
    public interface IOperations<TEntity, in TPk> where TEntity : Staff
    {
        List<TEntity> GetAll();
        TEntity Get(TPk id);
        TEntity Create(TEntity entity);
        TEntity Update(TPk id, TEntity entity);
        TEntity Delete(TPk id);
        List<string> Salary(TPk id);
        public event TransactionEventHandler StaffRecordDeleted;
        public event TransactionEventHandler NewStaffAdded;
        public event TransactionEventHandler StaffDetailsUpdated;
    }
}
