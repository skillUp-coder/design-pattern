using System;
using DesignPattern.Infrastructure.Services.SingletonPattern;

namespace DesignPattern.App.Services.SingletonSetUp
{
    public static class SetUpSingleton
    {
        public static void SetUp()
        {
            Console.WriteLine("Singleton:");
            
            var singletonFirst = Singleton.GetInstance();
            var singletonSecond = Singleton.GetInstance();

            Console.WriteLine(singletonFirst == singletonSecond 
                ? "Singleton works" 
                : "Singleton failed");
        }
    }
}