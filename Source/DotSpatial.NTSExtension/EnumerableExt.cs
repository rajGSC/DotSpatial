// ********************************************************************************************************
// Product Name: MapWindow.dll Alpha
// Description:  The basic module for MapWindow version 6.0
// ********************************************************************************************************
// The contents of this file are subject to the Mozilla Public License Version 1.1 (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
//
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF
// ANY KIND, either expressed or implied. See the License for the specific language governing rights and
// limitations under the License.
//
// The Original Code is from MapWindow.dll version 6.0
//
// The Initial Developer of this Original Code is Ted Dunsford. Created 6/18/2009 1:57:10 PM
//
// Contributor(s): (Open source contributors should list themselves and their modifications here).
//
// ********************************************************************************************************

using System;
using System.Collections.Generic;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;

namespace DotSpatial.NTSExtension
{
    /// <summary>
    /// EnumerableEM
    /// </summary>
    public static class EnumerableExt
    {
        #region Methods

        /// <summary>
        /// Converts an array of coordinates into points.
        /// Eventually I hope to reduce the amount of "casting" necessary, in order to allow as much as possible to occur via an interface.
        /// </summary>
        /// <param name="rawPoints">The coordinates that should be converted to points.</param>
        /// <returns>The resulting point array.</returns>
        public static IPoint[] CastToPointArray(this IEnumerable<Coordinate> rawPoints)
        {
            List<IPoint> result = new List<IPoint>();
            foreach (Coordinate rawPoint in rawPoints)
            {
                result.Add(new Point(rawPoint));
            }

            return result.ToArray();
        }

        /// <summary>
        /// cycles through any strong typed collection where the type implements ICLoneable
        /// and clones each member, inserting that member into the new list.
        /// </summary>
        /// <typeparam name="T">The type of the values in the list.</typeparam>
        /// <param name="original">The original enumerable collection of type T.</param>
        /// <returns>A deep copy of the list.</returns>
        public static List<T> CloneList<T>(this IEnumerable<T> original)
            where T : ICloneable
        {
            List<T> result = new List<T>();
            foreach (T item in original)
            {
                result.Add(SafeCastTo<T>(item.Clone()));
            }

            return result;
        }

        /// <summary>
        /// A Generic Safe Casting method that should simply exist as part of the core framework
        /// </summary>
        /// <typeparam name="T">The type of the member to attempt to cast to.</typeparam>
        /// <param name="obj">The original object to attempt to System.Convert.</param>
        /// <returns>An output variable of type T.</returns>
        private static T SafeCastTo<T>(object obj)
        {
            if (obj == null)
            {
                return default(T);
            }

            if (!(obj is T))
            {
                return default(T);
            }

            return (T)obj;
        }

        #endregion
    }
}