using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        // Game Controller Tests

        [TestMethod()]
        public void choosePlayerClass()
        {
            try
            {
                GameController vTest = new GameController(NonPlayerCharacter, PlayerCharacter);
                string vPlayerClass = vTest.choosePlayerClass("Warrior");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void getWinner()
        {
            try
            {
                GameController vTest = new GameController(PlayerCharacter, NonPlayerCharacter);
                string vResult = vTest.getWinner("Player");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void normalAttack()
        {
            try
            {
                GameController vTest = new GameController(PlayerCharacter, NonPlayerCharacter);
                vTest.normalAttack();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void specialAttack()
        {
            try
            {
                GameController vTest = new GameController(PlayerCharacter, NonPlayerCharacter);
                vTest.specialAttack();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void StartBattleTest()
        {
            try
            {
                GameController vTest = new GameController(NonPlayerCharacter, PlayerCharacter);
                vTest.startBattle();
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        // Character Unit Tests

        [TestMethod()]
        public void dealDamage()
        {
            try
            {
                Character vTest = new Character(10, 100, 100);
                int vDamage = vTest.dealDamage(10);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void getNormalAttackDamage()
        {
            try
            {
                Character vTest = new Character(10, 100, 100);
                int vResult = vTest.getNormalAttackDamage(10);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        // PlayerCharacter Unit Tests

        [TestMethod()]
        public void calculateSuccess()
        {
            try
            {
                PlayerCharacter vTest = new PlayerCharacter("Player", NormalAttack, SpecialAttack);
                bool vResult = vTest.calculateSuccess(True);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void getSpecialAttackDamage()
        {
            try
            {
                PlayerCharacter vTest = new PlayerCharacter("Player", NormalAttack, SpecialAttack);
                int vDamage = vTest.getSpecialAttackDamage(30);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        // Non Player Character Unit Tests

        [TestMethod()]
        public void selectEnemy()
        {
            try
            {
                NonPlayerCharacter vTest = new NonPlayerCharacter(NormalAttack, "Enemy");
                string vEnemy = vTest.selectEnemy("Goblin");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
