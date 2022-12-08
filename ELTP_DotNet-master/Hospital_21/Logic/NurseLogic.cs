using Hospital_21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_21.Models;
using Hospital_21.Logic;
//using Hospital_21.DataBaseForSearching;

namespace Hospital_21.Logic
{
   
        public class NurseLogic : StaffLogicAbstract
        {

            Dictionary<decimal, Nurse> NurseDataStore = new Dictionary<decimal, Nurse>();

            public string NurseRegisteration(Nurse nurse)
            {

                NurseDataStore.Add(nurse.StaffId, nurse);
                if (AllStaffDatabase.GlobalDB.ContainsKey(nurse.StaffName))
                {
                    AllStaffDatabase.GlobalDB[nurse.StaffName].Add((Staff)nurse);
                }
                else
                {
                    AllStaffDatabase.GlobalDB.Add(nurse.StaffName, new List<Staff>() { nurse });
                }
                return "Registration Successful";
            }


            public Dictionary<decimal, Nurse> GetAllNurse()
            {
                return NurseDataStore;

            }
            public List<Nurse> GetRecordBasedOnSpecialization(String spec)
            {
                List<Nurse> SpecificRecordList = new List<Nurse>();
                foreach (var v in NurseDataStore)
                {
                    if (v.Value.Specialization == spec)
                    {
                        SpecificRecordList.Add(v.Value);
                    }
                }
                return SpecificRecordList;
            }
            public Dictionary<decimal, Nurse> DeleteRecord(decimal id)

            {
                if (NurseDataStore.ContainsKey(id))
                {
                    NurseDataStore.Remove(id);
                    Console.WriteLine("Record Successfully Deleted");
                }
                else
                {
                    Console.WriteLine("Invalid ID, Record Not Found");

                }
                return NurseDataStore;
            }
            public Dictionary<decimal, Nurse> UpdateNurseRecord(decimal id, Nurse nurse)
            {
                if (NurseDataStore.ContainsKey(id))
                {
                    NurseDataStore[id] = nurse;
                    Console.WriteLine("Record Successfully Updated");
                }
                else
                {
                    Console.WriteLine("Invalid ID, Record Not Found");

                }
                return NurseDataStore;
            }
            public override decimal getIncomeUsingID(decimal id)
            {
                decimal TotalIncome = 0;
                if (NurseDataStore.ContainsKey(id))
                {

                    TotalIncome = NurseDataStore[id].Fees * 30 * 50 + NurseDataStore[id].BasicPay;
                }
                else
                {
                    Console.WriteLine("Record Not Found");
                }
                return TotalIncome - TaxforIncome(TotalIncome);
            }
            public override decimal TaxforIncome(decimal income)
            {
                decimal IncomeAfterTaxDeduction = 0;

                if (income >= 250000 && income <= 500000)
                {
                    IncomeAfterTaxDeduction = income - ((income * 5) / 100);
                }
               
                else
                {
                    IncomeAfterTaxDeduction = income - ((income * 20) / 100);

                }

                return IncomeAfterTaxDeduction;
            }

       
    }
    }


