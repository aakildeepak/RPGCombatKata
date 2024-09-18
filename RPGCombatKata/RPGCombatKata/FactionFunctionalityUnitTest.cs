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
        public void A_Character_Can_Join_A_Faction()
        {
            character1.JoinFaction("Knights");

            Assert.That(character1.Factions.Contains("Knights"), Is.True);
        }

        [Test]

        public void A_Character_Can_Join_More_Than_One_Faction()
        {
            character1.JoinFaction("Knights");
            character1.JoinFaction("Wizards");

            Assert.That(character1.Factions.Contains("Knights"), Is.True);
            Assert.That(character1.Factions.Contains("Wizards"), Is.True);

        }

        [Test]

        public void A_Newly_Created_Character_Has_Any_Factions()
        {
            Assert.That(character1.Factions.Count, Is.EqualTo(0));
        }

        [Test]

        public void A_Character_Can_Leave_A_Faction()
        {
            character1.JoinFaction("Knights");
            character1.LeaveFaction("Knights");

            Assert.That(character1.Factions.Contains("Knights"),Is.False);

        }

        [Test]

        public void A_Character_Can_Join_Multiple_Factions_Leave_One_Faction()
        {
            character1.JoinFaction("Knights");
            character1.JoinFaction("Wizards");

            character1.LeaveFaction("Wizards");

            Assert.That(character1.Factions.Count,Is.EqualTo(1));
            Assert.That(character1.Factions.Contains("Knights"), Is.True);


        }

        [Test]

        public void A_Character_Can_Join_Multiple_Faction_Leave_Multiple_Factions()
        {
            character1.JoinFaction("Knights");
            character1.JoinFaction("Wizards");

            character1.LeaveFaction("Knights");
            character1.LeaveFaction("Wizards");

            Assert.That(character1.Factions.Count, Is.EqualTo(0));

        }


    }
}
