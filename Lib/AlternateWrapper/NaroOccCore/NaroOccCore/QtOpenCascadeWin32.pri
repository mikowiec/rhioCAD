INCLUDEPATH += $(CASROOT)/inc

LIBS += $(CASROOT)/win32/lib/BinLPlugin.lib \
    $(CASROOT)/win32/lib/BinPlugin.lib \
    $(CASROOT)/win32/lib/BinXCAFPlugin.lib \
    $(CASROOT)/win32/lib/FWOSPlugin.lib \
    $(CASROOT)/win32/lib/mscmd.lib \
    $(CASROOT)/win32/lib/PTKernel.lib \
    $(CASROOT)/win32/lib/StdLPlugin.lib \
    $(CASROOT)/win32/lib/StdPlugin.lib \
    $(CASROOT)/win32/lib/TKAdvTools.lib \
    $(CASROOT)/win32/lib/TKBin.lib \
    $(CASROOT)/win32/lib/TKBinL.lib \
    $(CASROOT)/win32/lib/TKBinXCAF.lib \
    $(CASROOT)/win32/lib/TKBO.lib \
    $(CASROOT)/win32/lib/TKBool.lib \
    $(CASROOT)/win32/lib/TKBRep.lib \
    $(CASROOT)/win32/lib/TKCAF.lib \
    $(CASROOT)/win32/lib/TKCDF.lib \
    $(CASROOT)/win32/lib/TKCDLFront.lib \
    $(CASROOT)/win32/lib/TKCPPClient.lib \
    $(CASROOT)/win32/lib/TKCPPExt.lib \
    $(CASROOT)/win32/lib/TKCPPIntExt.lib \
    $(CASROOT)/win32/lib/TKCPPJini.lib \
    $(CASROOT)/win32/lib/TKCSFDBSchema.lib \
    $(CASROOT)/win32/lib/TKDCAF.lib \
    $(CASROOT)/win32/lib/TKDraw.lib \
    $(CASROOT)/win32/lib/TKernel.lib \
    $(CASROOT)/win32/lib/TKFeat.lib \
    $(CASROOT)/win32/lib/TKFillet.lib \
    $(CASROOT)/win32/lib/TKG2d.lib \
    $(CASROOT)/win32/lib/TKG3d.lib \
    $(CASROOT)/win32/lib/TKGeomAlgo.lib \
    $(CASROOT)/win32/lib/TKGeomBase.lib \
    $(CASROOT)/win32/lib/TKHLR.lib \
    $(CASROOT)/win32/lib/TKIDLFront.lib \
    $(CASROOT)/win32/lib/TKIGES.lib \
    $(CASROOT)/win32/lib/TKjcas.lib \
    $(CASROOT)/win32/lib/TKLCAF.lib \
    $(CASROOT)/win32/lib/TKMath.lib \
    $(CASROOT)/win32/lib/TKMesh.lib \
    $(CASROOT)/win32/lib/TKMeshVS.lib \
    $(CASROOT)/win32/lib/TKOffset.lib \
    $(CASROOT)/win32/lib/TKOpenGl.lib \
    $(CASROOT)/win32/lib/TKPCAF.lib \
    $(CASROOT)/win32/lib/TKPLCAF.lib \
    $(CASROOT)/win32/lib/TKPrim.lib \
    $(CASROOT)/win32/lib/TKPShape.lib \
    $(CASROOT)/win32/lib/TKService.lib \
    $(CASROOT)/win32/lib/TKShapeSchema.lib \
    $(CASROOT)/win32/lib/TKShHealing.lib \
    $(CASROOT)/win32/lib/TKStdLSchema.lib \
    $(CASROOT)/win32/lib/TKStdSchema.lib \
    $(CASROOT)/win32/lib/TKSTEP.lib \
    $(CASROOT)/win32/lib/TKSTEP209.lib \
    $(CASROOT)/win32/lib/TKSTEPAttr.lib \
    $(CASROOT)/win32/lib/TKSTEPBase.lib \
    $(CASROOT)/win32/lib/TKSTL.lib \
    $(CASROOT)/win32/lib/TKTCPPExt.lib \
    $(CASROOT)/win32/lib/TKTopAlgo.lib \
    $(CASROOT)/win32/lib/TKTopTest.lib \
    $(CASROOT)/win32/lib/TKV2d.lib \
    $(CASROOT)/win32/lib/TKV3d.lib \
    $(CASROOT)/win32/lib/TKViewerTest.lib \
    $(CASROOT)/win32/lib/TKVRML.lib \
    $(CASROOT)/win32/lib/TKXCAF.lib \
    $(CASROOT)/win32/lib/TKXCAFSchema.lib \
    $(CASROOT)/win32/lib/TKXDEDRAW.lib \
    $(CASROOT)/win32/lib/TKXDEIGES.lib \
    $(CASROOT)/win32/lib/TKXDESTEP.lib \
    $(CASROOT)/win32/lib/TKXml.lib \
    $(CASROOT)/win32/lib/TKXmlL.lib \
    $(CASROOT)/win32/lib/TKXmlXCAF.lib \
    $(CASROOT)/win32/lib/TKXSBase.lib \
    $(CASROOT)/win32/lib/TKXSDRAW.lib \
    $(CASROOT)/win32/lib/XCAFPlugin.lib \
    $(CASROOT)/win32/lib/XmlLPlugin.lib \
    $(CASROOT)/win32/lib/XmlPlugin.lib \
    $(CASROOT)/win32/lib/XmlXCAFPlugin.lib

CONFIG(release, release|debug) { 
        message ("Add here custom Release environment")

}
		
CONFIG(debug, release|debug) { 	
        message ("Add here custom Debug environment")

}	

