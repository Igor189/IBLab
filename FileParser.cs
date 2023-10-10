using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLab1
{
    public static class FileParser
    {
        public static List<User> Parse(MemoryStream memoryStream)
        {
            List<User> users = new List<User>();

            using (StreamReader r = new StreamReader(memoryStream, leaveOpen: true))
            {
                memoryStream.Position = 0;

                while (!r.EndOfStream)
                {
                    var line = r.ReadLine();
                    string[] columns = line.Split(' ');
                    users.Add(new User(columns[0], columns[1], bool.Parse(columns[2]), bool.Parse(columns[3])));
                }
            }

            return users;
        }
    }
}
