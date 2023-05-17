namespace NewUserProfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Lastname, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Enter name");
                User.Name = Console.ReadLine();

                Console.WriteLine("Enter lastname");
                User.Lastname = Console.ReadLine();

                Console.WriteLine("Enter login");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;

                Console.WriteLine("Do you have any pets? Yes or no?");
                var result = Console.ReadLine();

                if (result == "Yes")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Enter the user's age");
                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Enter the user's three favorite colors");

                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
        }
    }
}