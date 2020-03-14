using MarcosYPatrones.AdapterKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarcosYPatrones.AdapterKataTests
{
    [TestClass]
    public class AdapterKataTest
    {
        [TestMethod]
        public void MarioAdapter_Can_Attack()
        {
            var marioAdapter = new MarioAdapter(new Mario());
            var target = new Target { Health = 33 };

            marioAdapter.Attack(target);

            Assert.AreEqual(30, target.Health);
        }

        [TestMethod]
        public void Marine_Can_Attack()
        {
            var marine = new Marine();
            var target = new Target { Health = 33 };

            marine.Attack(target);

            Assert.AreEqual(27, target.Health);
        }

        [TestMethod]
        public void Zealot_Can_Attack()
        {
            var zealot = new Zealot();
            var target = new Target { Health = 33 };

            zealot.Attack(target);

            Assert.AreEqual(25, target.Health);
        }

        [TestMethod]
        public void Zergling_Can_Attack()
        {
            var zergling = new Zergling();
            var target = new Target { Health = 33 };

            zergling.Attack(target);

            Assert.AreEqual(28, target.Health);
        }
    }
}
