namespace JogoRPG
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " atacou usando magia negra.";
        }

        public string Attack(int Bonus){
            if(Bonus > 7){
                return this.Name + " atacou usando seu poder de invocação de um monstro com magia negra, com um bônus de " + Bonus + ".";
            }else{
                return this.Name + " atacou usando sua magia negra (golpe um pouco mais fraco) e com um bônus de " + Bonus + ".";
            }
        }
    }
}