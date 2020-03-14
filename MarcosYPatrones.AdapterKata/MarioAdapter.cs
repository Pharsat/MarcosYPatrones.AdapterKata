namespace MarcosYPatrones.AdapterKata
{
    public class MarioAdapter : IUnit
    {
        private readonly Mario _mario;

        public MarioAdapter(Mario mario)
        {
            _mario = mario;
        }

        public void Attack(Target target)
        {
            target.Health -= _mario.JumpAttack();
        }
    }
}
