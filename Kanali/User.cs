using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Kanali
{
    // Contains the settings the user will define in the settings tab
    public class User
    {
        public String download_path { get; set; }
        public Boolean media_scrolling { get; set; }
        public Boolean can_download { get; set; }
        public Boolean initialized = false;
        String filename = "Preferences.json";
        public User()
        {
            if (File.Exists(filename))
            {
                this.initialized = true;
            }

        }

        // Writes over existing json, makes new instance
        public void createJson(User usr)
        {
            String jsonString = JsonSerializer.Serialize(usr);
            File.WriteAllText(filename, jsonString);

            Console.WriteLine(File.ReadAllText(filename));
        }

        // Returns the contents of Preferences.json as a type Config 
        public User getJson()
        {
            return JsonSerializer.Deserialize<User>(File.ReadAllText(filename));
        }

        public String canProceed(String form)
        {
            switch (form)
            {
                // NEEDS: *Image directory path
                case "LIBRARY":
                    User user = new User();
                    if (!Directory.Exists(user.getJson().download_path))
                    {
                        return "Image folder not found, check path";
                    }
                    else { return "Nothing"; }

                // NEEDS: *Preferences.json file created
                case "SETTINGS":
                    if (!File.Exists(filename))
                    {
                        return "Nothing";
                    }
                    return "Nothing";
                default:
                    return "Nothing";
            }
        }

    }
    // Object to hold parameters
    public class Parameters
    {
        public string title;
        public string board;
        public List<String> whitelist;
        public List<String> blacklist;

        public Parameters(string title, string board, List<string> whitelist, List<string> blacklist)
        {
            this.title = title;
            this.board = board;
            this.whitelist = whitelist;
            this.blacklist = blacklist;
        }

        public void addParameters(Parameters pm)
        {

        }

    }
}
