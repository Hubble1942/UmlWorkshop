// -----------------------------------------------------------------------
// <copyright file="Check.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Text.Json.Serialization;

using Autofac;

namespace UmlWorkshop.Exercise1;

/// <summary>
/// A check.
/// </summary>
/// <param name="Name">The name of the check.</param>
/// <param name="StepFactory">The factory producing the steps of this check.</param>
public sealed record Check(
    UiText Name,
    [property: JsonIgnore] Func<ILifetimeScope, IEnumerable<IStep>> StepFactory)
{
    /// <summary>
    /// Gets the factory producing the extra set-up steps required in single check mode.
    /// </summary>
    [JsonIgnore]
    public Func<ILifetimeScope, IEnumerable<IStep>> SingleCheckSetUpStepFactory { get; init; } = _ => Enumerable.Empty<IStep>();

    /// <summary>
    /// Gets the factory producing the extra tear-down steps required in single check mode.
    /// </summary>
    [JsonIgnore]
    public Func<ILifetimeScope, IEnumerable<IStep>> SingleCheckTearDownStepFactory { get; init; } = _ => Enumerable.Empty<IStep>();
}
