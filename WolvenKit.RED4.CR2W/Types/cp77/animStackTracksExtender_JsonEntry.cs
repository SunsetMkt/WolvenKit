using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animStackTracksExtender_JsonEntry : CVariable
	{
		private CName _name;
		private CFloat _referenceValue;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("referenceValue")] 
		public CFloat ReferenceValue
		{
			get => GetProperty(ref _referenceValue);
			set => SetProperty(ref _referenceValue, value);
		}

		public animStackTracksExtender_JsonEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
