// Copyright (c) Intangible Realities Lab. All rights reserved.
// Licensed under the GPL. See License.txt in the project root for license information.

using System;
using Narupa.Core.Science;
using Narupa.Visualisation.Property;
using UnityEngine;

namespace Narupa.Visualisation.Node.Scale
{
    /// <summary>
    /// Base code for visualiser node which generates scales based upon atomic
    /// elements.
    /// </summary>
    [Serializable]
    public abstract class PerElementScale : VisualiserScale
    {
        private readonly ElementArrayProperty elements = new ElementArrayProperty();

        /// <summary>
        /// Atomic element array input.
        /// </summary>
        public IProperty<Element[]> Elements => elements;

        /// <inheritdoc cref="VisualiserScale.Refresh" />
        public override void Refresh()
        {
            if (elements.IsDirty && elements.HasValue)
            {
                RefreshScales();

                elements.IsDirty = false;
            }
        }

        private void RefreshScales()
        {
            var elementArray = elements.Value;
            var scaleArray = scales.HasValue ? scales.Value : new float[0];
            Array.Resize(ref scaleArray, elements.Value.Length);
            for (var i = 0; i < elements.Value.Length; i++)
                scaleArray[i] = GetScale(elementArray[i]);

            scales.Value = scaleArray;
        }

        /// <summary>
        /// Get the scale for the given atomic element.
        /// </summary>
        protected abstract float GetScale(Element element);
    }
}