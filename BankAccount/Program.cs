using System.ComponentModel.Design;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int correctPin = 1234;
            int enteredPin;

            Console.WriteLine("Ange din pinkod:");
            //Konvertera användarens inmatning till ett heltal
            bool isValidPin = int.TryParse(Console.ReadLine(), out enteredPin);

            //Kontrollera om PIN-koden stämmer
            if (isValidPin && enteredPin == correctPin)
            {
                //Instansiera bankAccount klassen och testa den
                PersonalBankAccount account = new PersonalBankAccount("1234556", "Jane Doe", 369669.99m);



                //Instansiera bankAccount klassen och testa den
                //PersonalBankAccount account=new PersonalBankAccount("1234556", "Jane Doe", 369669.69m);


                while (true)
                {
                    Console.WriteLine("\nVälj följande alternativ:");
                    Console.WriteLine("1: Insättning");
                    Console.WriteLine("2: Uttag");
                    Console.WriteLine("3: Saldo");
                    Console.WriteLine("4: Avsluta");
                    //Läser användarens val
                    string? choice = Console.ReadLine();

                    if (string.IsNullOrEmpty(choice))
                    {
                        Console.WriteLine("Ogiltig inmatning försök igen");
                        continue;
                    }


                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Ange beloppet du vill sätta in:");
                            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                            {
                                account.Deposit(depositAmount);
                            }
                            else
                            {
                                Console.WriteLine("Ogiligt belopp.");
                            }
                            break;
                        case "2":
                            Console.WriteLine("Ange belopp för uttag");
                            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                            {
                                account.Withdraw(withdrawAmount);
                            }
                            else
                            {
                                Console.WriteLine("Ogiligt belopp");

                            }
                            break;
                        case "3":
                            account.DisplayBalance();
                            return;
                        case "4":
                            Console.WriteLine("Loggar ut...");
                            return; //Avslutar hela programmet

                        default:
                            Console.WriteLine("Ogiltigt val. Vänligen ange ett giltigt alternativ.");
                            break;








                    }
                }


            }
            else
            {
                Console.WriteLine("Felaktig PIN-kod.");
            }
        }
    }
}