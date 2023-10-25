namespace _25oct_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon myWeapon = null;

            while (true)
            {
                Console.WriteLine("Enter your choice: \n<<<0 for gun information" +
                    ">>>\n<<<1 for Shoot" +
                    ">>>\n<<<2 for Fire All" +
                    ">>>\n<<<3 for Get Needed Bullet Count" +
                    ">>>\n<<<4 for Reload" +
                    ">>>\n<<<5 for Change Fire Mode" +
                    ">>>\n<<<6 for Exit" +
                    ">>>\n<<<w to create a weapon>>>:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        if (myWeapon != null)
                            DisplayGunInfo(myWeapon);
                        else
                            Console.WriteLine("No weapon created yet.");
                        break;
                    case "1":
                        if (myWeapon != null)
                            myWeapon.Shoot();
                        else
                            Console.WriteLine("No weapon created yet.");
                        break;
                    case "2":
                        if (myWeapon != null)
                            myWeapon.Fire();
                        else
                            Console.WriteLine("No weapon created yet.");
                        break;
                    case "3":
                        if (myWeapon != null)
                        {
                            int neededBullets = myWeapon.GetNeededBulletCount();
                            Console.WriteLine("Needed bullets: " + neededBullets);
                        }
                        else
                            Console.WriteLine("No weapon created yet.");
                        break;
                    case "4":
                        if (myWeapon != null)
                            myWeapon.Reload();
                        else
                            Console.WriteLine("No weapon created yet.");
                        break;
                    case "5":
                        if (myWeapon != null)
                            myWeapon.ChangeFireMode();
                        else
                            Console.WriteLine("No weapon created yet.");
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    case "w":
                        myWeapon = CreateWeapon();
                        Console.WriteLine("New weapon created.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static Weapon CreateWeapon()
        {
            Weapon newWeapon = new Weapon();

            bool validInput = false;

            do
            {
                Console.Write("Enter bullet capacity: ");
                newWeapon.bulletCap = Convert.ToInt32(Console.ReadLine());
                if (newWeapon.bulletCap <= 0)
                {
                    Console.WriteLine("Not possible.");
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            validInput = false;

            do
            {
                Console.Write("Enter current bullets: ");
                newWeapon.currentBullets = Convert.ToInt32(Console.ReadLine());
                if (newWeapon.currentBullets < 0 || newWeapon.currentBullets > newWeapon.bulletCap)
                {
                    Console.WriteLine("Not possible.");
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            validInput = false;

            do
            {
                Console.Write("Enter no bullet time: ");
                newWeapon.nobulletTime = Convert.ToInt32(Console.ReadLine());
                if (newWeapon.nobulletTime <= 0)
                {
                    Console.WriteLine("Not possible.");
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            validInput = false;

            do
            {
                Console.Write("Enter shooting mode (1 for single, 2 for auto): ");
                newWeapon.shootingMode = Convert.ToInt32(Console.ReadLine());
                if (newWeapon.shootingMode != 1 && newWeapon.shootingMode != 2)
                {
                    Console.WriteLine("Wrong Input. Please enter 1 for single or 2 for auto.");
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            return newWeapon;
        }

        static void DisplayGunInfo(Weapon weapon)
        {
            Console.WriteLine("Bullet Capacity: " + weapon.bulletCap);
            Console.WriteLine("Current Bullets: " + weapon.currentBullets);
            Console.WriteLine("No Bullet Time: " + weapon.nobulletTime);
            Console.WriteLine("Shooting Mode: " + weapon.shootingMode);
        }

    }
}


      
