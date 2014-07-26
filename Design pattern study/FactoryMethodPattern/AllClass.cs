using System;

namespace Design_pattern_study.FactoryMethodPattern
{
    // 工厂方法的思路：产品类统一实现一个接口（或者继承于一个抽象类），工厂类统一实现一个接口（或者继承于一个抽象类），产品类定义产品，工厂类创建（new）产品类对象。
    // 创建（new）产品对象时，用对应的工厂类来创建，产品类和工厂类一一对应。
    // 客户调用 某产品的工厂类来创建产品对象。
    
    #region 产品类

    /// <summary>
    ///     产品抽象类
    /// </summary>
    public abstract class Food
    {
        public abstract void print();
    }

    /// <summary>
    ///     土豆肉丝 类
    /// </summary>
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void print()
        {
            Console.WriteLine("一份土豆肉丝！");
        }
    }

    /// <summary>
    ///     西红柿炒鸡蛋 类
    /// </summary>
    public class TomatoScrambledEggs : Food
    {
        public override void print()
        {
            Console.WriteLine("一份西红柿炒蛋！");
        }
    }

    /// <summary>
    ///     新增一个食品类，继承Food类，实现其中的抽象方法
    ///     然后新增一个食品工厂类，继承Factory类，实现其中的抽象方法
    ///     客户调用这个新增的食品工厂类来创建 新增的食品对象
    /// </summary>
    public class NewFood : Food
    {
        public override void print()
        {
            Console.WriteLine("一份新菜！");
        }
    }

    #endregion

    #region 产品工厂类

    /// <summary>
    /// 创建Food对象的 工厂类
    /// </summary>
    public abstract class FoodFactory
    {
        public abstract Food Creat();
    }

    /// <summary>
    /// 创建 土豆肉丝 对象的工厂类
    /// </summary>
    public class ShreddedPorkWithPotatoesFactory:FoodFactory
    {
        public override Food Creat()
        {
            return new ShreddedPorkWithPotatoes();
        }

    }

    /// <summary>
    /// 创建 西红柿炒鸡蛋 对象的工厂类
    /// </summary>
    public class TomatoScrambledEggsFactory : FoodFactory
    {
        public override Food Creat()
        {
            return new TomatoScrambledEggs();
        }

    }

    /// <summary>
    /// 创建 新产品 对象的工厂类
    /// 每次创建一个新产品都要创建一个对应的工厂类
    /// </summary>
    public class NewFoodFactory : FoodFactory
    {
        public override Food Creat()
        {
            return new NewFood();
        }

    }

        
    #endregion
    
}