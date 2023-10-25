namespace _25oct_task
{
    internal class Weapon
    {

        public int bulletCap;
        public int currentBullets;
        public int nobulletTime;
        public int shootingMode;


        public void Shoot()
        {
            Console.WriteLine("Weapon fired once.");
            currentBullets -= 1;
        }
        public void Fire()
        {
            int OneBulletTime = bulletCap / nobulletTime;
            if (shootingMode == 1)
            {
                Console.WriteLine("Weapon fired once. Time taken: " + OneBulletTime + " milliseconds");
                currentBullets -= 1;
            }
            else if (shootingMode == 2)
            {
                Console.WriteLine("All bullets fired. Time taken: " + OneBulletTime * currentBullets + " milliseconds");
                currentBullets = 0;
            }
            else
            {
                Console.WriteLine("Wrong fire mode. Please select single-fire or automatic.");
            }
        }

        public int GetNeededBulletCount()
        {
            return bulletCap - currentBullets;
        }
        public void Reload()
        {
            Console.WriteLine("Weapon reloaded.");
            currentBullets = bulletCap;
        }

        public void ChangeFireMode()
        {
            Console.WriteLine("Enter 1 for single fire, 2 for automatic:");
            shootingMode = Convert.ToInt32(Console.ReadLine());
            if (shootingMode == 1)
            {
                Console.WriteLine("Weapon fired once.");
                currentBullets--;
            }
            else
            {
                if (shootingMode == 2)
                {
                    Console.WriteLine("Your Firing mode is now auto");
                }
                else
                {
                    if (shootingMode >= 3 || shootingMode < 0)
                    {
                        Console.WriteLine("Wrong input");
                    }
                }
            }
        
        }
        public void Exit()
        {
            Console.WriteLine("Click 6 to exit:");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 6)
            {
                Environment.Exit(0);
            }
        }
    }
}
