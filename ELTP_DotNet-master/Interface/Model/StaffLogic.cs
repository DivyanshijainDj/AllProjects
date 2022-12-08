using Interface;
using Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Model;

namespace Interface.Model
{

    public delegate void TransactionEventHandler();

    public class DoctorLogic : IOperations<Doctor, int>
    {
        public event TransactionEventHandler StaffRecordDeleted;
        public event TransactionEventHandler StaffDetailsUpdated;
        public event TransactionEventHandler NewStaffAdded;

        List<Doctor> DoctorList = new List<Doctor>() {
             new Doctor(){StaffId=1,StaffName="Divyanshi",BasicPay=2888,Education="MBBS",MaxPatientsPerDay=10,Fees=999,City="Nashik",Specilization="eye"},
             new Doctor(){  StaffId=2,StaffName="Princee",BasicPay=9923,Education="BHMS",MaxPatientsPerDay=20,Fees=999,City="Mumbai",Specilization="eye"},
             new Doctor(){  StaffId=3,StaffName="Sahil",BasicPay=2898,Education="MBBS",MaxPatientsPerDay=40,Fees=999,City="Nagpur",Specilization="heart"},
             new Doctor(){ StaffId=4,StaffName="Divyesh",BasicPay=28884,Education="ENGG",MaxPatientsPerDay=60,Fees=999,City="Mumbai",Specilization="heart"},
             new Doctor(){ StaffId = 5,StaffName = "Himank",BasicPay =1288,Education = "BTEch",MaxPatientsPerDay = 20,Fees = 999,City = "Mumbai",Specilization = "heart"},
  
                
};
        private Doctor doctorobj;


        Doctor IOperations<Doctor, int>.Create(Doctor entity)
        {
            DoctorList.Add(entity);
            GlobalIdStore.StaffIdStore.Add(entity.StaffId);
            NewStaffAdded();
            return entity;

        }

        Doctor IOperations<Doctor, int>.Delete(int id)
        {
            foreach (var v in DoctorList)
            {
                if (v.StaffId == id)
                {
                    doctorobj = v;
                    DoctorList.Remove(v);
                    GlobalIdStore.StaffIdStore.Remove(id);
                    StaffRecordDeleted();
                    Console.WriteLine("Record Deleted ");
                    return doctorobj;


                }
            }
            Console.WriteLine("Record Not Found..!");
            return null;

        }

        Doctor IOperations<Doctor, int>.Get(int id)
        {

            foreach (var v in DoctorList)
            {
                if (v.StaffId == id)
                {
                    return v;
                }
            }
            Console.WriteLine("Record Not Found..!");
            return null;
        }

        List<Doctor> IOperations<Doctor, int>.GetAll()
        {
            return DoctorList.OrderBy(x => x.StaffName).ToList();

        }

        Doctor IOperations<Doctor, int>.Update(int id, Doctor entity)
        {
            if (entity.StaffId == id)
            {
                for (int i = 0; i < DoctorList.Count; i++)
                {
                    if (DoctorList[i].StaffId == id)
                    {
                        DoctorList[i] = entity;
                        StaffDetailsUpdated();
                        return DoctorList[i];
                    }
                }
            }
            Console.WriteLine("Record Not Found..!");
            return null;
        }

        public List<string> Salary(int id)
        {
            bool flag = true;
            List<string> list = new List<string>();
            foreach (var v in DoctorList)
                if (v.StaffId == id)
                {
                    list.Add(v.StaffName);
                    flag = false;
                    list.Add(Convert.ToString(v.BasicPay));
                    list.Add(Convert.ToString((int)(v.BasicPay + (v.MaxPatientsPerDay * v.Fees * 10))));
                    list.Add(Convert.ToString((int)((v.BasicPay * 0.18))));
                    break;
                }
            if (flag)
                return null;

            return list;
        }
    }

    public class NurseLogic : IOperations<Nurse, int>
    {
        private Nurse nurseobj;
        List<Nurse> NurseList = new List<Nurse>() {
            new Nurse(){StaffId=6,StaffName="DIvyanshi",BasicPay=2888,Education="MBBS",NoofRoomsVisitedPerDay=10,Experience=999,City="Nashik",},
            new Nurse(){  StaffId=7,StaffName="Princee",BasicPay=2993,Education="BHMS",NoofRoomsVisitedPerDay=20,Experience=999,City="Mumbai"},
            new Nurse(){  StaffId=8,StaffName="Divyesh",BasicPay=28898,Education="MBBS",NoofRoomsVisitedPerDay=40,Experience=999,City="Nagpur"},
            new Nurse(){ StaffId=9,StaffName="Himank",BasicPay=28884,Education="ENGG",NoofRoomsVisitedPerDay=60,Experience=999,City="Mumbai",},
            new Nurse(){ StaffId = 10,StaffName = "roshani",BasicPay =1288,Education = "BTEch",NoofRoomsVisitedPerDay = 20,Experience = 999,City = "Mumbai",},
  

};

        public event TransactionEventHandler StaffRecordDeleted;
        public event TransactionEventHandler NewStaffAdded;
        public event TransactionEventHandler StaffDetailsUpdated;

        public List<string> Salary(int id)
        {
            bool flag = true;
            List<string> list = new List<string>();
            foreach (var v in NurseList)
                if (v.StaffId == id)
                {
                    list.Add(v.StaffName);
                    flag = false;
                    list.Add(Convert.ToString(v.BasicPay));
                    list.Add(Convert.ToString((int)(v.BasicPay + (v.NoofRoomsVisitedPerDay * 499 * 30))));
                    list.Add(Convert.ToString((int)((v.BasicPay * 0.18))));
                    break;
                }
            if (flag)
                return null;
            return list;
        }

        Nurse IOperations<Nurse, int>.Create(Nurse entity)
        {
            NurseList.Add(entity);
            GlobalIdStore.StaffIdStore.Add(entity.StaffId);
            NewStaffAdded();
            return entity;
        }

        Nurse IOperations<Nurse, int>.Delete(int id)
        {
            foreach (var v in NurseList)
            {
                if (v.StaffId == id)
                {
                    nurseobj = v;
                    NurseList.Remove(v);
                    GlobalIdStore.StaffIdStore.Remove(id);
                    StaffRecordDeleted();
                    Console.WriteLine("Record Deleted ");
                    return nurseobj;


                }
            }
            Console.WriteLine("Record Not Found..!");

            return null;
        }

        Nurse IOperations<Nurse, int>.Get(int id)
        {

            foreach (var v in NurseList)
            {
                if (v.StaffId == id)
                {
                    return v;
                }
            }
            Console.WriteLine("Record Not Found..!");
            return null;
        }

        List<Nurse> IOperations<Nurse, int>.GetAll()
        {
            return NurseList.OrderBy(x => x.StaffName).ToList();
        }

        Nurse IOperations<Nurse, int>.Update(int id, Nurse entity)
        {
            if (entity.StaffId == id)
            {
                for (int i = 0; i < NurseList.Count; i++)
                {
                    if (NurseList[i].StaffId == id)
                    {
                        NurseList[i] = entity;
                        StaffDetailsUpdated();
                        return NurseList[i];
                    }
                }
            }
            Console.WriteLine("Record Not Found..!");
            return null;
        }
    }

    public class DriverLogic : IOperations<Driver, int>
    {

        List<Driver> DriverList = new List<Driver>() {
             new Driver(){StaffId=11,StaffName="Divyanshi",BasicPay=2888,Education="MBBS",VehicleType="Ambulance",NoOfTripsPerDay=10,City="Nashik"},
             new Driver(){  StaffId=12,StaffName="Princee",BasicPay=23,Education="BHMS",VehicleType="Ambulance",NoOfTripsPerDay=20,City="Mumbai"},
             new Driver(){  StaffId=13,StaffName="Himank",BasicPay=288,Education="MBBS",VehicleType="PersonalDriver",NoOfTripsPerDay=30,City="Nagpur"},
             new Driver(){ StaffId=14,StaffName="Divyesh",BasicPay=28884,Education="ENGG",VehicleType="PersonalDriver",NoOfTripsPerDay=30,City="Mumbai"},
             new Driver(){ StaffId = 15,StaffName = "Rosahni",BasicPay =1288,Education = "BTEch",VehicleType = "PersonalDriver",NoOfTripsPerDay = 20,City = "Mumbai"},
   


};
        public event TransactionEventHandler StaffDetailsUpdated;
        public event TransactionEventHandler StaffRecordDeleted;
        public event TransactionEventHandler NewStaffAdded;

        private Driver driverobj;

        Driver IOperations<Driver, int>.Create(Driver entity)
        {
            DriverList.Add(entity);
            GlobalIdStore.StaffIdStore.Add(entity.StaffId);
            NewStaffAdded();
            return entity;
        }

        Driver IOperations<Driver, int>.Delete(int id)
        {

            foreach (var v in DriverList)
            {
                if (v.StaffId == id)
                {
                    driverobj = v;
                    DriverList.Remove(v);
                    GlobalIdStore.StaffIdStore.Remove(id);
                    StaffRecordDeleted();
                    Console.WriteLine("Record Deleted! ");

                    return driverobj;

                }
            }
            Console.WriteLine("Record Not Found..!");

            return null;

        }

        Driver IOperations<Driver, int>.Get(int id)
        {

            foreach (var v in DriverList)
            {
                if (v.StaffId == id)
                {
                    return v;
                }
            }
            Console.WriteLine("Record Not Found..!");
            return null;
        }

        List<Driver> IOperations<Driver, int>.GetAll()
        {
            return DriverList.OrderBy(x => x.StaffName).ToList();

        }

        Driver IOperations<Driver, int>.Update(int id, Driver entity)
        {
            if (entity.StaffId == id)
            {
                for (int i = 0; i < DriverList.Count; i++)
                {
                    if (DriverList[i].StaffId == id)
                    {
                        DriverList[i] = entity;
                        StaffDetailsUpdated();
                        return DriverList[i];
                    }
                }
            }
            Console.WriteLine("Record Not Found..!");
            return null;

        }

        public List<string> Salary(int id)
        {
            bool flag = true;
            List<string> list = new List<string>();
            foreach (var v in DriverList)
            {
                if (v.StaffId == id)
                {
                    list.Add(v.StaffName);
                    flag = false;
                    list.Add(Convert.ToString(v.BasicPay));
                    list.Add(Convert.ToString((int)(v.BasicPay + (v.NoOfTripsPerDay * 499 * 30))));
                    list.Add(Convert.ToString((int)((v.BasicPay * 0.18))));
                    break;
                }
            }
            if (flag)
                return null;
            return list;
        }
    }
    public class EventListener
    {

        private IOperations<Doctor, int> objdoc;
        private IOperations<Nurse, int> objnur;
        private IOperations<Driver, int> objdri;

     
        public EventListener(IOperations<Doctor, int> objdoc)
        {
            this.objdoc = objdoc;
            objdoc.NewStaffAdded += Staff_NewStaffAdded;
            objdoc.StaffRecordDeleted += Staff_StaffRecordDeleted;
            objdoc.StaffDetailsUpdated += Staff_StaffDetailsUpdated;

        }

        public EventListener(IOperations<Nurse, int> objnur)
        {
            this.objnur = objnur;

            objnur.NewStaffAdded += Staff_NewStaffAdded;
            objnur.StaffRecordDeleted += Staff_StaffRecordDeleted;
            objnur.StaffDetailsUpdated += Staff_StaffDetailsUpdated;
        }

        public EventListener(IOperations<Driver, int> objdri)
        {
            this.objdri = objdri;
            objdri.NewStaffAdded += Staff_NewStaffAdded;
            objdri.StaffRecordDeleted += Staff_StaffRecordDeleted;
            objdri.StaffDetailsUpdated += Staff_StaffDetailsUpdated;

        }

        private void Staff_NewStaffAdded()
        {
            Console.WriteLine("\n Staff Added \n");
        }
        private void Staff_StaffRecordDeleted()
        {
            Console.WriteLine("\n Record Deleted \n");

        }
        private void Staff_StaffDetailsUpdated()
        {
            Console.WriteLine("\n Details Updated \n");
        }
    }
}
