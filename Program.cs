
Console.ForegroundColor =  ConsoleColor.DarkGreen;
Console.WriteLine("--- Rolagem de Dado ---\n");
Console.ResetColor();
Console.Write("Quantas faces? ");
int faces = int.Parse(Console.ReadLine());

Random random = new Random();
int resultado = random.Next(1, faces+1);
Console.WriteLine("\n--- Rolagem de Dado ---\n");
Console.WriteLine("Rolagem: " + resultado);
