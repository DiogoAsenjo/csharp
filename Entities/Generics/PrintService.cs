namespace PrimeiroProjeto.Entities.Generics
{
    public class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;

        public void addValue (int value)
        {
            if(_count >= 10) throw new Exception("_values has reached it's maximum lenght!");
            _values[_count] = value;
            _count++;
        }

        public int first()
        {
            if(_count == 0) throw new Exception("_values has no value");
            return _values[0];
        }

        public void print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_values[i]);
            }
        }
    }
}