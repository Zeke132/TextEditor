using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    public class UserInfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Power { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }
    public class User
    {

        public static List<UserInfo> list = new List<UserInfo>();
        public  static UserInfo CurrentUser { get; set; }

        public static void LoadFromFile(string fn)
        {
            list.Clear();
            var arr=File.ReadAllLines(fn, Encoding.UTF8);
            foreach (var line in arr)
            {
                if (string.IsNullOrEmpty(line)) continue;
                var infos=line.Split(new char[] { ','},StringSplitOptions.RemoveEmptyEntries);
                var usr = new UserInfo
                {
                    UserName = infos[0],
                    Password = infos[1],
                    Power = infos[2],
                    FirstName = infos[3],
                    LastName = infos[4],
                    Birthday = DateTime.ParseExact(infos[5], "dd-MM-yyyy", System.Globalization.CultureInfo.CurrentCulture)
                };
                list.Add(usr);
            }
        }
        public  static void SaveToFile(string fn)
        {
            if (File.Exists(fn)) File.Delete(fn);
            var lines = new List<string>();
            foreach (var item in list)
            {
                var str = item.UserName + ",";
                str+=item.Password + ",";
                str += item.Power + ",";
                str += item.FirstName + ",";
                str += item.LastName + ",";
                str += item.Birthday.ToString("dd-MM-yyyy");
                lines.Add(str);
            }
            File.WriteAllLines(fn, lines.ToArray());
            LoadFromFile("login.txt");
        }
        public static bool ValidUser(string name,string pwd)
        {
            var u=list.Where(p => p.UserName == name).Where(p => p.Password == pwd).FirstOrDefault();
            if(u==null) return false;
            else
            {
                CurrentUser = u;
                return true;
            }
        }
    }
}
