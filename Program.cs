using System;

namespace MedicalNarrative
{
	internal class Program
	{
		static void Main()
		{


			Console.WriteLine("What is the gender of your Pt?");
			String gender = Console.ReadLine();

			Console.WriteLine("what postition was the Pt in?");
			var pos = Console.ReadLine();

			Console.WriteLine("How old is your Pt?");
			var age = Console.ReadLine();

			Console.WriteLine("What is your Pt complaing of?");
			string complaint = Console.ReadLine();

			Console.WriteLine("how long has the Pt been complaing of this?");
			var timeComplaint = Console.ReadLine();

			Console.WriteLine("What is the Pts medical Hx?");
			string Hx = Console.ReadLine();

			Console.WriteLine("what allergies does the Pt have? if none reply no allergies");
			string allergies = Console.ReadLine();

			Console.WriteLine("Is the Pt on any medication? if no medication say no medications");
			string meds = Console.ReadLine();

			Console.WriteLine("What were the Pts vital signs?");
			var vitals = Console.ReadLine();

			Console.WriteLine($"A- AOSTF {gender} Pt {pos} the Pt was {age}years old.");
			Console.WriteLine($"C- PT was complaing of {complaint} for {timeComplaint}");
			Console.WriteLine($"H- PT stated that they have {allergies}, and Hx of {Hx} and is on {meds}");
			Console.WriteLine($"A- PT was Given a Rapid physical assessment and a vitals assessment. Pt also had a 12lead EKG performed and BGL assessment. Vitals were as follows {vitals}");
			Console.WriteLine($"R- PT was assissted onto the stretcher and into the back of the ambulance.");
			Console.WriteLine($"T- PT was transported to CRMC by CEMS R-2 is back in service!");

		}
	}
}
