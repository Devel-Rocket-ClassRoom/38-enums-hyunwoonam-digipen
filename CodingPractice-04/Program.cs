using System;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 열거형과 switch 문");

    Animal animal = Animal.Dog;

    switch (animal)
    {
        case Animal.Chicken:
            Console.WriteLine("닭");
            break;

        case Animal.Dog:
            Console.WriteLine("개");
            break;

        case Animal.Pig:
            Console.WriteLine("돼지");
            break;
    }
}

Console.WriteLine();

{
    Console.WriteLine("2. 캐릭터 상태 관리");

    CharacterState state = CharacterState.Idle;

    void Update()
    {
        switch (state)
        {
            case CharacterState.Idle:
                Console.WriteLine("대기 애니메이션 재생");
                break;

            case CharacterState.Walking:
                Console.WriteLine("걷기 애니메이션 재생");
                break;

            case CharacterState.Running:
                Console.WriteLine("달리기 애니메이션 재생");
                break;

            case CharacterState.Jumping:
                Console.WriteLine("점프 애니메이션 재생");
                break;

            case CharacterState.Attacking:
                Console.WriteLine("공격 애니메이션 재생");
                break;

            case CharacterState.Dead:
                Console.WriteLine("죽음 애니메이션 재생");
                break;
        }
    }

    state = CharacterState.Attacking;

    Update();
}

Console.WriteLine();

{
    Console.WriteLine("3. 아이템 등급");

    void PrintItemInfo(string name, ItemRarity rarity)
    {
        Console.WriteLine($"아이템: {name}");
        Console.WriteLine($"등급: {rarity}");
    }

    PrintItemInfo("전설의 검", ItemRarity.Legendary);
}

Console.WriteLine();

{
    Console.WriteLine("4. 방향 처리");

    void Move(Direction direction)
    {
        switch (direction)
        {
            case Direction.Up:
                Console.WriteLine("위로 이동 (y + 1)");
                break;

            case Direction.Down:
                Console.WriteLine("아래로 이동 (y - 1)");
                break;

            case Direction.Left:
                Console.WriteLine("왼쪽으로 이동 (x - 1)");
                break;

            case Direction.Right:
                Console.WriteLine("오른쪽으로 이동 (x + 1)");
                break;
        }
    }

    Move(Direction.Up);
    Move(Direction.Right);
}