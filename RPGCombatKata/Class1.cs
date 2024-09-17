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

       
        }

    }
}