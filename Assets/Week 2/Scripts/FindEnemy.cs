using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public string name;
    public int health;

    public Enemy(string name, int health)
    {
        this.name = name;
        this.health = health;
    }
}

public class FindEnemy : MonoBehaviour
{
    // Danh sách các kẻ thù
    public List<Enemy> enemies = new List<Enemy>();

    void Start()
    {
        // Thêm các kẻ thù vào danh sách
        enemies.Add(new Enemy("Goblin", 30));
        enemies.Add(new Enemy("Orc", 50));
        enemies.Add(new Enemy("Troll", 70));
        enemies.Add(new Enemy("Dragon", 100));

        // Tìm kẻ thù có lượng máu nhỏ nhất
        Enemy weakestEnemy = FindEnemyWithSmallestHealth();
        if (weakestEnemy != null)
        {
            Debug.Log("Kẻ thù có lượng máu nhỏ nhất: " + weakestEnemy.name + " với " + weakestEnemy.health + " máu.");
        }

        // Tìm kẻ thù có lượng máu lớn nhất
        Enemy strongestEnemy = FindEnemyWithLargestHealth();
        if (strongestEnemy != null)
        {
            Debug.Log("Kẻ thù có lượng máu lớn nhất: " + strongestEnemy.name + " với " + strongestEnemy.health + " máu.");
        }
    }

    //----------------------Edit below here --------------------

    // Tìm kẻ thù có lượng máu nhỏ nhất
    public Enemy FindEnemyWithSmallestHealth()
    {
        if (enemies.Count == 0) return null; // Nếu không có kẻ thù nào

        Enemy smallestHealthEnemy = enemies[0]; // Khởi tạo với kẻ thù đầu tiên

        for (int i = 1; i < enemies.Count; i++)
        {
            if (enemies[i].health < smallestHealthEnemy.health)
            {
                smallestHealthEnemy = enemies[i];
            }
        }

        return smallestHealthEnemy;
    }

    // Tìm kẻ thù có lượng máu lớn nhất
    public Enemy FindEnemyWithLargestHealth()
    {
        if (enemies.Count == 0) return null; // Nếu không có kẻ thù nào

        Enemy largestHealthEnemy = enemies[0]; // Khởi tạo với kẻ thù đầu tiên

        for (int i = 1; i < enemies.Count; i++)
        {
            if (enemies[i].health > largestHealthEnemy.health)
            {
                largestHealthEnemy = enemies[i];
            }
        }

        return largestHealthEnemy;
    }

    //----------------------Edit above here --------------------
}


