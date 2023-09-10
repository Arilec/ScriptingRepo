using System;					
public class Program
{
	//Creates a weapon and enemies
	public Weapon Uchigatana;
	public Weapon Pistol;
	public Character player;
	public Character enemy;
	
	public void Main()
	{
		//defines our new weapons, weapon characteristics, and characters
		Uchigatana = new Weapon();
		Pistol = new Weapon();
		Pistol.weaponName = "Pistol";
		Pistol.magSize = 21;
		Pistol.ammoCount=Pistol.magSize;
		Pistol.damage = 5f;
		Pistol.Range = 50f;
		Pistol.maxAmmo = Pistol.magSize * 3;
		
		//Arming Player
		player = new Character();
		player.equippedWeapon = Pistol;
		player.health = 50f;

		//arming Enemy
		enemy = new Character();
		enemy.equippedWeapon = Uchigatana;
		//Offsetting Enemy Position
		enemy.posX = 100f;
		enemy.moveSpeed = 35f;


		Console.WriteLine("The Evil Samarai Warrior stands poised, ready for battle.");
		
		while(enemy.health > 0 || player.health > 0)
		{
			int actions = 2;
			while (actions != 0){
				//Setting up input
				Console.WriteLine("Enemy is at " + enemy.posX + ", player is at " + player.posX);
				//input
				Console.WriteLine("What Would You Like To do?");
				Console.WriteLine("1: Move Forward");
				Console.WriteLine("2: Move Attack");
				Console.WriteLine("3: Move Backward");
				Console.WriteLine("Actions remaining: "+ actions);
			
				int input1 = Convert.ToInt32(Console.ReadLine());
				if (input1 == 1)
				{
					//Player moves
					player.posX = player.posX+player.moveSpeed;
				} else if (input1 == 2)
				{
					//player attacks
					bool didHit = false;
					if(player.posX + player.equippedWeapon.Range >= enemy.posX || player.posX - player.equippedWeapon.Range <= enemy.posX)
					{
						didHit = true;
					} 
					
					Console.WriteLine("Player attacks enemy with " + player.equippedWeapon.weaponName);
					if (didHit)
					{
						Console.WriteLine("Player Hits");
						Console.WriteLine("it does " + player.equippedWeapon.damage + " damage");
						enemy.health -= player.equippedWeapon.damage;
					} else {
						Console.WriteLine("Player Misses");
					}
					Console.WriteLine("enemy is at " + enemy.health + " health");
					player.equippedWeapon.ammoCount--;
					player.equippedWeapon.maxAmmo--;
				} else if (input1 == 3) {
					//player moves back
					player.posX = player.posX-player.moveSpeed;
				}
				actions--;
			}
			// Enemy AI
			int EnemyActions = 2;
			while (EnemyActions != 0){
				
				if (enemy.posX + enemy.equippedWeapon.Range >= player.posX || enemy.posX - enemy.equippedWeapon.Range <= player.posX)
				{
					Console.WriteLine("Enemy attacks Player with " + enemy.equippedWeapon.weaponName);
	
					Console.WriteLine("Enemy Hits");
					Console.WriteLine("it does " + enemy.equippedWeapon.damage + " damage");
					player.health -= enemy.equippedWeapon.damage;
				} else if (enemy.posX > player.posX){
					enemy.posX =-enemy.moveSpeed;
					
				} else if (enemy.posX < player.posX){
					enemy.posX =+ enemy.moveSpeed;
					
				}
				Console.WriteLine("Enemy is at " + enemy.posX + ", player is at " + player.posX);
				Console.WriteLine("Player is at " + player.health + "health");
				EnemyActions--;
			
			}
			
		}
		if (player.health != 0){
				Console.WriteLine("Victory");
			} else {
				Console.WriteLine("Defeat");
			}

		
		
	}
}
//these are our classes
public class Weapon{
	public int ammoCount = 10;
	public int magSize = 10;
	public int maxAmmo = 10;
	public string weaponName = "Uchigatana";
	public float Range = 10f;
	public float damage = 16f;
}

public class Character {
	public float health = 20f;
	//if only I had vector2
	public float posX = 0f;
	public Weapon equippedWeapon;
	public float moveSpeed = 30f;
}
