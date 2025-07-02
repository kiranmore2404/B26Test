
employee e1 = new employee();
e1.firstname = "kiran";
e1.lastname = "more";
e1.print();

employee e2 = new parttimeemployee() { firstname = "kiran", lastname = "more", hourssalary = 13444 };
e2.print();


e1 = new parttimeemployee()
{
    firstname = "shiv",
    lastname = "wagmare",
    hourssalary = 20000,

};
e1.print();




Console.Read();
