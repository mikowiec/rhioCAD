#region Usages

using ApiCommon;
using ApiCommon.Generator;

#endregion

namespace ApiToWrapper.CodeWriters.Constructs
{
    public abstract class WriterClassConstruct
    {
        protected CSharpClassWriter _classWriter;
        protected DataNode _node;
        protected ParameterListWriter _parameterList;
        protected TypeUtil _typeUtil;

        public void Setup(CSharpClassWriter classWriter, DataNode node)
        {
            _classWriter = classWriter;
            _node = node;
            _parameterList = new ParameterListWriter(node);
            _typeUtil = new TypeUtil(node);
        }

        public abstract void Process();
    }
}