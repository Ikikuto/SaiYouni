# Agenda Phát Triển Game Week 2

## 1. Kể Tên 3 Hàm Màu Xanh (Blue) Mà Unity Sẽ Tự Động Gọi
Awake():
Hàm này được gọi ngay khi đối tượng được khởi tạo, ngay cả trước khi phương thức Start() được gọi.
Đây là nơi bạn nên khởi tạo các biến hoặc thực hiện các thiết lập mà bạn cần trước khi đối tượng bắt đầu chạy.
Màu Xanh: Đây là hàm Unity tự động gọi và được đặc biệt định danh trong MonoBehaviour.

Start():
Hàm này được gọi trước khi khung hình (frame) đầu tiên được cập nhật, sau khi đối tượng đã được khởi tạo xong.
Sử dụng Start() để khởi tạo mọi thứ cần thiết cho đối tượng trước khi bắt đầu cập nhật logic trong hàm Update().
Màu Xanh: Unity tự động gọi hàm này nếu nó được khai báo.

Update():
Hàm này được gọi mỗi khung hình (frame) và thường được dùng để xử lý logic của đối tượng, như chuyển động hoặc kiểm tra điều kiện.
Đây là hàm cập nhật liên tục, phù hợp cho việc kiểm tra các sự kiện thay đổi theo thời gian thực.
Màu Xanh: Unity tự động gọi hàm này mỗi frame khi game đang chạy.

## 2. Kể Tên 5 Loại Giải Thuật Sắp Xếp Khác Nhau
Bubble Sort (Sắp xếp nổi bọt):
So sánh các cặp phần tử liền kề và hoán đổi chúng nếu chúng không theo thứ tự. Quá trình này được lặp đi lặp lại cho đến khi không còn cặp nào cần hoán đổi.

Selection Sort (Sắp xếp chọn):
Tìm phần tử nhỏ nhất (hoặc lớn nhất) trong danh sách và đưa nó về đầu danh sách. Sau đó, tiếp tục tìm phần tử nhỏ nhất trong danh sách còn lại và lặp lại quá trình cho đến khi danh sách được sắp xếp.

Insertion Sort (Sắp xếp chèn):
Xây dựng dần dần danh sách đã sắp xếp bằng cách lấy từng phần tử từ danh sách chưa sắp xếp và chèn nó vào đúng vị trí trong danh sách đã sắp xếp.

Merge Sort (Sắp xếp trộn):
Chia danh sách thành hai nửa, sau đó sắp xếp từng nửa và cuối cùng trộn (merge) hai nửa đã được sắp xếp lại với nhau.

Quick Sort (Sắp xếp nhanh):
Chọn một phần tử làm "pivot" và sắp xếp các phần tử xung quanh nó sao cho các phần tử nhỏ hơn đứng bên trái và lớn hơn đứng bên phải. Sau đó, áp dụng đệ quy cho hai nửa danh sách.


## 3. Dùng Một Giải Thuật Sắp Xếp Khác Để Thay Cho Giải Thuật Trong Buổi Học
Giải Thuật Trong Buổi Học: Selection Sort
Giải Thuật Sắp Xếp Khác: Bubble Sort

## 4. Thực Hiện Random Cho Current HP
- Sử dụng code để thực hiện random cho giá trị **Current HP** của nhân vật hoặc đối tượng trong game.
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHP = 100; // Khai bao gia tri Max HP cua nhan vat
    public int currentHP;   // HP hien tai cua nhan vat

    void Start()
    {
        currentHP = Random.Range(1, maxHP + 1); // Random currentHP tu 1 den maxHP = 100
        Debug.Log("Current HP: " + currentHP);  // currentHP
    }
}

## 5. Tìm Enemy Có Current HP Nhỏ Nhất

- Viết code tìm đối tượng enemy có **Current HP** nhỏ nhất trong danh sách enemy.

using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public string name;
    public int currentHP;

    public Enemy(string name, int currentHP)
    {
        this.name = name;
        this.currentHP = currentHP;
    }
}

public class EnemyManager : MonoBehaviour
{
    void Start()
    {
        // Create List Enemy
        List<Enemy> enemies = new List<Enemy>
        {
            new Enemy("Goblin", 30),
            new Enemy("Orc", 50),
            new Enemy("Troll", 10),
            new Enemy("Dragon", 100)
        };

        // Tim Enemy co currentHP nho nhat
        Enemy weakestEnemy = FindEnemyWithLowestHP(enemies);

        // Kiem tra va in ra Enemy co HP thap nhat
        if (weakestEnemy != null)
        {
            Debug.Log($"Enemy with lowest HP: {weakestEnemy.name} with HP {weakestEnemy.currentHP}");
        }
    }

    Enemy FindEnemyWithLowestHP(List<Enemy> enemies)
    {
        if (enemies == null || enemies.Count == 0)
            return null;

        Enemy weakestEnemy = enemies[0];

        foreach (Enemy enemy in enemies)
        {
            if (enemy.currentHP < weakestEnemy.currentHP)
            {
                weakestEnemy = enemy;
            }
        }

        return weakestEnemy;
    }
}


## 6. Tìm Enemy Có Current HP Lớn Nhất

- Viết code tìm đối tượng enemy có **Current HP** lớn nhất trong danh sách enemy.

using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public string name;
    public int currentHP;

    public Enemy(string name, int currentHP)
    {
        this.name = name;
        this.currentHP = currentHP;
    }
}

public class EnemyManager : MonoBehaviour
{
    void Start()
    {
        // Create List Enemy
        List<Enemy> enemies = new List<Enemy>
        {
            new Enemy("Goblin", 30),
            new Enemy("Orc", 50),
            new Enemy("Troll", 10),
            new Enemy("Dragon", 100)
        };

        // Tim Enemy co currentHP cao nhat
        Enemy StrongestEnemy = FindEnemyWithHighestHP(enemies);

        // Kiem tra va in ra Enemy co HP thap nhat
        if (strongestEnemy != null)
        {
            Debug.Log($"Enemy with highest HP: {strongestEnemy.name} with HP {strongestEnemy.currentHP}");
        }
    }

    Enemy FindEnemyWithHighestHP(List<Enemy> enemies)
    {
        if (enemies == null || enemies.Count == 0)
            return null;

        Enemy strongestEnemy = enemies[0];

        foreach (Enemy enemy in enemies)
        {
            if (enemy.currentHP < strongestEnemy.currentHP)
            {
                strongestEnemy = enemy;
            }
        }

        return strongestEnemy;
    }
}

## 7. Bài Tập Về If Để Thực Hành

- Đọc IFStatementPractices.md

Đã đọc

## 8. Bài Tập Về Foreach Để Thực Hành

- Đọc ForeachPractices.md

Đã đọc

## 9. Bài Tập Về For Để Thực Hành

- Đọc ForPractices.md

Đã đọc