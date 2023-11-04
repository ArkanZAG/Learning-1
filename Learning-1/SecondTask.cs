namespace Learning_1;

public class SecondTask
{
    private string userName;
    private string password;
    private int loginAttempts = 0;
    private bool isAccountBlocked = false;

    public void Register()
    {
        Console.WriteLine("Register");
        Console.WriteLine("Please Insert Your UserName : ");
        userName = Console.ReadLine();
        Console.WriteLine("Please Insert Your Password : ");
        password = Console.ReadLine();
    }

    public void loginAttempt()
    {

        if (isAccountBlocked)
        {
            Console.WriteLine("Sorry your account have been blocked");
            return;
        }
        Console.WriteLine("Login");
        Console.WriteLine("UserName : ");
        string insertedUserName = Console.ReadLine();
        Console.WriteLine("Password : ");
        string insertedPassword = Console.ReadLine();

        if (userName == insertedUserName && password == insertedPassword)
        {
            Console.WriteLine("Welcome "+userName);
        }
        else
        {
            loginAttempts++;

            if (loginAttempts >= 3)
            {
                isAccountBlocked = true;
                Console.WriteLine("Sorry your account have been blocked");
            }
            else
            {
                Console.WriteLine("Username or Password is Incorrect");
                this.loginAttempt();
            }
        }
    }
}