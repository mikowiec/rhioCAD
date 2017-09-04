#region Usings

using System.Collections.Generic;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace TreeData.Capabilities
{
    public class ConceptInterpreter : StringInterpreter
    {
        public ConceptInterpreter()
        {
            Data = new SortedDictionary<string, string>();
            BlackList = new SortedDictionary<string, int>();
        }

        public SortedDictionary<string, string> Data { get; private set; }
        public SortedDictionary<string, int> BlackList { get; private set; }

        public void BlackListCapability(string capability)
        {
            BlackList[capability] = 0;
        }

        public void RemoveBlackListedCapability(string capability)
        {
            BlackList.Remove(capability);
        }

        public bool HasCapability(string capability)
        {
            if (Data.ContainsKey(capability))
            {
                return true;
            }

            foreach (var child in Parent.Children.Values)
            {
                var ri = child.Get<ReferenceInterpreter>();
                if (ri == null) continue;
                if (ri.Node.Set<ConceptInterpreter>().HasCapability(capability))
                    return true;
            }

            return false;
        }

        public override void Serialize(AttributeData data)
        {
            base.Serialize(data);
            var keys = new string[Data.Count];
            var values = new string[Data.Count];
            var blackListed = new string[BlackList.Count];
            Data.Keys.CopyTo(keys, 0);
            Data.Values.CopyTo(values, 0);
            BlackList.Keys.CopyTo(blackListed, 0);
            data.WriteAttribute("Keys", new List<string>(keys));
            data.WriteAttribute("Values", new List<string>(values));
            data.WriteAttribute("BlackListed", new List<string>(blackListed));
        }

        public override void Deserialize(AttributeData data)
        {
            base.Deserialize(data);

            var keys = data.ReadAttributeListString("Keys");
            var values = data.ReadAttributeListString("Values");
            Data.Clear();
            for (var i = 0; i < keys.Count; i++)
                Data[keys[i]] = values[i];

            var blackListed = data.ReadAttributeListString("BlackListed");
            BlackList.Clear();
            foreach (var item in blackListed)
                BlackList[item] = 0;
        }
    }
}