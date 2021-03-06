using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    private PhotonView photonView;

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!photonView.IsMine) return;

        if (Input.GetKey(KeyCode.A)) transform.Translate(-Time.deltaTime * 15, 0, 0);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Time.deltaTime * 15, 0, 0);

    }
}
