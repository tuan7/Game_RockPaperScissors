﻿using System;
namespace Game_RockPaperScissors
{
	public class RockPaperScissors
	{
		
		private string userA;
		private int userA_val;
		private int totalScoreA = 0;
		private string userB;
		private int userB_val;
		private int totalScoreB = 0;


		public void SetUserA(string user_a)
		{
			this.userA = user_a;
		}


		public void SetUserB(string user_b)
		{
			this.userB = user_b;
		}

		public void SetUserA_val(int enterVal) {
			this.userA_val = enterVal;
		}

		public void SetUserB_val(int enterVal)
		{
			this.userB_val = enterVal;
		}

		public int GetScoreA() {
			return this.totalScoreA;
		}

		public int GetScoreB()
		{
			return this.totalScoreB;
		}

		public void StartGame()
		{
			switch (this.userA_val)
			{
				//user A input
				case 1: //user A choose paper
					switch (this.userB_val)
					{
						case 1: //user B choose paper
							Console.WriteLine(this.userA + ": Paper");
							Console.WriteLine(this.userB + ": Paper");
							Console.WriteLine("Draw");
							break;
						case 2: //user B choose stone
							Console.WriteLine(this.userA + ": Paper");
							Console.WriteLine(this.userB + ": Stone");
							Console.WriteLine(this.userA + " won! " + this.userB + " lost");
							this.totalScoreA +=1;
							Console.WriteLine(this.userA + " scores: " + this.totalScoreA);
							break;
						case 3: //user B choose scissors
							Console.WriteLine(this.userA + ": Paper");
							Console.WriteLine(this.userA + ": Scissors");
							Console.WriteLine(this.userB + " won! " + this.userA + " lost");
							this.totalScoreB +=1;
							Console.WriteLine(this.userB + " scores: " + this.totalScoreB);
							break;
					}
					break;

				case 2: //user A choose stone
					switch (this.userB_val)
					{
						case 1: //user B choose paper
							Console.WriteLine(this.userA + ": Stone");
							Console.WriteLine(this.userB + ": Paper");
							Console.WriteLine(this.userB + " won! " + this.userA + " lost");
							this.totalScoreB +=1;
							Console.WriteLine(this.userB + " scores: " + this.totalScoreB);
							break;
						case 2: //user B choose stone
							Console.WriteLine(this.userA + ": Stone");
							Console.WriteLine(this.userB + ": Stone");
							Console.WriteLine("Draw");
							break;
						case 3: //user B choose scissors
							Console.WriteLine(this.userA + ": Stone");
							Console.WriteLine(this.userB + ": Scissors");
							Console.WriteLine(this.userA + " won! " + this.userB + " lost");
							this.totalScoreA +=1;
							Console.WriteLine(this.userA + " scores: " + this.totalScoreA);
							break;
					}
					break;

				case 3: //user A choose scissors
					switch (this.userB_val)
					{
						case 1: //user B choose paper
							Console.WriteLine(this.userA + ": Scissors");
							Console.WriteLine(this.userB + ": Paper");
							Console.WriteLine(this.userB + " won! " + this.userA + " lost");
							this.totalScoreB +=1;
							Console.WriteLine(this.userB + " scores: " + this.totalScoreB);
							break;
						case 2: //user B choose stone
							Console.WriteLine(this.userA + ": Scissors");
							Console.WriteLine(this.userB + ": Stone");
							Console.WriteLine(this.userB + " won! " + this.userA + " lost");
							this.totalScoreB +=1;
							Console.WriteLine(this.userB + " scores: " + this.totalScoreB);
							break;
						case 3: //user B choose scissors
							Console.WriteLine(this.userA + ": Scissors");
							Console.WriteLine(this.userB + ": Scissors");
							Console.WriteLine("Draw");
							break;
					}
					break;

			}
		}
	}
}
