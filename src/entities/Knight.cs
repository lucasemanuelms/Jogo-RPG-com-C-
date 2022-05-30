namespace JogoRPG
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " atacou usando sua espada.";
        }

        public string Attack(int Bonus){
            if(Bonus > 7){
                return this.Name + " atacou usando sua espada em chamas e com um bônus de " + Bonus + ".";
            }else{
                return this.Name + " atacou usando sua espada dourada e com um bônus de " + Bonus + ".";
            }
        }
    }
}