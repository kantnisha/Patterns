namespace Strategy.Code
{
    public class Character
    {
        private IWeapon _weapon;

        public void SetWeaponBehavior(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            _weapon.UseWeapon();
        }
    }
}