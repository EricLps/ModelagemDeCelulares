using System;
using AbstraindoUmCelular.Models;

namespace AbstraindoUmCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Nokia nokia = new Nokia(numero: "123456789", modelo: "G21", imei: "111111111", memoria: 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");
            Console.WriteLine($"Número: {nokia.Numero}, Modelo: {nokia.Modelo}, IMEI: {nokia.IMEI}, Memória: {nokia.Memoria}GB");

            Console.WriteLine("\n-----------------------------------\n");

            Console.WriteLine("Smartphone iPhone:");
            Iphone iphone = new Iphone(numero: "987654321", modelo: "14 Pro", imei: "222222222", memoria: 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
            Console.WriteLine($"Número: {iphone.Numero}, Modelo: {iphone.Modelo}, IMEI: {iphone.IMEI}, Memória: {iphone.Memoria}GB");

            Console.WriteLine("\nTestes concluídos.");
        }
    }

}
