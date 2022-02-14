using UnityEngine;

namespace CM.Managers
{
    public class AssetManager : MonoBehaviour
    {
        public static AssetManager Instance { get; private set; }

        [SerializeField]
        private AssetContainerSO _assetContainerSO;

        public T GetAsset<T>(string name) where T : Object
        {
            foreach (Object asset in _assetContainerSO.assets)
            {
                if (string.Equals(name, asset.name))
                {
                    return asset as T;
                }
            }

            return null;
        }

        private void Awake()
        {
            if (!Instance)
                Instance = this;
            else
                Destroy(this);
        }
    }
}