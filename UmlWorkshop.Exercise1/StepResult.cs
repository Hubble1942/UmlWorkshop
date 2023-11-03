// -----------------------------------------------------------------------
// <copyright file="StepResult.cs">
// Copyright (c) Christian Ewald. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace UmlWorkshop.Exercise1;

public sealed record StepResult
{
    /// <summary>
    /// Prevents a default instance of the <see cref="StepResult"/> class from being created.
    /// </summary>
    private StepResult()
    {
    }

    /// <summary>
    /// Gets a value indicating whether a step completed successfully.
    /// </summary>
    public required bool Success { get; init; }

    /// <summary>
    /// Gets the name of the step producing this result.
    /// </summary>
    public UiText StepName { get; init; } = UiText.Empty;

    /// <summary>
    /// Gets the caption to be displayed when the step failed.
    /// </summary>
    /// <remarks>The caption is only required when the step didn't succeed.</remarks>
    public UiText Caption { get; init; } = UiText.Empty;

    /// <summary>
    /// Gets the (optional) description to be displayed when the step failed.
    /// </summary>
    public UiText Description { get; init; } = UiText.Empty;

    /// <summary>
    /// Creates an instance of <see cref="StepResult"/> for successfully completed steps.
    /// </summary>
    /// <returns>The successful step result.</returns>
    public static StepResult Ok() => new StepResult { Success = true };

    /// <summary>
    /// Creates an instance of <see cref="StepResult" /> for failed steps.
    /// </summary>
    /// <param name="caption">The caption.</param>
    /// <param name="description">The description.</param>
    /// <returns>
    /// The failed step result.
    /// </returns>
    public static StepResult Fail(UiText caption, UiText? description = null)
         => new()
         {
             Success = false,
             Caption = caption,
             Description = description ?? UiText.Empty,
         };

    /// <summary>
    /// Creates an instance of <see cref="StepResult" /> for steps leaking unhandled exceptions.
    /// </summary>
    /// <param name="exception">The exception.</param>
    /// <returns>
    /// The failed step result.
    /// </returns>
    public static StepResult UnhandledException(Exception exception)
         => new()
         {
             Success = false,
             Caption = UiText.Of("Störung"),
             Description = UiText.Of(
                 """

                 Der Prüfschritt ist mit einer Störungsmeldung abgebrochen:

                 *{0}: {1}*

                 Sollte das Problem bestehen bleiben, informieren sie ihren Vorgesetzten oder wenden sich direkt an den M&F Kundensupport.

                 Hinweis: Die Log-Datei enthält zusätzliche Informationen zur Fehlerursache.

                 """).WithArguments(
                 exception.GetType().Name,
                 exception.Message),
         };
}
