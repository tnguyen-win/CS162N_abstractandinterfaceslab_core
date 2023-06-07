using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses {
	public class MexicanTrain : Train {
		public override void IsPlayable() {
			throw new NotImplementedException();
		}

		//public override bool IsPlayable(Hand h, Domino d, out bool mustFlip) {

		//}

		public MexicanTrain() : base() { }

		public MexicanTrain(int engineValue) : base(engineValue) { }
	}
}