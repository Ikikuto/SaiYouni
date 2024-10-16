using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    public int number = 5;
    public int n = 8;
    public int[] values;
    public int numberToCheck;   //bt 16
    public int[] integerArray;  //bt 18
    public int[] elements;      //bt 19
    public string inputString;  //bt 20

    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In Các Số Từ 1 Đến 100
        BaiTap2(); // Tính Tổng Các Số Từ 1 Đến 50
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

    // Bài Tập 1: In Các Số Từ 1 Đến 100
    void BaiTap1()
    {
        // Sử dụng vòng lặp for để in các số từ 1 đến 100
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến 50
    void BaiTap2()
    {
        int sum = 0;

        // Sử dụng vòng lặp for để tính tổng các số từ 1 đến 50
        for (int i = 1; i <= 50; i++)
        {
            sum += i; // Cộng giá trị của i vào biến sum
        }

        // In kết quả ra console
        Debug.Log("Tổng các số từ 1 đến 50 là: " + sum);
    }

    // Bài Tập 3: In Các Số Chẵn Từ 1 Đến 100
    void BaiTap3()
    {
        // Sử dụng vòng lặp for để in tất cả các số chẵn từ 1 đến 100
        for (int i = 1; i <= 100; i++)
        {
            // Kiểm tra nếu số là chẵn
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }

    // Bài Tập 4: Tính Tích Các Số Từ 1 Đến 10
    void BaiTap4()
    {
        // Khởi tạo biến tích với giá trị 1
        int product = 1;

        // Sử dụng vòng lặp for để tính tích các số từ 1 đến 10
        for (int i = 1; i <= 10; i++)
        {
            product *= i; // Nhân giá trị của i vào biến product
        }

        // In kết quả ra console
        Debug.Log("Tích của các số từ 1 đến 10 là: " + product);
    }

    // Bài Tập 5: Tìm Số Lớn Nhất Trong Một Mảng
    void BaiTap5()
    {
        // Khai báo một mảng số nguyên
        int[] numbers = { 3, 15, 8, 23, 42, 7, 16 };

        // Giả sử số lớn nhất ban đầu là phần tử đầu tiên của mảng
        int max = numbers[0];

        // Sử dụng vòng lặp for để tìm số lớn nhất
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i]; // Cập nhật max nếu tìm thấy giá trị lớn hơn
            }
        }

        // In kết quả ra console
        Debug.Log("Số lớn nhất trong mảng là: " + max);
    }

    // Bài Tập 6: Tính Tổng Các Số Lẻ Từ 1 Đến 100
    void BaiTap6()
    {
        int sum = 0;

        // Sử dụng vòng lặp for để tính tổng các số lẻ từ 1 đến 100
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0) // Kiểm tra nếu i là số lẻ
            {
                sum += i; // Cộng giá trị của i vào biến sum
            }
        }

        // In kết quả ra console
        Debug.Log("Tổng các số lẻ từ 1 đến 100 là: " + sum);
    }

    // Bài Tập 7: Đảo Ngược Chuỗi
    void BaiTap7()
    {
        string input = "Unity3D"; // Chuỗi cần đảo ngược
        string reversedString = "";

        // Sử dụng vòng lặp for để duyệt chuỗi từ cuối về đầu
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedString += input[i]; // Thêm ký tự vào chuỗi đảo ngược
        }

        // In kết quả ra console
        Debug.Log("Chuỗi ban đầu: " + input);
        Debug.Log("Chuỗi sau khi đảo ngược: " + reversedString);
    }

    // Bài Tập 8: In Ra Bảng Cửu Chương
    void BaiTap8()
    {
        //int number = 5;
       
            if (number < 1 || number > 10)
            {
                Debug.Log("Vui lòng nhập một số từ 1 đến 10.");
            }
            else
            {
                // Sử dụng vòng lặp for để in ra bảng cửu chương của số đã chọn
                for (int i = 1; i <= 10; i++)
                {
                    Debug.Log(number + " x " + i + " = " + (number * i));
                }
            }
    }

    // Bài Tập 9: Đếm Các Số Nguyên Dương Trong Mảng
    void BaiTap9()
    {
        // Khai báo một mảng số nguyên
        int[] numbers = { -5, 3, 0, 12, -1, 7, 9, -3, 4 };
        int count = 0;

        // Sử dụng vòng lặp for để đếm số lượng các số nguyên dương
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0) // Kiểm tra nếu số là dương
            {
                count++; // Tăng biến đếm nếu là số dương
            }
        }

        // In kết quả ra console
        Debug.Log("Số lượng các số nguyên dương trong mảng là: " + count);
    }

    // Bài Tập 10: In Tam Giác Số
    void BaiTap10()
    {
        // Sử dụng vòng lặp for để in ra tam giác số
        for (int i = 1; i <= 5; i++) // Duyệt từ 1 đến 5
        {
            string line = ""; // Khởi tạo chuỗi cho mỗi dòng

            for (int j = 1; j <= i; j++) // Duyệt từ 1 đến i để tạo ra các số trong dòng
            {
                line += j.ToString(); // Nối số j vào chuỗi
            }

            Debug.Log(line); // In dòng đã tạo ra ra console
        }
    }

    // Bài Tập 11: Tìm Phần Tử Nhỏ Nhất Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        int[] numbers = { 34, 12, 5, 67, 2, 90, -1, 15 };

        int min = numbers[0];

        // Sử dụng vòng lặp for để tìm số nhỏ nhất
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i]; // Cập nhật min nếu tìm thấy giá trị nhỏ hơn
            }
        }

        Debug.Log("Phần tử nhỏ nhất trong mảng là: " + min);
    }

    // Bài Tập 12: In Dãy Fibonacci
    void BaiTap12()
    {
        // Nhập số n từ người dùng
        int n = 10; // Bạn có thể thay đổi giá trị này hoặc sử dụng Input.GetKeyDown để nhập từ bàn phím

        // Gọi phương thức để in dãy Fibonacci
        PrintFibonacci(n);

        void PrintFibonacci(int n)
        {
            if (n < 1)
            {
                Debug.Log("Vui lòng nhập một số nguyên dương.");
                return;
            }

            // Khởi tạo các số Fibonacci
            int a = 0, b = 1;

            Debug.Log("Dãy Fibonacci từ 1 đến " + n + ":");

            // In dãy Fibonacci
            for (int i = 1; i <= n; i++)
            {
                int next = a + b; // Tính số tiếp theo trong dãy
                a = b; // Cập nhật a thành b
                b = next; // Cập nhật b thành next

                // Chỉ in ra các số lớn hơn 0
                if (a <= n)
                {
                    Debug.Log(a); // In ra số Fibonacci
                }
            }
        }

    }

    // Bài Tập 13: Tính Giai Thừa Của Một Số
    void BaiTap13()
    {
        if (n < 0)
        {
            Debug.Log("Vui lòng nhập một số nguyên dương.");
            return;
        }

        long factorial = 1;

        // Tính giai thừa sử dụng vòng lặp for
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        // Hiển thị kết quả trong Console
        Debug.Log($"Giai thừa của {n} là: {factorial}");
    }

    // Bài Tập 14: In Ra Các Số Nguyên Từ n Đến 1
    void BaiTap14()
    {
        if (n < 1)
        {
            Debug.Log("Vui lòng nhập một số nguyên dương.");
            return;
        }

        // Sử dụng vòng lặp for để in ra các số từ n đến 1
        for (int i = n; i >= 1; i--)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 15: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap15()
    {
        // Kiểm tra nếu mảng không có phần tử nào
        if (values.Length == 0)
        {
            Debug.Log("Mảng không có phần tử nào.");
            return;
        }

        int total = 0;

        // Sử dụng vòng lặp for để tính tổng các phần tử trong mảng
        for (int j = 0; j < values.Length; j++)
        {
            total += values[j];
        }

        // Hiển thị tổng của các phần tử trong Console
        Debug.Log($"Tổng của các phần tử trong mảng là: {total}");
    }

    // Bài Tập 16: Kiểm Tra Số Nguyên Tố
    void BaiTap16()
    {
        if (numberToCheck < 2)
        {
            Debug.Log($"{numberToCheck} không phải là số nguyên tố.");
            return;
        }

        bool isPrime = true;

        // Sử dụng vòng lặp for để kiểm tra số nguyên tố
        for (int currentDivisor = 2; currentDivisor <= Mathf.Sqrt(numberToCheck); currentDivisor++)
        {
            if (numberToCheck % currentDivisor == 0)
            {
                isPrime = false;
                break;
            }
        }

        // Hiển thị kết quả
        if (isPrime)
        {
            Debug.Log($"{numberToCheck} là số nguyên tố.");
        }
        else
        {
            Debug.Log($"{numberToCheck} không phải là số nguyên tố.");
        }
    }

    // Bài Tập 17: In Ra Dãy Số Chia Hết Cho 3
    void BaiTap17()
    {
        // Sử dụng vòng lặp for để in ra các số từ 1 đến 100 chia hết cho 3
        for (int counter = 1; counter <= 100; counter++)
        {
            if (counter % 3 == 0)
            {
                Debug.Log(counter);
            }
        }
    }

    // Bài Tập 18: Tìm Tổng Các Số Chẵn Trong Mảng
    void BaiTap18()
    {
        // Kiểm tra nếu mảng không có phần tử nào
        if (integerArray.Length == 0)
        {
            Debug.Log("Mảng không có phần tử nào.");
            return;
        }

        int evenSum = 0;

        // Sử dụng vòng lặp for để tính tổng các phần tử chẵn trong mảng
        for (int index = 0; index < integerArray.Length; index++)
        {
            if (integerArray[index] % 2 == 0)
            {
                evenSum += integerArray[index];
            }
        }

        // Hiển thị tổng của các phần tử chẵn trong Console
        Debug.Log($"Tổng các phần tử chẵn trong mảng là: {evenSum}");
    }

    // Bài Tập 19: Tính Trung Bình Cộng Của Mảng
    void BaiTap19()
    {
        // Kiểm tra nếu mảng không có phần tử nào
        if (elements.Length == 0)
        {
            Debug.Log("Mảng không có phần tử nào.");
            return;
        }

        int total = 0;

        // Sử dụng vòng lặp for để tính tổng các phần tử trong mảng
        for (int idx = 0; idx < elements.Length; idx++)
        {
            total += elements[idx];
        }

        // Tính trung bình cộng
        float average = (float)total / elements.Length;

        // Hiển thị trung bình cộng trong Console
        Debug.Log($"Trung bình cộng của các phần tử trong mảng là: {average}");
    }

    // Bài Tập 20: Đếm Số Ký Tự Hoa Trong Chuỗi
    void BaiTap20()
    {
        // Biến để lưu số lượng ký tự hoa
        int upperCaseCount = 0;

        // Sử dụng vòng lặp for để duyệt qua từng ký tự trong chuỗi
        for (int idx = 0; idx < inputString.Length; idx++)
        {
            // Kiểm tra xem ký tự có phải là chữ hoa không
            if (char.IsUpper(inputString[idx]))
            {
                upperCaseCount++;
            }
        }

        // Hiển thị số lượng ký tự hoa trong Console
        Debug.Log($"Số lượng ký tự hoa trong chuỗi là: {upperCaseCount}");
    }
}
