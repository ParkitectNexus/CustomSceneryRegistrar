using CustomSceneryRegistrar;
using UnityEngine;

namespace CustomSceneryRegistrar
{
    public class Main : IMod
    {
        private GameObject _go;

        public void onEnabled()
        {
            _go = new GameObject();

            _go.AddComponent<Registrar>();
        }

        public void onDisabled()
        {
            _go.GetComponent<Registrar>().UnloadScenery();

            Object.Destroy(_go);
        }

        public string Name { get { return "Custom Scenery Registrar"; } }
        public string Description { get { return "Custom Scenery Registrar, don't turn me off!"; } }
        public string Identifier { get { return "com.parkitectnexus.customsceneryregistrar"; } }
    }
}
