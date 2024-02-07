using E_Bussiness_Composite;

public class Program
{
    private static void Main(string[] args)
    {
        


        IShopping shopping1 = new Pant(2);
        IShopping shopping2 = new Shirt(2);
        IShopping  shopping3 = new Shoe(2);

        Process process = new Process(shopping1);

       
        process.stock_Delete();
        shopping1.get_Stock();
        process.stock_Update();
        shopping1.get_Stock();

        /*
            username = "mecitmert";
            password = "mecit123";
         */

    }
}