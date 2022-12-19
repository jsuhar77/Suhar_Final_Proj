bool isLooping = false;
const string MASTER_USERNAME = "MasterUser";
const string MASTER_PASSWORD = "passwordlol";


List<User> users = new List<User>();
List<Guest> guests = new List<Guest>();
List<Master> masters = new List<Master>();


Console.WriteLine("Press 1 to Login as an exsisting user");
Console.WriteLine("Press 2 to Spawn new Users");
string userInput = Console.ReadLine();


if (userInput == "1")
{

    Login();
}
else if (userInput == "2")
{
    CreateUsers();
}
else if (userInput == "3")
    Console.WriteLine("Can you read? Press 1 or 2...");


void CreateUsers()
{
    Console.WriteLine("Enter a Master Username: ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter the Password: ");
    string password = Console.ReadLine();

    if (username == MASTER_USERNAME && password == MASTER_PASSWORD)
    {
        isLooping = true;
        Console.Clear();
    }
    else
    {
        isLooping = false;
        Console.Clear();
        Console.WriteLine("Invalid Userame or Password");
        CreateUsers();
    }



    while (isLooping)
    {

        Console.WriteLine("Enter a BRAND NEW Username!: ");
        string un = Console.ReadLine();

        Console.WriteLine("Enter a BRAND NEW password!: ");
        string pw = Console.ReadLine();


        Console.WriteLine("Press 1 for Generic User");
        Console.WriteLine("Press 2 for a Guest");
        Console.WriteLine("Press 3 for a Master User");
        Console.WriteLine("Press 0 to Login");
        int selection = int.Parse(Console.ReadLine());

        Console.Clear();


        if (selection == 1)
        {
            users.Add(new User(un, pw));
            Console.WriteLine(un + " has been spawned in as a Generic User");
        }
        else if (selection == 2)
        {
            guests.Add(new Guest(un, pw));
            Console.WriteLine(un + " has been born as a Guest");
        }
        else if (selection == 3)
        {
            masters.Add(new Master(un, pw));
            Console.WriteLine(un + " has been genesized as a Master User");
        }
        else
        {
            Console.WriteLine("Invalid Selection. No user created.");
        }
        if (selection == 2)
        {
            User guest = new Guest(un, pw);
        }
        if (selection == 3)
        {
            User master = new Master(un, pw);
        }
        else if (selection == 0)
        {
            Login();
        }


        Console.WriteLine("All of the Current Users in this little System:");
        foreach (User usr in users)
        {
            Console.WriteLine(usr.username);
        }

        Console.WriteLine("Guests:");
        foreach (Guest gst in guests)
        {
            Console.WriteLine(gst.username);
        }

        Console.WriteLine("Masters:");
        foreach (Master msr in masters)
        {
            Console.WriteLine(msr.username);
        }
    }
}

void Login()
{
    Console.WriteLine("Enter your Username: ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter your Password: ");
    string password = Console.ReadLine();

    foreach (User user in users)
    {
        if (user.username == username)
        {
            if (user.password == password)
            {
                LoadApp(username);
            }
            else
            {
                Console.WriteLine("Invalid Password");
                Login();
            }
        }
        else
        {
            Console.WriteLine("Invalid Username");
            Login();
        }
    }
}


void LoadApp(string username)
{
    Console.WriteLine("Welcome " + username + ". How may we Assist you Today?");
}

