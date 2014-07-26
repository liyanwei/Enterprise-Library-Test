using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Design_pattern_study.SimpleFactoryPattern
{
    //产品继承于类（接口），
    //有多种产品，一个简单工厂类。其中产品共同实现一个产品接口或者继承于产品抽象类。当增加新产品时，在简单工厂类中增加case语句，以便能够创建该产品

    #region 抽象类版本
    /// <summary>
    /// 产品接口（抽象类），这里是Food
    /// </summary>
    public abstract class Food
    {
        public abstract void print();
    }

    /// <summary>
    /// 西红柿炒鸡蛋 类
    /// </summary>
    public class TomatoScrambledEggs : Food
    {
        public override void print()
        {
            Console.WriteLine("一份西红柿炒蛋！");
        }
    }

    /// <summary>
    /// 土豆肉丝 类
    /// </summary>
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void print()
        {
            Console.WriteLine("一份土豆肉丝！");
        }
    }

    /// <summary>
    /// 新增一个食品类，继承Food类，实现其中的抽象方法
    /// 然后再FoodFactory类中增加一个case语句即可
    /// </summary>
    public class NewFood : Food
    {
        public override void print()
        {
            Console.WriteLine("一份新菜！");
        }
    }

    /// <summary>
    /// 生成食物的工厂类，其中用静态方法来生成食物
    /// </summary>
    public class FoodFactory
    {
        public static Food CreatFood(string foodType)
        {
            Food food = null;
            if (foodType.Equals("西红柿炒蛋"))
            {
                food = new TomatoScrambledEggs();
            }
            else if (foodType.Equals("土豆肉丝"))
            {
                food = new ShreddedPorkWithPotatoes();
            }
            else if (foodType.Equals("新菜品"))
            {
                food = new NewFood();
            }


            return food;
        }
    }
    #endregion


    #region 接口版本
    public interface IFood
    {
        void print();
    }

    public class TomatoScrambledEggsI : IFood
    {
        public void print()
        {
            Console.WriteLine("西红柿炒蛋！");
        }
    }
    public class ShreddedPorkWithPotatoesI : IFood
    {
        public void print()
        {
            Console.WriteLine("一份土豆肉丝！");
        }
    }

    public class FoodFactoryI
    {
        public static IFood CreatFood(string foodType)
        {
            IFood food = null;
            if (foodType.Equals("西红柿炒蛋"))
            {
                food = new TomatoScrambledEggsI();
            }
            else if (foodType.Equals("土豆肉丝"))
            {
                food = new ShreddedPorkWithPotatoesI();
            }

            return food;
        }
    }
    #endregion
    
}
