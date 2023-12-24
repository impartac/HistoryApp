namespace HistoryApp
{
    public class Time
    {
        int _start;
        int _end;

        public Time() 
        {
            _start = 0;
            _end = 0;
        }
        public Time(int start, int end)
        {
            _start = start;
            _end = end;
        }

        public int Start
        {
            get { return _start; }
            set { _start = value; }
        }
        public int End
        {
            get { return _end; }
            set { _end = value; }
        }

        public override string ToString() 
        
        {
            return $"{_start} - {_end}";
        }
    }
}
