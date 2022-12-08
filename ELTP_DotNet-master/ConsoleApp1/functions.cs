using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aug4_files;

namespace Aug4_files
{
    public class functions
    {

        public static void GetDetails(string pathDir)
        {
            DirectoryInfo place = new DirectoryInfo(pathDir);

            FileInfo[] Files = place.GetFiles();
            Console.WriteLine("Files are:");
            Console.WriteLine();

            // Display the file names
            foreach (FileInfo i in Files)
            {
                Console.WriteLine(i.Name);
            }


            //gettings deatils of the files
            Console.WriteLine();
            Console.WriteLine("Please enter FileName to get details: ");

            string fileName;
            fileName = Console.ReadLine();


            if (fileName.Length == 0)
            {
                Console.WriteLine("Invalid File! Please enter a valid File name! ");
            }
            else
            {
                string path = @"C:\Users\coditas\Desktop\data\" + fileName;
                Console.WriteLine();


                FileInfo extension = new FileInfo(path);
                Console.WriteLine("==========================================");
                Console.WriteLine();
                Console.WriteLine("File Path : " + extension.FullName);
                Console.WriteLine("File Name : " + extension.Name);
                Console.WriteLine("File Extension : " + extension.Extension);
                Console.WriteLine("File Size : " + extension.Length);
                Console.WriteLine("File Created : " + extension.CreationTime);
                Console.WriteLine("File Modified : " + extension.LastWriteTime);
                Console.WriteLine("Last File Accessed : " + extension.LastAccessTime);
                Console.WriteLine("File Mode (Read) : " + extension.IsReadOnly);
                Console.WriteLine();
            }

        }



        public static void GetFiles()
        {
            DirectoryInfo place = new DirectoryInfo(@"C:\Users\coditas\Desktop\data");


            FileInfo[] Files = place.GetFiles();
            Console.WriteLine("Files in Directory are:");
            Console.WriteLine("=============================================================");
            Console.WriteLine();


            // Display the file names
            Console.WriteLine(" Name         Ext.         Size            Created              Modified");
            foreach (FileInfo i in Files)
            {
                Console.WriteLine("{0}      {1}         {2}         {3}        {4} ", i.Name, i.Extension, i.Length, i.CreationTime, i.LastWriteTime);
            }

            string path = @"C:\Users\coditas\Desktop\data";
            if (System.IO.Directory.GetDirectories(path).Length > 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("***************     Directory has Sub-Directory whose files are :     ****************** ");

                Console.WriteLine();

                                 
                string[] dirs = Directory.GetDirectories(path);

                foreach(var substring in dirs)
                {
                   
                    DirectoryInfo subdir = new DirectoryInfo(substring);

                    FileInfo[] subfiles = subdir.GetFiles();
                    Console.WriteLine($"Files in {substring} are :");
                    Console.WriteLine("=============================================================");

                    Console.WriteLine();

                    // Display the file names
                    foreach (FileInfo i in subfiles)
                    {
                        Console.WriteLine(i.Name, i.CreationTime);
                    }
                    Console.WriteLine();

                    
                }

            }
        }



        public static void CopyFiles()
        {
            string source_dir = @"C:\Users\coditas\Desktop\data";
            

            Console.WriteLine("Create Directory for copying");
            string DirName = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(DirName))
            {
                Console.WriteLine("Please enter Folder name , Try again!");
                Console.WriteLine();

            }
            else
            {
                string destination_dir = @"C:\Users\coditas\Desktop\" + DirName;


                foreach (string dir in System.IO.Directory.GetDirectories(source_dir, "*", System.IO.SearchOption.AllDirectories))
                {
                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(destination_dir, dir.Substring(source_dir.Length + 1)));

                }

                foreach (string file_name in System.IO.Directory.GetFiles(source_dir, "*", System.IO.SearchOption.AllDirectories))
                {

                    System.IO.File.Copy(file_name, System.IO.Path.Combine(destination_dir, file_name.Substring(source_dir.Length + 1)));

                }
                Console.WriteLine("Files Coiped Sucessfully!! ");
                Console.WriteLine();

            }
                
        }

        public static void imageConversion(string imageName)
        {

            FileStream fs = new FileStream(imageName, FileMode.Open, FileAccess.Read);

            byte[] imgByteArr = new byte[fs.Length];

            fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));
            fs.Close();


            //foreach (var bytes in imgByteArr)
            //{
            //    Console.Write(bytes);
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            byteToImage(imgByteArr);
            

        }

       static void byteToImage(byte[] result)
        {
            MemoryStream ms = new MemoryStream(result);
            Image ConvertedImage = Image.FromStream(ms);

            ConvertedImage.Save(@"C:\Users\coditas\Desktop\huskyConverted.jpg");

            Console.WriteLine("Image converted sucessfully !!");
        }

    }
}
