// See https://aka.ms/new-console-template for more information
String name;
int age;
String address;
double balance = 9000;
int option= 0;
int i = 0;

double deposit = 0;
double withdraw;
double newBalance = 0;



while(option != 3)
{
    Console.WriteLine("option 1\n Open an account \n option 2 \n Perform Transactions \n option 3\n Exit the application: ");
    Console.WriteLine("Enter option: ");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
        //Console.WriteLine("option 1\n Open an account \n option 2 \n Perform Transactions \n option 3\n Exit the application: ");
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Ener your age: ");
            age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your address: ");
            address = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("You are welcome: " + name);
          
            break;
         

        case 2:
            i++;
            newBalance = balance;
            Console.WriteLine("Enter 1 to deposit, Enter 2 to withdraw, Enter 3 to qiut: ");
            int option2;
            option2 = Convert.ToInt32(Console.ReadLine());
            
            switch (option2)
            {
                case 1: 
            Console.WriteLine("Enter amount to deposit: ");
            deposit = Convert.ToDouble(Console.ReadLine());
            newBalance += deposit;
             Console.WriteLine("Your new balance is: " + newBalance);
             break;

                case 2:
             Console.WriteLine("Enter amount to withdraw: ");
             withdraw = Convert.ToDouble(Console.ReadLine());
                    if (withdraw > balance)
                    {
                        Console.WriteLine("Insuffient Balance");
                    }
                    else
                    {
                        newBalance -= withdraw;
                        Console.WriteLine("Your new balance is: " + newBalance);
                    }
                    Console.WriteLine("your number of transaction so far: " +i);
                    break;
                case 3:
                    option = 3;
                    break;
                default:
                    Console.WriteLine("you have not input a valid number");
                    break;
                    
                    

            }
            break;


    }
  
}
