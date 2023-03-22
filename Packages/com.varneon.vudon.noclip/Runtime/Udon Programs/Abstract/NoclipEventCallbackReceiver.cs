using UdonSharp;

namespace Varneon.VUdon.Noclip.Abstract
{
    public abstract class NoclipEventCallbackReceiver : UdonSharpBehaviour
    {
        public abstract void OnNoclipEnabledStateChanged(bool enabled);
    }
}
