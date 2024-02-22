using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ShootWeapon : MonoBehaviour
{
    [SerializeField] private GameObject _launchPosition, _bulletPrefab;
    private bool _okayToShoot = true;
    private bool _shootingPaused = false;
    private InputData _inputData;
    private bool triggerValue;
    public AudioSource gun;


    // public AudioSource gun;
    // Start is called before the first frame update
    void Start()
    {
        _inputData = GetComponent<InputData>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_okayToShoot)
        {
            if(!_shootingPaused)
            {
                if(_inputData._rightController.TryGetFeatureValue(CommonUsages.triggerButton, out triggerValue) && triggerValue)
                {
                    // if(_aButtonPressed)
                    //{
                        gun.Play();
                        _shootingPaused = true;
                        Fire();
                        StartCoroutine(Pause());
                    //}
                }
            }
        }
        if(_inputData._leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool _yButtonPressed))
            {
                if(_yButtonPressed)
                {
                    GameObject save = GameObject.Find("GameController");
                    save.GetComponent<SaveLoad>().BeginShutdown();
                }
            }
    }
    private void Fire()
    {
        // gun.Play();
        GameObject bullet = Instantiate(_bulletPrefab) as GameObject;
        bullet.SetActive(true);
        bullet.transform.position = _launchPosition.transform.position;
        bullet.transform.rotation = _launchPosition.transform.rotation;

        bullet.GetComponent<Rigidbody>().AddForce(_launchPosition.transform.forward * 50f, ForceMode.Impulse);
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(0.5f);
        _shootingPaused = false;
    }

    public void PickedUpWeaponTrigger()
    {
        _okayToShoot = true;
    }

    public void DroppedWeaponTrigger()
    {
        _okayToShoot = false;
    }
}
