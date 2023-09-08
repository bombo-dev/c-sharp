public enum CreatureType {
  NONE,
  PLAYER = 1,
  MONSTER = 2
}

public class Creature {
  protected CreatureType CreatureType;
  protected int hp;
  protected int attack;

  protected Creature(CreatureType CreatureType, int hp, int attack) {
    this.CreatureType = CreatureType;
    this.hp = hp;
    this.attack = attack;
  }

  public CreatureType GetCreatureType() {
    return this.CreatureType;
  }

  public int GetHp() {
    return this.hp;
  }

  public int GetAttack() {
    return this.attack;
  }

  public bool IsDead() {
    return this.hp <= 0;
  }

  public void OnDamaged(Creature creature) {
    this.hp -= creature.GetAttack();

    if (this.hp < 0) {
      this.hp = 0;
    }
  }
  
}