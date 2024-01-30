using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private GameObject _enemy;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_enemy == null)
    {
        _enemy = Instantiate(enemyPrefab) as GameObject;
        float randomHeight = Random.Range(1.0f, 3.0f); // Generates a random number between 1.0 and 3.0
        _enemy.transform.position = new Vector3(0, randomHeight, 0);
        float angle = Random.Range(0, 360);
        _enemy.transform.Rotate(0, angle, 0);

        Renderer renderer = _enemy.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }

        if (_enemy == null)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(0, 1, 0);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
        }
    }
}
