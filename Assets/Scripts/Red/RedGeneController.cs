using UnityEngine;
using System.Collections;

namespace RPSIsland.Red {

	public class RedGeneController : RedGene_Base {

		private const string TAG = "RedGeneController";

		public float Vertical { get; set;}
		public float Horizontal { get; set;}
	
		private MoBoRed.Handler handler;

		public RedGeneController(MoBoRed.Handler handler) {
			this.handler = handler;
		}

		public override void Update () {
			Vertical = Input.GetAxis("Vertical");
			Horizontal = Input.GetAxis("Horizontal");

			if(Input.GetKeyDown(KeyCode.UpArrow)) {
				UtilLogger.Log(TAG, "KeyDown UpArrow");
			}
		}

		public bool IsDirNorth() { return handler.GetVertical() > 0;}
		public bool IsDirSouth() { return handler.GetVertical() < 0;}
		public bool IsDirEast() { return handler.GetHorizontal() > 0;}
		public bool IsDirWest() { return handler.GetHorizontal() < 0;}
	}

}