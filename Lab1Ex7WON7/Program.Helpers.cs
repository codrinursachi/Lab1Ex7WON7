partial class Program
{
    static (int,int) ReadNumbers()
    {
        Console.WriteLine("Introduceti 2 numere pentru a se verifica daca primul e divizibil cu al doilea");
        var numereRaw = Console.ReadLine()?.Split(" ");
        (int x, int y) numere=default;
        if (numereRaw?.Length != 2 ||
            !int.TryParse(numereRaw?[0],out numere.x)||
            !int.TryParse(numereRaw?[1],out numere.y))
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
        }
        return numere;
    }
    static void CheckDivisible((int,int) numere)
    {
        if (numere.Item1 % numere.Item2 == 0)
            Console.WriteLine("divizibil");
        else
            Console.WriteLine("indivizibil");
    }
}