using System;

// README.md를 읽고 코드를 작성하세요.

FilePermission file = FilePermission.None;

Console.WriteLine("=== 파일 권한 관리 ===\n");


Console.WriteLine($"현재 권한: {file}\n");

Console.WriteLine($"[권한 추가]");
AddPermission(FilePermission.Read);
AddPermission(FilePermission.Write);
AddPermission(FilePermission.Excute);

Console.WriteLine($"[권한 확인]]");
Console.WriteLine($"Read 권한:  {HasPermission(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {HasPermission(FilePermission.Write)}");
Console.WriteLine($"Execute 권한:{HasPermission(FilePermission.Excute)}");

Console.WriteLine($"[권한 제거]");
RemovePermission(FilePermission.Write);

Console.WriteLine($"[제거 후 확인]");
Console.WriteLine($"Read 권한:  {HasPermission(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {HasPermission(FilePermission.Write)}");
Console.WriteLine($"Execute 권한:{HasPermission(FilePermission.Excute)}");

void AddPermission(FilePermission add)
{
    file |= add;

    Console.WriteLine($"+ {add} 추가: {file}");
}

bool HasPermission(FilePermission has)
{
    return (file & has) != 0;
}

void RemovePermission(FilePermission add)
{
    file &= ~add;

    Console.WriteLine($"- {add} 제거: {file}");
}
