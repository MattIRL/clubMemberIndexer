namespace clubMemberIndexer
{

    internal class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }

            //indexer get and set methods
            public string this[int index]
            {
                get

                {
                    string tmp;
                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }
                    return (tmp);
                }

                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        Members[index] = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            ClubMembers club = new ClubMembers();

            club.ClubType = "SNL Season 1 Cast";
            club.ClubLocation = "New York City";
            club.MeetingDate = "Saturday Night";

            club[0] = "Dan Aykroyd";
            club[1] = "John Belushi";
            club[2] = "Chevy Chase";
            club[3] = "George Coe";
            club[4] = "Jane Curtin";
            club[5] = "Garrett Morris";
            club[6] = "Laraine Newman";
            club[7] = "Michael O'Donoghue";
            club[8] = "Gilda Radner";

            Console.WriteLine($"Club Type: {club.ClubType}");
            Console.WriteLine($"Location: {club.ClubLocation}");
            Console.WriteLine($"Meetings: {club.MeetingDate}");
            Console.WriteLine($"\nClub Members:\n");

            for (int i = 0; i < Size; i++)
            {
                if (!string.IsNullOrEmpty(club[i]))
                {
                    Console.WriteLine(club[i]);
                }
            }
        }
    }
}
