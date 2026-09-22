namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01
            //// 1. Create Collection
            //List<int> grades = new List<int>
            //{
            //    85, 92, 78, 95, 88, 70, 100, 65
            //};


            //// 2. Print Collection, Count, First and Last

            //Console.WriteLine("Grades:");

            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades.First()}");
            //Console.WriteLine($"Last Grade: {grades.Last()}");


            //// 3. Sort Ascending

            //grades.Sort();

            //Console.WriteLine("\nSorted Grades:");

            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Console.WriteLine();


            //// 4. First Grade Above 90

            //int firstAbove90 = grades.First(grade => grade > 90);

            //Console.WriteLine($"\nFirst grade above 90: {firstAbove90}");


            //// 5. All Grades Below 75

            //List<int> failingGrades =
            //    grades.Where(grade => grade < 75).ToList();

            //Console.WriteLine("\nFailing Grades:");

            //foreach (int grade in failingGrades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Console.WriteLine();


            //// 6. Remove All Failing Grades

            //grades.RemoveAll(grade => grade < 75);

            //Console.WriteLine("\nGrades after removing failing grades:");

            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Console.WriteLine();


            //// 7. Check if Any Grade Equals 100

            //bool has100 = grades.Any(grade => grade == 100);

            //Console.WriteLine($"\nContains grade 100: {has100}");


            //// 8. Create List<string>

            //List<string> gradeStrings =
            //    grades.Select(grade => $"Grade: {grade}").ToList();

            //Console.WriteLine("\nGrade Strings:");

            //foreach (string grade in gradeStrings)
            //{
            //    Console.WriteLine(grade);
            //}
            #endregion

            #region Exercise02  
            //// 1. Create Leaderboard
            //SortedDictionary<int, string> leaderboard =
            //    new SortedDictionary<int, string>();
         
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");
         
         
            //// 2. Print all entries
         
            //Console.WriteLine("Leaderboard:");
         
            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine($"Score: {player.Key} - Player: {player.Value}");
            //}
         
         
            //// 3. Access first key and first value
         
            //int firstKey = leaderboard.Keys.First();
         
            //string firstValue = leaderboard.Values.First();
         
            //Console.WriteLine($"\nFirst Score: {firstKey}");
            //Console.WriteLine($"First Player: {firstValue}");
         
         
            //// 4. Check if score 500 exists
         
            //bool exists = leaderboard.ContainsKey(500);
         
            //Console.WriteLine($"\nScore 500 exists: {exists}");
         
         
            //// 5. Safely get player with score 999
         
            //if (leaderboard.TryGetValue(999, out string playerName))
            //{
            //    Console.WriteLine($"Player with score 999: {playerName}");
            //}
            //else
            //{
            //    Console.WriteLine("No player found with score 999.");
            //}
         
         
            //// 6. Remove score 200
         
            //leaderboard.Remove(200);
         
            //Console.WriteLine("\nLeaderboard after removing score 200:");
         
            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine($"Score: {player.Key} - Player: {player.Value}");
            //}
    
            #endregion

}
    }
}
