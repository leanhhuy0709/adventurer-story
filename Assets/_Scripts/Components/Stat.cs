namespace _Scripts.Components
{
    public class Stat
    {
        private int _value;
        private int _maxValue;

        public Stat(int value, int maxValue)
        {
            _value = value;
            _maxValue = maxValue;
        }

        public int Get()
        {
            return _value;
        }

        public void Set(int value)
        {
            _value = value;
        }

        public int GetMax()
        {
            return _maxValue;
        }

        public void SetMax(int value)
        {
            _maxValue = value;
        }
    }
}