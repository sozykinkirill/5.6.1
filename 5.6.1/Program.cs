
namespace _5._6._1
{
    internal class Program
    {
        static (string Name, string LastName, int Age, bool Animal, string[] AnimalName, string[] color) MetUser()
        {
            (string Name, string LastName, int Age, bool Animal, string[] AnimalName, string[] color) User;

            //------------------------------------------ИМЯ _ ФАМИЛИЯ
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();
            //-------------------------------------------Возраст
            Console.WriteLine("Введите возраст пользователя");
            string numage;
            int numage1;

            do 
            {
                numage = Console.ReadLine();
            } 
            while (CheckNum(numage, out numage1));

            User.Age = numage1;
            //------------------------------------------Животное 
            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var result = Console.ReadLine();
            if (result == "Да")
            {
                Console.WriteLine("Введите кол-во животных");
                string numanimal;
                int numanimal1;
                do
                {
                    numanimal = Console.ReadLine();
                } while (CheckNum(numanimal, out numanimal1));
                User.AnimalName = MetodAnimals(numanimal1);
                User.Animal = true;
            }
            else
            {
                User.Animal = false;
                User.AnimalName = MetodAnimals(0);
            }

            //--------------------------------------------Цвета

            Console.WriteLine(" Сколько у вас любимых цветов?");
            string numcolor;
            int numcolor1;
            do
            {
                numcolor = Console.ReadLine();
            } 
            while (CheckNum(numcolor, out numcolor1));
            User.color = MetodColors(numcolor1);

            return User;
        }
        //------------------------------------------ПРОВЕРКА Значений
        static bool CheckNum(string number, out int corrnum)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0 && intnum < 120)
                {
                    corrnum = intnum;
                    return false;
                }
            }
            {
                corrnum = 0;
                return true;
            }
        }
        //------------------------------------------МЕТОД КЛИЧКИ
        static string[] MetodAnimals(int num)
        {
            var result = new string[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите кличку питомца");
                result[i] = Console.ReadLine();
            }
            return result;
        }
        //------------------------------------------МЕТОД ЦВЕТА
        static string[] MetodColors(int num)
        {
            var result = new string[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите любимый цвет");
                result[i] = Console.ReadLine();
            }
            return result;

        }
        static void Main(string[] args)
        {
            var ShowTime = MetUser();
            Console.ReadKey();
        }

        static void ShowColors(string Name, string LastName, int Age, bool Animal, string[] AnimalName, string[] color)
        {
            Console.WriteLine("Анкета");
            Console.Write("Имя:{0}, Фамилия:{1}, Возраст:{3}", Name, LastName, Age);
            if (Animal == true)
            {
                Console.WriteLine("У вас есть домашнее(ие) животное(ые):");
                foreach (var name in AnimalName)
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var favcolor in color)
            {
                Console.WriteLine(favcolor);
            }
        }
    }
}