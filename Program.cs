namespace Assignment_6._3
{
    class Program
    {
        static void Main()
        {
            CallCenter callCenter = new CallCenter();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Call");
                Console.WriteLine("2. Answer");
                Console.WriteLine("3. Display call count");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter call ID: ");
                            int callId;
                            if (int.TryParse(Console.ReadLine(), out callId))
                            {
                                callCenter.Call(callId);
                            }
                            else
                            {
                                Console.WriteLine("Invalid call ID.");
                            }
                            break;
                        case 2:
                            callCenter.Answer();
                            break;
                        case 3:
                            callCenter.DisplayCallCount();
                            break;
                        case 4:
                            Console.WriteLine("Exiting program.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid choice.");
                }
            }
        }
    }
}
