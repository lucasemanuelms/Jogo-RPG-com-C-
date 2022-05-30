namespace JogoRPG.src.entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public virtual string Attack(){
            return this.Name + "atacou usando sua espada.";
        }
    }
}