#region Usings

using NaroConstants.Names;
using NaroCppCore.Occ.AIS;
using NaroPipes.Actions;


#endregion

namespace NaroBasicPipes.Inputs
{
    public class ContextInput : InputBase
    {
        private readonly AISInteractiveContext _context;

        public ContextInput(AISInteractiveContext context)
            : base(InputNames.Context)
        {
            _context = context;
        }

        public override void OnConnect()
        {
            AddData(_context);
        }
    }
}