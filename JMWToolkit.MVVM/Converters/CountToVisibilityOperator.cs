/*
 * Copyright (c) 2023, J.M. Wiley
All rights reserved.

This source code is licensed under the BSD-style license found in the
LICENSE file in the root directory of this source tree. 
*/
namespace JMWToolkit.MVVM.Converters;

/// <summary>
/// An enum which tells which operand to use when doing the comparison.
/// </summary>
public enum CountToVisibilityOperator
{
    /// <summary>
    /// The Values are equal.
    /// </summary>
    Equals,

    /// <summary>
    /// The value is less than the count.
    /// </summary>
    LessThan,

    /// <summary>
    /// The value is less than or equal to the count.
    /// </summary>
    LessThanOrEqual,

    /// <summary>
    /// The value is greater than the count.
    /// </summary>
    GreaterThan,

    /// <summary>
    /// The value is greater than or equal to the count.
    /// </summary>
    GreaterThanOrEqual,

    /// <summary>
    /// The value is not equal to the count.
    /// </summary>
    NotEqual
}
