﻿/*******************************************************************************
 *
 * License :
 *
 *  SoundTouch audio processing library
 *  Copyright (c) Olli Parviainen
 *  C# port Copyright (c) Olaf Woudenberg
 *
 *  This library is free software; you can redistribute it and/or
 *  modify it under the terms of the GNU Lesser General Public
 *  License as published by the Free Software Foundation; either
 *  version 2.1 of the License, or (at your option) any later version.
 *
 *  This library is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 *  Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public
 *  License along with this library; if not, write to the Free Software
 *  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 *
 ******************************************************************************/

using System.Diagnostics;

namespace SoundTouch
{
    public abstract class TransposerBaseFloat : TransposerBase<float>
    {
        public static TransposerBase<float> NewInstance()
        {
            switch (_algoritm)
            {
                case Algoritm.Linear:
                    return new InterpolateLinearFloat();
                case Algoritm.Cubic:
                    return new InterpolateCubic();
                case Algoritm.Shannon:
                    return new InterpolateShannon();
                default:
                    Debug.Assert(false);
                    return null;
            }
        }
    }
}