using UnityEngine;
using UnityEngine.VFX;

namespace Pyro
{
    sealed class PyroLauncher : MonoBehaviour
    {
        [SerializeField] Camera _camera = null;
        [SerializeField] VisualEffect _vfx = null;

        VFXEventAttribute _attrib;

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var pos = Input.mousePosition;
                pos.z = _vfx.transform.position.z - _camera.transform.position.z;
                pos = _camera.ScreenToWorldPoint(pos);

                if (_attrib == null) _attrib = _vfx.CreateVFXEventAttribute();
                _attrib.SetVector3("position", pos);

                _vfx.SendEvent("OnManualSpawn", _attrib);
            }
        }
    }
}
