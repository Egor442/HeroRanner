using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private int _capasity;

    private List<GameObject> _pool = new List<GameObject>();

    protected void Initialize(GameObject prefabe)
    {
        for (int i = 0; i < _capasity; i++)
        {
            GameObject spawned = Instantiate(prefabe, _container.transform);
            spawned.SetActive(false);

            _pool.Add(spawned);
        }       
    }

    protected void Initialize(GameObject[] prefabs)
    {
        for (int i = 0; i < _capasity; i++)
        {
            int randomIndexEnemy = Random.Range(0, prefabs.Length);
            GameObject spawned = Instantiate(prefabs[randomIndexEnemy], _container.transform);
            spawned.SetActive(false);

            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = null;

        for (int i = 0; i < _pool.Count; i++)
        {
            if (_pool[i].activeSelf == false)
            {
                result = _pool[i];
                break;
            }
        }

        return result != null;
    }
}