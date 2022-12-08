using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_20
{
    public class NurseLogic
    {

        Dictionary<String, Nurse> nurses = new Dictionary<String, Nurse>();

        public Dictionary<String, Nurse> RegisterNewNurse(String key, Nurse nurse)
        {
            nurses.Add(key, nurse);
            return nurses;
        }
        public Dictionary<String, Nurse> UpdateNurseInfo(int id, Nurse nurse)
        {
            if (id == nurse.StaffId)
            {
                foreach (var item in nurses.Values)
                {
                    if (item.StaffId == nurse.StaffId)
                    {
                        // Update
                        item.StaffName = nurse.StaffName;
                        item.Email = nurse.Email;
                        item.DeptName = nurse.DeptName;
                        item.Education = nurse.Education;
                        item.ContatNo = nurse.ContatNo;
                        item.Gender = nurse.Gender;
                        item.DateOfBirth = nurse.DateOfBirth;
                        item.StaffCategory = nurse.StaffCategory;
                        item.ShiftStartTime = nurse.ShiftStartTime;
                        item.ShiftEndTime = nurse.ShiftEndTime;
                        item.BasicPay = nurse.BasicPay;
                        item.Specialization = nurse.Specialization;
                        item.Fees = nurse.Fees;
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
            return nurses;
        }
        public Dictionary<String, Nurse> DeleteNurse(String id)
        {
            // Logic for Delete
            // 1. Serach the object
            foreach (var item in nurses.Keys)
            {
                if (item == id)
                {
                    nurses.Remove(item);
                    break;
                }
            }
            // 2. Delete
            return nurses;
        }
        public Dictionary<String, Nurse> GetAllNurses()
        {
            return nurses;
        }
        public Nurse GetNurseById(int id)
        {

            // Search based on if if dounf return else return null
            return new Nurse();
        }
        public double netIncome(int id)
        {
            double netIncome = 0;
            var nurse = GetAllNurses();
            foreach (var item in nurse.Values)
            {
                if (id == item.StaffId)
                {
                    float hospitalShare = 0.7f;
                    netIncome = item.BasicPay + item.Fees + (hospitalShare - item.BasicPay);
                }
            }
            return netIncome;
        }
    }
}
