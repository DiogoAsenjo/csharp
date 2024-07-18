namespace PrimeiroProjeto.Entities.Generics
{
    public class PrintService<T> //O T serve como generics, assim quando for instanciar a classe, pode escolher o tipo (int, string, etc.);
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void addValue (T value)
        {
            if(_count >= 10) throw new Exception("_values has reached it's maximum lenght!");
            _values[_count] = value;
            _count++;
        }

        public T first()
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