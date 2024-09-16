using System.Reflection.PortableExecutable;

namespace RPGCombatKata
{
    public class Character
    { 
        public int Health { get; set; }
        public int Level { get; set; }

        public bool IsAlive { get; set; }

        public Character()
        {
            Health = 1000;
            Level = 1;
            IsAlive = true;
        }

        public void TakeDamage(int DamageDealt)
        {
             Health -= DamageDealt;
        }
    }

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Character_When_Created_Has_Default_Health_Value_Of_1000()
        {
            var character = new Character();

            Assert.That(character.Health, Is.EqualTo(1000));
        }

        [Test]
        public void Character_When_Created_Has_Default_Character_Level_Of_1()
        {
            var character = new Character();

            Assert.That(character.Level, Is.EqualTo(1));

        }

        [Test]
        public void Character_When_Created_Is_Alive_By_Default()
        {
            var character = new Character();

            Assert.That(character.IsAlive, Is.True);
        }

        [Test]
        public void Character1_When_Deals_Damage_Reduces_Character2_Health()
        {
            var character1 = new Character();
            var character2 = new Character();

            character2.TakeDamage(200);
            Assert.That(character2.Health, Is.EqualTo (800));
        }


    }
}