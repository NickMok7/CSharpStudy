int hp = 100;
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



for (int i = 0; i < 5; i++)
{
    hp -= 15;
    Console.WriteLine($"{i + 1}번째 공격! 남은 체력: {hp}");
}

if (hp <= 0)
{
    Console.WriteLine("사망");
}
else if (hp <= 30)
{
    Console.WriteLine("위험");
}
else if (hp <= 60)
{
    Console.WriteLine("주의");
}
else
{
    Console.WriteLine("양호");
}