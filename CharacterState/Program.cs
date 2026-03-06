using System;

// README.md를 읽고 아래에 코드를 작성하세요.

CharacterState C = new CharacterState(States.Idle);

Console.WriteLine("=== 캐릭터 상태 관리 ===");

while (true)
{
    Console.WriteLine($"현재 상태: {C.ShowCharacterState()}\n");

    Console.WriteLine("1. 상태 변경");
    Console.WriteLine("2. 상태 목록 보기");
    Console.WriteLine("3. 현재 행동 보기");
    Console.WriteLine("4. 종료");

    Console.Write("선택: ");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            C.ChangeState();
            break;
        case "2":
            ShowStateInfo();
            break;
        case "3":
            C.Behavior();
            break;
        case "4":
            Console.WriteLine("프로그램을 종료합니다.");
            return;
        default:
            Console.WriteLine("잘못된 입력입니다.");
            break;
    }

    Console.WriteLine();

}
void ShowStateInfo()
{
    Console.WriteLine("=== 상태 목록 ===");
    Console.WriteLine("Idle = 0");
    Console.WriteLine("Walking = 1");
    Console.WriteLine("Running = 2");
    Console.WriteLine("Jumping = 3");
    Console.WriteLine("Attacking = 4");
    Console.WriteLine("Dead = 5");

}
