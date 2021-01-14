using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jr_Movement : MonoBehaviour
{
    public float xySpeed = 100;
    public float ZSpeed = 12;

    void Start()
    {
        ZSpeed = 7;
    }


    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * xySpeed);


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

    LocalMove(h, v, xySpeed);
    //PositionCamera();

    }

    void LocalMove(float x, float y, float speed)
    {
        transform.localPosition += new Vector3(x, y, 0) * speed * Time.deltaTime;
        PositionCamera();
    }

    void PositionCamera()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);

    }

    public Transform aimTarget;

    void Direction(float h, float v, float speed)
    {
        aimTarget.localPosition = new Vector3(h, v, 1);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(aimTarget.position), Mathf.Deg2Rad * speed);
    }

    void HorizontalLean(Transform target, float axis, float leanLimit, float lerpTime)
    {
        Vector3 targetEulerAngels = target.localEulerAngles;
        target.localEulerAngles = new Vector3(targetEulerAngels.x, targetEulerAngels.y, Mathf.LerpAngle(targetEulerAngels.z, -axis * leanLimit, lerpTime));
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(aimTarget.position, .5f);
        Gizmos.DrawSphere(aimTarget.position, .15f);
    }
}
// faire avancer sur axe z automatiquement + avoir rotation fluide