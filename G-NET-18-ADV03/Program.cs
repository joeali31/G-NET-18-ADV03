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

            #region Exercise03
            //// Create a Collection  with 4 contacts
            //Dictionary<string, string> phoneBook = new()
            //{
            //    {"Ahmed", "01012345678"},
            //    {"Sara", "01198765432"},
            //    {"Ali", "01255555555"},
            //    {"Mona", "01544444444"}
            //};

            ////Add a new contact using [] syntax
            //phoneBook["Omar"] = "01287566947";

            //// Try adding a duplicate using .Add()
            //try
            //{
            //    phoneBook.Add("Mona" , "01287566974");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //// Try adding a duplicate using .TryAdd() 
            //Console.WriteLine($"TryAdd succeeded: {phoneBook.TryAdd("Mona", "01287566974")}");

            //// Search for a contact that doesn’t exist
            //Console.WriteLine($"Does exist? {phoneBook.ContainsKey("Ali")}");

            //// Get a contact with a fallback of "Not Found"
            //string res = phoneBook.ContainsKey("Ali") ? phoneBook["Ali"] : "Not found";
            //Console.WriteLine($"Ali's number: {res}");

            //// Print all Keys on one line, then all Values on another line
            //Console.WriteLine(string.Join(", " , phoneBook.Keys));
            //Console.WriteLine(string.Join(", ", phoneBook.Values));
            #endregion

            #region Exercise04
            //// Create a HashSet<string> with a case-insensitive comparer:
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //// Add these emails:
            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            //// Print Count
            //Console.WriteLine($"Count: {emails.Count}");

            //// Create two sets: Set A = {1,2,3,4,5} and Set B = {4,5,6,7,8}
            //HashSet<int> setA = new() { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new() { 4, 5, 6, 7, 8 };

            //HashSet<int> union = new HashSet<int>(setA);
            //union.UnionWith(setB);
            //Console.WriteLine($"Union With: {string.Join(", " , union)}");

            //HashSet<int> intersection = new HashSet<int>(setA);
            //intersection.IntersectWith(setB);
            //Console.WriteLine($"Union With: {string.Join(", ", intersection)}");

            //HashSet<int> except = new HashSet<int>(setA);
            //intersection.ExceptWith(setB);
            //Console.WriteLine($"Union With: {string.Join(", ", except)}");

            //HashSet<int> subset = new HashSet<int> { 1, 2};
            //bool isSubset = subset.IsSubsetOf(setA);
            //Console.WriteLine(isSubset);
            #endregion

        }
    }
}
