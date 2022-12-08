using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csv_Assignment
{
    
        public class FileOperation
        {
            FileStream filestream;


            public string filepath;
            public FileOperation(string filepath)
            {
                this.filepath = filepath;
            }
            public void csvgenerate()
            {
                try
                {
                using (File.Create(filepath)) ;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            public void CategorySearch(string StaffCategory)
            {
                try
                {
                    using (var reader = new StreamReader(filepath))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var records = csv.GetRecords<Staff>();
                        var record = (from item in records where item.StaffCategory == StaffCategory select item).ToList();
                        foreach (var StaffData in record)
                            if (StaffCategory == StaffData.StaffCategory)
                            {
                                Console.WriteLine($"  StaffId: {StaffData.StaffId}");
                                Console.WriteLine($"\tStaffName : {StaffData.StaffName}");
                                Console.WriteLine($"\tStaffCategory : {StaffData.StaffCategory}");
                                Console.WriteLine($"\tStaffEmail : {StaffData.Email}");
                                Console.WriteLine($"\tEducation : {StaffData.Education}");
                                Console.WriteLine($"\tContactNo : {StaffData.ContactNo}\n");
                            }

                    }
                }
                catch (Exception)
                {

                    throw;
                }
                

            }

            public void SearchByID(int StaffId)

            {
                try
                {

                    using (var reader = new StreamReader(filepath))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var records = csv.GetRecords<Staff>();
                        var StaffData = (from item in records where item.StaffId == StaffId select item).Take(1).ToList();

                        Console.WriteLine($"  StaffId: {StaffData[0].StaffId}");
                        Console.WriteLine($"\tStaffName : {StaffData[0].StaffName}");
                        Console.WriteLine($"\tStaffCategory : {StaffData[0].StaffCategory}");
                        Console.WriteLine($"\tStaffEmail : {StaffData[0].Email}");
                        Console.WriteLine($"\tEducation : {StaffData[0].Education}");
                        Console.WriteLine($"\tContactNo : {StaffData[0].ContactNo}\n");

                    }
                }

                catch (Exception)
                {

                    throw;
                }

            }


            public void CsvWrite(List<Staff> lis)
            {
                try
                {
                    using (var writer = new StreamWriter(filepath))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {

                        csv.WriteRecords(lis);


                    }

                    
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }



            public void Dispose()
            {
                filestream.Dispose();
                GC.SuppressFinalize(this);
            }
        }
    }

