using System;

enum States
{
    Idle,
    Walking,
    Running,
    Jumping,
    Attacking,
    Dead
}

class CharacterState
{
    States currState;

    public CharacterState(States state)
    {
        currState = state;
    }

    public void ChangeState()
    {
        Console.Write("\n변경할 상태 번호 입력 (0-5): ");

        if (int.TryParse(Console.ReadLine(), out int value) &&
            Enum.IsDefined(typeof(States), value))
        {
            currState = (States)value;
            Console.WriteLine($"상태가 {currState}(으)로 변경되었습니다.");
        }
        else
        {
            Console.WriteLine("올바른 상태 번호가 아닙니다.");
        }
    }

    public void Behavior()
    {
        switch(currState)
        {
            case States.Idle:
                Console.WriteLine("[행동] 대기합니다!");
                break;
            case States.Walking:
                Console.WriteLine("[행동] 걷습니다!");
                break;
            case States.Running:
                Console.WriteLine("[행동] 달립니다!");
                break;
            case States.Jumping:
                Console.WriteLine("[행동] 점프합니다!");
                break;
            case States.Attacking:
                Console.WriteLine("[행동] 적을 공격합니다!");
                break;
            case States.Dead:
                Console.WriteLine("[행동] 사망 상태입니다. 행동할 수 없습니다.");
                break;
        }
        
    }
    
    public States ShowCharacterState()
    {
        return currState;
    }
}

