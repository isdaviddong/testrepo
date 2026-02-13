using System;

namespace testrepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BMI 計算器 ===");
            Console.WriteLine();

            // 輸入身高
            double height = GetValidInput("請輸入身高（公分）: ");
            // 將公分轉換為公尺
            height = height / 100;

            // 輸入體重
            double weight = GetValidInput("請輸入體重（公斤）: ");

            // 計算 BMI
            double bmi = CalculateBMI(height, weight);

            // 顯示結果
            Console.WriteLine();
            Console.WriteLine($"您的 BMI 值為: {bmi:F2}");
            Console.WriteLine(GetBMIRecommendation(bmi));
        }

        /// <summary>
        /// 計算 BMI 值
        /// </summary>
        /// <param name="heightInMeters">身高（公尺）</param>
        /// <param name="weightInKg">體重（公斤）</param>
        /// <returns>BMI 值</returns>
        static double CalculateBMI(double heightInMeters, double weightInKg)
        {
            return weightInKg / (heightInMeters * heightInMeters);
        }

        /// <summary>
        /// 根據 BMI 值提供健康建議
        /// </summary>
        /// <param name="bmi">BMI 值</param>
        /// <returns>健康建議</returns>
        static string GetBMIRecommendation(double bmi)
        {
            if (bmi < 18.5)
            {
                return "體重過輕：建議增加營養攝取，適度運動以增加肌肉量。";
            }
            else if (bmi < 24)
            {
                return "體重正常：請繼續保持良好的飲食習慣和運動習慣。";
            }
            else if (bmi < 27)
            {
                return "體重過重：建議注意飲食控制，增加運動量。";
            }
            else
            {
                return "肥胖：建議諮詢醫生或營養師，制定合適的減重計畫。";
            }
        }

        /// <summary>
        /// 獲取有效的數字輸入
        /// </summary>
        /// <param name="prompt">提示訊息</param>
        /// <returns>有效的數字</returns>
        static double GetValidInput(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                
                if (double.TryParse(input, out value) && value > 0)
                {
                    return value;
                }
                
                Console.WriteLine("請輸入有效的正數！");
            }
        }
    }
}
