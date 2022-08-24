
namespace MicrosoftInterview
{
  public class FileSystem
    {
        private Dictionary<string, SortedSet<string>> Paths { get; set; }
        private Dictionary<string, string> Files { get; set; }
        public FileSystem()
        {
            Paths = new();
            Files = new();
        }

        public IList<string> Ls(string path)
        {
           
            if(Files.ContainsKey(path)) // if path is a file path :> /a/b/c/d.js, we want to return d.js, the file name.
            {
                var split = path.Split('/');
                return new List<string> { split[^1] };
            }
            else if(Paths.ContainsKey(path))
            {
                return Paths[path].ToList();
            }

            return new List<string>();
        }

        public void Mkdir(string path)
        {
            var directories = path.Split("/");

            for (int i = 1; i < directories.Length; i++) // /a/b/c  ["", a, b, c]  , /a/b/c/d.js => ["", a, b, c, d.js]
            {
                var currrent = string.Join("/", directories[..i]);
                string cPath = currrent == "" ? "/" : currrent;

                if (!Paths.ContainsKey(cPath) || !Paths[cPath].Contains(directories[i]))
                {
                    Paths.TryAdd(cPath, new SortedSet<string>());
                    Paths[cPath].Add(directories[i]);
                }                 
            }
        }

        public void AddContentToFile(string filePath, string content)
        {
            if (!Files.ContainsKey(filePath))
            {
                Mkdir(filePath);
                Files.Add(filePath, content);
            }
            else
                Files[filePath] += content;
        }

        public string ReadContentFromFile(string filePath) => Files[filePath];
       
    }
}
