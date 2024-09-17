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


        [Test]
        public void When_A_Number_Is_Passed_Adds_The_Number_Of_Level_To_The_Character()
        {

            character1.AddLevel( 5 );


            Assert.That(character1.Level, Is.EqualTo(6));
        }

        [Test]
        public void Damage_Is_Reduced_By_50_Percent_When_Character1_Is_5_Or_More_Levels_Higher_Than_Character2()
        {

            character1.AddLevel(6);
            character2.AddLevel(1);

            character1.TakeDamage(200, character2);

            Assert.That(character1.Health, Is.EqualTo(900));
        }


    }
}