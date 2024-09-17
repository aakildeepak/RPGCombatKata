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

            if (Health < 0)
            {
                Health = 0;
                IsAlive = false;
            }
        }
        public void Heal(int HealAmount)
            

        { 
            if (!IsAlive) 
                
                return;
            
            Health += HealAmount;

            if (Health > 1000)
            {
                Health = 1000;
            }
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

        [Test]
        public void Character_Dies_When_Health_Reaches_Zero()
        {
            var character = new Character();
         

            character.TakeDamage(1100);
            Assert.That(character.Health, Is.EqualTo(0));
            Assert.That(character.IsAlive, Is.False);
        }

        [Test]
        public void Dead_Character_Cannot_Be_Healed()
        {
            var character = new Character();


            character.TakeDamage(1100);


            character.Heal(200);

            Assert.That(character.Health, Is.EqualTo(0));
           
        }

        [Test]
        public void Alive_Character_Can_Be_Healed()
        {
            var character = new Character();



            character.TakeDamage(400);


            character.Heal(200);

            Assert.That(character.IsAlive, Is.True);
            Assert.That(character.Health, Is.EqualTo(800));

        }

        [Test]
        public void Alive_Character_Cannot_Be_Healed_More_Than_1000()
        {
            var character = new Character();



            character.TakeDamage(100);


            character.Heal(300);

            Assert.That(character.IsAlive, Is.True);
            Assert.That(character.Health, Is.EqualTo(1000));

        }

        [Test]
        public void Alive_Character_At_1000_Health_Cannot_Be_Healed()
        {
            var character = new Character();



            character.TakeDamage(0);

            character.Heal(300);

            Assert.That(character.IsAlive, Is.True);
            Assert.That(character.Health, Is.EqualTo(1000));

        }


    }
}