public enum PlayerType {
  NONE = 0,
  KNIGHT = 1,
  ARCHER = 2,
  MAGE = 3
}

public class Player {
  protected PlayerType type;
  protected int hp;
  protected int attack;

  protected Player(PlayerType type) {
    this.type = type;
  }

  protected new PlayerType GetType() {
    return this.type;
  }

  protected int GetHp() {
    return this.hp;
  }

  protected int GetAttack() {
    return this.attack;
  }

  public bool IsDead() {
    return this.hp <= 0;
  }

  public void OnDamaged(int damage) {
    this.hp -= damage;

    if (this.hp < 0) {
      this.hp = 0;
    }
  }
}

public class Knight : Player {

  public Knight(int hp, int attack) : base(PlayerType.KNIGHT) {
    this.hp = hp;
    this.attack = attack;
  }
}

public class Archer : Player {

  public Archer(int hp, int attack) : base(PlayerType.ARCHER) {
    this.hp = hp;
    this.attack = attack;
  }
}

public class Mage : Player {

  public Mage(int hp, int attack) : base(PlayerType.MAGE) {
    this.hp = hp;
    this.attack = attack;
  }
}