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
    
        public class TechnicainLogicAbs : StaffLogicAbstract
        {
            Dictionary<decimal, Technician> TechnicianDataStore = new Dictionary<decimal, Technician>();

            public string TechnicianRegisteration(Technician technician)
            {
                if (TechnicianDataStore.ContainsKey(technician.StaffId))
                {
                    return "StaffId already exists...Try with another ID";
                }
                TechnicianDataStore.Add(technician.StaffId, technician);

                if (AllStaffDatabase.GlobalDB.ContainsKey(technician.StaffName))
                {
                    AllStaffDatabase.GlobalDB[technician.StaffName].Add((Staff)technician);
                }
                else
                {
                    AllStaffDatabase.GlobalDB.Add(technician.StaffName, new List<Staff>() { technician });
                }
                return "Registration Successful";
            }
            public Dictionary<decimal, Technician> GetAllTechnician()
            {
                return TechnicianDataStore;

            }
            public List<Technician> GetRecordBasedOnSpecialization(String spec)
            {
                List<Technician> SpecificRecordList = new List<Technician>();
                foreach (var v in TechnicianDataStore)
                {
                    if (v.Value.Specialization == spec)
                    {
                        SpecificRecordList.Add(v.Value);
                    }
                }
                return SpecificRecordList;
            }
            public Dictionary<decimal, Technician> DeleteRecord(decimal id)

            {
                if (TechnicianDataStore.ContainsKey(id))
                {
                    TechnicianDataStore.Remove(id);
                    Console.WriteLine("Record Successfully Deleted");
                }
                else
                {
                    Console.WriteLine("Invalid ID, Record Not Found");

                }
                return TechnicianDataStore;
            }
            public Dictionary<decimal, Technician> UpdateTechnicianRecord(decimal id, Technician t)
            {
                if (TechnicianDataStore.ContainsKey(id))
                {
                    TechnicianDataStore[id] = t;
                    Console.WriteLine("Record Successfully Updated");
                }
                else
                {
                    Console.WriteLine("Invalid ID, Record Not Found");

                }
                return TechnicianDataStore;
            }
            public override decimal getIncomeUsingID(decimal id)
            {
                decimal TotalIncome = 0;
                if (TechnicianDataStore.ContainsKey(id))
                {

                    TotalIncome = TechnicianDataStore[id].Fees * 30 * 100 + TechnicianDataStore[id].BasicPay;
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
                else if (income > 500000 && income <= 750000)
                {
                    IncomeAfterTaxDeduction = income - ((income * 10) / 100);
                }
                else if (income > 750000 && income <= 1000000)
                {
                    IncomeAfterTaxDeduction = income - ((income * 15) / 100);
                }
                else
                {
                    IncomeAfterTaxDeduction = income - ((income * 20) / 100);

                }

                return IncomeAfterTaxDeduction;
            }
        }
    }


