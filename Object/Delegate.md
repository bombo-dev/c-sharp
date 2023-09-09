# Delegate
- 마치 프록시와 비슷한 느낌의 함수를 사용 할 수 있게 해준다.
- 그리고, 이는 함수를 일급 객체로 바라 볼 수 있게 해준다.

```C#
// delegate를 위한 함수 포맷을 만들어준다.
// 여기서는 int를 반환값으로 가지고 parameter가 없는 함수의 포맷이 결정되었다.
delegate int OnClicked();

// 함수를 인자로 받는다. 함수 자체를 일급 객체로 바라보는 것이다.
void ButtonPressed(OnClicked clickedFunction) {
  clickedFunction(); // 해당 함수를 실행해준다.
}

// delegate 포맷이 적용된 함수를 생성한다. 
int DelegateFunction() {
  Console.WriteLine("Delegate 함수 실행");
  return 0;
}

int DelegateFunction2() {
  Console.WriteLine("Delegate 함수 실행");
  return 0;
}

static void Main(string[] args) {
  ButtonPressed(DelegateFunction); // 함수를 인자로 전달한다.

  // 만약 여러개의 delegate를 같이 보내줘야 한다면
  OnClicked clicked = new OnClicked(DelegateFunction);
  clicked += DelegateFunction2; // 동일한 함수를 추가로 이을 수도 있다. clicked += DelegateFunction

  ButtonPressed(DelegateFunction); // 두 개의 함수가 이어져서 실행된다.
}
```

