// -----------------------------------------------------------------------
// <copyright file="SingleCheckPolicy.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace UmlWorkshop.Exercise1;

/// <summary>
/// Defines the behavior of phases regarding single-checking.
/// </summary>
public enum SingleCheckPolicy
{
    /// <summary>
    /// The default behavior. The phase will run normally during single checks runs.
    /// </summary>
    Default,

    /// <summary>
    /// The phase will be skipped during single checks runs.
    /// </summary>
    Skip,

    /// <summary>
    /// The phase will run in single check mode.
    /// </summary>
    SingleCheck,
}
