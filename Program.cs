namespace UserRegistrationwithLambdaexpr
{
    public class  Program
    {
        public static void Main(string[] args)
        {
            List<StudentDetails> studentDetails = new List<StudentDetails>()
            {
                new StudentDetails() {Id=1,Name="Monika",Phoneno=981234567,Address="Gurugram",Age=26},
                new StudentDetails() {Id=2,Name="Sapna",Phoneno=981234567,Address="Chandigarh",Age=29},
                new StudentDetails() {Id=3,Name="Jyoti",Phoneno=981234567,Address="Hamirpur",Age=31},
                new StudentDetails() {Id=4,Name="Rajeev",Phoneno=981234567,Address="Hamirpur",Age=32},
                new StudentDetails() {Id=5,Name="Sanjeev",Phoneno=981234567,Address="Hamirpur",Age=30},
                new StudentDetails() {Id=6,Name="Indu",Phoneno=981234567,Address="Hamirpur",Age=30},
                new StudentDetails() {Id=7,Name="Bandna",Phoneno=981234567,Address="Hamirpur",Age=37},
                new StudentDetails() {Id=8,Name="Priya",Phoneno=981234567,Address="Punjab",Age=20},
                new StudentDetails() {Id=9,Name="Bandu",Phoneno=981234567,Address="Punjab",Age=30},
                new StudentDetails() {Id=10,Name="Disu",Phoneno=981234567,Address="Hamirpur",Age=20},
                new StudentDetails() {Id=11,Name="Simran",Phoneno=981234567,Address="Hamirpur",Age=13},
                new StudentDetails() {Id=12,Name="Shanvi",Phoneno=981234567,Address="Hamirpur",Age=10},

            };
            //foreach(var list in studentDetails)
            //{
            //    Console.WriteLine($"ID= {list.Id} Name= {list.Name} Phoneno= {list.Phoneno} Address= {list.Address} Age= {list.Age}");
            //}

            Console.WriteLine("----------------------------------------Filter with Age---------------------------");
            Student_Management.StudentsDatawithAge(studentDetails);
            Console.WriteLine("----------------------------------------data arrange in decending order---------------------------");
            Student_Management.StudentsDataSortedinDecendingOrderBasedonAge(studentDetails);
            Console.WriteLine("--------------------------------------Search Student Data with Name-------------------------");
            Student_Management.SearchStudentDatawithName(studentDetails);

        }
    }
}