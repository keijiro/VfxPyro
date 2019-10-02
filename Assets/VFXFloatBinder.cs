using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

namespace Pyro
{
    [VFXBinder("Utility/Float Property")]
    public class VFXFloatBinder : VFXBinderBase
    {
        public string Property { get { return (string)m_Property; } set { m_Property = value; } }

        [VFXPropertyBinding("System.Single"), SerializeField]
        protected ExposedProperty m_Property = "FloatProperty";
        public VFXFloatProperty Target;

        public override bool IsValid(VisualEffect component)
        {
            return Target != null && component.HasFloat(m_Property);
        }

        public override void UpdateBinding(VisualEffect component)
        {
            component.SetFloat(m_Property, Target.value);
        }

        public override string ToString()
        {
            return string.Format("Float Property : '{0}' -> {1}", m_Property, Target == null ? "(null)" : Target.name);
        }
    }
}
