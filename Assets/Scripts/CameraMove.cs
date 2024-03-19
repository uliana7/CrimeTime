using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Camera))]
public class CameraMove : MonoBehaviour
{
    public float smooth = 2.5f; // сглаживание при следовании за персонажем
    public float offset; // значение смещения (отключить = 0)
    public SpriteRenderer boundsMap; // спрайт, в рамках которого будет перемещаться камера

    private Transform player;
    private Vector3 min, max, direction;
    private static CameraMove _inst;
    private Camera cam;

    void Awake()
    {
        _inst = this;
        cam = GetComponent<Camera>();
        cam.orthographic = true;
        CalculateBounds();
        FindPlayer();
    }

    // найти персонажа, если он был уничтожен, а потом возрожден
    // для вызова из другого класса, пишем: Camera2DFollowTDS.use.FindPlayer();
    public static void FindPlayer()
    {
        _inst.FindPlayer_inst();
    }

    // если в процессе игры, было изменено разрешение экрана
    // или параметр "Orthographic Size", то следует сделать вызов данной функции повторно
    public static void CalculateBounds()
    {
        _inst.CalculateBounds_inst();
    }

    void CalculateBounds_inst()
    {
        if (boundsMap == null) return;
        Bounds bounds = Camera2DBounds();
        min = bounds.max + boundsMap.bounds.min;
        max = bounds.min + boundsMap.bounds.max;
    }

    void FindPlayer_inst()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (player)
        {
            direction = player.right;
            Vector3 position = player.position + direction * offset;
            position.z = transform.position.z;
            transform.position = MoveInside(position, new Vector3(min.x, min.y, position.z), new Vector3(max.x, max.y, position.z));
        }
    }

    Bounds Camera2DBounds()
    {
        float height = cam.orthographicSize * 2;
        return new Bounds(Vector3.zero, new Vector3(height * cam.aspect, height, 0));
    }

    Vector3 MoveInside(Vector3 current, Vector3 pMin, Vector3 pMax)
    {
        if (boundsMap == null) return current;
        current = Vector3.Max(current, pMin);
        current = Vector3.Min(current, pMax);
        return current;
    }

    Vector3 Mouse()
    {
        Vector3 mouse = Input.mousePosition;
        mouse.z = -transform.position.z;
        return cam.ScreenToWorldPoint(mouse);
    }

    void Follow()
    {
        direction = player.right;
        Vector3 position = player.position + direction * offset;
        position.z = transform.position.z;
        position = MoveInside(position, new Vector3(min.x, min.y, position.z), new Vector3(max.x, max.y, position.z));
        transform.position = Vector3.Lerp(transform.position, position, smooth * Time.deltaTime);
    }

    void LateUpdate()
    {
        if (player)
        {
            Follow();
        }
    }
}
