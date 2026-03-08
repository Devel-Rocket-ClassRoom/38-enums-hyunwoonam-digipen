using System;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 값 지정 예제");

    Console.WriteLine((int)Animal.Horse);
    Console.WriteLine((int)Animal.Sheep);
    Console.WriteLine((int)Animal.Monkey);
}

Console.WriteLine();

{
    Console.WriteLine("2. 플래그 결합하기");

    CharacterStatus status = CharacterStatus.Poison | CharacterStatus.Paralyzed;

    Console.WriteLine(status);
}

Console.WriteLine();

{
    Console.WriteLine("3. 플래그 검사하기");

    CharacterStatus status = CharacterStatus.Poison | CharacterStatus.Confused;

    if ((status & CharacterStatus.Poison) == CharacterStatus.Poison)
    {
        Console.WriteLine("캐릭터가 독에 걸렸습니다!");
    }

    if ((status & CharacterStatus.Paralyzed) == CharacterStatus.Paralyzed)
    {
        Console.WriteLine("캐릭터가 마비에 걸렸습니다!");
    }
    else
    {
        Console.WriteLine("마비 상태가 아닙니다.");
    }
}

Console.WriteLine();

{
    Console.WriteLine("4. 플래그 추가 및 제거");

    CharacterStatus status = CharacterStatus.Poison;

    Console.WriteLine($"초기 상태: {status}");

    status |= CharacterStatus.Confused;

    Console.WriteLine($"혼란 추가: {status}");

    status &= ~CharacterStatus.Poison;

    Console.WriteLine($"독 제거: {status}");

    status ^= CharacterStatus.Invisible;

    Console.WriteLine($"투명 토글: {status}");
}

Console.WriteLine();

{
    Console.WriteLine("5. 플래그 열거형 활용 예제");

    BuffStatus buffStatus = BuffStatus.None;

    void ApplyBuff(BuffStatus buff)
    {
        buffStatus |= buff;

        Console.WriteLine($"버프 적용: {buff}");
        Console.WriteLine($"현재 버프: {buffStatus}");
    }

    void RemoveBuff(BuffStatus buff)
    {
        buffStatus &= ~buff;

        Console.WriteLine($"버프 해제: {buff}");
        Console.WriteLine($"현재 버프: {buffStatus}");
    }

    void HasBuff(BuffStatus buff)
    {
        Console.WriteLine($"공격력 버프 있음? {(buffStatus & buff) == buff}");
    }

    ApplyBuff(BuffStatus.AttackUp);
    ApplyBuff(BuffStatus.SpeedUp);

    HasBuff(BuffStatus.AttackUp);

    RemoveBuff(BuffStatus.AttackUp);

    HasBuff(BuffStatus.AttackUp);
}

