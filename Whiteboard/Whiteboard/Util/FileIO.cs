using Newtonsoft.Json;

namespace Whiteboard.Util
{
    internal static class FileIO
    {
        internal static string BasePath = AppDomain.CurrentDomain.BaseDirectory;
        internal static string DataPath = Path.Join(BasePath, "SaveData");
        internal static string StatePath = Path.Join(BasePath, "State");

        internal static void AssurePath(string path)
        {
            while (!string.IsNullOrEmpty(Path.GetExtension(path))){
                path = Path.GetDirectoryName(path) ?? string.Empty;
            }

            Directory.CreateDirectory(path);            
        }

        internal static T? LoadAs<T>(string path)
        {
            if (!File.Exists(path)) { return default; }
            using StreamReader sr = new(path);
            var content = sr.ReadToEnd();
            var ret = JsonConvert.DeserializeObject<T>(content);
            return ret ?? default;
        }

        internal static bool SaveAs<T>(string path, T obj)
        {
            AssurePath(path);
            var sj = JsonConvert.SerializeObject(obj, Formatting.Indented);
            using StreamWriter wr = new(path);
            wr.WriteLine(sj);
            return true;
        }
    }
}
