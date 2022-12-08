using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CS_FirstFile.Operations
{
    public class FileOperation
    {
        public void CreateFile(string directory, string fileName)
        {
            try
            {
                if (fileName.Substring(fileName.Length - 4) != ".txt")
                {
                    throw new Exception("File Format is not correct");
                }
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                
                FileStream fs = File.Create($"{directory}{fileName}");
                Console.WriteLine("The File is created successfully");
                // Close the file so that the handle can be released
                // and the file is accessible fr other operations
                fs.Close();
                fs.Dispose();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public void WriteFile(string directory, string fileName, string contents)
        {
            try
            {
                if (fileName.Substring(fileName.Length - 4) != ".txt")
                {
                    throw new Exception("File Format is not correct");
                }

                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }

                File.WriteAllText(directory+ fileName, contents);
                Console.WriteLine("Contents are written to the File");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void WriteFile( string fileName, string[] contents)
        {
            try
            {
                if (fileName.Substring(fileName.Length - 4) != ".txt")
                {
                    throw new Exception("File Format is not correct");
                }
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                File.WriteAllLines(fileName, contents);
                Console.WriteLine("Contents are written to the File");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ReadFile(string directory, string fileName)
        {
            try
            {
                if (fileName.Substring(fileName.Length - 4) != ".txt")
                {
                    throw new Exception("File Format is not correct");
                }
                string contents = string.Empty;
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                contents = File.ReadAllText(directory+ fileName);
                return contents;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AppendFile(string directory, string fileName, string contents)
        {
            try
            {
                if (fileName.Substring(fileName.Length - 4) != ".txt")
                {
                    throw new Exception("File Format is not correct");
                }
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                File.AppendAllText(directory+ fileName, contents);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AppendFile(string fileName, string[] contents)
        {
            try
            {
                if (fileName == string.Empty)
                {
                    throw new Exception("File Name Cannot be Empty");
                }
                File.AppendAllLines(fileName, contents);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void MakeCopy(string srcFileName, string destFileName)
        {
            if (srcFileName.Substring(srcFileName.Length - 4) != ".txt" && destFileName.Substring(destFileName.Length - 4) != ".txt")
            {
                throw new Exception("File Format is not correct");
            }
            if (srcFileName == string.Empty || destFileName == string.Empty)
            {
                throw new Exception("Source File Name or Destination File NAme Cannot be Empty");
            }
            File.Copy(srcFileName, destFileName);
            
        }

        public void move(string fileName, string destFileName)
        {
            if (fileName.Substring(fileName.Length - 4) != ".txt")
            {
                throw new Exception("File Format is not correct");
            }
            if (fileName == string.Empty || fileName == string.Empty)
            {
                throw new Exception("Source File Name or Destination File NAme Cannot be Empty");
            }
            File.Move(fileName, destFileName);

        }
        public void encrypt(string fileName)
        {
            if (fileName.Substring(fileName.Length - 4) != ".txt" )
            {
                throw new Exception("File Format is not correct");
            }
            if (fileName == string.Empty || fileName == string.Empty)
            {
                throw new Exception("Source File Name or Destination File NAme Cannot be Empty");
            }
            File.Encrypt(fileName);

        }


        public void decrypt(string srcFileName)
        {
            if (srcFileName.Substring(srcFileName.Length - 4) != ".txt" )
            {
                throw new Exception("File Format is not correct");
            }
            if (srcFileName == string.Empty)
            {
                throw new Exception("Source File Name or Destination File NAme Cannot be Empty");
            }
            File.Decrypt(srcFileName);

        }



        public void delete(string fileName)
        {
            if (fileName.Substring(fileName.Length - 4) != ".txt")
            {
                throw new Exception("File Format is not correct");
            }
            if (fileName == string.Empty || fileName == string.Empty)
            {
                throw new Exception("Source File Name or Destination File NAme Cannot be Empty");
            }
            File.Delete(fileName);

        }


    }
}