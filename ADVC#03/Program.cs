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

            #region Exercise03
            //// 1. Create Phone Book

            //Dictionary<string, string> phoneBook =
            //    new Dictionary<string, string>();

            //phoneBook.Add("Ahmed", "01011111111");
            //phoneBook.Add("Sara", "01022222222");
            //phoneBook.Add("Ali", "01033333333");
            //phoneBook.Add("Mona", "01044444444");


            //// 2. Add new contact using [] syntax

            //phoneBook["Omar"] = "01055555555";


            //// 3. Try adding duplicate using Add()

            //try
            //{
            //    phoneBook.Add("Ahmed", "01099999999");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Add Error: " + ex.Message);
            //}


            //// 4. Try adding duplicate using TryAdd()

            //bool added = phoneBook.TryAdd("Ahmed", "01099999999");

            //Console.WriteLine($"TryAdd succeeded: {added}");


            //// 5. Search for a contact that doesn't exist

            //bool found = phoneBook.ContainsKey("Youssef");

            //Console.WriteLine($"Youssef exists: {found}");


            //// 6. Get contact with fallback

            //string phone =
            //    phoneBook.GetValueOrDefault("Youssef", "Not Found");

            //Console.WriteLine($"Youssef phone: {phone}");


            //// 7. Print all Keys on one line

            //Console.WriteLine("\nKeys:");

            //foreach (string key in phoneBook.Keys)
            //{
            //    Console.Write(key + " ");
            //}


            //// Print all Values on another line

            //Console.WriteLine("\n\nValues:");

            //foreach (string value in phoneBook.Values)
            //{
            //    Console.Write(value + " ");
            //}

            #endregion

            #region Exercise04

            // 1. Create HashSet with case-insensitive comparer
         
            //HashSet<string> emails =
            //    new HashSet<string>(
            //        StringComparer.OrdinalIgnoreCase
            //    );
         
         
            //// 2. Add emails
         
            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");
         
         
            //// 3. Print Count
         
            //Console.WriteLine($"Email Count: {emails.Count}");
         
            //Console.WriteLine(
            //    "Ahmed and ahmed are considered the same."
            //);
         
            //Console.WriteLine(
            //    "Sara and sara are considered the same."
            //);
         
         
            //// 4. Create Set A and Set B
         
            //HashSet<int> setA =
            //    new HashSet<int> { 1, 2, 3, 4, 5 };
         
            //HashSet<int> setB =
            //    new HashSet<int> { 4, 5, 6, 7, 8 };
         
         
            //// Union
         
            //HashSet<int> union = new HashSet<int>(setA);
         
            //union.UnionWith(setB);
         
            //Console.WriteLine("\nUnion:");
         
            //foreach (int number in union)
            //{
            //    Console.Write(number + " ");
            //}
         
         
            //// Intersection
         
            //HashSet<int> intersection = new HashSet<int>(setA);
         
            //intersection.IntersectWith(setB);
         
            //Console.WriteLine("\n\nIntersection:");
         
            //foreach (int number in intersection)
            //{
            //    Console.Write(number + " ");
            //}
         
         
            //// Except
         
            //HashSet<int> except = new HashSet<int>(setA);
         
            //except.ExceptWith(setB);
         
            //Console.WriteLine("\n\nExcept:");
         
            //foreach (int number in except)
            //{
            //    Console.Write(number + " ");
            //}
         
         
            //// 6. IsSubsetOf
         
            //HashSet<int> subset =
            //    new HashSet<int> { 1, 2 };
         
            //bool isSubset = subset.IsSubsetOf(setA);
         
            //Console.WriteLine(
            //    $"\n\n{{1, 2}} is subset of Set A: {isSubset}"
            //    );
            //}
            #endregion

}
    }
}
