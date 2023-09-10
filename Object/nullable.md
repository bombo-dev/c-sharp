# Nullable
- struct 타입 (primitive type) 같은 경우에는 null 값을 가질 수 없다. 기본적으로 초기화 값이 존재하기 떄문이다.
- 그러나 임의적으로 null을 가능하도록 해줄 수 있는데 그것이 nullable 이다. 사용법은 다음과 같다.
```C#
Main() {
  // 1. struct 타입에 null을 넣는 경우
  int? number = null; // struct 타입에 null 선언
  Console.WriteLine(number.Value); // number에 null이 들어가있어 예외가 발생한다.
  
  // 2. 값을 초기화 하는 경우
  int? number = 5; // struct 타입에 null 선언
  Console.WriteLine(number.Value); // 5가 출력된다.

  // nullable struct가 null인지 확인
  if (number.HasValue) {
    
  }

  // nullable struct가 만약 null 이라면 해당 값 반환. 마치 Java에서의 Map.getOrDefault() 와 비슷하다.
  int? number = null;
  int b = number ?? 3;
  Console.WriteLine(b); // 3이 출력된다.
}
- 자바의 경우에는 null을 사용하지 않기 위하여 Optional로 null이 존재 할 수 있음과 존재 할 경우에 행하는 여러가지 메서드들이 존재한다.
- 하지만 nullable 같은 경우도 비슷하게 사용 할 수 있지만 자주 사용되는 것 같지는 않다.
