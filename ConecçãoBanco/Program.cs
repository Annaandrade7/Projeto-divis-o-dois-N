
try //tratamento de exeção 
{
    Console.WriteLine("Informe o primeiro valor!");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo valor!");
    int b = int.Parse(Console.ReadLine());
    int result = a / b;
    Console.WriteLine(result);
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("Algo de errado não esta certo!"+ ex.Message);
}
catch(FormatException ex)
{
    Console.WriteLine("Conversão de string para letra não é permitida!"+ ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Ocorreu um erro!"+ ex.Message);
}
finally
{
    Console.WriteLine("Passa aa");
}