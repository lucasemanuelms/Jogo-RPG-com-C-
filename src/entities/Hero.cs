namespace JogoRPG
{
    public class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;

        public Hero(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString(){
            return "Character data" + "\n" + "Name: " + this.Name + "\n" + "Level: " + this.Level + "\n" + "Hero type: " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + "atacou usando (aqui vai ser dito com o que o personagem atacou).";
        }
    }
}