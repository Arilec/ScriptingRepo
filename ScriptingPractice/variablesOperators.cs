using System;
					
public class Program
{
	//Creates a weapon and enemies
	public Weapon Uchigatana;
	public Character player;
	public Character enemy;
	
	public void Main()
	{
		//defines our new weapons and characters & arms characters
		Uchigatana = new Weapon();
		
		player = new Character();
		player.equippedWeapon = Uchigatana;
		//enemy position offset
		enemy = new Character();
		enemy.posX += 10f;
		enemy.equippedWeapon = Uchigatana;
		
		//player beats up enemy
		while(enemy.health > 0)
		{
			
			if(player.posX + player.equippedWeapon.Range < enemy.posX)
			{
				player.posX += player.moveSpeed;
				Console.WriteLine("Player moved forward");
				if (player.posX > enemy.posX)
				{
					player.posX = enemy.posX --;
				}
			} else {
				enemy.health -= player.equippedWeapon.damage;
				Console.WriteLine("Player attacks enemy with " + player.equippedWeapon.weaponName);
				Console.WriteLine("it does " + player.equippedWeapon.damage + " damage");
				Console.WriteLine("enemy is at " + enemy.health + " health");
			}
		}

		
	}
}
//these are our classes
public class Weapon{
	public int ammoCount = 10;
	public int magSize = 10;
	public int maxAmmo = 10;
	public string weaponName = "Uchigatana";
	public float Range = 5;
	public float damage = 5f;
}

public class Character {
	public float health = 20f;
	//if only I had vector2
	public float posX = 30f;
	public Weapon equippedWeapon;
	public float moveSpeed = 10f;
}

 .