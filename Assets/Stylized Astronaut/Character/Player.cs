using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private Animator anim;
	private CharacterController controller;

	public Camera mainCam;
	public Canvas nameCanvas;

	public float speed = 600.0f;
	public float jumpHeight = 2.5f;
	public float gravity = 9.8f;
	private Vector3 moveDirection = Vector3.zero;
	private bool grounded = true;
	private float jumpForce = 0f;

	void Start () {
		controller = GetComponent <CharacterController>();
		anim = gameObject.GetComponentInChildren<Animator>();
	}

	void Update (){
		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

		if (moveDirection != Vector3.zero) {
			anim.SetInteger ("AnimationPar", 1);
			anim.speed = 2;

			transform.forward = moveDirection;
		}
		else {
			anim.SetInteger ("AnimationPar", 0);
			anim.speed = 1;
		}

		moveDirection *= speed;
		moveDirection.x *= Time.deltaTime;
		moveDirection.z *= Time.deltaTime;

		if (jumpForce > 0.1f * gravity * Time.deltaTime)
			jumpForce -= 0.1f * gravity * Time.deltaTime;
		else
			jumpForce = 0f;

		if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
			anim.SetInteger("Jumping", 1);
			jumpForce = jumpHeight * gravity * Time.deltaTime;
        }
		else if (grounded)
        {
			anim.SetInteger("Jumping", 0);
        }

		moveDirection.y += jumpForce;
		if (jumpForce == 0f)
			moveDirection.y -= gravity * Time.deltaTime;

		controller.Move(moveDirection);
		grounded = controller.isGrounded;

		nameCanvas.transform.forward = mainCam.transform.forward;
	}
}
