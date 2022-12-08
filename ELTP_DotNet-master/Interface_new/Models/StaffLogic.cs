using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_new.Entities;
using Interface_new.DatabaseContainer;
namespace Interface_new.Models
{

    public class DoctorLogic : IDbOperations<Doctor, int>
    {
        Doctor IDbOperations<Doctor, int>.Create(Doctor entity)
        {
            if (HospitalDb.GlobalStaffStore != null)
            { HospitalDb.GlobalStaffStore.Add(entity.StaffId, entity); }
            return entity;
        }

        Doctor IDbOperations<Doctor, int>.Delete(int id)
        {

        }
                

        Doctor IDbOperations<Doctor, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Doctor> IDbOperations<Doctor, int>.GetAll()
        {
            throw new NotImplementedException();
        }

        Doctor IDbOperations<Doctor, int>.Update(int id, Doctor entity)
        {
            throw new NotImplementedException();
        }
    }

    public class NurseLogic : IDbOperations<Nurse, int>
    {
        
        Nurse IDbOperations<Nurse, int>.Create(Nurse entity)
        {
            {
                if (HospitalDb.GlobalStaffStore != null)
                { HospitalDb.GlobalStaffStore.Add(entity.StaffId, entity); }
                return entity;
            }
        }

        Nurse IDbOperations<Nurse, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Nurse IDbOperations<Nurse, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Nurse> IDbOperations<Nurse, int>.GetAll()
        {
            throw new NotImplementedException();
        }

        Nurse IDbOperations<Nurse, int>.Update(int id, Nurse entity)
        {
            throw new NotImplementedException();
        }
    }

    public class DriverLogic : IDbOperations<Driver, int>
    {
        Driver IDbOperations<Driver, int>.Create(Driver entity)
        {
            {
                if (HospitalDb.GlobalStaffStore != null)
                { HospitalDb.GlobalStaffStore.Add(entity.StaffId, entity); }
                return entity;
            }
        }

        Driver IDbOperations<Driver, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Driver IDbOperations<Driver, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Driver> IDbOperations<Driver, int>.GetAll()
        {
            throw new NotImplementedException();
        }

        Driver IDbOperations<Driver, int>.Update(int id, Driver entity)
        {
            throw new NotImplementedException();
        }
    }

}