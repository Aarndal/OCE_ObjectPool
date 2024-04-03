using UnityEngine;

public class ShootStuff : MonoBehaviour
{
    private bool hitsTarget;

    private void Update()
    {
        GameObject bullet = MyObjectPool.Instance.GetPooledObject();

        if (bullet != null)
            bullet.SetActive(true);

        if(hitsTarget)
            bullet.SetActive(false);
    }
}
