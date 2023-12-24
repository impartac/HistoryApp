
namespace HistoryApp
{
    
    public class Human
    {
        string _name;
        string _surname;
        string _fathername;

        Time? _live;

        string[] _info;
        public Human(string name, string fathername, string surname, Time live, string[] info)
        {
            _name = name;
            _surname = surname;
            _fathername = fathername;
            _live = live;
            _info = info;
        }
        public Human(string FIO) 
        {
            string[] temp = FIO.Split(' ');
            _name = temp[0];
            _surname = temp[2];
            _fathername = temp[1];
        }
        public string Name { get; set; }
        
        public string Surname { get; set; }
      
        public string Fathername { get; set; }

        public Time Live { get; set; }

        public string[] Info { get; set; }

        public override string ToString() 
        {
            return $"{_name} {_fathername} {_surname}";
        }
        public Human() {}
    }
    public class Ruler : Human 
    {
        Human[] _spouse;
        Human[] _children;
        Time _govering;
        string _number = "I";
        public Ruler(Human you, Human[] spouse, Human[] children, Time govering, params string[] dop) 
        {
            this.Name = you.Name;
            this.Surname = you.Surname;
            this.Fathername = you.Fathername;
            this.Live = you.Live;
            this.Info = you.Info;
            _spouse = spouse;
            _children = children;
            _govering = govering;
            if (dop != null && dop.Length != 0)
            {
                _number = dop[0];
            }
        }
    }
}