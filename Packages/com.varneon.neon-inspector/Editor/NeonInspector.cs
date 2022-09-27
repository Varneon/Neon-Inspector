using UnityEngine;
using UnityEngine.UIElements;
using Varneon.VInspector;

namespace Varneon.NeonInspector
{
    public class NeonInspector : InspectorBase
    {
        [SerializeField]
        private Texture2D banner;

        protected override void OnInspectorVisualTreeAssetCloned(VisualElement root)
        {
            root.Q("Banner").style.backgroundImage = banner;
        }
    }
}
