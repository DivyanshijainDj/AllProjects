using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign_26.Database;
using Assign_26.Entities;
using Assign_26.Logic;

namespace Assign_26.Logic
{
    public class NurseLogic : IDbOperations
    {
        Dictionary<string, Staff> IDbOperations.Create(string key, Staff staff)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, Staff> IDbOperations.Delete(string key)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, Staff> IDbOperations.Get(string key)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, Staff> IDbOperations.GetAll()
        {
            throw new NotImplementedException();
        }

        Dictionary<string, Staff> IDbOperations.Update(string key, Staff staff)
        {
            throw new NotImplementedException();
        }
    }
}
