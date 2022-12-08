using Assign_26.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_26.Logic
{
    public class DriverLogic : IDbOperations
    {
        Dictionary<string, Staff> IDbOperations.Create(string key, Staff staff)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, Doctor> IDbOperations.Create(string key, Doctor doctor)
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
