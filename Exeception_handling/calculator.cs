
public class calculator
{
    public void division(int a, int b)
    {
        try
        {
            int c = a / b;
            Console.WriteLine($"Division of {a} / {b} = {c}");
         

        }
        catch
        {
            //Console.WriteLine($" inner exeception called { ex.Message}");
            //throw new Exception("This is a custom exception message");
            throw;

        }
        
    }
}
