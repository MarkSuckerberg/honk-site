using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Shared
{
    public class charSheet
    {
        public string name = "Name";
        public string pronouns = "Pronoun";
        public int powerLevel = "150";
        public Dictionary<string, int> Stats = new() { { "Strength", 0 }, { "Agility", 0 }, { "Fighting", 0 }, { "Awareness", 0 }, { "Stamina", 0 }, { "Dexterity", 0 }, { "Intellect", 0 }, { "Presence", 0 } };
    }
}