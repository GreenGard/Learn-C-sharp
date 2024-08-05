namespace CalculatorApp;

class Program
{
    static void Main(string[] args)
    {
        int num1;
        int num2;
        int sum;
        string calculate;
        

            Console.WriteLine("Add number to calculate");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Add a second number to calculate");
            num2 = Convert.ToInt32(Console.ReadLine());
    

    
            Console.WriteLine("Add operator a for adding, s for substract, m for multiply and any other letter for divide");
            calculate = Console.ReadLine();

            

            if (calculate == "a")
                {
                sum = num1 + num2;
                }
            else if (calculate == "s")
                {
                    sum = num1 - num2;
                }
            else if (calculate == "m")
                {
                    sum = num1 * num2;
                }
            else
                {
                    sum = num1 / num2;
                }

            Console.WriteLine("answer:" + sum);
            
            Console.ReadKey();
    }
}
