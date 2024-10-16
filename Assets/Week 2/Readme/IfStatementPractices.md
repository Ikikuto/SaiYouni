# Bài Tập Thực Hành: Câu Lệnh If

## Giới Thiệu

Câu lệnh **if** là một trong những cấu trúc điều kiện quan trọng trong lập trình, cho phép thực hiện các khối lệnh khi điều kiện cho trước là đúng. Dưới đây là 20 bài tập giúp bạn luyện tập kỹ năng sử dụng câu lệnh **if** để kiểm tra điều kiện và xử lý các tình huống khác nhau.

## 20 Bài Tập Thực Hành Về If

### Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0

Viết chương trình kiểm tra xem một số nguyên nhập từ bàn phím là số **dương**, **âm**, hay **bằng 0**.
using UnityEngine;

public class NumberCheck : MonoBehaviour
{
    // Số nguyên cần kiểm tra
    public int number;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckNumber(number);
    }

    // Hàm kiểm tra số nguyên
    void CheckNumber(int num)
    {
        if (num > 0)
        {
            Debug.Log(num + " là số dương.");
        }
        else if (num < 0)
        {
            Debug.Log(num + " là số âm.");
        }
        else
        {
            Debug.Log("Số này bằng 0.");
        }
    }
}


### Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ

Viết chương trình kiểm tra xem một số nguyên nhập từ bàn phím là **chẵn** hay **lẻ**.
using UnityEngine;

public class EvenOddChecker : MonoBehaviour
{
    // Số nguyên cần kiểm tra
    public int inputNumber;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckEvenOdd(inputNumber);
    }

    // Hàm kiểm tra số chẵn lẻ
    void CheckEvenOdd(int num)
    {
        if (num % 2 == 0)
        {
            Debug.Log(num + " là số chẵn.");
        }
        else
        {
            Debug.Log(num + " là số lẻ.");
        }
    }
}


### Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ

Viết chương trình kiểm tra xem một học sinh có đỗ kỳ thi không nếu **điểm trung bình >= 5.0**.
using UnityEngine;

public class ExamResultChecker : MonoBehaviour
{
    // Điểm trung bình của học sinh
    public float averageScore;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckExamResult(averageScore);
    }

    // Hàm kiểm tra kết quả kỳ thi
    void CheckExamResult(float score)
    {
        if (score >= 5.0f)
        {
            Debug.Log("Học sinh đã đỗ kỳ thi.");
        }
        else
        {
            Debug.Log("Học sinh không đỗ kỳ thi.");
        }
    }
}


### Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số

Viết chương trình kiểm tra và in ra số lớn nhất trong hai số nguyên nhập từ bàn phím.
using UnityEngine;

public class MaxNumberChecker : MonoBehaviour
{
    // Hai số nguyên cần kiểm tra
    public int firstNumber;
    public int secondNumber;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckMaxNumber(firstNumber, secondNumber);
    }

    // Hàm kiểm tra và in ra số lớn nhất
    void CheckMaxNumber(int num1, int num2)
    {
        if (num1 > num2)
        {
            Debug.Log("Số lớn nhất là: " + num1);
        }
        else if (num1 < num2)
        {
            Debug.Log("Số lớn nhất là: " + num2);
        }
        else
        {
            Debug.Log("Hai số bằng nhau: " + num1);
        }
    }
}


### Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng

Viết chương trình kiểm tra xem một người có thể mua hàng không nếu **số tiền** của họ lớn hơn hoặc bằng **giá sản phẩm**.
using UnityEngine;

public class PurchaseChecker : MonoBehaviour
{
    // Số tiền của người mua
    public float customerMoney;

    // Giá sản phẩm
    public float productPrice;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckPurchase(customerMoney, productPrice);
    }

    // Hàm kiểm tra xem người mua có đủ tiền không
    void CheckPurchase(float money, float price)
    {
        if (money >= price)
        {
            Debug.Log("Người mua có thể mua sản phẩm.");
        }
        else
        {
            Debug.Log("Người mua không đủ tiền để mua sản phẩm.");
        }
    }
}


### Bài Tập 6: Kiểm Tra Năm Nhuận

Viết chương trình kiểm tra xem một năm nhập từ bàn phím có phải là **năm nhuận** hay không (năm nhuận là năm chia hết cho 4 nhưng không chia hết cho 100, hoặc chia hết cho 400).
using UnityEngine;

public class LeapYearChecker : MonoBehaviour
{
    // Năm cần kiểm tra
    public int year;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckLeapYear(year);
    }

    // Hàm kiểm tra năm nhuận
    void CheckLeapYear(int inputYear)
    {
        if ((inputYear % 4 == 0 && inputYear % 100 != 0) || (inputYear % 400 == 0))
        {
            Debug.Log(inputYear + " là năm nhuận.");
        }
        else
        {
            Debug.Log(inputYear + " không phải là năm nhuận.");
        }
    }
}


### Bài Tập 7: Tính Giá Vé Xem Phim

Viết chương trình tính giá vé xem phim với điều kiện:

- Nếu người mua **dưới 18 tuổi**, giá vé là 50,000 đồng.
- Nếu người mua **từ 18 tuổi trở lên**, giá vé là 100,000 đồng.

using UnityEngine;

public class TicketPriceCalculator : MonoBehaviour
{
    // Tuổi của người mua
    public int age;

    // Giá vé
    private int ticketPrice;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CalculateTicketPrice(age);
    }

    // Hàm tính giá vé dựa trên độ tuổi
    void CalculateTicketPrice(int customerAge)
    {
        if (customerAge < 18)
        {
            ticketPrice = 50000; // Giá vé cho người dưới 18 tuổi
        }
        else
        {
            ticketPrice = 100000; // Giá vé cho người từ 18 tuổi trở lên
        }

        Debug.Log("Giá vé cho người " + customerAge + " tuổi là: " + ticketPrice + " đồng.");
    }
}


### Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc

Viết chương trình kiểm tra xem một học sinh có đạt danh hiệu **học sinh xuất sắc** không nếu điểm trung bình của họ lớn hơn hoặc bằng 9.0.
using UnityEngine;

public class StudentAwardChecker : MonoBehaviour
{
    // Điểm trung bình của học sinh
    public float averageGrade;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckForExcellenceAward(averageGrade);
    }

    // Hàm kiểm tra danh hiệu học sinh xuất sắc
    void CheckForExcellenceAward(float grade)
    {
        if (grade >= 9.0f)
        {
            Debug.Log("Học sinh đạt danh hiệu học sinh xuất sắc.");
        }
        else
        {
            Debug.Log("Học sinh không đạt danh hiệu học sinh xuất sắc.");
        }
    }
}


### Bài Tập 9: So Sánh Ba Số

Viết chương trình kiểm tra và in ra số lớn nhất trong ba số nguyên nhập từ bàn phím.
using UnityEngine;

public class MaxOfThreeNumbers : MonoBehaviour
{
    // Ba số nguyên cần kiểm tra
    public int firstNumber;
    public int secondNumber;
    public int thirdNumber;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckMaxOfThree(firstNumber, secondNumber, thirdNumber);
    }

    // Hàm kiểm tra và in ra số lớn nhất
    void CheckMaxOfThree(int num1, int num2, int num3)
    {
        int maxNumber = num1; // Giả định số lớn nhất ban đầu là num1

        if (num2 > maxNumber)
        {
            maxNumber = num2; // Cập nhật maxNumber nếu num2 lớn hơn
        }

        if (num3 > maxNumber)
        {
            maxNumber = num3; // Cập nhật maxNumber nếu num3 lớn hơn
        }

        Debug.Log("Số lớn nhất là: " + maxNumber);
    }
}


### Bài Tập 10: Tính Tiền Lương

Viết chương trình tính tiền lương của nhân viên theo công thức:

- Nếu nhân viên làm **trên 40 giờ**, lương được tính là **40 giờ đầu** với mức lương cố định và **số giờ làm thêm** được tính với mức **lương gấp đôi**.
- Nếu làm **dưới hoặc bằng 40 giờ**, lương chỉ được tính với mức lương cố định.

using UnityEngine;

public class SalaryCalculator : MonoBehaviour
{
    // Mức lương cố định cho 40 giờ đầu
    public float fixedSalary = 3000000; // Ví dụ: 3,000,000 đồng
    // Số giờ làm việc của nhân viên
    public int hoursWorked;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        float totalSalary = CalculateSalary(hoursWorked);
        Debug.Log("Tiền lương của nhân viên là: " + totalSalary + " đồng.");
    }

    // Hàm tính tiền lương
    float CalculateSalary(int hours)
    {
        if (hours > 40)
        {
            // Tính số giờ làm thêm
            int overtimeHours = hours - 40;
            // Tính lương với giờ làm thêm
            float overtimeSalary = overtimeHours * (fixedSalary / 40) * 2; // Lương gấp đôi
            return fixedSalary + overtimeSalary; // Tổng lương
        }
        else
        {
            return fixedSalary; // Lương cố định
        }
    }
}


### Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ

Viết chương trình kiểm tra xem một người có thể vào câu lạc bộ không nếu họ **trên 18 tuổi** và có **thẻ thành viên**.
using UnityEngine;

public class ClubEntryChecker : MonoBehaviour
{
    // Tuổi của người muốn vào câu lạc bộ
    public int age;

    // Biến kiểm tra có thẻ thành viên hay không
    public bool hasMembershipCard;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckClubEntry(age, hasMembershipCard);
    }

    // Hàm kiểm tra xem người đó có thể vào câu lạc bộ không
    void CheckClubEntry(int personAge, bool membershipCard)
    {
        if (personAge > 18 && membershipCard)
        {
            Debug.Log("Người này có thể vào câu lạc bộ.");
        }
        else
        {
            Debug.Log("Người này không thể vào câu lạc bộ.");
        }
    }
}


### Bài Tập 12: Phân Loại Học Sinh

Viết chương trình phân loại học sinh dựa trên điểm trung bình:

- **Xuất sắc** nếu điểm trung bình >= 9.0
- **Giỏi** nếu điểm trung bình >= 8.0
- **Khá** nếu điểm trung bình >= 7.0
- **Trung bình** nếu điểm trung bình >= 5.0
- **Yếu** nếu điểm trung bình < 5.0

using UnityEngine;

public class StudentGradeClassifier : MonoBehaviour
{
    // Điểm trung bình của học sinh
    public float averageGrade;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        ClassifyStudent(averageGrade);
    }

    // Hàm phân loại học sinh dựa trên điểm trung bình
    void ClassifyStudent(float grade)
    {
        if (grade >= 9.0f)
        {
            Debug.Log("Học sinh đạt danh hiệu: Xuất sắc.");
        }
        else if (grade >= 8.0f)
        {
            Debug.Log("Học sinh đạt danh hiệu: Giỏi.");
        }
        else if (grade >= 7.0f)
        {
            Debug.Log("Học sinh đạt danh hiệu: Khá.");
        }
        else if (grade >= 5.0f)
        {
            Debug.Log("Học sinh đạt danh hiệu: Trung bình.");
        }
        else
        {
            Debug.Log("Học sinh đạt danh hiệu: Yếu.");
        }
    }
}


### Bài Tập 13: Tính Tiền Điện

Viết chương trình tính tiền điện theo công thức:

- Nếu số điện <= 100 kWh, giá điện là 1,500 đồng/kWh.
- Nếu số điện > 100 kWh, giá điện là 2,000 đồng/kWh cho phần vượt quá 100 kWh.

using UnityEngine;

public class ElectricityBillCalculator : MonoBehaviour
{
    // Số điện tiêu thụ (kWh)
    public float electricityUsage;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        float totalBill = CalculateElectricityBill(electricityUsage);
        Debug.Log("Tổng tiền điện phải trả là: " + totalBill + " đồng.");
    }

    // Hàm tính tiền điện
    float CalculateElectricityBill(float usage)
    {
        float bill = 0;

        if (usage <= 100)
        {
            bill = usage * 1500; // Giá điện cho phần ≤ 100 kWh
        }
        else
        {
            // Tính tiền cho 100 kWh đầu
            bill = 100 * 1500;
            // Tính tiền cho phần vượt quá 100 kWh
            bill += (usage - 100) * 2000;
        }

        return bill; // Trả về tổng tiền điện
    }
}


### Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức

Viết chương trình kiểm tra xem một nhân viên có đủ điều kiện thăng chức không nếu họ đã làm việc **trên 5 năm** và có **đánh giá công việc tốt**.
using UnityEngine;

public class PromotionEligibilityChecker : MonoBehaviour
{
    // Số năm làm việc của nhân viên
    public int yearsOfService;

    // Đánh giá công việc
    public bool hasGoodPerformanceReview;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckPromotionEligibility(yearsOfService, hasGoodPerformanceReview);
    }

    // Hàm kiểm tra xem nhân viên có đủ điều kiện thăng chức không
    void CheckPromotionEligibility(int serviceYears, bool performanceReview)
    {
        if (serviceYears > 5 && performanceReview)
        {
            Debug.Log("Nhân viên đủ điều kiện thăng chức.");
        }
        else
        {
            Debug.Log("Nhân viên không đủ điều kiện thăng chức.");
        }
    }
}


### Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển

Viết chương trình kiểm tra xem một đơn hàng có được miễn phí vận chuyển không nếu giá trị đơn hàng lớn hơn hoặc bằng 500,000 đồng.
using UnityEngine;

public class ShippingFeeChecker : MonoBehaviour
{
    // Giá trị đơn hàng
    public float orderValue;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckFreeShipping(orderValue);
    }

    // Hàm kiểm tra xem đơn hàng có được miễn phí vận chuyển không
    void CheckFreeShipping(float value)
    {
        if (value >= 500000)
        {
            Debug.Log("Đơn hàng được miễn phí vận chuyển.");
        }
        else
        {
            Debug.Log("Đơn hàng không được miễn phí vận chuyển.");
        }
    }
}


### Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân

Viết chương trình tính thuế thu nhập cá nhân theo công thức:

- Nếu thu nhập <= 10 triệu đồng, thuế suất là 5%.
- Nếu thu nhập > 10 triệu đồng và <= 20 triệu đồng, thuế suất là 10%.
- Nếu thu nhập > 20 triệu đồng, thuế suất là 20%.

using UnityEngine;

public class IncomeTaxCalculator : MonoBehaviour
{
    // Thu nhập cá nhân
    public float income;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        float taxAmount = CalculateIncomeTax(income);
        Debug.Log("Số thuế thu nhập cá nhân phải trả là: " + taxAmount + " đồng.");
    }

    // Hàm tính thuế thu nhập cá nhân
    float CalculateIncomeTax(float income)
    {
        float taxRate;

        if (income <= 10000000) // <= 10 triệu
        {
            taxRate = 0.05f; // 5%
        }
        else if (income > 10000000 && income <= 20000000) // > 10 triệu và <= 20 triệu
        {
            taxRate = 0.10f; // 10%
        }
        else // > 20 triệu
        {
            taxRate = 0.20f; // 20%
        }

        return income * taxRate; // Tính và trả về số thuế phải trả
    }
}


### Bài Tập 17: Tính Điểm Trung Bình Của Môn Học

Viết chương trình tính điểm trung bình của 3 bài kiểm tra và kiểm tra xem học sinh có đạt không (điểm >= 5.0).
using UnityEngine;

public class AverageScoreCalculator : MonoBehaviour
{
    // Điểm của 3 bài kiểm tra
    public float testScore1;
    public float testScore2;
    public float testScore3;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        float averageScore = CalculateAverageScore(testScore1, testScore2, testScore3);
        CheckPass(averageScore);
    }

    // Hàm tính điểm trung bình
    float CalculateAverageScore(float score1, float score2, float score3)
    {
        return (score1 + score2 + score3) / 3; // Tính điểm trung bình
    }

    // Hàm kiểm tra xem học sinh có đạt hay không
    void CheckPass(float average)
    {
        if (average >= 5.0f)
        {
            Debug.Log("Học sinh đạt.");
        }
        else
        {
            Debug.Log("Học sinh không đạt.");
        }
    }
}


### Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng

Viết chương trình kiểm tra xem một cửa hàng có thể nhập thêm hàng hay không nếu **số lượng hàng hiện tại < 100** và **hàng trong kho còn đủ chỗ**.
using UnityEngine;

public class StockChecker : MonoBehaviour
{
    // Số lượng hàng hiện tại
    public int currentStock;

    // Kiểm tra xem trong kho còn đủ chỗ hay không
    public bool isStorageAvailable;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckIfCanRestock(currentStock, isStorageAvailable);
    }

    // Hàm kiểm tra xem cửa hàng có thể nhập thêm hàng hay không
    void CheckIfCanRestock(int stock, bool storageAvailable)
    {
        if (stock < 100 && storageAvailable)
        {
            Debug.Log("Cửa hàng có thể nhập thêm hàng.");
        }
        else
        {
            Debug.Log("Cửa hàng không thể nhập thêm hàng.");
        }
    }
}


### Bài Tập 19: Tìm Số Lớn Hơn 10

Viết chương trình kiểm tra xem một số nguyên nhập từ bàn phím có lớn hơn 10 hay không.
using UnityEngine;

public class NumberChecker : MonoBehaviour
{
    // Số nguyên được nhập từ Inspector
    public int inputNumber;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckIfGreaterThanTen(inputNumber);
    }

    // Hàm kiểm tra xem số nguyên có lớn hơn 10 hay không
    void CheckIfGreaterThanTen(int number)
    {
        if (number > 10)
        {
            Debug.Log("Số nhập vào lớn hơn 10.");
        }
        else
        {
            Debug.Log("Số nhập vào không lớn hơn 10.");
        }
    }
}


### Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học

Viết chương trình kiểm tra xem một học sinh có đủ điều kiện đăng ký khóa học nâng cao không nếu họ đã hoàn thành **khóa học cơ bản**, **điểm tổng kết >= 7.0**, và có **thư giới thiệu từ giáo viên**.
using UnityEngine;

public class CourseRegistrationChecker : MonoBehaviour
{
    // Biến kiểm tra đã hoàn thành khóa học cơ bản
    public bool completedBasicCourse;

    // Điểm tổng kết
    public float cumulativeScore;

    // Biến kiểm tra có thư giới thiệu từ giáo viên
    public bool hasTeacherRecommendation;

    // Hàm này sẽ chạy khi chương trình bắt đầu
    void Start()
    {
        CheckEligibilityForAdvancedCourse(completedBasicCourse, cumulativeScore, hasTeacherRecommendation);
    }

    // Hàm kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
    void CheckEligibilityForAdvancedCourse(bool completedCourse, float score, bool hasRecommendation)
    {
        if (completedCourse && score >= 7.0f && hasRecommendation)
        {
            Debug.Log("Học sinh đủ điều kiện đăng ký khóa học nâng cao.");
        }
        else
        {
            Debug.Log("Học sinh không đủ điều kiện đăng ký khóa học nâng cao.");
        }
    }
}


## Kết Luận

Các bài tập trên sẽ giúp bạn làm quen với câu lệnh **if** trong lập trình, từ những bài tập cơ bản đến các tình huống điều kiện phức tạp hơn. Việc thực hành nhiều bài tập này sẽ giúp bạn hiểu rõ hơn cách sử dụng câu lệnh điều kiện trong các ứng dụng thực tế.
