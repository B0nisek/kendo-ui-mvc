using DAL.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class DataInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            var ad1 = new Address()
            {
                ID = 0,
                City = "Brno",
                Street = "Ceska",
                ZipCode = "602 00"
            };

            var ad2 = new Address()
            {
                ID = 1,
                City = "Ostrava",
                Street = "Ceska",
                ZipCode = "265 35"
            };

            var ad3 = new Address()
            {
                ID = 2,
                City = "Martinkovice",
                Street = "Martinkovicka",
                ZipCode = "549 73"
            };

            var ad4 = new Address()
            {
                ID = 3,
                City = "Broumov",
                Street = "Mala Kolonie",
                ZipCode = "550 01"
            };

            var ad5 = new Address()
            {
                ID = 4,
                City = "Hradec Kralove",
                Street = "Jupiterska",
                ZipCode = "165 24"
            };

            var ad6 = new Address()
            {
                ID = 5,
                City = "Znojmo",
                Street = "Hurikan",
                ZipCode = "759 63"
            };

            var ad7 = new Address()
            {
                ID = 6,
                City = "Molitan",
                Street = "Sultan",
                ZipCode = "547 86"
            };

            var ad8 = new Address()
            {
                ID = 7,
                City = "Kulihrob",
                Street = "Maskerska",
                ZipCode = "563 89"
            };

            var aList = new List<Address>()
            {
                ad1, ad2, ad3, ad4, ad5, ad6, ad7, ad8
            };

            var l1 = new HashSet<Address>()
            {
                ad1, ad2
            };

            var l2 = new HashSet<Address>()
            {
                ad3
            };

            var l3 = new HashSet<Address>()
            {
                ad4
            };

            var l4 = new HashSet<Address>()
            {
                ad5, ad7
            };

            var l5 = new HashSet<Address>()
            {
                ad2, ad6, ad8
            };

            var c1 = new Customer()
            {
                ID = 0,
                Name = "Klaun",
                Surname = "Sasek",
                Addresses = l1,
                IC = "27604977",
                DIC = "CZ27604977"
            };

            var c2 = new Customer()
            {
                ID = 1,
                Name = "Hrobnik",
                Surname = "Pepa",
                Addresses = l2,
                IC = "47123737",
                DIC = "CZ47123737"
            };

            var c3 = new Customer()
            {
                ID = 2,
                Name = "Kulecnik",
                Surname = "Skoda",
                Addresses = l3,
                IC = "01380991",
                DIC = "CZ01380991"
            };

            var c4 = new Customer()
            {
                ID = 3,
                Name = "Hlavoun",
                Surname = "Velky",
                Addresses = l4,
                IC = "26423987",
                DIC = "CZ26423987"
            };

            var c5 = new Customer()
            {
                ID = 4,
                Name = "Ahoj",
                Surname = "Tyranosaurus",
                Addresses = l4,
                IC = "25551281",
                DIC = "CZ25551281"
            };

            var pList = new List<Customer>()
            {
                c1, c2, c3, c4, c4, c5
            };

            ad1.Customers.Add(c1);

            ad2.Customers.Add(c1);

            ad3.Customers.Add(c2);

            ad4.Customers.Add(c3);

            ad5.Customers.Add(c4);
            ad5.Customers.Add(c5);

            ad7.Customers.Add(c4);
            ad7.Customers.Add(c5);

            pList.ForEach(c => context.Customers.Add(c));
            aList.ForEach(a => context.Addresses.Add(a));

            context.SaveChanges();
        }
    }
}
