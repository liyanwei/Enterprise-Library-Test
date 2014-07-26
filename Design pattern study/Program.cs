using System;

namespace Design_pattern_study
{
    class Program
    {
        /// <summary>
        /// Main函数就是客户端、使用者
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i;
            i = 1;//测试 简单工厂模式 simple factory pattern  抽象类
            i = 2;//测试 简单工厂模式 simple factory pattern  接口类
            i = 3; //测试 工厂方法模式 factory method patterm 抽象类
            if (i == 1)
            {
                // 客户想要一个  西红柿炒蛋
                SimpleFactoryPattern.Food food1 = SimpleFactoryPattern.FoodFactory.CreatFood("西红柿炒蛋");
                food1.print();

                // 客户想要一个  土豆肉丝
                SimpleFactoryPattern.Food food2 = SimpleFactoryPattern.FoodFactory.CreatFood("土豆肉丝");
                food2.print();


                // 客户想要一个  新菜品
                SimpleFactoryPattern.Food food3 = new SimpleFactoryPattern.NewFood();
                food3.print();
            }
            else if (i == 2)
            {
                // 客户想要一个  西红柿炒蛋
                SimpleFactoryPattern.IFood food1 = SimpleFactoryPattern.FoodFactoryI.CreatFood("西红柿炒蛋");
                food1.print();

                // 客户想要一个  土豆肉丝
                SimpleFactoryPattern.IFood food2 = SimpleFactoryPattern.FoodFactoryI.CreatFood("土豆肉丝");
                food2.print();
            }
            else if (i == 3)
            {
                // 客户想要一个  西红柿炒蛋
                var foodFactory1 = new FactoryMethodPattern.TomatoScrambledEggsFactory();
                FactoryMethodPattern.Food food = foodFactory1.Creat();//创建Food对象
                food.print();

               

                // 客户想要一个  土豆肉丝
                var foodFactory2 = new FactoryMethodPattern.ShreddedPorkWithPotatoesFactory();
                food = foodFactory2.Creat();
                food.print();


                // 客户想要一个  新菜品
                var foodFactory3 = new FactoryMethodPattern.NewFoodFactory();
                food = foodFactory3.Creat();
                food.print();
            }




            Console.WriteLine("按任意键结束...");
            Console.ReadKey();
        }
    }
}
