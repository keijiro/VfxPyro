using UnityEngine;

namespace Pyro
{
    public class VFXFloatParameter : MonoBehaviour
    {
        public float value {
            get { return _value; }
            set { _value = value; }
        }

        [SerializeField] float _value;
    }
}
