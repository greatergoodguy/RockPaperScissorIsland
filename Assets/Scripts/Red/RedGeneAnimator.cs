using UnityEngine;
using System.Collections;

namespace RPSIsland.Red {

	public class RedGeneAnimator : RedGene_Base {

		const int DIR_NORTH = 2;
		const int DIR_SOUTH = 0;
		const int DIR_EAST = 3;
		const int DIR_WEST = 1;

		private MoBoRed.Handler handler;
		private Animator animator;

		public RedGeneAnimator(MoBoRed.Handler handler) {
			this.handler = handler;

			animator = handler.GetComponent<Animator>();
		}

		public override void Update () {
			if (handler.IsDirNorth()) {
				animator.SetInteger("Direction", DIR_NORTH);
			}
			else if (handler.IsDirSouth()) {
				animator.SetInteger("Direction", DIR_SOUTH);
			}
			else if (handler.IsDirEast()) {
				animator.SetInteger("Direction", DIR_EAST);
			}
			else if (handler.IsDirWest()) {
				animator.SetInteger("Direction", DIR_WEST);
			}
		}

	}
}