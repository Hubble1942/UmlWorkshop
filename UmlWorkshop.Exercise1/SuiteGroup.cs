// ------------------------------------------------------------------------------------------
//  <copyright file="SuiteGroup.cs">
// Copyright (c) Christian Ewald. All rights reserved.
//  </copyright>
// ------------------------------------------------------------------------------------------

namespace UmlWorkshop.Exercise1;

/// <summary>
/// A suite group specification.
/// </summary>
/// <param name="Name">The name.</param>
/// <param name="ImageUrl">The URL of the associated image.</param>
/// <param name="Suites">The suites.</param>
public sealed record SuiteGroup(UiText Name, string ImageUrl, IImmutableList<Suite> Suites)
{
    /// <summary>
    /// Gets a value indicating whether this suite group contains a self check suite.
    /// </summary>
    public bool ContainsSelfCheckSuite
        => this.Suites.Any(s => s.IsSelfCheck);

    /// <summary>
    /// Gets a value indicating whether suite in this instance may run in single check mode.
    /// </summary>
    public bool IsSingleCheckable => this.Suites.Any(s => s.IsSingleCheckable);

    /// <summary>
    /// Creates a <see cref="SuiteGroup" /> instance.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="imageUrl">The URL of the associated image.</param>
    /// <param name="suites">The suites.</param>
    /// <returns>
    /// The created instance.
    /// </returns>
    public static SuiteGroup Create(UiText name, string imageUrl, params Suite[] suites)
        => new(name, imageUrl, suites.ToImmutableList());
}
