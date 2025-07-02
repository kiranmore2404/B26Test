
//addDelegate del1 = delegate(int a ,int b)
//{
//    Console.WriteLine("The sum is: " + (a + b));
//};
addDelegate del1 = (a, b) => Console.WriteLine(a + b);
del1(10, 20);



print del = name => name;
string name = del("kiram");
Console.WriteLine(name);

//print del = delegate (string names)
//{
//    return names;
//};


//printa del3 = delegate (string fn , string ln){
//    Console.WriteLine("First Name: " + fn + ", Last Name: " + ln);
//};
//del3("kiran", "more");



printa del3 = (fn, ln) =>
{
    Console.WriteLine("First Name: " + fn + ", Last Name: " + ln);
};
del3("kiran", "more");

printb del4  =  (fn, ln)  =>
{
    return "First Name: " + fn + ", Last Name: " + ln;
};
 string result =   del4("kishor", "more"); 
Console.WriteLine(result);

//getlength del5 = delegate (string d)
//{
//    return d.Length;
//};

getlength del5 = d =>  d.Length; ;

del5("kiran more");
Console.WriteLine("Length of string is: " + del5("kiran more"));







Console.Read();
