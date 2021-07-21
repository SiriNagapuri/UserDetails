using System;

namespace UserDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter age(completed years and months)");
            decimal age = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter gender('M' for Male and 'F' for Female");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter city");
            String city = Console.ReadLine();
            Console.WriteLine("Enter mobile number");
            long number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter pincode");
            long pincode = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(
                "Name:    " + name + Environment.NewLine + 
                "Age:     " + age + Environment.NewLine + 
                "Gender:  " + gender + Environment.NewLine + 
                "City:    " + city + Environment.NewLine + 
                "Mobile:  " + number + Environment.NewLine + 
                "Pincode: " + pincode);                  
        }
    }
}
