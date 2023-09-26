using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletoPool : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    private int poolSize = 10;
    [SerializeField] private List<GameObject> bulletList;

    private static BulletoPool instance;
    public static BulletoPool Instance
    {
        get { return instance; }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        AddBulletsToPool(poolSize);
    }
    private void AddBulletsToPool(int amount)
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            bulletList.Add(bullet);
            bullet.transform.parent = transform;
        }
    }
    public GameObject RequestBullet()
    {
        for (int i = 0; i < bulletList.Count; i++)
        {
            if (!bulletList[i].activeSelf)
            {
                bulletList[i].SetActive(true);
                return bulletList[i];
            }
        }
        return null;
    }
}
