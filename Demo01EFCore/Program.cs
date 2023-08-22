// See https://aka.ms/new-console-template for more information

using Demo01EFCore.Data;
using Demo01EFCore.Models;

using var context = new ApplicationDbContext();

/*
Student student = new Student()
{
    FirstName = "Carole2",
    LastName = "Topart",
    Phone = "0101010101",
    Email = "carole.topart@gmail.com"
};
*/

/*
//CREATE => Ajout d'un étudiant
context.Students.Add(student);  
context.SaveChanges();
*/

/*
//READ
Console.WriteLine("Récupération de tous les étudiants !");
List<Student> students = context.Students.ToList();
foreach (var s in students)
        Console.WriteLine($"{s.Id} {s.FirstName} {s.LastName}");
Console.WriteLine("Récupération de l'Id [1]!");
Student student1 = context.Students.Find(1)!;
Console.WriteLine($"{student1.Id} {student1.FirstName} {student1.LastName}");
*/

/*
Console.WriteLine("recup d'un entity avec un prédicat (delegate qui retourne un booléen)"); 
Student student2 = context.Students.SingleOrDefault(s => s.LastName == "Topart")!;
Console.WriteLine($"{student2.Id} {student2.LastName} {student2.LastName}");

Console.WriteLine("recup de plusieurs entity avec un prédicat (delegate qui retourne un booléen)");
List<Student> students = context.Students.Where(s => s.LastName = "Topart").ToList();
foreach (var s in students)
    Console.WriteLine($"{s.Id} {s.FirstName} {s.LastName}");
*/

/*
//UPDATE
Console.WriteLine("Récupération de l'id");
Student student2 = context.Students.Find(2)!;
Console.WriteLine($"Màj de l'id 2");
student2.FirstName = "Carole Bis";
context.Students.Update(student2);
context.SaveChanges();
*/

/*
//DELETE
Student student4 = context.Students.Find(2);
context.Students.Remove(student4);
context.SaveChanges();
*/