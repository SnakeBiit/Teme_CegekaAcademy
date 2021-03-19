using GenericsExercise.Console.Given;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericsExercise.Console
   
{
    public class Program
    {

        static ServicePersistence pers = new ServicePersistence();
        static List<Student> studs = new List<Student>();
        static List<University> univs = new List<University>();
        
        static void Main(string[] args)
        {
             
            MainMenu();
           
        }
        static void MainMenu()
        {
            Student stud = new Student();
            University univ = new University();
            System.Console.WriteLine("1.Add a student");
            System.Console.WriteLine("2.Add an university");
            System.Console.WriteLine("3.Show all students");
            System.Console.WriteLine("4.Show all universities");
            System.Console.WriteLine("5.Console clear");
            string userChoice = System.Console.ReadLine();
           
            switch (userChoice){
                case "1":
                    System.Console.WriteLine("Student id: ");
                    string studentId = System.Console.ReadLine();
                    System.Console.WriteLine("Student first name: ");
                    string studentFirstName = System.Console.ReadLine();
                    System.Console.WriteLine("Student last name: ");
                    string studentLastName = System.Console.ReadLine();
                    stud.Id =  studentId;
                    stud.FisrtName = studentFirstName;
                    stud.LastName = studentLastName;
                    studs.Add(stud);

                    Insert(stud);

                    MainMenu();
                    break;

                case "2":
                    System.Console.WriteLine("University id: ");
                    string univId = System.Console.ReadLine();
                    System.Console.WriteLine("University Name: ");
                    string univName = System.Console.ReadLine();
                    System.Console.WriteLine("Univ adress: ");
                    string univAdress = System.Console.ReadLine();
                    univ.Id = univId;
                    univ.Name = univName;
                    univ.Address = univAdress;
                    univs.Add(univ);

                    Insert(univ);

                    MainMenu();
                    break;
                case "3":
                    read<Student>();
                    MainMenu();
                    break;
                case "4":
                    read<University>();
                    MainMenu();
                    break;
                case "5":
                    System.Console.Clear();
                    MainMenu();
                    break;
                default:
                    System.Console.Clear();
                    MainMenu();
                    break;
            }
            
        }
        private static void Insert<T>(T el) where T : IEntity
        {
            pers.InsertAsync<T>(el);
        }
 
        private async static void read<T>() where T:IEntity
        {
            try
            {
                if(pers.GetAllAsync<T>() == null) { throw new InvalidOperationException("No entities of this type stored"); };
                var element = await pers.GetAllAsync<T>();
                int i = 0;
                foreach (var el in element)
                {
                    if (el.GetType() == studs[i].GetType())
                    {
                        System.Console.WriteLine("Student id: " + studs[i].Id + " Name: " + studs[i].FisrtName + " " + "Last Name: " + studs[i].LastName);
                    }
                    else if (el.GetType() == univs[i].GetType())
                    {
                        System.Console.WriteLine("University id: " + univs[i].Id + " University name: " + univs[i].Name + " " + "Adress: " + univs[i].Address);
                    }
                    i++;
                }
            }
            catch(InvalidOperationException i)
            {
                System.Console.WriteLine("Please insert students or universities in order to read them", i.Message);
            }
        }
     
    }
}