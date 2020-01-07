

namespace Sprocket
{
    public class Math
    {
        private readonly int _number_one;
        private readonly int _number_two;

    public Math(int number_one, int number_two)
        {
            _number_one = number_one;
            _number_two = number_two;
        }

        public int Sum()
        {
            return _number_one + _number_two;
        }

        public int Product()
        {
            return _number_one / _number_two;
        }

        public decimal Divide()
        {
            return _number_one / _number_two;
        }
    }
}
