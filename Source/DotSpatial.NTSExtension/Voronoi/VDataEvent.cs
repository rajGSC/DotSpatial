﻿// ********************************************************************************************************
// Product Name: DotSpatial.Topology.dll
// Description:  The basic topology module for the new dotSpatial libraries
// ********************************************************************************************************
// The contents of this file are subject to the Lesser GNU Public License (LGPL)
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
// http://dotspatial.codeplex.com/license
//
// Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF
// ANY KIND, either expressed or implied. See the License for the specific language governing rights and
// limitations under the License.
//
// The Initial Developer of this Original Code is Ted Dunsford. Created 8/27/2009 4:55:32 PM
//
// Contributor(s): (Open source contributors should list themselves and their modifications here).
// Name              |   Date             |   Comments
// ------------------|--------------------|---------------------------------------------------------
// Benjamin Dittes   | August 10, 2005    |  Authored original code for working with laser data
// Ted Dunsford      | August 26, 2009    |  Ported and cleaned up the raw source from code project
// ********************************************************************************************************

using System;

namespace DotSpatial.NTSExtension.Voronoi
{

    /// <summary>
    /// The VDataEvent.
    /// </summary>
    internal class VDataEvent : VEvent
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VDataEvent"/> class.
        /// </summary>
        /// <param name="dp">Vector used as DataPoint.</param>
        public VDataEvent(Vector2 dp)
        {
            DataPoint = dp;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the DataPoint of this event.
        /// </summary>
        public Vector2 DataPoint { get; }

        /// <summary>
        /// Gets the Y value.
        /// </summary>
        public override double Y => DataPoint.Y;

        /// <summary>
        /// Gets the X value.
        /// </summary>
        protected override double X => DataPoint.X;

        #endregion
    }
}