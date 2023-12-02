using UserProfile.Model;
using UserProfile.Repository;

namespace UserProfile;

public class UserManager
{
    
    public static void Main(string[] args)
    {
        List<User> users = new List<User>();
        List<User> tmpUsers = new List<User>();
        List<Profile> profiles = new List<Profile>();
        List<Transaction> transactions = new List<Transaction>();

        UserService _userService = new UserService(users);

        ProfileService _profileService = new ProfileService(profiles, users);
        TransactionService _transactionService = new TransactionService();

        Console.WriteLine("Enter options to navigate menu");
        Console.WriteLine("0 = Home, 1 = Add User, 2 View User\n" +
            "3 = Edit user, 4 = Update profile");

        var input = Console.ReadLine();

        switch(input){
            case "0":
                Main(null);
                input = Console.ReadLine();
                break;

            case "1":
                var d = _userService.Add(new User()
                {
                    Id = 1,
                    Email = "johndoe@email.com"
                });

                d = _userService.Add(new User()
                {
                    Id = 2,
                    Email = "someone@email.com"
                });

                foreach (var item in users)
                {
                    Console.WriteLine($"User Id : {item.Id} | Email : {item.Email}");
                }
                Console.WriteLine("Enter options to navigate menu");
                input = Console.ReadLine();

                Main(null);

                break;

            case "2":
                
                Console.WriteLine("Add new user");

                Console.WriteLine("Add user id");
                var id = Console.ReadLine();
                
                Console.WriteLine("Add user email");
                var email = Console.ReadLine();
                var u = _userService.Add(new User
                {
                    Id = Convert.ToInt32(id),
                    Email = email
                });

                Console.WriteLine("User successfully add");
                Console.WriteLine($"User Id : {u.Id} | Email : {u.Email}");

                Console.WriteLine("Enter options to navigate menu");
                input = Console.ReadLine();

                Main(null);

                break;

            case "3":
                d = _userService.Add(new User()
                {
                    Id = 1,
                    Email = "johndoe@email.com"
                });

                d = _userService.Add(new User()
                {
                    Id = 2,
                    Email = "someone@email.com"
                });

                d = _userService.Add(new User()
                {
                    Id = 2,
                    Email = "someone@email.com"
                });

                var us = _userService.AllUsers();

                us = users;

                foreach (var item in us)
                {
                    Console.WriteLine($"User Id : {item.Id} | Email : {item.Email}");
                }
                Console.WriteLine("Enter options to navigate menu");

                Console.WriteLine("Enter options to navigate menu");
                input = Console.ReadLine();
                Main(null);
                break;

            case "4":
                var prof = new Profile
                {
                    UserId = 1,
                    Address="Lagos",
                    FullName= "Joe dan",
                    Phones= "1234",
                    Id = 1
                };



                var prf = _profileService.Update(prof);

                Console.WriteLine("Enter options to navigate menu");
                input = Console.ReadLine();
                Main(null);
                break;

            default: Main(null);
                break;
        }

        

        Console.WriteLine();
        Console.WriteLine("Get a single user");

        Console.WriteLine();

        var user = _userService.View(3);

        if (user != null)
        {
            Console.WriteLine($"User Id : {user.Id} | Email : {user.Email}");
        }
        else
        {
            Console.WriteLine("No record exist");
        }



    }
}