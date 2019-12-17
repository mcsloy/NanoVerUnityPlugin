using System;
using System.Collections.Generic;
using Narupa.Core.Math;
using UnityEngine;

namespace Narupa.Frontend.Manipulation
{
    /// <summary>
    /// Represents a grab between a particle and world-space position
    /// </summary>
    // TODO: this was exposed last minute and should be refactored into 
    // something cleaner, and not expose EndManipulation publically. See
    // issue #74
    public class ActiveParticleGrab : IActiveManipulation
    {
        /// <inheritdoc cref="IActiveManipulation.ManipulationEnded"/>
        public event Action ManipulationEnded;

        /// <summary>
        /// A unique identifier for this interaction.
        /// </summary>
        public string Id { get; }
        
        /// <summary>
        /// The set of particle indices involved in this interaction.
        /// </summary>
        public IReadOnlyList<int> ParticleIndices => particleIndices;

        private readonly List<int> particleIndices = new List<int>();
        
        /// <summary>
        /// The position of the manipulator.
        /// </summary>
        public Vector3 GrabPosition { get; private set; }

        /// <summary>
        /// A set of properties associated with this manipulation.
        /// </summary>
        public Dictionary<string, object> Properties { get; } = new Dictionary<string, object>();

        /// <summary>
        /// Callback for when the grab position is updated.
        /// </summary>
        public event Action ParticleGrabUpdated;

        public ActiveParticleGrab(IEnumerable<int> particleIndices)
        {
            Id = Guid.NewGuid().ToString();
            this.particleIndices.AddRange(particleIndices);
        }

        /// <inheritdoc />
        public void UpdateManipulatorPose(UnitScaleTransformation manipulatorPose)
        {
            GrabPosition = manipulatorPose.position;
            ParticleGrabUpdated?.Invoke();
        }

        /// <inheritdoc />
        public void EndManipulation()
        {
            ManipulationEnded?.Invoke();
        }

        private const string KeyResetVelocities = "reset_velocities";

        public bool ResetVelocities
        {
            set => Properties[KeyResetVelocities] = value;
        }
    }
}