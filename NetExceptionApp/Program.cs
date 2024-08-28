try
{
    ParsInt();
}
catch (Exception ex)
{
    Console.WriteLine($"Level 0: {ex.Message}");
}



void ParsInt()
{
    try
    {
        string snumber = "123a";
        int number = Int32.Parse(snumber);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Level 1: {ex.Message}");
        throw;
    }
}



//string snumber = "123";
//int number;

//if (Int32.TryParse(snumber, out number))
//{
//    Console.WriteLine($"Not error {number}");
//}
//else
//{
//    Console.WriteLine("Error");
//}



//try
//{
//    int a = 10, b;
//    b = Int32.Parse(Console.ReadLine());

//    Console.WriteLine(a / b);
//}
//catch(Exception ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//    return;
//}
//finally
//{
//    Console.WriteLine("Finally block");
//}