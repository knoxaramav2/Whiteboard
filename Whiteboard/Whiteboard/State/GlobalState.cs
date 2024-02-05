using Newtonsoft.Json;
using Whiteboard.Util;

namespace Whiteboard.State
{
    internal class GlobalState
    {
        [JsonProperty]
        protected DateTime LastSaveDate;
        [JsonIgnore]
        protected StoryState? LastStory;

        [JsonProperty]
        internal string LastSavePath { get; set; }

        [JsonProperty]
        internal List<string> RecentSaves { get; set; }

        private static string StatePath => Path.Join(FileIO.StatePath, "progdat.info");

        public GlobalState() {
            LastStory = null;
            LastSavePath = string.Empty;
            RecentSaves = [];
            LastSaveDate = DateTime.Now;
        }

        internal static GlobalState Load()
        {
            var ret = FileIO.LoadAs<GlobalState>(StatePath);
            return ret ?? new GlobalState();
        }

        public void SetCurrentStory(StoryState state)
        {
            LastStory = state;
            LastSavePath = LastStory?.FilePath ?? string.Empty;
        }

        public void Save()
        {
            if (string.IsNullOrEmpty(LastSavePath) && RecentSaves.Contains(LastSavePath))
            {
                RecentSaves.Add(LastSavePath);
            }
            LastSaveDate = DateTime.Now;
            FileIO.SaveAs(StatePath, this);
        }

    }
}
