﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System.Collections;

namespace Microsoft.Toolkit.Uwp.UI
{
    /// <summary>
    /// Sort description
    /// </summary>
    public class SortDescription
    {
        /// <summary>
        /// Gets the name of property to sort on
        /// </summary>
        public string PropertyName { get; }

        /// <summary>
        /// Gets the direction of sort
        /// </summary>
        public SortDirection Direction { get; }

        /// <summary>
        /// Gets the comparer
        /// </summary>
        public IComparer Comparer { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortDescription"/> class that describes
        /// a sort on the object itself
        /// </summary>
        /// <param name="direction">direction of sort</param>
        public SortDescription(SortDirection direction)
        {
            Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortDescription"/> class that describes
        /// a sort on the object itself
        /// </summary>
        /// <param name="direction">directio of sort</param>
        /// <param name="comparer">comparer to use</param>
        public SortDescription(SortDirection direction, IComparer comparer)
        {
            Direction = direction;
            Comparer = comparer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortDescription"/> class.
        /// </summary>
        /// <param name="propertyName">name of property to sort on</param>
        /// <param name="direction">direction of sort</param>
        public SortDescription(string propertyName, SortDirection direction)
        {
            PropertyName = propertyName;
            Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SortDescription"/> class.
        /// </summary>
        /// <param name="propertyName">name of property to sort on</param>
        /// <param name="direction">direction of sort</param>
        /// <param name="comparer">comparer to use</param>
        public SortDescription(string propertyName, SortDirection direction, IComparer comparer)
        {
            PropertyName = propertyName;
            Direction = direction;
            Comparer = comparer;
        }
    }
}