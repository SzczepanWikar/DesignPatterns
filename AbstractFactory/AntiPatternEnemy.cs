namespace AbstractFactory
{
    internal class AntiPatternEnemy
    {
        public int HP { get; set; }
        public EnemyType Type { get; private set; }
        public string? Name { get; set; }

        public AntiPatternEnemy(EnemyType type)
        {
            Type = type;
            switch (Type)
            {
                case EnemyType.Human:
                    HP = 100;
                    break;
                case EnemyType.Flying: 
                    HP = 50;
                    break;
                case EnemyType.Beast: 
                    HP = 300;
                    break;
                case EnemyType.Magical: 
                    Name = "Daniel";
                    HP= 50;
                    break;
            }
        }
        public void OnDemage()
        {
            switch (Type)
            {
                case EnemyType.Human:
                    HP -= 10;
                    Console.WriteLine("Blooding effect.");
                    break;
                case EnemyType.Flying:
                    HP -= 20;
                    break;
                case EnemyType.Beast:
                    HP -= 5;
                    break;
                case EnemyType.Magical:
                    HP -= 15;
                    break;
            }
        }
        public void Attack()
        {
            switch (Type)
            {
                case EnemyType.Human:
                    Console.WriteLine("Close distance physical attack!");
                    break;
                case EnemyType.Flying:
                    Console.WriteLine("Close distance physical attack!");
                    break;
                case EnemyType.Beast:
                    Console.WriteLine("Close distance physical attack!");
                    break;
                case EnemyType.Magical:
                    Console.WriteLine("Fireball!");
                    break;
            }
        }
        public void Move()
        {
            switch (Type)
            {
                case EnemyType.Human:
                    Console.WriteLine("Medium range move.");
                    break;
                case EnemyType.Flying:
                    Console.WriteLine("Fly.");
                    break;
                case EnemyType.Beast:
                    Console.WriteLine("Medium range move.");
                    break;
                case EnemyType.Magical:
                    Console.WriteLine("Teleportation!");
                    break;
            }
        }
    }
}
