using System;
using System.Linq;

namespace Mod2_JoinOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var records = DataLoader.Load(@"./");
            var maleTop5 = records
                .Where(r => r.Gender == Gender.Male && r.Rank <= 5);
            var femaleTop5 = records
                .Where(r => r.Gender == Gender.Female && r.Rank <= 5);

            var result = Enumerable.Join(
                    maleTop5, femaleTop5,
                    r => r.Rank, r => r.Rank,
                    (mr, fr) => (Rank: mr.Rank, Male: mr.Name, Female: fr.Name)
                 );
            var result2 = from mr in maleTop5
                          join fr in femaleTop5
                          on mr.Rank equals fr.Rank
                          select (Rank: mr.Rank, Male: mr.Name, Female: fr.Name);

            System.Console.WriteLine("-------------Join-------------\n");
            System.Console.WriteLine($"Rank\tMale\tFemale");
            foreach (var item in result)
            {
                System.Console.WriteLine($"{item.Rank}\t{item.Male}\t{item.Female}");
            }

            var maleTop20 = records
                .Where(r => r.Gender == Gender.Male && r.Rank <= 20);
            var alphabet = Enumerable.Range('A', 26).Select(e => (char)e);

            var result3 = Enumerable.GroupJoin(
                alphabet, maleTop20,
                c => c, r => r.Name[0],
                (c, g) => (Start: c, Names: String.Join(",", g.Select(r => r.Name)))
             );

            var result4 = from c in alphabet
                          join r in maleTop20
                          on c equals r.Name[0] into g
                          select (Start: c, Names: String.Join(",", g.Select(r => r.Name)));

            System.Console.WriteLine("\n-------------GroupJoin-------------\n");
            foreach (var item in result3)
            {
                Console.WriteLine($"{item.Start}: {item.Names}");
            }
        }
    }
}
