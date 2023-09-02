using UnityEditor;
using UnityEngine;
using Varneon.VUdon.Editors.Editor;

namespace Varneon.VUdon.Noclip.Editor
{
    /// <summary>
    /// Custom inspector for Noclip prefab
    /// </summary>
    [CustomEditor(typeof(Noclip))]
    public class NoclipEditor : InspectorBase
    {
        [SerializeField]
        private Texture2D bannerIcon;

        protected override string PersistenceKey => "Varneon/VUdon/Noclip/Editor/Foldouts";

        protected override InspectorHeader Header => new InspectorHeaderBuilder()
            .WithTitle("VUdon - Noclip")
            .WithDescription("Drag & drop prefab for adding flight for worlds")
            .WithURL("GitHub", "https://github.com/Varneon/VUdon-Noclip")
            .WithIcon(bannerIcon)
            .Build();
    }
}
