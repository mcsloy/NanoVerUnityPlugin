using System;
using System.Collections.Generic;
using Narupa.Visualisation.Node.Protein;
using Narupa.Visualisation.Properties.Collections;
using Narupa.Visualisation.Property;
using UnityEngine;

namespace Narupa.Visualisation.Node.Adaptor
{
    [Serializable]
    public class SecondaryStructureAdaptorNode : PassThroughAdaptorNode
    {
        internal PolypeptideSequenceNode polypeptideSequence = new PolypeptideSequenceNode();
        internal SecondaryStructureNode secondaryStructure = new SecondaryStructureNode();

        private SecondaryStructureArrayProperty assignments = new SecondaryStructureArrayProperty();

        [SerializeField]
        private DsspOptions options = new DsspOptions();

        public SecondaryStructureAdaptorNode()
        {
            polypeptideSequence.AtomNames.LinkedProperty = this.ParticleNames;
            secondaryStructure.AtomPositions.LinkedProperty = this.ParticlePositions;
            polypeptideSequence.AtomResidues.LinkedProperty = this.ParticleResidues;
            polypeptideSequence.ResidueNames.LinkedProperty = this.ResidueNames;
            polypeptideSequence.ResidueEntities.LinkedProperty = this.ResidueEntities;
            secondaryStructure.ResidueCount.LinkedProperty = this.ResidueCount;

            secondaryStructure.AtomNames.LinkedProperty = polypeptideSequence.AtomNames;
            secondaryStructure.AtomResidues.LinkedProperty = polypeptideSequence.AtomResidues;
            secondaryStructure.PeptideResidueSequences.LinkedProperty =
                polypeptideSequence.ResidueSequences;
            assignments.LinkedProperty = secondaryStructure.ResidueSecondaryStructure;

            secondaryStructure.DsspOptions = options;
        }

        public override void Refresh()
        {
            base.Refresh();
            polypeptideSequence.Refresh();
            secondaryStructure.Refresh();
        }

        private const string ResidueSecondaryStructureKey = "residue.secondarystructures";

        public override IReadOnlyProperty GetProperty(string key)
        {
            if (key == ResidueSecondaryStructureKey)
                return assignments;
            return base.GetProperty(key);
        }

        public override IEnumerable<(string name, IReadOnlyProperty property)> GetProperties()
        {
            foreach (var prop in base.GetProperties())
                yield return prop;
            yield return (ResidueSecondaryStructureKey, assignments);
        }

        public override IReadOnlyProperty<T> GetOrCreateProperty<T>(string name)
        {
            if (typeof(T) == typeof(SecondaryStructureAssignment[]) &&
                name.Equals(ResidueSecondaryStructureKey))
            {
                return assignments as IReadOnlyProperty<T>;
            }

            return base.GetOrCreateProperty<T>(name);
        }
    }
}