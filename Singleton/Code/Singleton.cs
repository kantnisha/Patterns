namespace Singleton.Code
{
    public class Singleton
    {
        private static Singleton _uniqueInstance;
        private Singleton()
        {
            
        }

        public static Singleton Instance 
        {
            get
            {
                if (_uniqueInstance == null)
                {
                    _uniqueInstance = new Singleton();
                }
                return _uniqueInstance;
            }
        }
    }
}