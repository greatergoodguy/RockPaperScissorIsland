using UnityEngine;
using System.Collections;

namespace RPSIsland.Red {

	public class MoBoRed : MonoBehaviour {

		RedGeneController rgController;
		RedGeneAnimator rgAnimator;
		
		void Start () {
			Handler handler = new Handler(this);

			rgController = new RedGeneController(handler);
			rgAnimator = new RedGeneAnimator(handler);
		}

		void Update () {
			rgController.Update();
			rgAnimator.Update();
		}

		public class Handler {

			MoBoRed red;

			public Handler(MoBoRed red) {
				this.red = red;
			}

			public float GetVertical() 		{ return red.rgController.Vertical;}
			public float GetHorizontal() 	{ return red.rgController.Horizontal;}

			public bool IsDirNorth() { return red.rgController.IsDirNorth();}
			public bool IsDirSouth() { return red.rgController.IsDirSouth();}
			public bool IsDirEast() { return red.rgController.IsDirEast();}
			public bool IsDirWest() { return red.rgController.IsDirWest();}

			public T GetComponent<T>() where T : Component { return red.GetComponent<T>();}
		}
	}
}