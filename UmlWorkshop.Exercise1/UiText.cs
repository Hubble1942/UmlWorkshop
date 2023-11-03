// -----------------------------------------------------------------------
// <copyright file="UiText.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Runtime.CompilerServices;

namespace UmlWorkshop.Exercise1;

/// <summary>
/// Helper class to mark localizable texts.
/// </summary>
public sealed record UiText
{
    /// <summary>
    /// Represents the empty <see cref="UiText"/>.
    /// </summary>
    public static readonly UiText Empty = new(string.Empty, string.Empty);

    /// <summary>
    /// Initializes a new instance of the <see cref="UiText"/> class.
    /// </summary>
    /// <param name="template">The template.</param>
    /// <param name="callerFilePath">The caller file path.</param>
    internal UiText(string template, string callerFilePath)
    {
        this.Template = template;
        this.CallerFilePath = callerFilePath;
    }

    /// <summary>
    /// Gets the template.
    /// </summary>
    public string Template { get; }

    /// <summary>
    /// Gets the file path of the code instantiating this instance.
    /// </summary>
    public string CallerFilePath { get; }

    /// <summary>
    /// Gets the arguments.
    /// </summary>
    public ImmutableArray<object> Arguments { get; private init; } = ImmutableArray<object>.Empty;

    /// <summary>
    /// Gets a value indicating whether this instance is empty.
    /// </summary>
    public bool IsEmpty => this.Template == string.Empty;

    /// <summary>
    /// Creates an <see cref="UiText" /> instance of the specified template.
    /// </summary>
    /// <param name="template">The template.</param>
    /// <param name="callerFilePath">The caller file path.</param>
    /// <returns>
    /// The <see cref="UiText" />.
    /// </returns>
    public static UiText Of(string template, [CallerFilePath] string callerFilePath = "")
        => new(template, callerFilePath);

    /// <summary>
    /// Creates a cloned <see cref="UiText"/> with the specified arguments.
    /// </summary>
    /// <param name="arguments">The arguments.</param>
    /// <returns>The cloned <see cref="UiText"/>.</returns>
    public UiText WithArguments(params object[] arguments)
        => this with { Arguments = arguments.ToImmutableArray() };

    /// <summary>
    /// Renders this <see cref="UiText"/> into its invariant representation.
    /// </summary>
    /// <returns>The rendered invariant string.</returns>
    public string ToInvariantString() // TODO ewc 2023-05-01: Handle arguments of type UiText differently. Call ToInvariantString on them as well.
        => string.Format(this.Template, this.Arguments.ToArray());

    /// <inheritdoc/>
    public override string ToString() // TODO ewc 2023-04-04: Render string using selected language (As soon as we do more I18N/L10N)
        => string.Format(this.Template, this.Arguments.ToArray());
}
