using Assign_26.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_26.Logic
{
    /// <summary>
    /// The 'in' means input parameter 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPk"></typeparam>
    public interface IDbOperations
    {
        Dictionary<String, Staff> GetAll();
        Dictionary<String, Staff> Get(string key);
        Dictionary<String, Staff> Create(string key, Staff staff);
        Dictionary<String, Staff> Update(string key, Staff staff);
        Dictionary<String, Staff> Delete(string key);
        Dictionary<string, Doctor> Create(string key, Doctor doctor);
    }
}
