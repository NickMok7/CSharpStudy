// int hp = 100;
// string name = "동훈";

// // System.Console.WriteLine(hp);
// // System.Console.WriteLine(name);

// // Console.WriteLine($"체력: {hp}");

// float speed = 5.5f;
// bool isSurvive = true;

// Console.WriteLine($"이름: {name}");
// Console.WriteLine($"체력: {hp}");
// Console.WriteLine($"이동속도: {speed}");
// Console.WriteLine($"생존: {isSurvive}");

// Console.WriteLine($"전투 시작! 체력: {hp}");
// hp -= 30;
// Console.WriteLine($"30 데미지! 체력: {hp}");
// hp -= 95;
// Console.WriteLine($"25 데미지! 체력: {hp}");
// hp += 15;
// Console.WriteLine($"물약 회복! 체력: {hp}");

// if(hp <= 0)
// {
//     Console.WriteLine("캐릭터가 사망했습니다...");
// }
// else
// {
//     Console.WriteLine($"전투 종료! 남은 체력: {hp}");
// }
// hp = 30;

// for (int i = 0; i < 5; i++)
// {
//     hp -= 15;
//     Console.WriteLine($"{i + 1}번째 공격! 남은 체력: {hp}");
// }

// if (hp <= 0)
// {
//     Console.WriteLine("사망");
// }
// else if (hp <= 30)
// {
//     Console.WriteLine("위험");
// }
// else if (hp <= 60)
// {
//     Console.WriteLine("주의");
// }
// else
// {
//     Console.WriteLine("양호");
// }

// void TakeDamage(int damage)
// {
//     hp -= damage;
//     Console.WriteLine($"{damage} 데미지! 남은 체력: {hp}");
// }

// void Heal(int amount)
// {
//     hp += amount;
//     Console.WriteLine($"{amount} 회복! 남은 체력: {hp}");
// }

// TakeDamage(30);
// TakeDamage(25);
// Heal(15);

// Character player = new Character();

// player.name = "동훈";
// player.hp = 100;

// Character monster = new Character();

// monster.name = "슬라임";
// monster.hp = 50;

// player.TakeDamage(30);
// monster.TakeDamage(20);

// Console.WriteLine($"{player.hp} 플레이어 체력!");
// Console.WriteLine($"{monster.hp} 몬스터 체력!");

// Character player = new Character("동훈", 100);
// Character monster = new Character("슬라임", 50);

// class Character
// {
//     public string name;
//     public int hp;

//     public Character(string characterName, int startHp)
//     {
//         name = characterName;
//         hp = startHp;
//     }
//     public void TakeDamage(int damage)
//     {
//         hp -= damage;
//         Console.WriteLine($"{name}, {damage} 데미지! 남은 체력: {hp}");
//     }
// }

Character player = new Character("동훈", 100);
Character monster = new Character("슬라임", 50);
Player player2 = new Player("동훈", 100, 50);

player.TakeDamage(30);
monster.TakeDamage(20);
player2.TakeDamage(30);
player2.ShowScore();
Console.WriteLine($"체력: {player.GetHp()}");

Console.WriteLine($"플레이어 체력: {player.GetHp()}");
Console.WriteLine($"몬스터 체력: {monster.GetHp()}");
class Character
{
    public string name;
    private int hp;

    public Character(string characterName, int startHp)
    {
        name = characterName;
        hp = startHp;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp < 0) hp = 0;
        Console.WriteLine($"{name}, {damage} 데미지! 남은 체력: {hp}");
    }

    public int GetHp()
    {
        return hp;
    }
}

class Player : Character
{
    public int score;

    public Player(string playerName, int startHp, int startScore) : base(playerName, startHp)
    {
        score = startScore;
    }

    public void ShowScore()
    {
        Console.WriteLine($"{name}의 점수: {score}");
    }
}