using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment_4August
{
    public class FileOperation
    {
        FileStream fs;


        public string filepath;
        public FileOperation(string filepath)
        {
            this.filepath = filepath;
        }

        public void CreateFile()
        {
            try
            {
                fs = new FileStream(filepath, FileMode.Create);
                fs.Close();
                fs.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Read(string StaffCategory)
        {
            try
            {
                fs = new FileStream(filepath, FileMode.Open);
                StreamReader streamReader = new StreamReader(fs);

                string dataFromFile = string.Empty;

                Console.WriteLine($" {StaffCategory} are :");
                Console.WriteLine();

              
                     


                while ((dataFromFile = streamReader.ReadLine()) != null)
                {

                    var StaffData = JsonSerializer.Deserialize<Staff>(dataFromFile);
                    if (StaffCategory == StaffData.StaffCategory)
                    {

                        Console.WriteLine($"  StaffId: {StaffData.StaffId}");
                        Console.WriteLine($"StaffName : {StaffData.StaffName}");
                        Console.WriteLine($"StaffCategory : {StaffData.StaffCategory}");
                        Console.WriteLine($"StaffEmail : {StaffData.Email}");
                        Console.WriteLine($"Education : {StaffData.Education}");
                        Console.WriteLine($"ContactNo : {StaffData.ContactNo}");
                        Console.WriteLine();
                    }
                    

                }
            }
            catch (Exception)
            {

                throw;
            }
            fs.Close();
            fs.Dispose();


        }


        public void SearchById(int StaffId)

        {
            try
            {

                fs = new FileStream(filepath, FileMode.Open);
                StreamReader streamReader = new StreamReader(fs);


                string dataFromFile = string.Empty;
                bool FoundStaff = true;

                while ((dataFromFile = streamReader.ReadLine()) != null)
                {
                    var StaffData = JsonSerializer.Deserialize<Staff>(dataFromFile);
                    if (StaffId == StaffData.StaffId)
                    {

                        Console.WriteLine($"\nDetails of entered Staff : ");
                        Console.WriteLine();
                        Console.WriteLine($"  Id: {StaffData.StaffId}");
                        Console.WriteLine($"  Name : {StaffData.StaffName}");
                        Console.WriteLine($"  Category : {StaffData.StaffCategory}");
                        Console.WriteLine($"  Email : {StaffData.Email}");
                        Console.WriteLine($"  Education : {StaffData.Education}");
                        Console.WriteLine($"  Contact : {StaffData.ContactNo}\n");
                        FoundStaff = false;


                        streamReader.Close();

                        break;
                    }

                }
                if (FoundStaff)
                {
                    Console.WriteLine("Staff Record Not Found...!");
                }
            }
            catch (Exception)
            {

                throw;
            }

            fs.Close();
            fs.Dispose();
        }


        public void Delete(int StaffId)
        {
            try
            {
                bool FoundStaff = false;

                List<Staff> DataLeft = new List<Staff>();
                string dataFromFile = string.Empty;

                fs = new FileStream(filepath, FileMode.Open);
                StreamReader streamReader = new StreamReader(fs);


               

                while ((dataFromFile = streamReader.ReadLine()) != null)
                {
                    var StaffData = JsonSerializer.Deserialize<Staff>(dataFromFile);
                    if (StaffId != StaffData.StaffId)
                    {
                        DataLeft.Add(StaffData);
                    }
                    else
                    {
                        FoundStaff = true;
                    }
                }


                streamReader.Close();
                fs.Close();
                fs.Dispose();


                WriteIntoFile(DataLeft);
                if (FoundStaff)
                {
                    Console.WriteLine("Record Deleted1");
                }
                else
                {
                    Console.WriteLine("Staff not found");

                }


            }
            catch (Exception)
            {

                throw;
            }


        }

        public void Update(int StaffId, Staff s)
        {
            bool FoundStaff = false;
            fs = new FileStream(filepath, FileMode.Open);


            StreamReader streamReader = new StreamReader(fs);
            List<Staff> DataLeft = new List<Staff>();


            string dataFromFile = string.Empty;
            while ((dataFromFile = streamReader.ReadLine()) != null)
            {
                var StaffData = JsonSerializer.Deserialize<Staff>(dataFromFile);
                if (StaffId == StaffData.StaffId)
                {
                    DataLeft.Add(s);
                    FoundStaff = true;
                }
                else
                {
                    DataLeft.Add(StaffData);

                }
            }
            streamReader.Close();
            fs.Close();
            fs.Dispose();
            WriteIntoFile(DataLeft);
            if (FoundStaff)
            {
                Console.WriteLine("Updated Sucessfully");
            }
            else
            {
                Console.WriteLine("Staff not found..!!");

            }
        }




        
        public void WriteIntoFile(List<Staff> list)
        {
            try
            {
                File.WriteAllText(filepath, string.Empty);


                foreach (var data in list)
                {
                    fs = new FileStream(filepath, FileMode.Append);

                    StreamWriter streamWriter = new StreamWriter(fs);
                    streamWriter.WriteLine(JsonSerializer.Serialize(data));
                    streamWriter.Close();


                }
                fs.Close();
                fs.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }




        public void Dispose()
        {
            fs.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
