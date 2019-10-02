using UnityEngine;
using UnityEngine.Experimental.VFX;
using UnityEngine.Experimental.VFX.Utility;

namespace Pyro
{
    [VFXBinder("Utility/Float Parameter")]
    public class VFXFloatBinder : VFXBinderBase
    {
        public string Parameter { get { return (string)m_Parameter; } set { m_Parameter = value; } }

        [VFXParameterBinding("System.Single"), SerializeField]
        protected ExposedParameter m_Parameter = "FloatParameter";
        public VFXFloatParameter Target;

        public override bool IsValid(VisualEffect component)
        {
            return Target != null && component.HasFloat(m_Parameter);
        }

        public override void UpdateBinding(VisualEffect component)
        {
            component.SetFloat(m_Parameter, Target.value);
        }

        public override string ToString()
        {
            return string.Format("Float Parameter : '{0}' -> {1}", m_Parameter, Target == null ? "(null)" : Target.name);
        }
    }
}
