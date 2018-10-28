// Procedural programming, getting the smallest from a list of numbers 
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2,3,4,5,6};
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater that the number in the list");
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(list);
                smallests.Add(min);
                list.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
      
    }
}

/// <summary>
/// Write a program and ask the user to enter a few words separated by a space. Use the words to 
/// create a variable name with PascalCase convention. For example, if the user types: 
/// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
/// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
/// "NumberOfStudents". If the user doesn't supply any words, display "Error".
/// </summary>
class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();
            var result = GetVariableName(input);
            Console.WriteLine(result);

        }

        public static string GetVariableName(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
                return "";

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            return variableName;
        }

    }
	
/// <summary>
/// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
/// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
/// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
/// </summary>

 class Program
{
	static void Main(string[] args)
	{
		Console.Write("Enter time: ");
		var input = Console.ReadLine();
		var result = IsValidTime(input);
		Console.WriteLine(result);
	}

	public static bool IsValidTime(string time)
	{
		if (String.IsNullOrWhiteSpace(time))
			return false;

		var components = time.Split(':');
		if (components.Length != 2)
			return false;

		try
		{
			var hour = Convert.ToInt32(components[0]);
			var minute = Convert.ToInt32(components[1]);

			return (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59);
		}
		catch (Exception)
		{
			return false;
		}
	}


}

/// <summary>
/// Write a program and ask the user to enter an English word. Count the number of vowels 
/// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
/// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
/// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
/// </summary>

 class Program
{
	static void Main(string[] args)
	{
		Console.Write("Enter a word: ");
		var input = Console.ReadLine().ToLower();
		var result = CountVowels(input);
		Console.WriteLine(result);

	}

	public static int CountVowels(string word)
	{
		var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });
		var vowelsCount = 0;

		// Note the ToLower() here. This is used to count for both A and a. 
		foreach (var character in word.ToLower())
		{
			if (vowels.Contains(character))
				vowelsCount++;
		}

		return vowelsCount;
	}

}
