// -----------------------------------------------------------------------
// <copyright file="Suite.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace UmlWorkshop.Exercise1;

/// <summary>
/// A suite specification.
/// </summary>
/// <param name="Name">The name.</param>
/// <param name="Tag">The tag (unique user readable identifier).</param>
/// <param name="Phases">The phases.</param>
public sealed record Suite(UiText Name, string Tag, IImmutableList<Phase> Phases)
{
    /// <summary>
    /// Gets a value indicating whether this instance is a self check.
    /// </summary>
    public bool IsSelfCheck { get; init; }

    /// <summary>
    /// Gets a value indicating whether this instance may run in single check mode.
    /// </summary>
    public bool IsSingleCheckable => this.Phases.Any(p => p.SingleCheckPolicy == SingleCheckPolicy.SingleCheck);

    /// <summary>
    /// Creates a <see cref="Suite" /> instance.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="tag">The tag (unique user readable identifier).</param>
    /// <param name="phases">The phases.</param>
    /// <returns>
    /// The created instance.
    /// </returns>
    public static Suite Create(UiText name, string tag, params Phase[] phases)
        => new(name, tag, phases.ToImmutableList());
}
