# Reflection (리플렉션)
- 보통 클래스 내에 protected 혹은 private로 접근 제어자가 걸려있는 경우 public으로 따로 외부에서 접근하도록 하지 않는 이상은 외부에서 접근 할 수 있는 방법이 없다.
- 이를 해결하기 위한 방법이 바로 `Reflection`이다.
- `Reflection`을 사용하기 위해서는 System.Reflection을 먼저 링킹(using) 해야한다.

- 참조타입의 모든 객체는 Object를 상속받고 있다. Object에 있는 메서드를 사용 할 수 있는데, 주로 사용되는 건 `GetType()`이다.
- `GetType()`으로 Type을 반환하게 되면 여러가지 Reflection을 할 수 있는 메서드 혹은 enum 및 정적 필드 혹은 메서드들을 사용 할 수 있게 된다.

```C#
Monster monster = new Monster();
Type type = monster.GetType();

// 접근 제어자에 접근을 할 수 있게 해주고, 이에 대한 조건들을 명시 할 수 있게 해준다.
var fields = type.GetFields(System.Reflection.BindingFlag.Public
    || System.Reflection.BindingFlag.NonPublic
    || System.Reflection.BindingFlag.Static
    || System.Reflection.BindingFlag.Instance);

// fields는 FieldInfo[] 을 받는다.

foreach (FieldInfo field in fields) {
  string access = "";
  if (field.IsPublic) {
    access = "public";
  } else if (field.IsPrivate) {
    access = "private";
  } else {
    access = "protected";
  }
  Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
  // 출력 형태 : 접근제어자 반환타입 필드명 
}
```
- 리플렉션은 프로그래밍을 하면서 실제로는 많이 사용 할 일이 적다.
- 하지만 게임 엔진을 만들 경우에 해당 필드에 간단하게 접근을 할 수 있게해준다.
- C#, Java는 Reflection을 사용 할 수 있도록 구현이 되어있지만 C++ 같은 경우에는 아직 구현이 안되어있어 언리얼은 필드 접근이 복잡하다.
