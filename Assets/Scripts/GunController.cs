using UnityEngine;
using UnityEngine.UI;

public class GunController : MonoBehaviour
{
    public float damage = 10.0f;
    [SerializeField]
    private float weaponRange = 100.0f;
    [SerializeField]
    private Camera cam;
    public ParticleSystem muzzleflash;
    public GameObject impact;
    private float  nextfire = 0f;
    public float fireRate = 5f;
    public int MaxAmmo = 40;
    private int CurentAmmo;
    public Text ammotext;


    private void Start()
    {
        CurentAmmo = MaxAmmo;
        ammotext.text = CurentAmmo.ToString() + "/" + MaxAmmo.ToString();
    }

    void Update()
    {
        if (CurentAmmo <= 0)
        {
            //reloading
            CurentAmmo = MaxAmmo;
        }
        if (Input.GetButton("Fire1") && Time.time >= nextfire)
        {
            muzzleflash.Play();
            nextfire = Time.time + 1.0f / fireRate;
            Shoot();
            CurentAmmo -= 1;
            ammotext.text = CurentAmmo.ToString() + "/" + MaxAmmo.ToString();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward,out hit,weaponRange))
        {
            EnemyController target = hit.transform.GetComponent<EnemyController>();
            if(target!=null && target.gameObject.CompareTag("Enemy"))
            {
                target.TakeDamage(damage);
                GameObject impactObj = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactObj, 20.0f);
            }
        }
    }
}
