using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import thư viện UI

public class IfStatementPractise : MonoBehaviour
{
    public int number;                      //bt 1
    public int inputNumber;                 //bt 2
    public float averageScore;              //bt 3
    public int firstNumber;                 //bt 4
    public int secondNumber;                //bt 4
    public float customerMoney;             //bt 5
    public float productPrice;              //bt 5
    public int year;                        //bt 6
    private int ticketPrice;                //bt 7
    public int age;                         //bt 7
    public float averageGrade;              //bt 8
    public int firsttNumber;                //bt 9
    public int seconddNumber;               //bt 9
    public int thirddNumber;                //bt 9
    public float fixedSalary = 3000000;     //bt 10
    public int hoursWorked;                 //bt 10
    public int agee;                        //bt 11
    public bool hasMembershipCard;          //bt 11
    public float averageGradee;             //bt 12
    public float electricityUsage;          //bt 13
    public int yearsOfService;              //bt 14
    public bool hasGoodPerformanceReview;   //bt 14
    public float orderValue;                //bt 15
    public float income;                    //bt 16
    public float testScore1;                //bt 17
    public float testScore2;                //bt 17
    public float testScore3;                //bt 17
    public int currentStock;                //bt 18
    public bool isStorageAvailable;         //bt 18
    public int newinputNumber;              //bt 19
    public bool completedBasicCourse;       //bt 20
    public float cumulativeScore;           //bt 20
    public bool hasTeacherRecommendation;   //bt 20

    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(inputNumber); // Kiểm tra số chẵn hay lẻ
        BaiTap3(); // Kiểm tra điều kiện thi đỗ
        BaiTap4(); // Tìm số lớn nhất trong hai số
        BaiTap5(); // Kiểm tra điều kiện mua hàng
        BaiTap6(); // Kiểm tra năm nhuận
        BaiTap7(); // Tính giá vé xem phim
        BaiTap8(); // Kiểm tra học sinh xuất sắc
        BaiTap9(); // So sánh ba số
        BaiTap10(); // Tính tiền lương
        BaiTap11(); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(); // Phân loại học sinh
        BaiTap13(); // Tính tiền điện
        BaiTap14(); // Kiểm tra điều kiện thăng chức
        BaiTap15(); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(); // Tính thuế thu nhập cá nhân
        BaiTap17(); // Tính điểm trung bình của môn học
        BaiTap18(); // Kiểm tra điều kiện nhập hàng
        BaiTap19(); // Tìm số lớn hơn 10
        BaiTap20(); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    void BaiTap1()
    {
        CheckNumber(number);

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

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2(int num)
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

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3()
    {
        CheckExamResult(averageScore);

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

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4()
    {
        CheckMaxNumber(firstNumber, secondNumber);

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

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5()
    {
        CheckPurchase(customerMoney, productPrice);

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

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6()
    {
        CheckLeapYear(year);

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

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7()
    {
        CalculateTicketPrice(age);

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

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8()
    {
        CheckForExcellenceAward(averageGrade);

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

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9()
    {
        CheckMaxOfThree(firsttNumber, seconddNumber, thirddNumber);

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

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10()
    {
        float totalSalary = CalculateSalary(hoursWorked);
        Debug.Log("Tiền lương của nhân viên là: " + totalSalary + " đồng.");

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

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11()
    {
        CheckClubEntry(agee, hasMembershipCard);

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

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12()
    {
        ClassifyStudent(averageGradee);

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

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13()
    {
        float totalBill = CalculateElectricityBill(electricityUsage);
        Debug.Log("Tổng tiền điện phải trả là: " + totalBill + " đồng.");

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

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14()
    {
        CheckPromotionEligibility(yearsOfService, hasGoodPerformanceReview);

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

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15()
    {
        CheckFreeShipping(orderValue);

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

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16()
    {
        float taxAmount = CalculateIncomeTax(income);
        Debug.Log("Số thuế thu nhập cá nhân phải trả là: " + taxAmount + " đồng.");

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

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17()
    {
        float averageScore = CalculateAverageScore(testScore1, testScore2, testScore3);
        CheckPass(averageScore);

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

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18()
    {
        CheckIfCanRestock(currentStock, isStorageAvailable);

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

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19()
    {
        CheckIfGreaterThanTen(newinputNumber);

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

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20()
    {
        CheckEligibilityForAdvancedCourse(completedBasicCourse, cumulativeScore, hasTeacherRecommendation);

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
}
