using ModeloPrubea.Entidades;
using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customers = new Customer() {
                store_id = 1,
                first_name = "Diego",
                last_name = "Pati;o",
                email = "diego@gmail.com",
                activateboll = true,
                create_date = new DateTime(2021, 01, 24),
                last_update = new DateTime(2021, 01, 24),
                activate = true

            };

            Customer customers2 = new Customer()
            {
                store_id = 1,
                first_name = "Diego",
                last_name = "Pati;o",
                email = "diego@gmail.com",
                activateboll = true,
                create_date = new DateTime(2021, 01, 24),
                last_update = new DateTime(2021, 01, 24),
                activate = true

            };

            Customer customers1 = new Customer()
            {
                store_id = 1,
                first_name = "Diego",
                last_name = "Pati;o",
                email = "diego@gmail.com",
                activateboll = true,
                create_date = new DateTime(2021, 01, 24),
                last_update = new DateTime(2021, 01, 24),
                activate = true

            };
            Customer customers4 = new Customer()
            {
                store_id = 1,
                first_name = "Diego",
                last_name = "Pati;o",
                email = "diego@gmail.com",
                activateboll = true,
                create_date = new DateTime(2021, 01, 24),
                last_update = new DateTime(2021, 01, 24),
                activate = true

            };

            Payment payment1 = new Payment()
            {
                staff_id = 2,
                amount = 250,
                payment_date = new DateTime(2021, 01, 24)

            };
            Payment payment1 = new Payment()
            {
                staff_id = 2,
                amount = 250,
                payment_date = new DateTime(2021, 01, 24)

            };
            Payment payment2 = new Payment()
            {
                staff_id = 2,
                amount = 250,
                payment_date = new DateTime(2021, 01, 24)

            };
            Payment payment3 = new Payment()
            {
                staff_id = 2,
                amount = 250,
                payment_date = new DateTime(2021, 01, 24)

            };
            Payment payment4 = new Payment()
            {
                staff_id = 2,
                amount = 250,
                payment_date = new DateTime(2021, 01, 24)

            };



        }
    }
}
