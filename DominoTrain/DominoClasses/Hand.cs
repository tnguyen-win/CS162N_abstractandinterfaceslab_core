using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominoClasses {
	public class Hand {
		protected List<Domino> dominoes;

		public int numDominoes {
			get => dominoes.Count;
		}

		public void AddDomino(Domino c) {
			dominoes.Add(c);
		}

		public Domino Discard(int i) {
			Domino c = GetDomino(i);

			dominoes.RemoveAt(i);

			return c;
		}

		public Domino GetDomino(int i) {
			return dominoes[i];
		}

		public Hand() {
			dominoes = new List<Domino>();
		}

		public Hand(Deck d, int numDominoes) {
			dominoes = new List<Domino>();

			for (var i = 0; i < numDominoes; i++) AddDomino(d[i]);
		}

		public bool HasDomino(Domino c) {
			return IndexOf(c) != -1;
		}

		public bool HasDomino(int v) {
			return GetDomino(v).Side1 == v;
		}

		public bool HasDomino(int s, int v) {
			return IndexOf(s, v) != -1;
		}

		public int IndexOf(Domino c) {
			return dominoes.IndexOf(c);
		}

		public int IndexOf(int v) {
			return dominoes.IndexOf(dominoes[v]);
		}

		public int IndexOf(int s, int v) {
			foreach (Domino c in dominoes) if (c.Side1 == s) if (c.Side2 == v) return dominoes.IndexOf(c);

			return -1;
		}

		public override string ToString() {
			string output = "";

			foreach (Domino c in dominoes) output += $"{c}\n";

			return output;
		}
	}
}