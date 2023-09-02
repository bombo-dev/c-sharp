using System;

namespace CsharpGrammer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int
            // 정수형 타입
            // 1. sbyte 8-bit 음수 포함 
            // 2. byte,8-bit 양수만 
            // 3. short 16-bit 음수 포함 
            // 4. ushort 16-bit 양수만
            // 5. int 32-bit 음수 포함 
            // 6. uint 32-bit 양수만 
            // 7. long 64-bit 음수 포함 
            // 8. ulong 64-bit 양수만 
            // 9. nint platform 의존적 음수 포함  
            // 10. nuint platform 의존적 양수만 

            // float
            // string
            // bool

            // [데이터 타입] [이름]

            char ch = 'A';
            Console.WriteLine("아스키 값 표현 : " + (int)ch);

            // 정수형 타입을 소수형으로 변환하면 적절하게 소수로 나오는가?
            int a = 100;
            float c = a;
            Console.WriteLine(c); // 정수 출력

            float d = (float)a;
            Console.WriteLine(d); // 명시적도 정수 출력

            double e = Convert.ToDouble(a);
            Console.WriteLine(e); // Convert를 해도 정수 출력


            Console.WriteLine("문자를 입력해주세요. : ");

            // 문자열을 출력하는 형태를 만들어보자.
            int currentHp = 80;
            int maxHp = 100;
            Console.Write("format 사용 -> ");
            Console.WriteLine(string.Format("현재 나의 상태{0}/{1} 입니다.", currentHp, maxHp));

            Console.Write("$ 사용 -> ");
            Console.WriteLine($"현재 나의 상태{currentHp}/{maxHp} 입니다.");

            int operand = 4;
            // += 형태가 가능한가
            operand += 2;
            Console.WriteLine(operand);
        }
    }
}