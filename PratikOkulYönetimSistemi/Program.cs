using PratikOkulYönetimSistemi;

Person student = new Person();
student.Name = "Harry";
student.Surname = "Potter";
student.BirthDate = "31 Temmuz 1980";

Person student2 = new Person();
student2.Name = "Hermione";
student2.Surname = "Granger";
student2.BirthDate = "19 Eylül 1979";

Person student3 = new Person();
student3.Name = "Ron";
student3.Surname = "Weasley";
student3.BirthDate = "1 Mart 1980";

Person teacher = new Person();
teacher.Name = "Albus";
teacher.Surname = "Dumbledore";
teacher.BirthDate = "Temmuz 1881";

student.Student();
student2.Student();
student3.Student();
Console.WriteLine("-----------------------------");
teacher.Teacher();


