using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntityParametersStorage : ISerializable
	{
		private CArray<CHandle<entEntityParameter>> _parameters;

		[Ordinal(0)] 
		[RED("parameters")] 
		public CArray<CHandle<entEntityParameter>> Parameters
		{
			get => GetProperty(ref _parameters);
			set => SetProperty(ref _parameters, value);
		}

		public entEntityParametersStorage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
