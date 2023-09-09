# 제너릭
- 제너릭은 전체적으로 자바와 비슷하다. 하지만 조금 다른 부분이 있다면 제너릭의 제한 부분이다. 다음처럼 자바에서의 제너릭을 먼저 살펴보자.
### 자바 
```java
// T와 T의 자식만 가능할 경우
<? extends T>
<K extends T>
// T와 T의 부모 타입만 가능할 경우
<? super T>
<K super T>
```

### C#
```C#
where T : struct // T는 null을 허용하지 않는 값 형식 즉, primitive type
where T : class // T는 참조 형식
where T : new() // T는 기본 생성자가 있어야 함.
where T : notnull // T는 null이 아닌 형식이어야 함.
where T : unmanaged // T는 null이 아닌 비관리형 형식이어야 함.
where T : <base class name> // T는 기본 클래스 이거나 이 클래스에서 파생된 클래스이여야 한다.
where T : <interface name> // T는 인터페이스이거나 파생된 유형이어야 한다.
```

- 큰 차이점을 보면 해당 타입으로 부터 조상 타입까지 가능한 super의 형태는 없는 것으로 보인다.
## 비관리형 타입
- sbyte
- byte
- short
- ushort
- int
- uint
- long
- ulong
- char
- float
- double
- decimal
- bool
- enum
- pointer
