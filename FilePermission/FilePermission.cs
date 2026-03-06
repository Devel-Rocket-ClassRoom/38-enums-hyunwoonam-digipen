using System;
using System.Collections.Generic;
using System.Text;

[Flags]
enum FilePermission
{
    None = 0,
    Read = 1,
    Write = 2,
    Excute = 4,
}
