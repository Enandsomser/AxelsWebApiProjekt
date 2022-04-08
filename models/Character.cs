namespace TEST_dotnet.models
{
    public class Character
    {
        public int Id{get; set;}
        public string Name{get; set;} = "Golum";
        public int HitPoints{get;set;} = 50;
        public int Strength{get;set;} = 7;
        public int Defence{get;set;} = 5;
        public int Intelligence{get;set;} = 1;
        public RPGclass Class{get;set;} = RPGclass.Goblin;
    }
}