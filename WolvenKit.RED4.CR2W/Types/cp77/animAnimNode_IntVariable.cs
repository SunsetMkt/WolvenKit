using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_IntVariable : animAnimNode_IntValue
	{
		private CName _variableName;

		[Ordinal(11)] 
		[RED("variableName")] 
		public CName VariableName
		{
			get => GetProperty(ref _variableName);
			set => SetProperty(ref _variableName, value);
		}

		public animAnimNode_IntVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}