using Bookstore.Application.DTOs.CustomerDTOs;
using Bookstore.Application.Services;
using Bookstore.Application.Validations.CustomerValidators;

public  class CustomerMembers
{    public  void AddCustomer()
    {
        try
        {
            var validator = new CustomerVlaidator();
            var customermanager = new CustomerManager();

            Console.Write("Müştəri adını daxil edin:");
            var name = Console.ReadLine();
    
            Console.Write("Müştəri adresini daxil edin:");
            var address = Console.ReadLine();
            

            var createcustomer = new CustomerCreateDTO
            {
                Name = name,
                Address = address
            };
            var result=validator.Validate(createcustomer);
            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                customermanager.Add(createcustomer);
                Console.WriteLine($"{createcustomer.Name} adli musteri daxil edildi.");
            }
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }
    public void GetAllCustomer()
    {
        try
        {
            var customermanager = new CustomerManager();
            var customerlist = customermanager.GetAll();
            Console.WriteLine($"{("Id"),-15}{("Name"),-15}{("Address")}");
            Console.WriteLine(new string('-', 35));
            foreach (var customer in customerlist)
            {
                Console.WriteLine($"{customer.Id,-15}{customer.Name,-15}{customer.Address}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    
    }
}