﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPeg.Common
{
    /// <summary>
    /// NOTE: Ordering is important. It's used inside the Instruction struct to quickly determine
    /// whether the instruction has a label or not.
    /// </summary>
    public enum InstructionType : byte
    {
        /// <summary>
        /// BoundsCheck LFail Offset _ _
        /// </summary>
        BoundsCheck = 0,

        /// <summary>
        /// Char LFail Offset CMin CMax
        /// </summary>
        Char = 1,

        /// <summary>
        /// Jump L _ _ _
        /// </summary>
        Jump = 2,

        /// <summary>
        /// Call _ _ P FailMap
        /// </summary>
        Call = 3,

        /// <summary>
        /// MarkLabel L _ _ _
        /// </summary>
        MarkLabel = 4,

        /// <summary>
        /// Advance _ Offset _ _
        /// </summary>
        Advance,

        /// <summary>
        /// Return _ _ 0 _ (Success)
        /// Return _ _ X _ (where X is non-zero: Failure)
        /// </summary>
        Return,

        /// <summary>
        /// StorePosition _ _ V _
        /// </summary>
        StorePosition,

        /// <summary>
        /// RestorePosition _ Offset V _
        /// </summary>
        RestorePosition,
        
        /// <summary>
        /// Capture _ Offset V CaptureKey
        /// </summary>
        Capture,
    }
}
