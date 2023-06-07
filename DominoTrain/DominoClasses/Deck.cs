using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses {
	public class Deck {
		private readonly List<Domino> dominoes = new List<Domino>();

		public Deck() {
			for (int value = 1; value <= 13; value++) for (int suit = 1; suit <= 4; suit++) dominoes.Add(new Domino(suit, value));
		}

		public int NumCards {
			get => dominoes.Count;
		}

		public bool IsEmpty {
			get => (dominoes.Count == 0);
		}

		public Domino this[int i] {
			get => dominoes[i];
		}

		public Domino Deal() {
			if (!IsEmpty) {
				Domino c = dominoes[0];

				dominoes.Remove(c);

				return c;
			}

			return null;
		}

		public void Shuffle() {
			Random gen = new Random();

			for (int i = 0; i < NumCards; i++) {
				int rnd = gen.Next(0, NumCards);

				Domino c = dominoes[rnd];

				dominoes[rnd] = dominoes[i];
				dominoes[i] = c;
			}
		}

		public override string ToString() {
			string output = "";

			foreach (Domino c in dominoes) output += $"{c}\n";

			return output;
		}
	}
}