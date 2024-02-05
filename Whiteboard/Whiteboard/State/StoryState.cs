﻿using Newtonsoft.Json;
using Whiteboard.Util;

namespace Whiteboard.State
{
    public class StoryState(
        string profileName,
        string path)
    {
        [JsonProperty]
        public string ProfileName { get; private set; } = profileName;
        [JsonProperty]
        public string FilePath { get; private set; } = path;

        public static StoryState? Load(string path)
        {
            var ret = FileIO.LoadAs<StoryState>(path);
            return ret;
        }

        public void Save() 
        {
            FileIO.SaveAs(FilePath, this);
        }
    }
}