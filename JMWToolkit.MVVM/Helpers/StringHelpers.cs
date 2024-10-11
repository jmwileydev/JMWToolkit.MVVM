/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/

using System.Windows;

namespace JMWToolkit.MVVM.Helpers;

/// <summary>
/// Static StringHelpers. I am sure this class will grow over time. For now two simple
/// routines to load a string resource.
/// </summary>
public static class StringResourceHelpers
{
    /// <summary>
    /// Loads a string resource and then formats it with the supplied parameters
    /// </summary>
    /// <param name="formatId">Resource Id for the string format</param>
    /// <param name="args">Variable list of arguments for the string format</param>
    /// <returns></returns>
    public static string FormatStringResource(this string formatId, params object[] args)
    {
        var string_format = (string)Application.Current.FindResource(formatId);
        return string.Format(string_format, args);
    }

    /// <summary>
    /// Simply loads the string specified by the resourceId
    /// </summary>
    /// <param name="resourceId">Id of the string to load</param>
    /// <returns></returns>
    public static string LoadFromResource(this string resourceId)
    {
        return (string)Application.Current.FindResource(resourceId);
    }
}
