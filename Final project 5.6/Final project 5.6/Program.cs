using System;
class Program

{
    static void Main(string[] args)
    {
        var user = EnterUser();
        ShowUser(user);
    }
    static (string Name, string LastName, int Age, string[] PetNames, string[] FavColors) EnterUser()
    {
        (string Name, string LastName, int Age, string[] PetNames, string[] FavColors) User;

        Console.WriteLine("Введите имя");
        User.Name = Console.ReadLine();

        Console.WriteLine("Введите фамилию");
        User.LastName = Console.ReadLine();

        string age;
        int intage;
        do
        {
            Console.WriteLine("Введите возраст цифрами");
            age = Console.ReadLine();
        }
        while (CheckNum(age, out intage));
        User.Age = intage;

        Console.WriteLine("У вас есть питомец? (Да/Нет)");
        string havepet = Console.ReadLine();
        if (havepet == "Да")
        {
            string pet;
            int intpet;
            do
            {
                Console.WriteLine("Сколько у вас питомцев");
                pet = Console.ReadLine();
            }
            while (CheckNum(pet, out intpet));
            User.PetNames = ShowPet(intpet);
        }
        else 
        {
            User.PetNames = null;
        }

        string color;
        int intcolor;
        do
        {
            Console.WriteLine("Сколько у вас любимых цветов?");
            color = Console.ReadLine();
        }
        while (CheckNum(color, out intcolor));
        User.FavColors = ShowColor(intcolor);

        return User;
    }
    
    static bool CheckNum(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }
        {
            corrnumber = 0;
            return true;
        }
    }
    
    static string[] ShowPet(int intpet)
    {
        string[] PetNames = new string[intpet];
            for (int i = 0; i < intpet; i++)
            {
                Console.WriteLine($"Введите кличку питомца {i + 1}");
                PetNames[i] = Console.ReadLine();
            }
        return PetNames;
    }
    
    static string[] ShowColor(int intcolor)
    {
        string[] FavColors = new string[intcolor];
        for (int i = 0; i < intcolor; i++)
        {
            Console.WriteLine($"Введите любимый цвет {i + 1}");
            FavColors[i] = Console.ReadLine();
        }
        return FavColors;
    }

    static void ShowUser((string Name, string LastName, int Age, string[] PetNames, string[] FavColors) User)
    {
        Console.WriteLine($"Имя: {User.Name}");
        Console.WriteLine($"Фамилия: {User.LastName}");
        Console.WriteLine($"Возраст: {User.Age}");

        if (User.PetNames != null)
        {
            foreach (var namepet in User.PetNames)
            {
                if (namepet == null) continue;
                Console.WriteLine($"Кличка питомца: {namepet}");
            }
        }
        foreach (var namecolor in User.FavColors)
        {
            if (namecolor == null) continue;
            Console.WriteLine($"Любимый цвет: {namecolor}");
        }
    }
}