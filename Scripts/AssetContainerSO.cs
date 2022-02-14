using UnityEngine;

namespace CM.Managers
{
    [CreateAssetMenu(fileName = "New Asset Container", menuName = "CM/SO/Asset Container")]
    public class AssetContainerSO : ScriptableObject
    {
        public Object[] assets;
    }
}