/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
using System;

namespace JMWToolkit.MVVM.Converters;

/// <summary>
/// The arguments passed to the CountToVisibilityConverter.
/// </summary>
public class CountToVisibilityArguments
{
    /// <summary>
    /// The Operator to be applied to the value and the Count.
    /// </summary>
    public CountToVisibilityOperator Operator { get; set; } = CountToVisibilityOperator.Equals;

    /// <summary>
    /// The Count to be compared to the bound value.
    /// </summary>
    public Int32 Count { get; set; } = 0;

    /// <summary>
    /// The VisibilityConverterMode, collapsed is the default.
    /// </summary>
    public VisibilityConverterMode VisibilityConverterMode {get; set; } = VisibilityConverterMode.Collapsed;
}
