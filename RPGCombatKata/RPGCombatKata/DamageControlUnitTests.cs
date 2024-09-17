﻿using System.Reflection.PortableExecutable;

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

       
        

    }
}