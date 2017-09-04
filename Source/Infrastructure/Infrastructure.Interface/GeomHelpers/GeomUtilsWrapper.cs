#region Usings

using System.Collections.Generic;
using ShapeFunctionsInterface.Utils;
using TreeData.AttributeInterpreter;
using TreeData.NaroData;

#endregion

namespace Naro.Infrastructure.Interface.GeomHelpers
{
    public class GeomUtilsWrapper
    {
        public List<SceneSelectedEntity> IdentifySelectedNodes(Node rootLabel)
        {
            return NodeBuilderUtils.IdentifySelectedNodes(rootLabel);
        }

        public List<SceneSelectedEntity> IdentifyDetectedNodes(Node rootLabel)
        {
            return NodeBuilderUtils.IdentifyDetectedNodes(rootLabel);
        }
    }
}
