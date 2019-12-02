using System;
using Narupa.Visualisation.Node;
using Narupa.Visualisation.Property;
using UnityEngine;

namespace Narupa.Visualisation.Node.Calculator
{
    public abstract class LerpNode<TValue, TProperty> : GenericOutputNode where TProperty : ArrayProperty<TValue>, new()
    {
        [SerializeField]
        private TProperty input = new TProperty();
        
        private TProperty output = new TProperty();

        private TValue[] cached = new TValue[0];

        protected override bool IsInputValid => input.HasNonNullValue();
        protected override bool IsInputDirty => input.IsDirty;
        protected override void ClearDirty()
        {
            input.IsDirty = false;
        }

        protected override void UpdateOutput()
        {
            if (cached.Length != input.Value.Length)
            {
                output.Resize(input.Value.Length);
                Array.Resize(ref cached, input.Value.Length);
            }
            for (var i = 0; i < input.Value.Length; i++)
            {
                cached[i] = MoveTowards(cached[i], input[i]);
            }

            output.Value = cached;
        }

        protected abstract TValue MoveTowards(TValue current, TValue target);

        protected override void ClearOutput()
        {
            output.UndefineValue();
        }
    }
}