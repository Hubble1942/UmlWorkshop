// -----------------------------------------------------------------------
// <copyright file="Phase.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace UmlWorkshop.Exercise1;

/// <summary>
/// The specification of a phase.
/// </summary>
/// <param name="Name">The name.</param>
/// <param name="Checks">The checks.</param>
public sealed record Phase(UiText Name, IImmutableList<Check> Checks)
{
    /// <summary>
    /// The empty phase.
    /// </summary>
    public static readonly Phase Empty = Create(UiText.Empty);

    /// <summary>
    /// Gets the kind.
    /// </summary>
    public PhaseKind Kind { get; init; }

    /// <summary>
    /// Gets the single check policy.
    /// </summary>
    public SingleCheckPolicy SingleCheckPolicy { get; init; }

    /// <summary>
    /// Gets a value indicating whether, after finishing this phase, the engine automatically continues to the next phase.
    /// </summary>
    public bool AutoContinue { get; init; }

    /// <summary>
    /// Gets the optional route to a page to be displayed while this phase is active.
    /// </summary>
    /// <remarks>
    /// If this property is <c>null</c> the generic run page is displayed.
    /// </remarks>
    public string? PageRoute { get; init; }

    /// <summary>
    /// Gets a value indicating whether this instance is a set-up phase.
    /// </summary>
    public bool IsSetUp => this.Kind == PhaseKind.SetUp;

    /// <summary>
    /// Gets a value indicating whether this instance is a specification phase.
    /// </summary>
    public bool IsSpecification => this.Kind == PhaseKind.Specification;

    /// <summary>
    /// Gets a value indicating whether this instance is a success-only phase.
    /// </summary>
    public bool IsSuccessOnly => this.Kind == PhaseKind.SuccessOnly;

    /// <summary>
    /// Gets a value indicating whether this instance is a tear-down phase.
    /// </summary>
    public bool IsTearDown => this.Kind == PhaseKind.TearDown;

    /// <summary>
    /// Creates a <see cref="Phase" /> instance.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="checks">The checks.</param>
    /// <returns>
    /// The created instance.
    /// </returns>
    public static Phase Create(UiText name, params Check[] checks)
        => new(name, checks.ToImmutableList());
}
