using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.AdapterKata
{
    public class Zergling : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 5;
        }
    }
}
