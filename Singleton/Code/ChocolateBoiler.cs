namespace Singleton.Code
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler _instance;
        private static readonly object _sync = new object();

        public static ChocolateBoiler Instance
        {
            get
            {
                lock (_sync)
                {
                    if (_instance == null)
                    {
                        _instance = new ChocolateBoiler();
                    }
                    return _instance;
                }
            }
        }

        private bool _empty;
        private bool _boiled;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public void Fill()
        {
            if (_empty)
            {
                _empty = false;
                _boiled = false;
            }
        }

        public void Drain()
        {
            if (!_empty && _boiled)
            {
                _empty = true;
            }
        }

        public void Boiled()
        {
            if (!_empty && !_boiled)
            {
                _boiled = true;
            }
        }

        public bool IsEmpty
        {
            get { return _empty; }
        }
        public bool IsBoiled
        {
            get { return _boiled; }
        }
    }
}