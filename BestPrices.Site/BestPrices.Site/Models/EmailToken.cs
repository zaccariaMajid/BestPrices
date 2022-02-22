using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPrices.Site.Models
{
    public class EmailToken
    {
        public string Id { get; set; }
        public string IdUser { get; set; }
        public DateTime Date { get; set; }
        public string Token { get; set; }
    }
    public class TokenMaker
    {
        public TokenMaker()
        {
            _chars = new char[]
            {
                'A', 'B', 'C', 'E', 'F', 'G', 'H', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            _random = new Random((int)DateTime.Now.Ticks);
        }
        private char[] _chars { get; set; }
        private Random _random { get; set; }
        private int _cycles = 6;
        public string GetToken()
        {
            string toReturn = default;
            for(int x = 0; x<_cycles; x++)
            {
                toReturn = toReturn + _chars[_random.Next(_chars.Length - 1)];
            }
            return toReturn;
        }
    }
}
