using DesafioPOO.Models;

Console.WriteLine("=== TESTE DO SISTEMA DE SMARTPHONES ===\n");

// Criando instância do Nokia
Console.WriteLine("--- TESTANDO NOKIA ---");
Nokia nokia = new Nokia("11999999999", "Nokia 3310", "123456789012345", "32GB");
Console.WriteLine($"Número: {nokia.Numero}");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n" + new string('-', 40) + "\n");

// Criando instância do iPhone
Console.WriteLine("--- TESTANDO IPHONE ---");
Iphone iphone = new Iphone("11999999999", "iPhone 12", "123456789012345", "128GB");
Console.WriteLine($"Número: {iphone.Numero}");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
Console.WriteLine("\n" + new string('-', 40) + "\n");


// Demonstrando polimorfismo
Console.WriteLine("--- DEMONSTRANDO POLIMORFISMO ---");
List<Smartphone> smartphones = new List<Smartphone>
{
    new Nokia("11555554444", "Nokia Lumia", "333333333333333", "32GB"),
    new Iphone("11333332222", "iPhone 14", "444444444444444", "128GB")
};

string[] apps = { "Angry Birds", "Spotify" };
for (int i = 0; i < smartphones.Count; i++)
{
    Console.WriteLine($"Smartphone {i + 1}:");
    smartphones[i].InstalarAplicativo(apps[i]);
}

Console.WriteLine("\nTestes concluídos!");