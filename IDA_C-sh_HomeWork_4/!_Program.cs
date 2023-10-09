// HomeWork template 1.3 // date: 29.09.2023

using IDA_C_sh_HomeWork_4;
using Service;
using System;
using System.Linq.Expressions;
using System.Text;

/// QUESTIONS ///
/// 
/// 1.  Автосвойства
/// long _integer { get; set; } = 1;
/// поле private - set/get не работают ? в чем смысл такой записи?
/// и наоборот:
/// public long _integer {get; set;}
/// и public поле и без метода допускает доуступ
/// 
////////////////
///
///  2. В целом мне идея в задании 1 не понравилась: как это Product наследник Money?
///  Если Money отражает стоимость продукта мне кажется логичнее включить Money композционно как поле:
///  Money _price
///
////////////////
///
///  3. Как разрешить контекст? 
///  Product наследует Money, в каждом есть метод name_. Как из product_obj обратиться к Money.name_?



// HomeWork 04 : [Inheritance] --------------------------------

namespace IDA_C_sh_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MainMenu.MainMenu mainMenu = new MainMenu.MainMenu();

            do
            {
                Console.Clear();
                mainMenu.Show_menu();
                if (mainMenu.User_Choice_Handle() == 0) break;
                Console.ReadKey();
            } while (true);
            // Console.ReadKey();
        }

        public static void Task_1(string work_name)
        /* Задание 1 
         * Запрограммируйте класс Money (объект класса опе-
        рирует одной валютой) для работы с деньгами.
        В классе должны быть предусмотрены поле для хране-
        ния целой части денег (доллары, евро, гривны и т.д.) и поле
        для хранения копеек (центы, евроценты, копейки и т.д.).
        Реализовать методы для вывода суммы на экран, за-
        дания значений для частей.
        На базе класса Money создать класс Product для работы
        с продуктом или товаром. Реализовать метод, позволяю-
        щий уменьшить цену на заданное число.
        Для каждого из классов реализовать необходимые
        методы и поля.*/
        {
            Console.WriteLine(work_name + "\n");

            Money money_obj_1 = new Money("USD", 5, 45);
            money_obj_1.cents_ = 195;
            Console.WriteLine("--- money_obj_1:");
            money_obj_1.COUT();
            money_obj_1.name_ = "EUR";
            money_obj_1.integer_ = 0;
            Console.WriteLine("\n\nmoney_obj_1.name_ = \"EUR\";\r\n" +
                "money_obj_1.integer_ = 0;\n" +
                "\n---money_obj_1:\n" +
                money_obj_1);

            Money money_obj_2 = new Money("EUR", 3, 74);
            Console.WriteLine("\n--- money_obj_2:\n" + money_obj_2);

            
            Console.WriteLine("\nmoney_obj_1 + money_obj_2 -> " + ((money_obj_1 + money_obj_2)));

            Product product_obj_1 = new Product("computer","EUR", 99,99 );
            product_obj_1.Info();
            Console.WriteLine("\n\nproduct_obj_1 - money_obj_2");
            Product product_obj_2 = product_obj_1 - money_obj_2;
            product_obj_2.Info();

        }
        public static void Task_2(string work_name)
        /* Задание 2. 
         * Создать базовый класс «Устройство» и производные
        классы «Чайник», «Микроволновка», «Автомобиль», «Па-
        роход». С помощью конструктора установить имя каждого
        устройства и его характеристики.
        Реализуйте для каждого из классов методы:
        ■ Sound — издает звук устройства (пишем текстом в
        консоль);
        ■ Show — отображает название устройства;
        ■ Desc — отображает описание устройства.*/

        {
            Console.WriteLine(work_name + "\n");

            ElecticPot electicPot_obj = new ElecticPot();
            MicroWaveOven microWaveOven_obj = new MicroWaveOven();
            Car car_obj = new Car();

            Show(electicPot_obj);
            Sound(electicPot_obj);
            Desc(electicPot_obj);

            Show(microWaveOven_obj);
            Sound(microWaveOven_obj);
            Desc(microWaveOven_obj);

            Show(car_obj);
            Sound(car_obj);
            Desc(car_obj);

            void Sound(Device obj)  { obj.Sound(); }
            void Show(Device obj)   { obj.Show(); }
            void Desc(Device obj)   { obj.Desc(); }
        }
        public static void Task_3(string work_name)
        /* Задание 3 
         * Создать базовый класс «Музыкальный инструмент»
        и производные классы «Скрипка», «Тромбон», « Укулеле»,
        «Виолончель». С помощью конструктора установить имя
        каждого музыкального инструмента и его характеристики.
        Реализуйте для каждого из классов методы:
        ■ Sound — издает звук музыкального инструмента
        (пишем текстом в консоль);
        ■ Show — отображает название музыкального инстру-
        мента;
        ■ Desc — отображает описание музыкального инстру-
        мента;
        ■ History — отображае*/

        {
            Console.WriteLine(work_name + "\n");

            Violin violin_obj = new Violin();
            Violoncello violoncello_obj = new Violoncello();
            Ukulele ukulele_obj = new Ukulele();
            Trombon trombon_obj = new Trombon();

            Show(violin_obj);
            Sound(violin_obj);
            Desc(violin_obj);
            History(violin_obj);

            Show(violoncello_obj);
            Sound(violoncello_obj);
            Desc(violoncello_obj);
            History(violoncello_obj);

            Show(ukulele_obj);
            Sound(ukulele_obj);
            Desc(ukulele_obj);
            History(ukulele_obj);

            Show(trombon_obj);
            Sound(trombon_obj);
            Desc(trombon_obj);
            History(trombon_obj);


            void Sound(MusicalTool obj) { obj.Sound(); }
            void Show(MusicalTool obj) { obj.Show(); }
            void Desc(MusicalTool obj) { obj.Desc(); }
            void History(MusicalTool obj) { obj.History(); }


        }
        public static void Task_4(string work_name)
        /* Задание 4 
         * Создать абстрактный базовый класс Worker (работника)
        с методом Print(). Создайте четыре производных класса:
        President, Security, Manager, Engineer. Переопределите метод
        Print() для вывода информации, соответствующей
        каждому типу работника.*/

        {
            Console.WriteLine(work_name + "\n");

            President president_obj = new President();
            president_obj.Print();

            Security security_obj = new Security();
            security_obj.Print();

            Manager manager_obj = new Manager();
            manager_obj.Print();

            Engineer engineer_obj = new Engineer();
            engineer_obj.Print();
        }


    }// class Program
}// namespace