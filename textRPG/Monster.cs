public enum MonsterType {
  SLIME = 0,
  OAK = 1,
  SKELETON = 2
}

public class Monster : Creature {
  protected MonsterType monsterType; 

  public Monster(MonsterType monsterType, int hp, int attack) : base(CreatureType.MONSTER, hp, attack) {
    this.monsterType = monsterType;
  }

  public MonsterType GetMonsterType() {
    return this.monsterType;
  }
}

public class Slime : Monster {

  public Slime() : base(MonsterType.SLIME, 30, 3) {

  }
}

public class Oak : Monster {

  public Oak() : base(MonsterType.OAK, 50, 5) {
    
  }
}

public class Skeleton : Monster {

  public Skeleton() : base(MonsterType.SKELETON, 40, 4) {
    
  }
}

