using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hospital_20
{
    public class TechnicanLogic
    {
        Dictionary<String, Technician> techs = new Dictionary<String, Technician>();


        public Dictionary<String, Technician> RegisterNewTechnician(String key, Technician tech)
        {
            techs.Add(key, tech);
            return techs;
        }
        public Dictionary<String, Technician> UpdateTechnicianInfo(int id, Technician tech)
        {
            if (id == tech.StaffId)
            {
                foreach (var item in techs.Values)
                {
                    if (item.StaffId == tech.StaffId)
                    {
                        // Update
                        
                        item.StaffName = tech.StaffName;
                        item.Email = tech.Email;
                        item.DeptName = tech.DeptName;
                        item.Education = tech.Education;
                        item.ContatNo = tech.ContatNo;
                        item.Gender = tech.Gender;
                        item.DateOfBirth = tech.DateOfBirth;
                        item.StaffCategory = tech.StaffCategory;
                        item.ShiftStartTime = tech.ShiftStartTime;
                        item.ShiftEndTime = tech.ShiftEndTime;
                        item.BasicPay = tech.BasicPay;
                        item.Specialization = tech.Specialization;
                        item.Fees = tech.Fees;
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
            return techs;
        }
        public Dictionary<String, Technician> DeleteTechnician(String id)
        {
            // Logic for Delete
            // 1. Serach the object
            foreach (var item in techs.Keys)
            {
                if (item == id)
                {
                    techs.Remove(item);
                    break;
                }
            }
            // 2. Delete

            return techs;
        }
        public Technician GetTechnicianById(int id)
        {

            // Search based on if if dounf return else return null
            return new Technician();
        }
        public Dictionary<String, Technician> GetAllTechnicians()
        {
            return techs;
        }
        public double netIncome(int id)
        {
            double netIncome = 0;
            var tech = GetAllTechnicians();
            foreach (var item in tech.Values)
            {
                if (id == item.StaffId)
                {
                    float hospitalShare = 0.7f;
                    netIncome = item.BasicPay + (hospitalShare - item.BasicPay);
                }
            }
            return netIncome;
        }
    }
}
