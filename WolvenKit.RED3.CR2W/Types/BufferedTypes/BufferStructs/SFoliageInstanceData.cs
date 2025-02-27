using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
   
   


    

    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SFoliageInstanceData : CVariable
    {
        [Ordinal(0)] [RED] public CFloat PositionX { get; set; }
        [Ordinal(1)] [RED] public CFloat PositionY { get; set; }
        [Ordinal(2)] [RED] public CFloat PositionZ { get; set; }
        [Ordinal(3)] [RED] public CFloat Yaw { get; set; }
        [Ordinal(4)] [RED] public CFloat Pitch { get; set; }
        [Ordinal(5)] [RED] public CFloat Roll { get; set; }

        public SFoliageInstanceData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }

        
    }
}