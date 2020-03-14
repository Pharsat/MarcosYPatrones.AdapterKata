using System;
using System.Collections.Generic;
using System.Text;

namespace MarcosYPatrones.AdapterKata
{
    public class Marine : IUnit
    {
        public void Attack(Target target)
        {
            target.Health -= 6;
        }
    }
}
