// -----------------------------------------------------------------------
// <copyright file="CheckBench.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace UmlWorkshop.Exercise1;

/// <summary>
/// A check bench specification.
/// </summary>
/// <param name="Type">The type.</param>
/// <param name="Name">The name.</param>
/// <param name="SuiteGroups">The suite groups.</param>
public sealed record CheckBench(string Type, string Name, IImmutableList<SuiteGroup> SuiteGroups)
{
    /// <summary>
    /// Gets all suites.
    /// </summary>
    public ImmutableList<Suite> Suites
        => this.SuiteGroups.SelectMany(s => s.Suites).ToImmutableList();

    /// <summary>
    /// Creates a <see cref="CheckBench"/> instance.
    /// </summary>
    /// <param name="type">The test bench type.</param>
    /// <param name="name">The name.</param>
    /// <param name="suiteGroups">The suite groups.</param>
    /// <returns>The created instance.</returns>
    public static CheckBench Create(string type, string name, params SuiteGroup[] suiteGroups)
        => new(type, name, suiteGroups.ToImmutableList());
}
