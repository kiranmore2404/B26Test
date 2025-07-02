Icustomer c1 = new Silvercustomer();
c1.printticket();
Console.WriteLine(c1.getticketAmount());
c1.kk();


c1 = new Goldcustomer();
c1.printticket();
Console.WriteLine(c1.getticketAmount());
c1.printticketanount = 100;
Console.WriteLine(c1.printticketanount);

IA a = new A();
a.printA();
a.print();


IB b = new A();
b.printB();
b.print();

A a2 = new A();
a2.printA();
a2.printB();
((IA)a2).print();
((IB)a2).print();

((IA)a2).print();




Console.Read();
