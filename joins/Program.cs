

var trainers = Trainer.GetAll();
Console.WriteLine("Trainers:");
foreach (var trainer in trainers)
{
    Console.WriteLine($"Id: {trainer.Id}, Name: {trainer.Name}, Experience: {trainer.Experience}");
}


var students = Student.GetAll();
Console.WriteLine("\nStudents:");
foreach (var student in students)
{
    Console.WriteLine($"RollNumber: {student.RollNumber}, Name: {student.Name}, City: {student.City}, TrainerId: {student.TrainerId}");
}
//var innerjoin = students.Join(trainers, s => s.TrainerId, t => t.Id, (s, t) => new { sname = s.Name,tname = t.Name});
//Console.WriteLine("**** inner join result ****");

//foreach (var item in innerjoin)

//{

//    Console.WriteLine($"student name : {item.sname} trainer name : {item.tname}");

////}

//var innerjoin = students.GroupJoin(trainers, s => s.TrainerId, t => t.Id, (s, st) => new { sname = s.Name, });
//Console.WriteLine("**** inner join result ****");

//foreach (var item in innerjoin)

//{

//    Console.WriteLine($"student name : {item.sname} trainer name :");

//}






Console.Read();