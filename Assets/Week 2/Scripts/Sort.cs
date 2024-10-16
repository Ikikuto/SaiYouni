using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = Random.Range(minValue, maxValue);
        }
        return randomArray;
    }
    //----------------------Edit below --------------------
    // Sort Algorithm 1: Bubble Sort (Sắp Xếp Nổi Bọt)
    public void BubbleSort(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Hoán đổi
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // Sort Algorithm 2: Selection Sort (Sắp xếp chọn)
    public void SelectionSort(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length - 1; i++)
        {
            // Giả sử phần tử đầu tiên là phần tử nhỏ nhất
            int minIndex = i;
            for (int j = i + 1; j < length; j++)
            {
                // Tìm phần tử nhỏ nhất trong phần còn lại
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            // Hoán đổi phần tử nhỏ nhất với phần tử đầu tiên
            if (minIndex != i)
            {
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }

    // Sort Algorithm 3: Insertion Sort (Sắp Xếp Chèn)
    public void InsertionSort(int[] array)
    {
        int length = array.Length;
        for (int i = 1; i < length; i++)
        {
            int key = array[i];
            int j = i - 1;

            // Di chuyển các phần tử lớn hơn key lên một vị trí
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            // Đặt key vào đúng vị trí
            array[j + 1] = key;
        }
    }

    // Sort Algorithm 4: Quick Sort (Sắp Xếp Nhanh)
    public void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Chia mảng thành hai phần
            int pivotIndex = Partition(array, low, high);

            // Đệ quy sắp xếp hai phần
            QuickSort(array, low, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }

    private int Partition(int[] array, int low, int high)
    {
        int pivot = array[high]; // Chọn phần tử cuối làm pivot
        int i = low - 1; // Chỉ số của phần tử nhỏ hơn pivot

        for (int j = low; j < high; j++)
        {
            // Nếu phần tử hiện tại nhỏ hơn hoặc bằng pivot
            if (array[j] <= pivot)
            {
                i++;
                // Hoán đổi array[i] và array[j]
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        // Hoán đổi array[i + 1] và array[high] (pivot)
        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;

        return i + 1; // Trả về chỉ số của pivot sau khi hoán đổi
    }

    // Sort Algorithm 5: Merge Sort (Sắp Xếp Trộn)
    public void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            // Sắp xếp hai nửa
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            // Gộp hai nửa đã sắp xếp
            Merge(array, left, mid, right);
        }
    }

    private void Merge(int[] array, int left, int mid, int right)
    {
        // Tính kích thước của hai nửa mảng
        int n1 = mid - left + 1;
        int n2 = right - mid;

        // Tạo các mảng tạm thời
        int[] L = new int[n1];
        int[] R = new int[n2];

        // Sao chép dữ liệu vào các mảng tạm thời
        for (int i = 0; i < n1; i++)
            L[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            R[j] = array[mid + 1 + j];

        // Gộp các mảng tạm thời lại
        int k = left; // Chỉ số của mảng gốc
        int iL = 0; // Chỉ số cho mảng L
        int iR = 0; // Chỉ số cho mảng R

        while (iL < n1 && iR < n2)
        {
            // Sắp xếp theo thứ tự từ lớn đến bé
            if (L[iL] >= R[iR])
            {
                array[k] = L[iL];
                iL++;
            }
            else
            {
                array[k] = R[iR];
                iR++;
            }
            k++;
        }

        // Sao chép phần còn lại của mảng L (nếu có)
        while (iL < n1)
        {
            array[k] = L[iL];
            iL++;
            k++;
        }

        // Sao chép phần còn lại của mảng R (nếu có)
        while (iR < n2)
        {
            array[k] = R[iR];
            iR++;
            k++;
        }
    }

    //----------------------Edit above --------------------
    public void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element " + i + ": " + array[i]);
        }
    }

    void Start()
    {
        int[] randomNumbers = GenerateRandomArray(10, 1, 100);
        //----------------------Edit below --------------------
        // từ bé đến lớn
        //BubbleSort(randomNumbers);

        // từ bé đến lớn
        //SelectionSort(randomNumbers);

        // từ bé đến lớn
        //InsertionSort(randomNumbers);

        // từ bé đến lớn
        //QuickSort(randomNumbers,0, randomNumbers.Length - 1);

        // từ lớn đến bé
        MergeSort(randomNumbers, 0, randomNumbers.Length - 1);

        //----------------------Edit above --------------------
        ReadArray(randomNumbers);
    }
}
