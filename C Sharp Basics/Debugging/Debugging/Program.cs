namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string>() { "frank", "joe", "michelle", "andy", "maria", "carlos", "angelina" };
            var partyFriends = GetPartyFriends(null,10);
            foreach (var name in partyFriends)
            {
                Console.WriteLine(name);
            }
            /*Console.WriteLine("_____________________________");
            Console.WriteLine();*/
           /* foreach(var name in friends)
            {
                Console.WriteLine(name);
            }*/
            Console.ReadKey();
        }
       

        static List<string> GetPartyFriends(List<string> list,int Count)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list", "argument cant be null.");
            }
            var buffer = new List<string>(list);
            //created a copy of list as removing elements from original friends list would be risky as we would be removing the actucal value as it is pass by reference..
            var partyFriends = new List<string>();
           
            if (Count > list.Count)
                throw new ArgumentOutOfRangeException("list", "count is greater than the number of elements in the list.");
            while (partyFriends.Count < Count) {
                string currentFriend = GetPartyFriend(buffer);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
            }
            return partyFriends;
        }
        static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
           for(int i =0; i< list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
           return shortestName;
        }
    }
}
