using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses {
	public class PaperTrain : Train {
		private Hand hand;
		bool open;

		public bool isOpen() => open;

		public void Close() => open = false;

		public override bool IsPlayable(Hand h, Domino d, out bool mustFlip) => IsPlayable(d, out mustFlip);

		public void Open() => open = true;

		public PaperTrain(Hand h) => hand = h;

		public PaperTrain(Hand h, int engineValue) {
			hand = h;
			EngineValue = engineValue;
		}
	}
}