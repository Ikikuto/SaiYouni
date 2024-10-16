# Bài Tập Thực Hành: Vòng Lặp For

## Giới Thiệu

Vòng lặp **For** là một trong những cấu trúc lặp cơ bản và được sử dụng phổ biến nhất trong lập trình. Vòng lặp này giúp thực hiện một đoạn mã nhiều lần dựa trên điều kiện cho trước. Dưới đây là 20 bài tập giúp bạn rèn luyện kỹ năng sử dụng vòng lặp **For** trong nhiều tình huống khác nhau.

## 20 Bài Tập Thực Hành Về For

### Bài Tập 1: In Các Số Từ 1 Đến 100

Viết một chương trình sử dụng vòng lặp **For** để in các số từ 1 đến 100.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Sử dụng vòng lặp for để in các số từ 1 đến 100
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }
}


### Bài Tập 2: Tính Tổng Các Số Từ 1 Đến 50

Viết một chương trình sử dụng vòng lặp **For** để tính tổng các số từ 1 đến 50.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
}

### Bài Tập 3: In Các Số Chẵn Từ 1 Đến 100

Viết một chương trình sử dụng vòng lặp **For** để in tất cả các số chẵn từ 1 đến 100.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
}


### Bài Tập 4: Tính Tích Các Số Từ 1 Đến 10

Viết một chương trình sử dụng vòng lặp **For** để tính tích của các số từ 1 đến 10.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
}


### Bài Tập 5: Tìm Số Lớn Nhất Trong Một Mảng

Viết một chương trình sử dụng vòng lặp **For** để tìm số lớn nhất trong một mảng số nguyên.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
}


### Bài Tập 6: Tính Tổng Các Số Lẻ Từ 1 Đến 100

Viết một chương trình sử dụng vòng lặp **For** để tính tổng các số lẻ từ 1 đến 100.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumOddNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
}


### Bài Tập 7: Đảo Ngược Chuỗi

Viết một chương trình sử dụng vòng lặp **For** để đảo ngược một chuỗi.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
}


### Bài Tập 8: In Ra Bảng Cửu Chương

Viết một chương trình sử dụng vòng lặp **For** để in ra bảng cửu chương của một số bất kỳ (từ 1 đến 10).
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Số để in bảng cửu chương (có thể thay đổi tùy ý)
    public int number = 5;

    // Start is called before the first frame update
    void Start()
    {
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
}


### Bài Tập 9: Đếm Các Số Nguyên Dương Trong Mảng

Viết một chương trình sử dụng vòng lặp **For** để đếm số lượng các số nguyên dương trong một mảng số nguyên.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountPositiveNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
}


### Bài Tập 10: In Tam Giác Số

Viết một chương trình sử dụng vòng lặp **For** để in ra một tam giác số như sau:
1
12
123
1234
12345

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberTriangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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
}


### Bài Tập 11: Tìm Phần Tử Nhỏ Nhất Trong Mảng

Viết một chương trình sử dụng vòng lặp **For** để tìm phần tử nhỏ nhất trong một mảng số nguyên.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Khai báo một mảng số nguyên
        int[] numbers = { 34, 12, 5, 67, 2, 90, -1, 15 };
        
        // Giả sử số nhỏ nhất ban đầu là phần tử đầu tiên của mảng
        int min = numbers[0];

        // Sử dụng vòng lặp for để tìm số nhỏ nhất
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i]; // Cập nhật min nếu tìm thấy giá trị nhỏ hơn
            }
        }

        // In kết quả ra console
        Debug.Log("Phần tử nhỏ nhất trong mảng là: " + min);
    }
}


### Bài Tập 12: In Dãy Fibonacci

Viết một chương trình sử dụng vòng lặp **For** để in ra dãy Fibonacci từ 1 đến n (n là số nhập từ người dùng).
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FibonacciSequence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Nhập số n từ người dùng
        int n = 10; // Bạn có thể thay đổi giá trị này hoặc sử dụng Input.GetKeyDown để nhập từ bàn phím

        // Gọi phương thức để in dãy Fibonacci
        PrintFibonacci(n);
    }

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


### Bài Tập 13: Tính Giai Thừa Của Một Số

Viết một chương trình sử dụng vòng lặp **For** để tính giai thừa của một số nguyên dương n.
using UnityEngine;

public class FactorialCalculator : MonoBehaviour
{
    // Giá trị n nhập từ Inspector trong Unity
    public int n;

    // Hàm này sẽ được gọi khi nhấn Play
    void Start()
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
}


### Bài Tập 14: In Ra Các Số Nguyên Từ n Đến 1

Viết một chương trình sử dụng vòng lặp **For** để in ra các số nguyên từ n đến 1, với n là số nhập từ người dùng.
using UnityEngine;

public class PrintNumbers : MonoBehaviour
{
    // Giá trị n nhập từ Inspector
    public int n;

    // Hàm Start được gọi khi nhấn Play trong Unity
    void Start()
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
}


### Bài Tập 15: Tính Tổng Các Phần Tử Trong Mảng

Viết một chương trình sử dụng vòng lặp **For** để tính tổng các phần tử trong một mảng số nguyên.
using UnityEngine;

public class ArraySum : MonoBehaviour
{
    // Mảng số nguyên được khai báo và nhập giá trị từ Inspector
    public int[] values;

    // Hàm Start được gọi khi nhấn Play trong Unity
    void Start()
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
}


### Bài Tập 16: Kiểm Tra Số Nguyên Tố

Viết một chương trình sử dụng vòng lặp **For** để kiểm tra xem một số nguyên có phải là số nguyên tố hay không.
using UnityEngine;

public class PrimeChecker : MonoBehaviour
{
    // Số nguyên được nhập từ Inspector
    public int numberToCheck;

    // Hàm Start sẽ được gọi khi nhấn Play
    void Start()
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
}


### Bài Tập 17: In Ra Dãy Số Chia Hết Cho 3

Viết một chương trình sử dụng vòng lặp **For** để in ra các số từ 1 đến 100 chia hết cho 3.
using UnityEngine;

public class DivisibleByThree : MonoBehaviour
{
    // Hàm Start sẽ được gọi khi nhấn Play
    void Start()
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
}


### Bài Tập 18: Tìm Tổng Các Số Chẵn Trong Mảng

Viết một chương trình sử dụng vòng lặp **For** để tính tổng các phần tử chẵn trong một mảng số nguyên.
using UnityEngine;

public class EvenSumCalculator : MonoBehaviour
{
    // Mảng số nguyên được khai báo và nhập giá trị từ Inspector
    public int[] integerArray;

    // Hàm Start sẽ được gọi khi nhấn Play
    void Start()
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
}


### Bài Tập 19: Tính Trung Bình Cộng Của Mảng

Viết một chương trình sử dụng vòng lặp **For** để tính trung bình cộng của các phần tử trong một mảng số nguyên.
using UnityEngine;

public class AverageCalculator : MonoBehaviour
{
    // Mảng số nguyên được khai báo và nhập giá trị từ Inspector
    public int[] elements;

    // Hàm Start sẽ được gọi khi nhấn Play
    void Start()
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
}


### Bài Tập 20: Đếm Số Ký Tự Hoa Trong Chuỗi

Viết một chương trình sử dụng vòng lặp **For** để đếm số lượng ký tự hoa trong một chuỗi.
using UnityEngine;

public class UpperCaseCounter : MonoBehaviour
{
    // Chuỗi được nhập từ Inspector
    public string inputString;

    // Hàm Start sẽ được gọi khi nhấn Play
    void Start()
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


## Kết Luận

Các bài tập trên giúp bạn rèn luyện kỹ năng sử dụng vòng lặp **For** để giải quyết các bài toán cơ bản và nâng cao trong lập trình. Thực hành nhiều sẽ giúp bạn hiểu sâu hơn về cấu trúc vòng lặp và cách áp dụng chúng vào các bài toán thực tế.
