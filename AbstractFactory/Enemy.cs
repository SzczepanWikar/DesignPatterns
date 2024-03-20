namespace AbstractFactory
{
    internal abstract class Enemy
    {
        public int HP { get; set; }
        public EnemyType Type { get; set; }

        public abstract void OnDemage();
        public abstract void Attack();
        public abstract void Move();
    }

    internal class EnemyFactory
    {
        public Enemy CreateEnemy(EnemyType type)
        {
            switch(type)
            {
                case EnemyType.Human: return new HumanEnemy();
                case EnemyType.Flying: return new FlyingEnemy();
                case EnemyType.Beast: return new BeastEnemy();
                case EnemyType.Magical: return new MagicalEnemy();
                default: return null;
            }
        }
    }

    internal class HumanEnemy : Enemy
    {
        public EnemyType Type { get; } = EnemyType.Human;

        public HumanEnemy()
        {
            HP = 100;
        }
        public override void Attack()
        {
            Console.WriteLine("Close distance physical attack!");
        }

        public override void Move()
        {
            Console.WriteLine("Medium range move.");
        }

        public override void OnDemage()
        {
            HP -= 10;
            Console.WriteLine("Blooding effect.");
        }
    }

    internal class FlyingEnemy : Enemy
    {
        public EnemyType Type { get; } = EnemyType.Flying;

        public FlyingEnemy()
        {
            HP = 50;
        }
        public override void Attack()
        {
            Console.WriteLine("Close distance physical attack!");
        }

        public override void Move()
        {
            Console.WriteLine("Fly.");
        }

        public override void OnDemage()
        {
            HP -= 20;
        }
    }

    internal class BeastEnemy : Enemy
    {
        public EnemyType Type { get; } = EnemyType.Flying;

        public BeastEnemy()
        {
            HP = 300;
        }
        public override void Attack()
        {
            Console.WriteLine("Close distance physical attack!");
        }

        public override void Move()
        {
            Console.WriteLine("Small range move.");
        }

        public override void OnDemage()
        {
            HP -= 5;
        }
    }

    internal class MagicalEnemy : Enemy
    {
        public EnemyType Type { get; } = EnemyType.Flying;

        public string Name { get; } = "Daniel";
        public MagicalEnemy()
        {
            HP = 50;
        }
        public override void Attack()
        {
            Console.WriteLine("Fireball!");
        }

        public override void Move()
        {
            Console.WriteLine("Teleportation!");
        }

        public override void OnDemage()
        {
            HP -= 15;
        }
    }
}
