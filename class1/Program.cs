Student s1 = new Student();

s1.Print(); // test name



Student s2 = new Student();

s2.Print(); // test name



Student s3 = new Student();

s3.Print(); // test name



Student s4 = new Student("vihaan", "rahtod");

s4.Print(); // vihaan rathod



// copy s4 object to new object

// Student s5 = new Student(s4.FirstName, s4.LastName);



//Student s5 = new Student();

//s5.FirstName = s4.FirstName;

//s5.LastName = s4.LastName;



Student s5 = new Student(s4);

s5.Print(); // vihaan rathod



Student s6 = s5;

s6.Print();



s6.FirstName = "mihaan";



s6.Print();

s5.Print();



Console.Read();