namespace JogoRPG
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + "atacou usando suas bombas de fumaça e shurikens.";
        }

        public string Attack(int Bonus){
            return "";
        }
    }
}