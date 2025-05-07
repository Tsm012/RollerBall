using System;
using TMPro;

public static class GlobalEventManager
{
    public static event Action PickupMessage;

    public static void EmitPickupMessage() => PickupMessage?.Invoke();
}
