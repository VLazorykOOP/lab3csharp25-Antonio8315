using System;
using System.Linq;

namespace Task_2
{
public class Task_2
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        
        public Person(int id, string surname, string name, int age)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Age = age;
        }
        
        public virtual void Show()
        {
            Console.WriteLine($"ID: {Id}, Прізвище: {Surname}, Ім'я: {Name}, Вік: {Age} років");
        }
    }

    class Employee : Person
    {
        public string Position { get; set; }
        public float Salary { get; set; }

        public Employee(int id, string surname, string name, int age, string position, float salary)
            : base(id, surname, name, age)
        {
            Position = position;
            Salary = salary;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Посада: {Position}, Зарплата: {Salary}");
        }
    }

    class Worker : Employee
    {
        public string WorkType { get; set; }
        public int WorkingHours { get; set; }

        public Worker(int id, string surname, string name, int age, string position, float salary, string workType, int workingHours)
            : base(id, surname, name, age, position, salary)
        {
            WorkType = workType;
            WorkingHours = workingHours;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Тип роботи: {WorkType}, Години роботи: {WorkingHours}");
        }
    }

    class Engineer : Employee
    {
        public string Specialization { get; set; }
        public int QualificationLevel { get; set; }

        public Engineer(int id, string surname, string name, int age, string position, float salary, string specialization, int qualificationLevel)
            : base(id, surname, name, age, position, salary)
        {
            Specialization = specialization;
            QualificationLevel = qualificationLevel;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Спеціалізація: {Specialization}, Рівень кваліфікації: {QualificationLevel}");
        }
    }

    
        public void main2()
        {
            Person[] employees = new Person[]
            {
                new Worker(1, "Іванов", "Олексій", 30, "Робітник", 30000, "Будівництво", 8),
                new Engineer(2, "Петров", "Андрій", 28, "Інженер", 45000, "Програмування", 3),
                new Worker(3, "Сидоров", "Дмитро", 35, "Робітник", 28000, "Монтаж", 10),
                new Engineer(4, "Коваленко", "Ірина", 40, "Інженер", 50000, "Автоматизація", 5)
            };

            Console.WriteLine("Список працівників:");
            foreach (var emp in employees)
            {
                emp.Show();
                Console.WriteLine("--------------------------------");
            }

            // Сортування за віком
            var sortedEmployees = employees.OrderBy(e => e.Age).ToArray();
            Console.WriteLine("\nСписок працівників (відсортовано за віком):");
            foreach (var emp in sortedEmployees)
            {
                emp.Show();
                Console.WriteLine("--------------------------------");
            }
        }
    
}
}
