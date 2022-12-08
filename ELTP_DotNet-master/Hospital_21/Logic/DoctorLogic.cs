using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_21.Models;


using Hospital_21.Logic;


namespace Hospital_21.Logic
{
    
        public class DoctorLogic : StaffLogicAbstract

         { 
            Dictionary<decimal, Doctor> DoctorDataStore = new Dictionary<decimal, Doctor>();

            public string DoctorRegisteration(Doctor doctor)
            {

                DoctorDataStore.Add(doctor.StaffId, doctor);
                if (AllStaffDatabase.GlobalDB.ContainsKey(doctor.StaffName))
                {
                    AllStaffDatabase.GlobalDB[doctor.StaffName].Add((Staff)doctor);
                }
                else
                {
                    AllStaffDatabase.GlobalDB.Add(doctor.StaffName, new List<Staff>() { doctor });
                }
                return "Successfully Registered";
            }


            public Dictionary<decimal, Doctor> GetAllDoctors()
            {
                return DoctorDataStore;

            }


            public List<Doctor> GetRecordBasedOnSpecialization(String spec)
            {
                List<Doctor> SpecificRecordList = new List<Doctor>();
                foreach (var v in DoctorDataStore)
                {
                    if (v.Value.Specialization == spec)
                    {
                        SpecificRecordList.Add(v.Value);
                    }
                }
                return SpecificRecordList;
            }


            public Dictionary<decimal, Doctor> DeleteRecord(decimal id)

            {
                if (DoctorDataStore.ContainsKey(id))
                {
                    DoctorDataStore.Remove(id);
                    Console.WriteLine("Record Successfully Deleted");
                }
                else
                {
                    Console.WriteLine("Invalid ID, Record Not Found");

                }
                return DoctorDataStore;
            }
            public Dictionary<decimal, Doctor> UpdateDoctorRecord(decimal id, Doctor doctor)
            {
                if (DoctorDataStore.ContainsKey(id))
                {
                    DoctorDataStore[id] = doctor;
                    Console.WriteLine("Record Successfully Updated");
                }
                else
                {
                    Console.WriteLine("Invalid ID, Record Not Found");

                }
                return DoctorDataStore;
            }

        


            public override decimal getIncomeUsingID(decimal id)
            {
                decimal TotalIncome = 0;
                if (DoctorDataStore.ContainsKey(id))
                {

                    TotalIncome = DoctorDataStore[id].MaxPatientsPerDay * 30 * DoctorDataStore[id].Fees + DoctorDataStore[id].BasicPay;
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }
                return TotalIncome - TaxforIncome(TotalIncome);
            }

            public override decimal TaxforIncome(decimal income)
            {
                decimal Deduce = 0;

                if (income >= 15000 && income <= 25000)
                {        Deduce = income - ((income * 3) / 100);       }

                else if (income > 250000 && income <= 400000)
                {        Deduce = income - ((income * 5) / 100);       }

                else if (income > 400000 && income <= 500000)
                {        Deduce = income - ((income * 10) / 100);       }

                else
                {        Deduce = income - ((income * 20) / 100);       }

                return Deduce;
            }



        }

    }

