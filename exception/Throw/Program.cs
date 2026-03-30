try
{
    A.executandoA();
}

catch(Exception ex)
{
        Console.WriteLine($"A exceção foi tratada ba cgana de A: {ex.Message}");
}

class A
{
    public static void executandoA()
    {
        //try
        //{
            B.executandoB();
        //}
        //catch (Exception ex) 
        //{
        //    Console.WriteLine($"A execeção foi tratada em A: {ex.Message}");
        //}
    }
}

class B
{
    public static void executandoB() 
    {

        C.executandoC();
        /*try
        {
        }
        catch (Exception ex) 
        {
            Console.WriteLine($"A execeção foi tratada em B: {ex.Message}");
        }*/

    }
}

class C
{
    public static void executandoC()
    {
        throw new NotImplementedException("O método não foi implementado em C");
    }
}