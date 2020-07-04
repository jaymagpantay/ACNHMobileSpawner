﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OffsetHelper
{
    public const ulong InventoryOffset = 0xABA526A8;

    public const ulong WalletAddress = InventoryOffset + 0xB8;
    public const ulong MilesAddress = InventoryOffset - 0x24980;
    public const ulong BankAddress = InventoryOffset + 0x3451C;

    public const ulong TurnipAddress = 0xAA890CB0;
    public const ulong VillagerAddress = TurnipAddress - 4267840;
}
