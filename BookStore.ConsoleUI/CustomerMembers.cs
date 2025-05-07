using Bookstore.Application.DTOs.CustomerDTOs;
using Bookstore.Application.Services;

internal static class CustomerMembers
{    public static void AddCustomer()
    {
        var customermanager = new CustomerManager();
        Console.Write("Müştəri adını daxil edin:");
        var name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Enter name");
        }
        Console.Write("Müştəri adresini daxil edin:");
        var address = Console.ReadLine();
        if (string.IsNullOrEmpty(address))
        {
            Console.WriteLine("Enter Adress");
        }

        var createcustomer = new CustomerCreateDTO
        {
            Name = name,
            Address = address

        };

        customermanager.Add(createcustomer);

    }
}