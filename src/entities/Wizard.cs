namespace JogoRPG  
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " atacou usando sua magia.";
        }

        public string Attack(int Bonus){
            if(Bonus > 7){
                return this.Name + " atacou usando seu poder de invocação, com um bônus de " + Bonus + ".";
            }else{
                return this.Name + " atacou usando seu poder de telecinese e com um bônus de " + Bonus + ".";
            }
        }
    }
}