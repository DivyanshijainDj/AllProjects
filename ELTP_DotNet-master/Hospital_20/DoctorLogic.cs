using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_20
{
    public class DoctorLogic
    {
        Dictionary<String, Doctor> doctors = new Dictionary<String, Doctor>();

        
        public Dictionary<String, Doctor> RegisterNewDoctor(String key, Doctor doctor)
        {
            
            doctors.Add(key, doctor);
            return doctors;
        }
        public Dictionary<String, Doctor> UpdateDoctorInfo(int id, Doctor doctor)
        {
            if (id == doctor.StaffId)
            {
                foreach (var item in doctors.Values)
                {
                    if (item.StaffId == doctor.StaffId)
                    {
                        // Update
                        item.StaffName = doctor.StaffName;
                        item.Email = doctor.Email;
                        item.DeptName = doctor.DeptName;
                        item.Education = doctor.Education;
                        item.ContatNo = doctor.ContatNo;
                        item.Gender = doctor.Gender;
                        item.DateOfBirth = doctor.DateOfBirth;
                        item.ShiftStartTime = doctor.ShiftStartTime;
                        item.ShiftEndTime = doctor.ShiftEndTime;
                        item.BasicPay = doctor.BasicPay;
                        item.Specialization = doctor.Specialization;
                        item.Fees = doctor.Fees;
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
            return doctors;
        }
        public Dictionary<String, Doctor> DeleteDoctor(String id)
        {
            
                foreach (var item in doctors.Keys)
                {
                    if (item == id)
                    {
                        doctors.Remove(id);
                        break;
                    }
                
            }
           
            return doctors;
        }
        public Dictionary<String, Doctor> GetAllDoctors()
        {
            return doctors;
        }
        public Doctor GetDoctorById(int id)
        {
            return new Doctor();
        }
        public double netIncome(int id)
        {
            double netIncome = 0;
            var doc = GetAllDoctors();
            foreach (var item in doc.Values)
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