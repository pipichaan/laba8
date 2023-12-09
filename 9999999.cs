Console.WriteLine("Введите x");
Console.WriteLine("Введите y");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
try //код с возможным исключением 
{
    int z = x / y;
    if (x == 0)
    {
        throw new Exception("искл"); //генерация исключения(сюда передается сообщение об исключении)
    }
    else
    {
        Console.WriteLine($"ответ {z}");
    }
}
catch (DivideByZeroException rr) // делить на 0 нельзя(обработка исключения)
{
    Console.WriteLine(rr.StackTrace);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message); // позволяет получть информацию об исключении
}
