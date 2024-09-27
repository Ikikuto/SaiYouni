# Khai Báo Thêm 5 Phương Thức Cho Class Enemy
public class Enemy
{
    public float health;
    public float speed;
    public float damage;
    public Transform target;

    public Enemy(float health, float speed, float damage, Transform target)
    {
        this.health = health;
        this.speed = speed;
        this.damage = damage;
        this.target = target;
    }

    // Method 1:  Enemy chay khoi ng choi
    public void RunAway()
    {
    }

    // Method 2: Hoi mau cho Enemy
    public void HealEnemy()
    {
    }

    // Method 3: Enemy song lai
    public void EnemyRevive()
    {
    }

    // Method 4: Enemy Chet
    private void Die()
    {
    }

    // Method 5: Enemy tuan tra
    public void Patrol()
    {
    }
}

## Mục Tiêu

Hướng dẫn này giúp bạn hiểu cách khai báo và triển khai thêm 5 phương thức cho class `Enemy` trong Unity C#. Các phương thức này sẽ giúp quản lý hành vi của kẻ địch trong trò chơi.

# Khai Báo Thêm 5 Biến Cho Class Enemy
public class Enemy
{
    float health;           //Mau ke dich
    float speed;            //Toc do ke dich
    float damage;           //Sat thuong ke dich
    int level;              //Cap do ke dich    
    string enemyName;       //Ten ke dich
}

## Mục Tiêu
Hướng dẫn này giúp bạn hiểu cách khai báo và triển khai thêm 5 biến cho class `Enemy` trong Unity C#. Các biến này sẽ giúp quản lý các thuộc tính và trạng thái của kẻ địch trong trò chơi.
