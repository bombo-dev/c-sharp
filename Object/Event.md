# Event
- Delegate 문법을 보완하기 위해 등장하게 되었다.
- 디자인 패턴에서의 옵저버 패턴과 동일하게 동작한다.

```C#
class InputManager {
  public delegate void OnInputKey();
  public event OnInputKey inputKey; // 이벤트를 선언한다. 이때 참조 타입이 delegate 함수이다.

  public void Update() {
    inputKey(); // delegate 함수를 호출하는 것과 같다.
  }
}

class Program {
  pubilc void Method() {
    Console.WriteLine("이벤트 출력");
  }

  static void Main(string[] args) {
    InputManager inputManager = new InputManager();
    inputManager.inputKey += Method; // InputManager의 inputKey를 구독하게 된다. 그리고 inputKey는 자신을 구독하고 있는 Method를 수행한다.
    inputManager.inputKey -= Method; // -= 연산을 통해서 구독을 취소 할 수도 있다.
    inputManager.Update();
  }
}
