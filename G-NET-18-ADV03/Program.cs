namespace G_NET_18_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01
            // task 01
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First Grade: {grades.First()}");
            //Console.WriteLine($"Last Grade: {grades.Last()}");

            //grades.Sort();
            //Console.WriteLine("\nSorted Grades:");
            //Console.WriteLine(string.Join(", ", grades));

            //Console.WriteLine($"First grade above 90: {grades.Find(g => g > 90)}");

            //var gradesBelow75 = grades.FindAll(g => g < 75);
            //Console.WriteLine(string.Join(", ", gradesBelow75));

            //var removingFailing = grades.RemoveAll(g => g < 75);
            //Console.WriteLine($"After removing failing grades: {string.Join(", ", removingFailing)}");

            //var equal100 = grades.Any(g => g == 100);
            //Console.WriteLine($"Contains grade 100: {equal100}");

            ////List<string> gradeStrings = new List<string>();
            ////foreach (var item in grades)
            ////{
            ////    gradeStrings.Add($"Grade: {item}");
            ////}

            //List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();

            //foreach (var item in gradeStrings)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exercise02
            //SortedList<int, string> leaderboard = new()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona",
            //};

            //foreach (var item in leaderboard)
            //{
            //    Console.WriteLine($"Score: {item.Key}, Player: {item.Value}");
            //}

            //Console.WriteLine($"First key: {leaderboard.First().Key} , First value: {leaderboard.First().Value}");

            //Console.WriteLine(leaderboard.ContainsKey(5000));

            //if (leaderboard.TryGetValue(999 , out string player999))
            //{
            //    Console.WriteLine($"Player with score 999: {player999}");
            //}
            //else
            //{
            //    Console.WriteLine("Score 999 not found.");
            //}

            //leaderboard.Remove(200);
            //Console.WriteLine("\nUpdated Leaderboard:");
            //foreach (var item in leaderboard)
            //{
            //    Console.WriteLine($"Score: {item.Key}, Player: {item.Value}");
            //}
            #endregion

        }
    }
}
