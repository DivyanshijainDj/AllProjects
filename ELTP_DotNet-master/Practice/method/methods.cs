using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.method
{
    
        public class  methods
        {

         public int Age;

          string Name;

        public void ObjectQuery()

        {

            List<methods> people = new List<methods>();

            people.Add(new methods { Age = 12, Name = "Bob" });

            people.Add(new methods { Age = 44, Name = "Cindy" });

            people.Add(new methods { Age = 13 , Name= "Sanidhya"});

            people.Add(new methods { Age = 2, Name = "divyanshi" });

            

           

            var teenagers = from person in people

                            where person.Age > 11 && person.Age < 40

                            select person;

            Console.WriteLine("Results:");

            foreach (var teen in teenagers)

            {

                Console.WriteLine("--> Name = {0}, Age = {1}", teen.Name, teen.Age);

            }

            Console.ReadLine();

            // static void main(string[] args)
            //{

            //    ObjectQuery();
            //}
        }



    }
       
    }

