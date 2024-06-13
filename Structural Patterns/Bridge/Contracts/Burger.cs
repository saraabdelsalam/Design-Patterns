namespace Structural_Patterns.Bridge.Contracts
{
    public abstract class Burger
    {
        protected ICombo combo;
        public Burger(ICombo combo)
        {
            this.combo = combo;
        }
        public abstract void GetDetails();
    }
}
