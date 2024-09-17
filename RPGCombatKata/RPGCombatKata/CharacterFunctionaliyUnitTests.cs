using System.Reflection.PortableExecutable;

namespace RPGCombatKata
{
   
    public class CharacterFunctionaliyUnitTests
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
        public void Character_When_Created_Has_Default_Health_Value_Of_1000()
        {
            
            Assert.That(character1.Health, Is.EqualTo(1000));
        }

        [Test]
        public void Character_When_Created_Has_Default_Character_Level_Of_1()
        {
            

            Assert.That(character1.Level, Is.EqualTo(1));

        }

        [Test]
        public void Character_When_Created_Is_Alive_By_Default()
        {
           

            Assert.That(character1.IsAlive, Is.True);
        }

        [Test]
        public void Character_When_Deals_Damage_Reduces_Health()
        {


            character1.TakeDamage(200, character2);
            Assert.That(character1.Health, Is.EqualTo (800));
        }

        [Test]
        public void Character_Dies_When_Health_Reaches_Zero()
        {

            character1.TakeDamage(1100, character2);
            Assert.That(character1.Health, Is.EqualTo(0));
            Assert.That(character1.IsAlive, Is.False);
        }

        [Test]
        public void Dead_Character_Cannot_Be_Healed()
        {

            character1.TakeDamage(1100, character2);


            character1.Heal(200, character1);

            Assert.That(character1.Health, Is.EqualTo(0));
           
        }

        [Test]
        public void Alive_Character_Can_Be_Healed()
        {

            character1.TakeDamage(400, character2);


            character1.Heal(200, character1);

            Assert.That(character1.IsAlive, Is.True);
            Assert.That(character1.Health, Is.EqualTo(800));

        }

        [Test]
        public void Alive_Character_Cannot_Be_Healed_More_Than_1000()
        {

            character1.TakeDamage(100, character2);


            character1.Heal(300, character1);

            Assert.That(character1.IsAlive, Is.True);
            Assert.That(character1.Health, Is.EqualTo(1000));

        }

        [Test]
        public void Alive_Character_At_1000_Health_Cannot_Be_Healed()
        {
            character1.TakeDamage(0, character2);

            character1.Heal(300, character1);

            Assert.That(character1.IsAlive, Is.True);
            Assert.That(character1.Health, Is.EqualTo(1000));

        }
                              
    }
}