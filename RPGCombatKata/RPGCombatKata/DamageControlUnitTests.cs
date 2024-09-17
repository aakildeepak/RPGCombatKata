using System.Reflection.PortableExecutable;

namespace RPGCombatKata
{

    public class DamageControlUnitTests
    {
        private Character character1;
        private Character character2;

        [SetUp]
        public void Setup()
        {
            character1 = new Character("Bob");
            character2 = new Character("Chris");
        }

        [Test]
        public void A_Character_Cannot_Deal_Damage_To_Itself()
        {

            character1.TakeDamage (200, character1);

            Assert.That(character1.Health, Is.EqualTo(1000));
        }


        [Test]
        public void A_Character_Can_Only_Heal_Itself()
        {

            character1.TakeDamage(200, character2);

            character1.Heal(200, character1);


            Assert.That(character1.Health, Is.EqualTo(1000));
        }

        [Test]
        public void A_Character_Can_Only_Heal_Itself_And_Not_Other_Character()
        {

            character1.TakeDamage(200, character2);

            character1.Heal(200, character2);


            Assert.That(character1.Health, Is.EqualTo(800));
        }








    }
}