// -----------------------------------------------------------------------
// <copyright file="StepState.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace UmlWorkshop.Exercise1;

/// <summary>
/// The state of a step.
/// </summary>
public enum StepState
{
    /// <summary>
    /// The step is idle, awaiting its execution.
    /// </summary>
    Idle,

    /// <summary>
    /// The step is being executed.
    /// </summary>
    Running,

    /// <summary>
    /// The step has successfully finished.
    /// </summary>
    Done,

    /// <summary>
    /// The step has failed.
    /// </summary>
    Failed,

    /// <summary>
    /// The step has been skipped.
    /// </summary>
    Skipped,
}
