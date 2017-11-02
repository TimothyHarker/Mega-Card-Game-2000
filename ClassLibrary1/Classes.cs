using System;
using System.Windows;

namespace ClassLibrary
{
    public class Character
    {
        private int maxHealthpoints { set; get; }
        private int currentHealthPoints { set; get; }
        private int baseDamage { set; get; }



        public int dealDamage(int damageAmount)
        {
            currentHealthPoints -= damageAmount;
            return currentHealthPoints;
        }

        public int getNormalAttackDamage()
        {
            return baseDamage;
        }
    }

    public class PlayerCharacter : Character
    {
        private char characterName { set; get; }
        private NormalAttack normalAttack { set; get; }
        private SpecialAttack specialAttack { set; get; }

        public int dealDamage()
        {
            throw new NotImplementedException();
        }

        public bool calculateSuccess()
        {
            Random Roll = new Random();

            if (Roll.Next(1, 2) == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }

    public class Mage : PlayerCharacter
    {

    }

    public class Thief : PlayerCharacter
    {

    }

    public class Warrior : PlayerCharacter
    {

    }

    public class NonPlayerCharacter : Character
    {
        private char enemyType { set; get; }
        private NormalAttack attack { set; get; }

        public string selectEnemy()
        {
            
        }
    }

    public class Attack
    {

    }

    public class NormalAttack : Attack
    {

    }

    public class SpecialAttack : Attack
    {

    }

    public class Beserk : SpecialAttack
    {

    }

    public class BackStab : SpecialAttack
    {

    }

    public class Fireball : SpecialAttack
    {

    }

    public class GameController
    {
        private PlayerCharacter player;
        private NonPlayerCharacter enemy;

        public string choosePlayerCharacter()
        {
            if (choosenClass = "Warrior")
            {
                player = new Warrior(50, 50, 10, "Warrior", 10);
            }

            if (choosenClass = "Thief")
            {
                player = new Thief(50, 50, 10, "Thief", 10);
            }

            if (choosenClass = "Mage")
            {
                player = new Mage(50, 50, 10, "Mage", 10);
            }
        }

        // Displays Winner of game
        public void displayWinner(string winnerName)
        {
            if (getWinner = "enemy")
            {
                MessageBox.Show("You Died, Game Over");
            }

            if (getWinner = "player")
            {
                MessageBox.Show("Congratulations You Win! Game will now end");
            }

        }

        // Gets winner name
        public string getWinner()
        {
            if (player.currentHealthPoints <= 0)
            {
                return "enemy";
            }

            if (enemy.currentHealthPoints <= 0)
            {
                return "player";
            }
        }

        public void normalAttack()
        {
            throw new NotImplementedException();
        }

        public void specialAttack()
        {
            throw new NotImplementedException();
        }

        public void startBattle()
        {
            throw new NotImplementedException();
        }
    }
}
