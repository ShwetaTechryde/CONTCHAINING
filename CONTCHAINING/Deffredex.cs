
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ क्वेरी बनाना: 5 से बड़े नंबर निकालने के लिए
        var query = from num in numbers
                    where num ==5
                    select num;
        Console.WriteLine("क्वेरी बन गई, लेकिन अभी execute नहीं हुई।");

        // अब क्वेरी को execute करने के लिए foreach लूप चलाना
        Console.WriteLine("5 से बड़े नंबर:");
        foreach (var number in query)
        {
            Console.WriteLine(number);
        }
    }
}
//Notes: Conlusion:

//Once a query is defined, it can be executed multiple times
//Before the query is executed, the data source may change
//Full list of deferred LINQ operations, typically these operations return an IEnumerable<T> or IOrderedEnumerable<T> object:

//AsEnumerable
//Cast
//Concat
//DefaultIfEmpty
//Distinct
//Except
//GroupBy
//GroupJoin
//Intersect
//Join
//OfType
//OrderBy
//OrderByDescending
//Range
//Repeat
//Reverse
//Select
//SelectMany
//Skip
//SkipWhile
//Take
//TakeWhile
//ThenBy
//ThenByDescending
//Union
//Where