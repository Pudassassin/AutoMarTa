using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Automarta;

namespace Instructions
{
    public enum InsID
    {
        Act_MoveTo = 100,
        Act_MoveBack,
        Act_Mine,
        Act_PickUp,
        Act_DropAt,
        Act_Build,
        Act_Repair,
        Act_Attack,
        Act_Wait,

        Check_ScanAll = 200,
        Check_ScanNearest,
        Check_ScanFarthest,
        Check_GetHpPercent,
        Check_GetPosition,
        Check_CheckTag,
        Check_GetFlagList,
        Check_CheckFlagPlaced,
        Check_GetFlagPosition,

        Var_StoreMem = 300,
        Var_ReadMem,
        Var_AddToList,
        Var_RemoveFromList,
        Var_ListCount,
        Var_FirstInList,
        Var_LastInList,
        Var_nInlist,
        Var_ClearList,

        Ctrl_If = 400,
        Ctrl_Else,
        Ctrl_RepeatN,
        Ctrl_While,

        Ctrl_LoopCount,

        Misc_Log = 500,

        _CMP_EQ = 0,
        _CMP_NEQ,
        _CMP_L,
        _CMP_LE,
        _CMP_G,
        _CMP_GE
    }

    public class InstructionObject
    {
        public String Name;
        public List<InstructionNode> Instructions;
    }

    public class InstructionNode
    {
        public InsID Command;
        public Parameter[] Params;
        public int ParamsCount()
        {
            return Params.Length;
        }
    }
}
