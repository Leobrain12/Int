using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    interface Ibased
    {
        double BasedDouble(double basedouble);
        int BasedInt(int basedint);
        char BasedChar(char basedchar);

    }
    public class Based : Ibased
    {
        public double BasedDouble(double basedouble)
        {
            Console.WriteLine("Введите дробное число - ");
            basedouble = Convert.ToDouble(Console.ReadLine());
            Console.Write(basedouble);
            return basedouble;
        }
        public int BasedInt(int basedint)
        {
            Console.Write(basedint);
            return basedint;
        }
        public char BasedChar(char basedchar)
        {
            Console.WriteLine("Введите букву - ");
            basedchar = Convert.ToChar(Console.ReadLine());
            Console.Write(basedchar);
            return basedchar;
        }
    }
    public class Client
    {
        public double ClientDouble(double clientdouble)
        {
            Console.WriteLine("Введите дробное число - ");
            clientdouble = Convert.ToDouble(Console.ReadLine());
            Console.Write(clientdouble);
            return clientdouble;

        }
        public int ClientInt(int clientint)
        {
            Console.WriteLine("Введите целое число число - ");
            clientint = Convert.ToInt32(Console.ReadLine());
            clientint = clientint * 2;
            Console.Write(clientint);
            return clientint;

        }
        public char ClientChar(char clientchar)
        {
            Console.WriteLine("Введите букву - ");
            Console.Write(clientchar);
            return clientchar;
        }
    }
    public class ClientAdapter : Client, Ibased
    {
        Client client;
        private Client clientdouble = new Client();
        public ClientAdapter(Client c)
        {
            client = c;
        }
        public double BasedDouble(double basedouble) => ClientDouble(basedouble);
        public int BasedInt(int basedint) => ClientInt(basedint);
        public char BasedChar(char basedchar) => ClientChar(basedchar);
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            char c;
            int count = 0;
            Client h = new Client();
            Ibased m = new ClientAdapter(h);
            m.BasedInt(a);
        }
    }
}
