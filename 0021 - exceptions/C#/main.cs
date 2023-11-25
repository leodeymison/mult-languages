using System;

class Project
{
    static void Main()
    {
        try
        {
            int n1 = 10;
            int n2 = 0;
            int res = n1 / n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
        }
        catch (Exception error)
        {
            Console.WriteLine("Erro ao dividir valores", error);
            Console.WriteLine("Message: {0}", error.Message);
            Console.WriteLine("Tipo...: {0}", error.GetType());
        }

        try
        {
            int n1 = 10;
            int n2 = 2;
            int res = n1 / n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
        }
        catch (Exception error)
        {
            Console.WriteLine("Erro ao dividir valores: {0}", error);
        }
        finally
        {
            Console.WriteLine("Fim do processo");
        }
    }
}