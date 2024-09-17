using System.Reflection.PortableExecutable;

namespace RPGCombatKata
{
   
    public class Tests
    {
        private Character character;
    
        [SetUp]
        public void Setup()
        {
            character = new Character();
        }

        [Test]
        public void Character_When_Created_Has_Default_Health_Value_Of_1000()
        {
            
            Assert.That(character.Health, Is.EqualTo(1000));
        }

        [Test]
        public void Character_When_Created_Has_Default_Character_Level_Of_1()
        {
            

            Assert.That(character.Level, Is.EqualTo(1));

        }

        [Test]
        public void Character_When_Created_Is_Alive_By_Default()
        {
           

            Assert.That(character.IsAlive, Is.True);
        }

        [Test]
        public void Character_When_Deals_Damage_Reduces_Health()
        {


            character.TakeDamage(200);
            Assert.That(character.Health, Is.EqualTo (800));
        }

        [Test]
        public void Character_Dies_When_Health_Reaches_Zero()
        {


            character.TakeDamage(1100);
            Assert.That(character.Health, Is.EqualTo(0));
            Assert.That(character.IsAlive, Is.False);
        }

        [Test]
        public void Dead_Character_Cannot_Be_Healed()
        {

            character.TakeDamage(1100);


            character.Heal(200);

            Assert.That(character.Health, Is.EqualTo(0));
           
        }

        [Test]
        public void Alive_Character_Can_Be_Healed()
        {

            character.TakeDamage(400);


            character.Heal(200);

            Assert.That(character.IsAlive, Is.True);
            Assert.That(character.Health, Is.EqualTo(800));

        }

        [Test]
        public void Alive_Character_Cannot_Be_Healed_More_Than_1000()
        {

            character.TakeDamage(100);


            character.Heal(300);

            Assert.That(character.IsAlive, Is.True);
            Assert.That(character.Health, Is.EqualTo(1000));

        }

        [Test]
        public void Alive_Character_At_1000_Health_Cannot_Be_Healed()
        {
            character.TakeDamage(0);

            character.Heal(300);

            Assert.That(character.IsAlive, Is.True);
            Assert.That(character.Health, Is.EqualTo(1000));

        }
                              
    }
}