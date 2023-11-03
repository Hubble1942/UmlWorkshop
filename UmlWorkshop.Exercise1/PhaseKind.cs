// -----------------------------------------------------------------------
// <copyright file="PhaseKind.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace UmlWorkshop.Exercise1;

/// <summary>
/// The phase kind.
/// </summary>
public enum PhaseKind
{
    /// <summary>
    /// Just a bloody normal phase.
    /// </summary>
    Normal,

    /// <summary>
    /// A phase used to specify the run.
    /// </summary>
    /// <remarks>
    /// While running in <see cref="Specification"/> phases, the run will not be persisted.
    /// </remarks>
    Specification,

    /// <summary>
    /// A phase setting things up.
    /// </summary>
    /// <remarks>
    /// Requires a later <see cref="TearDown"/> phase.
    /// </remarks>
    SetUp,

    /// <summary>
    /// A phase tearing stuff down.
    /// </summary>
    /// <remarks>
    /// If a <see cref="SetUp"/> has previously been active, <see cref="TearDown"/> phases are always run.
    /// </remarks>
    TearDown,

    /// <summary>
    /// A phase which is only executed when the run has been successfully so far.
    /// </summary>
    SuccessOnly,
}
