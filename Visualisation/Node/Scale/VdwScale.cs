// Copyright (c) Intangible Realities Lab. All rights reserved.
// Licensed under the GPL. See License.txt in the project root for license information.

using System;
using Narupa.Core.Science;
using Narupa.Visualisation.Property;
using UnityEngine;

namespace Narupa.Visualisation.Node.Scale
{
    /// <summary>
    /// Visualiser node which scales each particle by its Van der Waals radius
    /// </summary>
    [Serializable]
    public class VdwScale : PerElementScale
    {
        /// <summary>
        /// Multiplier for each radius.
        /// </summary>
        public IProperty<float> Scale => scale;

        [SerializeField]
        private FloatProperty scale = new FloatProperty
        {
            Value = 1f
        };

        /// <summary>
        /// Get the scale of the provided atomic element.
        /// </summary>
        protected override float GetScale(Element element)
        {
            return (element.GetVdwRadius() ?? 1f) * scale.Value;
        }
    }
}