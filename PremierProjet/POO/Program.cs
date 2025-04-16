

using _10_heritage;

namespace Classes
{
    class Program
    {
        class Person
        {
            private string name; // field 
            public string Name // property 
            {
                get
                {
                    return name;
                }
                //set
                //{
                //    name = value;
                //}
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("Name cannot be empty.");
                    name = value;
                }
            }
        }

        internal class Student
        {
            public int id, age;
            public string name, subject;

            public Student(int id, string name, int age, string subject)
            {
                this.id = id;
                this.age = age;
                this.name = name;
                this.subject = subject;
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Student id: {id}\nStudent name: {name}\n" +
                    $"Student age: {age}\nStudent sugject: {subject}\n");
            }
        }
        class StudentsGenertor
        {
            Student student1 = new Student(001, "Jack", 23, "Math");
            Student student2 = new Student(001, "Harry", 27, "Science");
            Student student3 = new Student(001, "Omnia", 25, "Programming");
            Student student4 = new Student(001, "Ahmed", 22, "English");
            public List<Student> StudentsList()
            {
                List<Student> students = new List<Student>();
                students.Add(student1);
                students.Add(student2);
                students.Add(student3);
                students.Add(student4);
                return students;
            }

            public void DisplayStudentsList()
            {
                foreach (var student in StudentsList())
                {
                    student.ShowInfo();
                }
            }
        }

        class Vehicle
        {
            public string Brand { get; set; }

            public void Honk()
            {
                Console.WriteLine("Bippp, bipp, biiiip!");
            }
        }

        /* sealed */ class Car : Vehicle
        {
            public string Model { get; set; }
        }

        public interface ICalculable
        {
            // Membres statiques
            static int Factor = 10;
            static int MultiplyByFactor(int number) => number * Factor;
            // Méthode avec un corps, implémentation par défaut
            public int Ajouter(int a, int b) => a + b;
    
            // Méthode sans corps, nécessitant une implémentation dans la classe
            public int Soustraire(int a, int b);

            // Type imbriqué
            public class NestedClass
            {
                public void Display() => Console.WriteLine("Inside NestedClass");
            }
        }

        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Liam";
            Console.WriteLine(person1.Name);

            StudentsGenertor studentsGenertor = new StudentsGenertor();
            studentsGenertor.DisplayStudentsList();

            Car car = new Car();
            car.Brand = "Opel";
            car.Model = "Corsa";
            Console.WriteLine($"The car brand is : {car.Brand}, it's model is : {car.Model}");
            car.Honk();

            Vehicule vehicule = new Vehicule("BMW", 340, 30);
            Voiture voiture1 = new Voiture("Honda", 200, 100, 4);
            Moto moto = new Moto("Yamaha", 300, 40, 12);
            Console.WriteLine(vehicule);
            Console.WriteLine(voiture1);
            Console.WriteLine(moto);
            moto.SetVitesse(150);
            voiture1.SetVitesse(380);
            Console.WriteLine(voiture1);
            Console.WriteLine(moto);
        }
    }
}