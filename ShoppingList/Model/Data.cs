namespace ShoppingList.Model
{
    public class Data
    {
        public static List<User> Users = new List<User>
        {
            new User {UserId = 1, Username = "Damian", Password = "test123", FullName = "Damian Krasnowski", Email = "dkrasnowski@gmail.com", PhoneNumber = 420213769},
            new User {UserId = 2, Username = "Oskar", Password = "test1234", FullName = "Oskar Chyra", Email = "ochyra@gmail.com", PhoneNumber = 538453231},
            new User {UserId = 3, Username = "Krzysztof", Password = "kris123", FullName = "Krzysztof Olendzki", Email = "kolendzki@gmail.com", PhoneNumber = 532144632},
            new User {UserId = 4, Username = "Bożena", Password = "zakupki123", FullName = "Bożena Bochenek", Email = "bbochenek@gmail.com", PhoneNumber = 534423512}
        };
        
    }
}
