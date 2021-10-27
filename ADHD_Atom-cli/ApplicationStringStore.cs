using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace ADHD_Atom_cli
{
    public class ApplicationStringStore
    {
        private static readonly string _filePath = Path.Combine("ADHD_Atom-cli", "ApplicationStrings.json");
        private static readonly JsonDocument document = JsonDocument.Parse(File.ReadAllText(_filePath));
        public string GetString(string set, string key)
        {
            JsonElement root = document.RootElement;
            JsonElement setElement = root.GetProperty(set);
            JsonElement keyElement = setElement.GetProperty(key);
            return keyElement.GetString();
        }

        public string GetString(string set, string key, string subkey)
        {
            JsonElement root = document.RootElement;
            JsonElement setElement = root.GetProperty(set);
            JsonElement keyElement = setElement.GetProperty(key);
            JsonElement subkeyElement = keyElement.GetProperty(subkey);
            return subkeyElement.GetString();
        }
    }
}