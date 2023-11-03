// -----------------------------------------------------------------------
// <copyright file="StepKind.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace UmlWorkshop.Exercise1;

/// <summary>
/// The kind a check-step.
/// </summary>
public enum StepKind
{
    /// <summary>
    /// Specifies purely manual steps.
    /// </summary>
    Manual,

    /// <summary>
    /// Specifies manually initiated, but automatically checked steps.
    /// </summary>
    SemiAuto,

    /// <summary>
    /// Specifies purely automatic steps.
    /// </summary>
    Auto,
}
