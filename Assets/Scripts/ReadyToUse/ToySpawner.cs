using UnityEngine;

namespace ReadyToUse
{
    public class ToySpawner : MonoBehaviour
    {
        [Range(1.0f, 5.0f)]
        public float SpawnFrequency;
        public Transform SpawnPlace;
        public Transform SpawnerDirection;
        private GameObject[] toyPrefabs;
        private float spawnTimer;

        private void Awake()
        {
            toyPrefabs = Resources.LoadAll<GameObject>("Toys");
        }

        private void Update()
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer > SpawnFrequency)
            {
                spawnTimer = 0.0f;
                Spawn();
            }
        }

        private void Spawn()
        {
            GameObject toy = Instantiate<GameObject>(toyPrefabs[Random.Range(0, toyPrefabs.Length)], SpawnPlace.position, Random.rotation);
            toy.GetComponent<Rigidbody>().AddForce(SpawnerDirection.forward * Random.Range(10.0f, 40.0f), ForceMode.Impulse);
            EventsManager.OnToySpawn();
        }
    }
}
