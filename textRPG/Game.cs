using System;

public enum GameMode {
  NONE,
  LOBBY,
  TOWN,
  FIELD
}

public class Game {
  
  private GameMode gameMode = GameMode.LOBBY;
  private Random random = new Random();
  private Player player = null;

  public void Process() {

    switch (gameMode) {
      case GameMode.LOBBY:
        ProcessLobby();
        break;
      case GameMode.TOWN:
        ProcessTown();
        break;
      case GameMode.FIELD:
        ProcessField();
        break; 
    }
  }

  public void ProcessLobby() {
    Console.WriteLine("직업을 선택하세요.");
    Console.WriteLine("[1] 기사");
    Console.WriteLine("[2] 궁수");
    Console.WriteLine("[3] 마법사");

    string input = Console.ReadLine();

      switch (input) {
        case "1":
          player = new Knight();
          gameMode = GameMode.TOWN;
          break;

        case "2":
          player = new Archer();
          gameMode = GameMode.TOWN;
          break;

        case "3":
          player = new Mage();
          gameMode = GameMode.TOWN;
          break;

        default:
          Console.WriteLine("잘못된 번호가 입력되었습니다. 직업을 다시 선택해주세요.");
          break;
      }
  }

  public void ProcessTown() {
    Console.WriteLine("이동 할 장소를 선택해주세요.");
    Console.WriteLine("[1] : 로비로 돌아가기");
    Console.WriteLine("[2] : 필드로 나가기");

    string input = Console.ReadLine();

    switch(input) {
      case "1":
        gameMode = GameMode.LOBBY;
        break;

      case "2":
        gameMode = GameMode.FIELD;
        break;

      default:
        Console.WriteLine("잘못된 번호가 입력되었습니다. 장소를 다시 선택해주세요.");
        break;
    }
  }

  public void ProcessField() {
    Monster monster = CreateMonster();
    bool isEscaped = false;

    while(!monster.IsDead() && !isEscaped) {
      Console.WriteLine("플레이어의 행동을 결정해주세요.");
      Console.WriteLine("[1] 몬스터와 싸운다.");
      Console.WriteLine("[2] 도망친다.");

      string input = Console.ReadLine();
    
      switch(input) {
        case "1" :
          Fight(monster);
          break;

        case "2" :
          TryEscape(ref isEscaped, monster);
          break;
      }
    }
  }

  private Monster CreateMonster() {
    int monsterNumber = random.Next(0, 3);
    Monster monster = null;
    switch(monsterNumber) {
      case 0:
        monster = new Slime();
        break;

      case 1:
        monster = new Oak();
        break;

      case 2:
        monster = new Skeleton();
        break;
    }
    Console.WriteLine($"{monster.GetMonsterType()}이 생성되었습니다.");
    return monster;
  }

  private void Fight(Monster monster) {
    monster.OnDamaged(player);
    Console.WriteLine($"{player.GetPlayerType()} 가 {monster.GetMonsterType()} 에게 공격");
    Console.WriteLine($"{monster.GetMonsterType()}의 남은 HP : {monster.GetHp()}");

    if (monster.IsDead()) {
      Console.WriteLine("승리하였습니다.");
      return;
    }

    player.OnDamaged(monster);
    Console.WriteLine($"{monster.GetMonsterType()}가 {player.GetPlayerType()} 에게 공격");
    Console.WriteLine($"{player.GetPlayerType()}의 남은 HP : {player.GetHp()}");
    if (player.IsDead()) {
      Console.WriteLine("패배하였습니다.");
      gameMode = GameMode.LOBBY;
    }
  }

  private void TryEscape(ref bool isEscaped, Monster monster) {
    int value = random.Next(0, 101);

    if (value <= 33) {
      Console.WriteLine("탈출에 성공하였습니다.");
      isEscaped = true;
      gameMode = GameMode.TOWN;
      return;
    }
    
    Console.WriteLine("탈출에 실패하였습니다.");
    Fight(monster);
  }
}