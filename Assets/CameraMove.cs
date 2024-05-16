using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{
    public float sensitivityMouse = 5f;
    public float sensitivetyKeyBoard = 0.5f;
    public float sensitivetyMouseWheel = 10f;

    private float cameraPY;
    void Start()
    {
        transform.position = new Vector3(-80.63945f, 68.17574f, 21.14158f);
        cameraPY = transform.position.y;
    }
    void Update()
    {
        // 滚轮实现镜头缩进和拉远
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            this.GetComponent<Camera>().fieldOfView = this.GetComponent<Camera>().fieldOfView - Input.GetAxis("Mouse ScrollWheel") * sensitivetyMouseWheel;
        }
        // 鼠标右键控制镜头方向
        if (Input.GetMouseButton(1))
        {
            float anglesX = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * sensitivityMouse;
            float anglesY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityMouse;
            transform.localEulerAngles = new Vector3(anglesX, anglesY, 0);
        }
        // 键盘按钮←/a和→/d实现视角水平移动，键盘按钮↑/w和↓/s实现视角水平旋转
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(Input.GetAxis("Horizontal") * sensitivetyKeyBoard, 0, 0);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            // 水平左右移动冻结Y轴移动
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            // transform.position = new Vector3(transform.position.x, cameraPY, transform.position.z);
            transform.Translate(0, 0, Input.GetAxis("Vertical") * sensitivetyKeyBoard);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(0, -1.2f*sensitivetyKeyBoard, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(0, 1.2f*sensitivetyKeyBoard, 0);
        }

        if(transform.position.y<5){
            transform.position = new Vector3(transform.position.x, 5, transform.position.z);
        }

    }

}