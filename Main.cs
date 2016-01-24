using UnityEngine;

namespace CustomSceneryRegistrar
{
    public class Main : IMod
    {
        public void onEnabled()
        {

        }

        public void onDisabled()
        {
            Registrar.UnloadScenery();
        }

        public string Name { get { return "Custom Scenery Registrar"; } }
        public string Description { get { return "Custom Scenery Registrar, don't turn me off!"; } }
        public string Identifier { get { return "com.parkitectnexus.customsceneryregistrar"; } }
    }
}
