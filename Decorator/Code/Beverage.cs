
namespace Decorator.Code
{
    public abstract class Beverage
    {
        protected string Description = "Unknown Beverage";
        protected int Size = 1;

        public virtual string GetDescription()
        {
            return GetSizeDescription() + Description;
        }

        public abstract double Cost();

        public void SetSize(int size)
        {
            Size = size;
        }
        public int GetSize()
        {
            return Size;
        }
        public string GetSizeDescription()
        {
            string pref;
            switch (Size)
            {
                case 1:
                    pref = "Little";
                    break;
                case 2:
                    pref = "Middle";
                    break;
                default:
                    pref = "Big";
                    break;
            }
            return pref;
        }
    }
}