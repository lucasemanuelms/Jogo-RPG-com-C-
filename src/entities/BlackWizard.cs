namespace JogoRPG.src.entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public virtual string Attack(){
            return this.Name + "atacou usando magia negra.";
        }
    }
}