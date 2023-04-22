using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationwithLambdaexpr
{
    public class Student_Management
    {
        public static void StudentsDatawithAge(List<StudentDetails> studentDetails)
        {
            //----------------------------------------Filter with Age---------------------------
            //By using LINQ
            //var studentsByAge = from StudentDetails in studentDetails where StudentDetails.Age >= 12 && StudentDetails.Age <= 18 select StudentDetails;
            //By using LAMBDA EXPRESSION c                                                
            var StudentByAgeLambda =studentDetails.FindAll(age =>age.Age >=12 && age.Age <=18);
            
            foreach(var list in StudentByAgeLambda)
            {
                Console.WriteLine($"ID= {list.Id} Name= {list.Name} Phoneno= {list.Phoneno} Address= {list.Address} Age={list.Age}");
            }
        }
        //----------------------------------------data arrange in decending order---------------------------

        public static void StudentsDataSortedinDecendingOrderBasedonAge(List<StudentDetails> studentDetails)
        {
            //var StudentByAgeLambda=studentDetails.OrderByDescending
                foreach(var list in studentDetails.OrderByDescending(age => age.Age).ToList())
                {
                Console.WriteLine($"ID= {list.Id} Name= {list.Name} PhoneNo= {list.Phoneno} Address= {list.Address} Age={list.Age}");

                }
        }
        //----------------------------------------Search Student Data with Name---------------------------

        public static void SearchStudentDatawithName(List<StudentDetails> studentDetails)
        {
            var lambdaexprOFname = studentDetails.Any(name => name.Name == "Monika");
            Console.WriteLine(lambdaexprOFname);
        }



    }
}
