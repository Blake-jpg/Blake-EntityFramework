using Microsoft.EntityFrameworkCore;

namespace Blake_EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var userInput = new FauxInput())
            {
                var Jim = new Customer()
                {
                    CustomerId = 1,
                    FirstName = "Jim",
                    LastName = "Smith",
                    BirthDate = 05/12/1954
                };

                userInput.Customers.Add(Jim);
                userInput.SaveChanges();
            }
        }
    }
}
