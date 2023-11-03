// -----------------------------------------------------------------------
// <copyright file="IStep.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace UmlWorkshop.Exercise1;

/// <summary>
/// A single step of a check.
/// </summary>
public interface IStep
{
    /// <summary>
    /// Gets the tag.
    /// </summary>
    string Tag { get; }

    /// <summary>
    /// Gets the name.
    /// </summary>
    UiText Name { get; }

    /// <summary>
    /// Gets the kind.
    /// </summary>
    StepKind Kind { get; }

    /// <summary>
    /// Gets the state.
    /// </summary>
    StepState State { get; }

    /// <summary>
    /// Gets a value indicating whether manual reruns are allowed.
    /// </summary>
    bool AllowsManualRerun { get; }

    /// <summary>
    /// Executes this instance.
    /// </summary>
    /// <param name="changeNotifier">The change notifier.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>
    /// The result.
    /// </returns>
    Task<StepResult> Execute(Action changeNotifier, CancellationToken cancellationToken);

    /// <summary>
    /// Triggers this instance.
    /// </summary>
    void Trigger();
}
