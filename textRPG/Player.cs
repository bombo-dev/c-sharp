public enum PlayerType {
  NONE = 0,
  KNIGHT = 1,
  ARCHER = 2,
  MAGE = 3
}

public class Player : Creature {
  protected PlayerType playerType;

  protected Player(PlayerType playerType, int hp, int attack) : base(CreatureType.PLAYER, hp, attack) {
    this.playerType = playerType;
  }

  public PlayerType GetPlayerType() {
    return this.playerType;
  }
}

public class Knight : Player {

  public Knight() : base(PlayerType.KNIGHT, 100, 10) {
    
  }
}

public class Archer : Player {

  public Archer() : base(PlayerType.ARCHER, 70, 12) {

  }
}

public class Mage : Player {

  public Mage() : base(PlayerType.MAGE, 50, 15) {

  }
}