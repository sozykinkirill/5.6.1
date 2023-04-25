

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
            /*
            string numage;
            int numage1;
            do 
            {
                Console.WriteLine("Введите возраст пользователя");
                numage = Console.ReadLine();
            } 
            while (CheckNum(numage, out numage1));
            User.Age = numage1;
            */
            //-------------------Возраст + Проверка 
            int numage1;
            Console.WriteLine("Введите возраст пользователя");
            while ( true )
            {
                
 
                if ( int.TryParse( Console.ReadLine( ), out numage1) )
                {
                    User.Age = numage1;
                    break;
                }
                else
                {
                    Console.WriteLine( "Некоректное значение, повторите ввод" );
                }
                
            }
            

            //------------------------------------------Животное 
            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var result = Console.ReadLine();
            if (result == "Да")
            {
                string numAnimal;
                int numAnimal1;
                do
                {
                    Console.WriteLine("Введите кол-во животных");
                    numAnimal = Console.ReadLine();
                } while (CheckNum(numAnimal, out numAnimal1));
                User.AnimalName = MetodAnimals(numAnimal1);
                User.Animal = true;
            }
            else
            {
                User.Animal = false;
                User.AnimalName = MetodAnimals(0);
            }

            //--------------------------------------------Цвета

            
            string numcolor;
            int numcolor1;
            do
            {
                Console.WriteLine("Сколько у вас любимых цветов?");
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
            var Show = MetUser();
            ShowAnket(Show);
            Console.ReadKey();
        }

        static void ShowAnket((string Name, string LastName, int Age, bool Animal, string[] AnimalName, string[] color) User) 
        {
            Console.WriteLine("Анкета");
            Console.WriteLine("Имя:{0}, Фамилия:{1}, Возраст: {2}", User.Name, User.LastName, User.Age);

            if (User.Animal == true)
            {
                Console.WriteLine("У вас есть домашнее(ие) животное(ые) по кличке:");
                foreach (var name in User.AnimalName)
                {
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine("Ваши любимые цвета:");
            foreach (var favcolor in User.color)
            {
                Console.WriteLine(favcolor);
            }
        }
    }
}