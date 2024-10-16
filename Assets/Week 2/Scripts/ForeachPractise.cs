using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    public int target;      //bt 9

    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Sử dụng foreach để in tất cả các phần tử trong mảng
        foreach (int number in numbers)
        {
            Debug.Log(number);
        }
    }

    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // In ra tổng của các phần tử
        Debug.Log("Tổng các phần tử trong mảng là: " + sum);

    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 10, 20, 5, 40, 15 };

        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        int max = numbers[0];
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

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 10, 25, 32, 47, 50, 68, 73 };

        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        int evenCount = 0;

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

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        List<string> stringList = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Date",
            "Elderberry"
        };

        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        foreach (string str in stringList)
        {
            Debug.Log(str);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        List<string> stringList = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Pineapple",
            "Elderberry"
        };
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        string longestString = stringList[0];
        
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

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        int sum = 0;

        foreach (int number in numbers)
        {
            if (number % 2 != 0) // Kiểm tra nếu là số lẻ
            {
                sum += number; // Cộng số lẻ vào tổng
            }
        }

        // In ra tổng các số lẻ
        Debug.Log("Tổng các số lẻ trong mảng là: " + sum);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        Debug.Log("Các số chẵn trong mảng là:");
        foreach (int number in numbers)
        {
            if (number % 2 == 0) // Kiểm tra nếu là số chẵn
            {
                Debug.Log(number); // In số chẵn ra trong Console của Unity
            }
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
            // Khai báo mảng số nguyên
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

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

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { -1, 2, -3, 4, 5, -6, 7, -8, 9, -10 };

        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        int negativeCount = 0;

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

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 5, 12, 7, 15, 8, 22, 3, 14 };

        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        Debug.Log("Các số lớn hơn 10 trong mảng là:");
        foreach (int number in numbers)
        {
            if (number > 10) // Kiểm tra nếu số lớn hơn 10
            {
                Debug.Log(number); // In số đó ra trong Console của Unity
            }
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        List<string> stringList = new List<string> { "Unity", "C#", "Hello", "World", "AI", "Game" };

        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        string shortestString = stringList[0];

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

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
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

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 3, 14, 5, 9, 22, 7, 8, 22 };

        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng

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

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        List<string> strings = new List<string>()
    {
        "Apple", "Banana", "Avocado", "Cherry", "Apricot", "Blueberry"
    };

        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        foreach (string str in strings)
        {
            if (str.StartsWith("A"))
            {
                Debug.Log(str);
            }
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        List<string> strings = new List<string>()
    {
        "Welcome", "Hi", "Hello", "Goodbye", "Greetings"
    };

        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
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

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 3, -5, 7, -2, 0, -8, 4 };

        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        foreach (int num in numbers)
        {
            if (num < 0)
            {
                Debug.Log("Negative number: " + num);
            }
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        int[] numbers = { 3, 5, 7, 5, 0, 8, 5, 4 };

        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        int targetElement = 5;

        int count = 0;

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

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 3, 15, 7, 12, 0, 25, 8, 4 };

        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10

        // Tạo một danh sách mới để chứa các phần tử lớn hơn 10
        List<int> greaterThanTen = new List<int>();

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

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        List<string> strings = new List<string>()
    {
        "Unity", "Game", "Developer", "Programming", "AI", "Tutorial"
    };

        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        foreach (string str in strings)
        {
            if (str.Length > 5)
            {
                Debug.Log("String with more than 5 characters: " + str);
            }
        }
    }

}
