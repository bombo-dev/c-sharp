# Lambda
- C# 또한 람다 표현식을 사용할 수 있다.
- 이전에 delegate를 사용하면 함수를 일급 객체를 사용했던 것처럼 delegate를 활용하여 익명 객체를 만들어 낼 수 있다.

```C#
delegate bool ItemSelector(Item item);

Main() {
  // 익명 객체를 만드는 방법
  ItemSelector selector = new ItemSelector(delegate (Item item) { return item.ItemType == ItemType.RARE; }

  // 람다를 사용하는 방법
  ItemSelector selector = new ItemSelector((Item item) => { return item.ItemType == ItemType.RARE; }
}
```
- C# 또한 자바처럼 함수형 인터페이스처럼 미리 만들어진 것이 있다.

## Func
- 반환 타입이 있는 경우에 사용한다.
- `Func<Item, bool>`
- Func에는 인자가 여러 개 계속 추가 된 형태로 제너릭이 구성되어있다. 즉, `Func<Item, int, bool>` 도 가능하다는 것이다.

## Action
- 반환 타입이 없는 경우에 사용한다.
- `Action<Item>`
- 자바의 Consumer와 동일하다. 이 또한 Func 처럼 여러 개의 인자를 받을 수 있다.
