namespace Players_and_Monsters_Inheritance.Wizard
{
    public abstract class Wizard : Hero
    {
        protected Wizard(string username, int lvl) 
            : base(username, lvl)
        {
        }
    }
}
