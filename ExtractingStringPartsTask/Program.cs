namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";
            
            // output the length of state
            Console.WriteLine(state.Length);

            // Concatenate the contents of city and landmark * don't forget to add a space
            string citylandmark = city + " " + landmark;

            // output the first character of country
            Console.WriteLine(country[0]);

            // output a concatenation of the first and last characters of city
            Console.WriteLine(city[0] + city[city.Length - 1]);

            // output the substring of landmark starting at c and outputting to the end
            Console.WriteLine(landmark.Substring(2,landmark.Length - 2));  ///dont forget its the start index and the (desired) LENGTH of the substring, not the 'end index'

            // output the substring of country starting at the first S and ending at the first A
            Console.WriteLine(country.Substring(7, 3));

            // output the position of f in California
            Console.WriteLine(state.IndexOf('f'));

           
            //************CHALLENGE****************//
            // Output how many vowels are in each of the strings in the format
            // California has n vowels
            string country2 = country.ToLower(); // Convert to lowercase for case-insensitive comparison
            string state2 = state.ToLower();
            string city2 = city.ToLower();
            string landmark2 = landmark.ToLower();
            ///char[] vowels = { 'a', 'e', 'i', 'o', 'u' }; // Array of vowels???
            char a = 'a';
            char e = 'e';
            char i = 'i';
            char o = 'o';
            char u = 'u';
           
            int vowelCount = 0;
            for (int y = 0; y < country2.Length; y++)
            {
                if (country2[i] == a || country2[i] == e || country2[i] == i || country2[i] == o || country2[i] == u)
                {
                    vowelCount = vowelCount + 1;
                }
                y = y + 1;
            }
            Console.WriteLine(country + " has " + vowelCount + " vowels");


            vowelCount = 0;
            for (int y = 0; y < state2.Length; y++)
            {
                if (state2[i] == a || state2[i] == e || state2[i] == i || state2[i] == o || state2[i] == u)
                {
                    vowelCount = vowelCount + 1;
                }
                y = y + 1;
            }
            Console.WriteLine(state + " has " + vowelCount + " vowels");


            vowelCount = 0;
            for (int y = 0; y < city2.Length; y++)
            {
                if (city2[i] == a || city2[i] == e || city2[i] == i || city2[i] == o || city2[i] == u)
                {
                    vowelCount = vowelCount + 1;
                }
                y = y + 1;
            }
            Console.WriteLine(city + " has " + vowelCount + " vowels");


            vowelCount = 0;
            for (int y = 0; y < landmark2.Length; y++)
            {
                if (landmark2[i] == a || landmark2[i] == e || landmark2[i] == i || landmark2[i] == o || landmark2[i] == u)
                {
                    vowelCount = vowelCount + 1;
                }
                y = y + 1;
            }
            Console.WriteLine(landmark + " has " + vowelCount + " vowels");

            // Show your evidence of the program running in the Readme file
        }
    }
}
