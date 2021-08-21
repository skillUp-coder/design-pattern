#pragma warning disable 649

namespace DesignPattern.Infrastructure.Services.SingletonPattern
{
    public class Singleton
    {
        private static Singleton _instance;
        
        // The Constructor of the Singleton should always be hidden to prevent
        // create an object using the new operator.
        private Singleton()
        {
            
        }

        public static Singleton GetInstance()
        {
            return _instance ??= new Singleton();
        }
    }
}