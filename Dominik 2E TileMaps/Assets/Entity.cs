using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity 
{
		string name;
		int age;
		string faction;
		string occupation;
		int level;
		int health;
		int strength;
		int magic;
		int defense;
		int speed;
		int damage;
		int armor;
		string weapon;
		int position;
        private void Start() {
            Entity a = new Entity();
            Player b = new Player();
            Enemys c = new Enemys();

            c.name = "Enemy";

            Entity e = c as Entity;

           
        }
		public virtual void TakeDamage(int amount)
		{
            health-=amount;	
		}
        public void Attack(Entity entity)
        {
            entity.health-=damage;
        }
}
public class Player : Entity
{
    public string[] inventory;
    int money;
    string[] skills;

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);
       
    }
}
public class Enemys : Entity
{
    public string[] skills;
}
