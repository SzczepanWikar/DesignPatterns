using AbstractFactory;

var human = new AntiPatternEnemy(EnemyType.Human);
var magician = new EnemyFactory().CreateEnemy(EnemyType.Magical);

human.Attack();
magician.Move();