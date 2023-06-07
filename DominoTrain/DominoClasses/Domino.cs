using System;

namespace DominoClasses {
	//public abstract class Domino : IComparable<Domino> {
	public class Domino {
		private int side1;
		private int side2;

		public int Side1 {
			get => side1;
			set {
				if (value >= 0 && value <= 12) side1 = value;
				else throw new ArgumentException("Value must be between 0 and 12.");
			}
		}

		public int Side2 {
			get => side2;
			set {
				if (value >= 0 && value <= 12) side2 = value;
				else throw new ArgumentException("Value must be between 0 and 12.");
			}
		}

		public Domino() {
			Side1 = 0;
			Side2 = 0;
		}

		public Domino(int p1, int p2) {
			Side1 = p1;
			Side2 = p2;
		}

		public void Flip() {
			int temp = side1;

			side1 = side2;
			side2 = temp;
		}

		public int Score {
			get => side1 + side2;
		}

		public bool IsDouble() {
			return side1 == side2;
		}

		public override string ToString() {
			return string.Format($"Side 1: {side1} | Side 2: {side2}");
		}

		//public int CompareTo(Domino other) {
		//	return string.Compare(this.Score, other.Score, StringComparison.OrdinalIgnoreCase);
		//	return other.Score;
		//}
	}
}