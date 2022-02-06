using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Hashmap.");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            ///Split converts paragraph  into array of sub strings.
            string[] para = paragraph.Split(' ');
            ///Creating reference of MyMapNode.
            MyMapNode<int, string> hash = new MyMapNode<int, string>(para.Length);
            int key = 0;
            ///foreach iterates on paragraph and adds key and value to hash.
            foreach (string word in para)
            {
                hash.Add(key, word);
                key++;
            }
            Console.WriteLine("Frequency :" + hash.GetFrequency("avoidable"));
            hash.RemoveValue("avoidable");
            Console.WriteLine("Frequency :" + hash.GetFrequency("avoidable"));

        }
    }
}
