using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Smartphone nokia = new Nokia("123456", "Nokia 3310", "111111111111111", 64);
        Console.WriteLine("### Teste com Nokia ###");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Testando a classe iPhone
        Smartphone iphone = new Iphone("654321", "iPhone 13", "222222222222222", 128);
        Console.WriteLine("### Teste com iPhone ###");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("Testes concluídos.");
    }
}
