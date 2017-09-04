#region Usings

using System.Collections.Generic;
using NaroCppCore.Occ.AIS;

using ShapeFunctionsInterface.Utils;
using TreeData.NaroData;
using TreeData.NaroDataViewer;

#endregion

namespace ShapeFunctionsInterface.Interpreters
{
    /// <summary>
    ///   Attribute that keeps in tree various OpenCascade data
    /// </summary>
    public class DocumentContextInterpreter : AttributeInterpreterBase
    {
        public ShapeGraph ShapesGraph;
        private AISInteractiveContext _context;
        private Document _document;
        public int ActiveSketch { get; set; }

        /// <summary>
        ///   Default constructor that setup the attribute type
        /// </summary>
        public DocumentContextInterpreter()
        {
            Numbering = new AutoNumbering();
            ShapeManager = new ContextShapeManager();
            ActiveSketch = -1;
        }

        public Document Document
        {
            set
            {
                _document = value;
                ShapesGraph.SetDocument(_document);
            }
            get { return _document; }
        }

        /// <summary>
        ///   AIS Context
        /// </summary>
        public AISInteractiveContext Context
        {
            get { return _context; }
            set
            {
                _context = value;
                ShapeManager.Context = _context;
            }
        }

        public ContextShapeManager ShapeManager { get; private set; }

        /// <summary>
        ///   Numbering information
        /// </summary>
        public AutoNumbering Numbering { get; private set; }

        protected override void OnActivate()
        {
            base.OnActivate();
            ShapesGraph = new ShapeGraph();
        }

        public override void Serialize(AttributeData data)
        {
            var words = new List<string>();
            var wordIndexes = new List<int>();
            foreach (var wordNumber in Numbering.Indexes)
            {
                words.Add(wordNumber.Key);
                wordIndexes.Add(wordNumber.Value);
            }
            data.WriteAttribute("Words", words);
            data.WriteAttribute("WordIds", wordIndexes);
            data.WriteAttribute("Freeze", Numbering.Freeze ? 1 : 0);
            data.WriteAttribute("ActiveSketch", ActiveSketch);
        }

        public override void Deserialize(AttributeData data)
        {
            var words = data.ReadAttributeListString("Words");
            var wordIndexes = data.ReadAttributeListInteger("WordIds");

            ActiveSketch = data.ReadAttributeInteger("ActiveSketch");
            Numbering.Indexes = new SortedDictionary<string, int>();
            for (var i = 0; i < words.Count; i++)
                Numbering.Indexes[words[i]] = wordIndexes[i];
            Numbering.Freeze = data.ReadAttributeInteger("Freeze") != 0;
        }
    }
}