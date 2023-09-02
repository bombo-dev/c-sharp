using System;
namespace CSharpGrammer.datatype
{
	public class DataType
	{
		public DataType()
		{
            // 정수형 타입
            // int
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

            // 2진수, 16진수 표현
            // 0b101110
            // 0xFF

            // 변환

            // default 10진법 
            // Convert.ToString(a, radix);


            // 소수형 타입
            // float
            // float a = 3.512312f; // float는 거의 사용 안함
            // double b = 3.52423; // 가장 큰 부동 소수점 표시 소수이기 떄문에 캐스팅 X


            // 문자형 타입 
            // string
            // string name = "Bombo";
            // char ch = 'X';

            // 아스키 값 표현 (int)ch

            // 문자열 입력
            // Console.ReadLine();

            // String to Int
            // int.Parse(string);

            // 문자열 표현 형태
            // string.Format("문자 {0}, 문자 2 {1}", var1, var2);
            // string msg = $"문자 {var1} 문자 2 {var2}";

            // 참 거짓 표현 
            // bool

            // bool a = true;
            // bool b = false;

            // 캐스팅
            // 자바와 동일하다. 더 큰 사이즈에서 더 작은 사이즈로 캐스팅을 하려면 명시적인 형변환을 해주어야 한다.

            // 산술 연산자
            // +, -, *, /, % 존재
        }
    }
}

