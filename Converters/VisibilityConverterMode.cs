/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
namespace JMWToolkit.MVVM.Converters;

/// <summary>
/// Enum which can be used to specify the conversion for our visibility converters.
/// </summary>
public enum VisibilityConverterMode
{
    /// <summary>
    /// Control will be collapsed when condition is false
    /// </summary>
    Collapsed,
    /// <summary>
    /// Control will be hidden when the condition is false
    /// </summary>
    Hidden,
    /// <summary>
    /// Control will be collapsed when the condition is true
    /// </summary>
    InverseCollapsed,
    /// <summary>
    /// Control will be hidden when the condition is true
    /// </summary>
    InverseHidden
};
