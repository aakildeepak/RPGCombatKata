using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatKata
{
    public class FactionFunctionalityUnitTest
    {
        private Character character1;
        private Character character2;

        [SetUp]
        public void setup()
        {
            character1 = new Character("Jon");
            character2 = new Character("Jim");

        }

        [Test]
        public void Character_Can_Join_A_faction()
        {
            character1.JoinFaction("Knights");

            Assert.That(character1.Factions.Contains("Knights"), Is.True);
        }
    }
}
