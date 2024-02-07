using E_Bussiness_Strategy;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("e-Sigorta Sitesine Hos Geldiniz");

        Console.WriteLine("Size Nasil Yardimci olabiliriz :\n" +
            "1.Trafik Sigortasi \n" +
            "2.Arac Kasko \n" +
            "3.Dogal Afet Sigortasi");
        Console.WriteLine("Secim :");
         int temp = Convert.ToInt32(Console.ReadLine());
        InsuranceContext context = new InsuranceContext(temp);  
    }
}