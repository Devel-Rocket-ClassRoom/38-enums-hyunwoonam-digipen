using System;

// README.md를 읽고 아래에 코드를 작성하세요.
{
    Console.WriteLine("1. 열거형의 기본 값");

    Animal animal = Animal.Dragon;

    Console.WriteLine($"Animal.Dragon: {(int)animal}, {animal}");
}

Console.WriteLine();

{
    Console.WriteLine("2. Enum.GetValues - 열거형 값 목록");

    Console.WriteLine("Priority 열거형의 값들:");

    Array values = Enum.GetValues(typeof(Priority));

    foreach (object value in values)
    {
        Priority priority = (Priority)value;

        Console.WriteLine($"{priority} = {(int)priority}");
    }
}