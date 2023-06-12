using System;
using DominoClasses;
using System.ComponentModel;

namespace DominoTrain {
	class Program {
		static void DisplayTemplate(string instructions, string init, string expected, string got, bool end) {
			if (instructions != "") Console.WriteLine($"[{instructions}]");
			if (init != "") Console.WriteLine($"Before - [{init}].");
			if (expected != "") Console.WriteLine($"Expecting - [{expected}].");
			if (got != "") Console.WriteLine($"After - [{got}].");

			Console.WriteLine(end ? "" : "\n");
		}

		static void Program1() {

			static void GetTrainLength() {
				Random r = new();
				Hand h = new();
				Train t = new PaperTrain(h, r.Next(0, 6));

				for (var i = 0; i < 7; i++) {
					Domino d = new(r.Next(0, 6), r.Next(0, 6));

					t.Add(d);
				}

				DisplayTemplate("get the count of the dominos in the Train", $"\n{t}", "7", t.Count.ToString(), false);
			}

			static void GetTrainEngineValue() {
				Random r = new();
				Hand h = new();
				Train t = new PaperTrain(h, r.Next(0, 6));

				int v = t.EngineValue;

				t.EngineValue = 22;

				DisplayTemplate("get the engine value for the Train", v.ToString(), "22", t.EngineValue.ToString(), false);
			}

			static void CheckTrainIsEmpty() {
				Random r = new();
				Hand h = new();
				Train t = new PaperTrain(h, r.Next(0, 6));

				for (var i = 0; i < 7; i++) {
					Domino d = new(r.Next(0, 6), r.Next(0, 6));

					t.Add(d);
				}

				DisplayTemplate("determine whether the Train is empty or contains dominos", $"\n{t}", "False", t.IsEmpty.ToString(), false);
			}

			static void GetLastTrainDomino() {
				Random r = new();
				Hand h = new();
				Train t = new PaperTrain(h, r.Next(0, 6));

				for (var i = 0; i < 7; i++) {
					Domino d = new(r.Next(0, 6), r.Next(0, 6));

					t.Add(d);
				}

				DisplayTemplate("get the last domino object in the Train", $"\n{t}", "Last domino in train list", t.LastDomino.ToString(), false);
			}

			static void GetSecondTrainSideValue() {
				Random r = new();
				Hand h = new();
				Train t = new PaperTrain(h, r.Next(0, 6));
				Domino d2 = new(r.Next(0, 6), r.Next(0, 6));
				bool mustFlip = true;

				for (var i = 0; i < 7; i++) {
					Domino d = new(r.Next(0, 6), r.Next(0, 6));

					t.Add(d);
				}

				string playableValue = t.IsPlayable(h, d2, out mustFlip) ? d2.Side2.ToString() : "N/A";

				DisplayTemplate("get the side 2 value of the last domino or the playable value for the Train", $"\n{t}Test playable domino - {d2}\n", "Side 2 value for last domino and the playable domino in train list", $"\nLast domino side 2 value - {t.LastDomino.Side2}\nPlayable domino side 2 value - {playableValue}\n", false);
			}

			static void GetTrainDominoByIndex() {
				Random r = new();
				Hand h = new();
				Train t = new PaperTrain(h, r.Next(0, 6));

				for (var i = 0; i < 7; i++) {
					Domino d = new(r.Next(0, 6), r.Next(0, 6));

					t.Add(d);
				}

				DisplayTemplate("get a domino object based on its position or index in the Train", $"\n{t}", "Domino at index 2", t[2].ToString(), false);
			}

			static void CheckDominoIsPlayable() {
				Random r = new();
				Hand h = new();
				Train t = new PaperTrain(h, r.Next(0, 6));
				Domino d2 = new(r.Next(0, 6), r.Next(0, 6));
				bool mustFlip = true;

				for (var i = 0; i < 7; i++) {
					Domino d1 = new(r.Next(0, 6), r.Next(0, 6));

					t.Add(d1);
				}

				DisplayTemplate("determine if a specific domino is playable on the Train and if it must be flipped in order to be played", $"\n{t}Test playable domino - {d2}\n", "\nExpected true and/or false values", $"\nIs playable - {t.IsPlayable(h, d2, out mustFlip)}\nRequires a flip - {mustFlip}\n", false);
			}

			//static void PlayDomino() {

			//}

			static void DisplayTrainAttributes() {
				Random r = new();
				Hand h = new();
				Train t = new PaperTrain(h, r.Next(0, 6));
				string s = "";

				for (var i = 0; i < 7; i++) {
					Domino d = new(r.Next(0, 6), r.Next(0, 6));

					t.Add(d);
				}

				for (var i = 0; i < TypeDescriptor.GetProperties(t).Count; i++) {
					if (i == 0) s += "\n";

					s += $"{TypeDescriptor.GetProperties(t)[i].Name} = {TypeDescriptor.GetProperties(t)[i].GetValue(t)}\n";
				}

				DisplayTemplate("convert its attributes to a string for displaying on the screen", $"\n{t}", "\nCount = 7\nEngineValue = {engine value}\nIsEmpty = False\nLast Domino = Side 1: {side1 value} | Side 2: {side 2 value}\nPlayableValue = {playable value}\n", s, true);
			}

			// get the count of the dominos in the Train
			GetTrainLength();

			// get the engine value for the Train
			GetTrainEngineValue();

			// determine whether the Train is empty or contains dominos
			CheckTrainIsEmpty();

			// get the last domino object in the Train
			GetLastTrainDomino();

			// get the side 2 value of the last domino or the playable value for the Train
			GetSecondTrainSideValue();

			// get a domino object based on its position or index in the Train
			GetTrainDominoByIndex();

			// determine if a specific domino is playable on the Train and if it must be flipped in order to be played
			CheckDominoIsPlayable();

			// play a specific domino from a specific hand on the Train.  This should generate an error if the domino is not playable
			//PlayDomino();

			// convert its attributes to a string for displaying on the screen
			DisplayTrainAttributes();
		}

		static void Program2() {

		}

		static void Program3() {

		}

		static void Main() {
			Program1();
			//Program2();
			//Program3();
		}
	}
}