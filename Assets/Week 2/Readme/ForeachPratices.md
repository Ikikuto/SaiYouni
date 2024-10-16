# Bài Tập Thực Hành: Vòng Lặp Foreach

## Giới Thiệu

Vòng lặp **foreach** trong lập trình được sử dụng để duyệt qua các phần tử của một tập hợp (ví dụ như mảng, danh sách, hay tập hợp). Vòng lặp này giúp duyệt qua từng phần tử mà không cần biết đến chỉ số cụ thể, giúp mã dễ đọc và ngắn gọn hơn. Dưới đây là 20 bài tập giúp bạn rèn luyện kỹ năng sử dụng vòng lặp **foreach**.

## 20 Bài Tập Thực Hành Về Foreach

### Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để in tất cả các phần tử của một mảng số nguyên.
using UnityEngine;

public class ArrayPrinter : MonoBehaviour
{
    void Start()
    {
        // Khởi tạo một mảng số nguyên
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Sử dụng vòng lặp foreach để in tất cả các phần tử trong mảng
        foreach (int number in numbers)
        {
            Debug.Log(number);
        }
    }
}


### Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để tính tổng tất cả các phần tử trong một mảng số nguyên.
using UnityEngine;

public class ArraySumCalculator : MonoBehaviour
{
    void Start()
    {
        // Khởi tạo một mảng số nguyên
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Khởi tạo biến để lưu tổng
        int sum = 0;

        // Sử dụng vòng lặp foreach để tính tổng tất cả các phần tử trong mảng
        foreach (int number in numbers)
        {
            sum += number;
        }

        // In ra tổng của các phần tử
        Debug.Log("Tổng các phần tử trong mảng là: " + sum);
    }
}


### Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để tìm phần tử lớn nhất trong một mảng số nguyên.
using UnityEngine;

public class MaxElementFinder : MonoBehaviour
{
    void Start()
    {
        // Khởi tạo một mảng số nguyên
        int[] numbers = { 10, 20, 5, 40, 15 };

        // Giả định rằng phần tử đầu tiên là lớn nhất
        int max = numbers[0];

        // Sử dụng vòng lặp foreach để tìm phần tử lớn nhất
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // In ra phần tử lớn nhất
        Debug.Log("Phần tử lớn nhất trong mảng là: " + max);
    }
}


### Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để đếm số lượng các phần tử chẵn trong một mảng số nguyên.
using UnityEngine;

public class EvenNumberCounter : MonoBehaviour
{
    void Start()
    {
        // Khởi tạo một mảng số nguyên
        int[] numbers = { 10, 25, 32, 47, 50, 68, 73 };

        // Biến để đếm số lượng phần tử chẵn
        int evenCount = 0;

        // Sử dụng vòng lặp foreach để đếm số lượng phần tử chẵn
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        // In ra số lượng phần tử chẵn
        Debug.Log("Số lượng phần tử chẵn trong mảng là: " + evenCount);
    }
}


### Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách

Viết một chương trình sử dụng vòng lặp **foreach** để in tất cả các chuỗi trong một danh sách các chuỗi.
using System.Collections.Generic;
using UnityEngine;

public class StringListPrinter : MonoBehaviour
{
    void Start()
    {
        // Khởi tạo một danh sách các chuỗi
        List<string> stringList = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Date",
            "Elderberry"
        };

        // Sử dụng vòng lặp foreach để in ra tất cả các chuỗi
        foreach (string str in stringList)
        {
            Debug.Log(str);
        }
    }
}


### Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách

Viết một chương trình sử dụng vòng lặp **foreach** để tìm chuỗi dài nhất trong một danh sách các chuỗi.
using System.Collections.Generic;
using UnityEngine;

public class LongestStringFinder : MonoBehaviour
{
    void Start()
    {
        // Khởi tạo một danh sách các chuỗi
        List<string> stringList = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Pineapple",
            "Elderberry"
        };

        // Biến để lưu chuỗi dài nhất
        string longestString = stringList[0];

        // Sử dụng vòng lặp foreach để tìm chuỗi dài nhất
        foreach (string str in stringList)
        {
            if (str.Length > longestString.Length)
            {
                longestString = str;
            }
        }

        // In ra chuỗi dài nhất
        Debug.Log("Chuỗi dài nhất trong danh sách là: " + longestString);
    }
}


### Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để tính tổng tất cả các phần tử lẻ trong một mảng số nguyên.
using System;

public class OddNumberSum
{
    public static void Main(string[] args)
    {
        // Khai báo mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Khởi tạo biến tổng
        int sum = 0;

        // Sử dụng vòng lặp foreach để tính tổng các số lẻ
        foreach (int number in numbers)
        {
            if (number % 2 != 0) // Kiểm tra nếu là số lẻ
            {
                sum += number; // Cộng số lẻ vào tổng
            }
        }

        // In ra tổng các số lẻ
        Console.WriteLine("Tổng các số lẻ trong mảng là: " + sum);
    }
}


### Bài Tập 8: In Các Số Chẵn Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để in tất cả các số chẵn trong một mảng số nguyên.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenNumberPrinter : MonoBehaviour
{
    void Start()
    {
        // Khai báo mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Sử dụng vòng lặp foreach để in các số chẵn
        Debug.Log("Các số chẵn trong mảng là:");
        foreach (int number in numbers)
        {
            if (number % 2 == 0) // Kiểm tra nếu là số chẵn
            {
                Debug.Log(number); // In số chẵn ra trong Console của Unity
            }
        }
    }
}


### Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để kiểm tra xem một phần tử cụ thể có tồn tại trong một mảng số nguyên hay không.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementChecker : MonoBehaviour
{
    void Start()
    {
        // Khai báo mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Phần tử cần kiểm tra
        int target = 5;
        
        // Gọi hàm kiểm tra sự tồn tại của phần tử
        bool exists = CheckIfElementExists(numbers, target);

        // In ra kết quả kiểm tra
        if (exists)
        {
            Debug.Log("Phần tử " + target + " tồn tại trong mảng.");
        }
        else
        {
            Debug.Log("Phần tử " + target + " không tồn tại trong mảng.");
        }
    }

    // Hàm kiểm tra xem phần tử có tồn tại trong mảng không
    bool CheckIfElementExists(int[] array, int target)
    {
        foreach (int number in array)
        {
            if (number == target) // Nếu tìm thấy phần tử trong mảng
            {
                return true;
            }
        }
        return false; // Nếu không tìm thấy phần tử
    }
}


### Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để đếm số lượng các phần tử âm trong một mảng số nguyên.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegativeNumberCounter : MonoBehaviour
{
    void Start()
    {
        // Khai báo mảng số nguyên
        int[] numbers = { -1, 2, -3, 4, 5, -6, 7, -8, 9, -10 };

        // Khởi tạo biến đếm
        int negativeCount = 0;

        // Sử dụng vòng lặp foreach để đếm các phần tử âm
        foreach (int number in numbers)
        {
            if (number < 0) // Kiểm tra nếu là số âm
            {
                negativeCount++; // Tăng biến đếm
            }
        }

        // In ra số lượng phần tử âm
        Debug.Log("Số lượng phần tử âm trong mảng là: " + negativeCount);
    }
}

### Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để in tất cả các số lớn hơn 10 trong một mảng số nguyên.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersGreaterThanTen : MonoBehaviour
{
    void Start()
    {
        // Khai báo mảng số nguyên
        int[] numbers = { 5, 12, 7, 15, 8, 22, 3, 14 };

        // Sử dụng vòng lặp foreach để in các số lớn hơn 10
        Debug.Log("Các số lớn hơn 10 trong mảng là:");
        foreach (int number in numbers)
        {
            if (number > 10) // Kiểm tra nếu số lớn hơn 10
            {
                Debug.Log(number); // In số đó ra trong Console của Unity
            }
        }
    }
}


### Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách

Viết một chương trình sử dụng vòng lặp **foreach** để tìm chuỗi có độ dài ngắn nhất trong một danh sách các chuỗi.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortestStringFinder : MonoBehaviour
{
    void Start()
    {
        // Khai báo danh sách các chuỗi
        List<string> stringList = new List<string> { "Unity", "C#", "Hello", "World", "AI", "Game" };

        // Biến lưu chuỗi ngắn nhất và khởi tạo với giá trị đầu tiên
        string shortestString = stringList[0];

        // Sử dụng vòng lặp foreach để tìm chuỗi ngắn nhất
        foreach (string str in stringList)
        {
            if (str.Length < shortestString.Length) // So sánh độ dài chuỗi
            {
                shortestString = str; // Cập nhật chuỗi ngắn nhất
            }
        }

        // In ra chuỗi ngắn nhất
        Debug.Log("Chuỗi có độ dài ngắn nhất là: " + shortestString);
    }
}


### Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để nhân đôi giá trị của tất cả các phần tử trong một mảng số nguyên.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleArrayValues : MonoBehaviour
{
    void Start()
    {
        // Khai báo mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Sử dụng vòng lặp foreach để nhân đôi giá trị của các phần tử
        Debug.Log("Giá trị ban đầu của các phần tử:");
        foreach (int number in numbers)
        {
            Debug.Log(number); // In ra giá trị ban đầu
        }

        // Vòng lặp để nhân đôi giá trị của các phần tử
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 2; // Nhân đôi giá trị của phần tử
        }

        // In ra các giá trị sau khi đã nhân đôi
        Debug.Log("Giá trị sau khi nhân đôi:");
        foreach (int number in numbers)
        {
            Debug.Log(number); // In ra giá trị đã nhân đôi
        }
    }
}


### Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để tìm phần tử lớn thứ hai trong một mảng số nguyên.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLargestFinder : MonoBehaviour
{
    void Start()
    {
        // Khai báo mảng số nguyên
        int[] numbers = { 3, 14, 5, 9, 22, 7, 8, 22 };

        // Kiểm tra nếu mảng có ít hơn 2 phần tử
        if (numbers.Length < 2)
        {
            Debug.Log("Mảng phải có ít nhất 2 phần tử.");
            return;
        }

        // Khởi tạo biến để tìm phần tử lớn nhất và lớn thứ hai
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        // Vòng lặp foreach để tìm phần tử lớn nhất và lớn thứ hai
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                secondLargest = largest; // Cập nhật phần tử lớn thứ hai
                largest = number;        // Cập nhật phần tử lớn nhất
            }
            else if (number > secondLargest && number != largest)
            {
                secondLargest = number; // Cập nhật phần tử lớn thứ hai
            }
        }

        // In ra phần tử lớn thứ hai
        if (secondLargest == int.MinValue)
        {
            Debug.Log("Không có phần tử lớn thứ hai hợp lệ.");
        }
        else
        {
            Debug.Log("Phần tử lớn thứ hai trong mảng là: " + secondLargest);
        }
    }
}


### Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A

Viết một chương trình sử dụng vòng lặp **foreach** để in ra tất cả các chuỗi bắt đầu bằng chữ cái 'A' trong một danh sách các chuỗi.
using System.Collections.Generic;
using UnityEngine;

public class StringFilter : MonoBehaviour
{
    // Tạo một danh sách chuỗi
    private List<string> strings = new List<string>()
    {
        "Apple", "Banana", "Avocado", "Cherry", "Apricot", "Blueberry"
    };

    // Hàm này sẽ được gọi khi chạy game
    void Start()
    {
        // Sử dụng vòng lặp foreach để in các chuỗi bắt đầu bằng 'A'
        foreach (string str in strings)
        {
            if (str.StartsWith("A"))
            {
                Debug.Log(str);
            }
        }
    }
}


### Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không

Viết một chương trình sử dụng vòng lặp **foreach** để kiểm tra xem một danh sách các chuỗi có chứa chuỗi "Hello" hay không.
using System.Collections.Generic;
using UnityEngine;

public class CheckHello : MonoBehaviour
{
    // Tạo một danh sách các chuỗi
    private List<string> strings = new List<string>()
    {
        "Welcome", "Hi", "Hello", "Goodbye", "Greetings"
    };

    // Hàm này sẽ được gọi khi game bắt đầu
    void Start()
    {
        bool containsHello = false;

        // Sử dụng vòng lặp foreach để kiểm tra nếu danh sách chứa chuỗi "Hello"
        foreach (string str in strings)
        {
            if (str == "Hello")
            {
                containsHello = true;
                break; // Dừng vòng lặp nếu tìm thấy "Hello"
            }
        }

        // In kết quả ra console
        if (containsHello)
        {
            Debug.Log("The list contains 'Hello'.");
        }
        else
        {
            Debug.Log("The list does not contain 'Hello'.");
        }
    }
}


### Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để in ra tất cả các phần tử âm trong một mảng số nguyên.
using UnityEngine;

public class NegativeNumbers : MonoBehaviour
{
    // Tạo một mảng số nguyên
    private int[] numbers = { 3, -5, 7, -2, 0, -8, 4 };

    // Hàm này sẽ được gọi khi game bắt đầu
    void Start()
    {
        // Sử dụng vòng lặp foreach để in các phần tử âm
        foreach (int num in numbers)
        {
            if (num < 0)
            {
                Debug.Log("Negative number: " + num);
            }
        }
    }
}


### Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để đếm số lần xuất hiện của một phần tử cụ thể trong một mảng số nguyên.
using UnityEngine;

public class CountElementOccurrences : MonoBehaviour
{
    // Tạo một mảng số nguyên
    private int[] numbers = { 3, 5, 7, 5, 0, 8, 5, 4 };

    // Phần tử cần đếm
    public int targetElement = 5;

    // Hàm này sẽ được gọi khi game bắt đầu
    void Start()
    {
        int count = 0;

        // Sử dụng vòng lặp foreach để đếm số lần xuất hiện của phần tử targetElement
        foreach (int num in numbers)
        {
            if (num == targetElement)
            {
                count++;
            }
        }

        // In kết quả ra console
        Debug.Log("Element " + targetElement + " appears " + count + " times.");
    }
}


### Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng

Viết một chương trình sử dụng vòng lặp **foreach** để tạo một danh sách mới từ các phần tử có giá trị lớn hơn 10 trong một mảng số nguyên.
using System.Collections.Generic;
using UnityEngine;

public class FilterGreaterThanTen : MonoBehaviour
{
    // Tạo một mảng số nguyên
    private int[] numbers = { 3, 15, 7, 12, 0, 25, 8, 4 };

    // Hàm này sẽ được gọi khi game bắt đầu
    void Start()
    {
        // Tạo một danh sách mới để chứa các phần tử lớn hơn 10
        List<int> greaterThanTen = new List<int>();

        // Sử dụng vòng lặp foreach để duyệt qua các phần tử trong mảng
        foreach (int num in numbers)
        {
            if (num > 10)
            {
                greaterThanTen.Add(num);  // Thêm phần tử vào danh sách mới nếu nó lớn hơn 10
            }
        }

        // In danh sách các phần tử lớn hơn 10 ra console
        Debug.Log("Elements greater than 10:");
        foreach (int num in greaterThanTen)
        {
            Debug.Log(num);
        }
    }
}


### Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự

Viết một chương trình sử dụng vòng lặp **foreach** để in ra tất cả các chuỗi có độ dài lớn hơn 5 ký tự trong một danh sách các chuỗi.
using System.Collections.Generic;
using UnityEngine;

public class FilterStringsByLength : MonoBehaviour
{
    // Tạo một danh sách các chuỗi
    private List<string> strings = new List<string>()
    {
        "Unity", "Game", "Developer", "Programming", "AI", "Tutorial"
    };

    // Hàm này sẽ được gọi khi game bắt đầu
    void Start()
    {
        // Sử dụng vòng lặp foreach để duyệt qua các chuỗi trong danh sách
        foreach (string str in strings)
        {
            if (str.Length > 5)
            {
                Debug.Log("String with more than 5 characters: " + str);
            }
        }
    }
}


## Kết Luận

Các bài tập này sẽ giúp bạn làm quen với việc sử dụng vòng lặp **foreach** để duyệt qua các phần tử trong các tập hợp khác nhau, từ mảng số nguyên đến danh sách các chuỗi. Việc thực hành sẽ giúp bạn hiểu rõ hơn về cú pháp và ứng dụng của vòng lặp **foreach** trong lập trình.
