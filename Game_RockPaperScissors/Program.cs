using System;

namespace Game_RockPaperScissors
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			RockPaperScissors play = new RockPaperScissors();

			Console.WriteLine("Enter your name");
			string participant_a = Console.ReadLine();
			play.SetUserA(participant_a);

			Console.WriteLine("Your friend's name");
			string participant_b = Console.ReadLine();
			play.SetUserB(participant_b);
			for (int i = 1; i < 10; i++) //it will be 10 games
			{
				Console.WriteLine(participant_a + ": Enter 1 for paper, 2 for rock, 3 for scissors");
				string user_A_Input = ReadPassword(); //get user A input (hidden text by using def. ReadPassword instead "Console.ReadLine()")
				int a = int.Parse(user_A_Input);

				Console.WriteLine(participant_b + ": Enter 1 for paper, 2 for rock, 3 for scissors");
				string user_B_Input = ReadPassword(); //get user B input (hidden text by using def. ReadPassword instead "Console.ReadLine()")
				int b = int.Parse(user_B_Input);


				play.SetUserA_val(a);
				play.SetUserB_val(b);
				play.StartGame();
			}

			Console.WriteLine("Game over!");
			Console.WriteLine(participant_a + ": " +play.GetScoreA());
			Console.WriteLine(participant_b + ": " +play.GetScoreB());
		}

		public static string ReadPassword()
		{
			string password = "";
			ConsoleKeyInfo info = Console.ReadKey(true);
			while (info.Key != ConsoleKey.Enter)
			{
				if (info.Key != ConsoleKey.Backspace)
				{
					Console.Write("*");
					password += info.KeyChar;
				}
				else if (info.Key == ConsoleKey.Backspace)
				{
					if (!string.IsNullOrEmpty(password))
					{
						// remove one character from the list of password characters
						password = password.Substring(0, password.Length - 1);
						// get the location of the cursor
						int pos = Console.CursorLeft;
						// move the cursor to the left by one character
						Console.SetCursorPosition(pos - 1, Console.CursorTop);
						// replace it with space
						Console.Write(" ");
						// move the cursor to the left by one character again
						Console.SetCursorPosition(pos - 1, Console.CursorTop);
					}
				}
				info = Console.ReadKey(true);
			}

			// add a new line because user pressed enter at the end of their password
			Console.WriteLine();
			return password;
		}
	}
}


