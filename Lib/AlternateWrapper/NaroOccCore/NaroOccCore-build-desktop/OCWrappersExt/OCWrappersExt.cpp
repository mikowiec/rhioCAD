#include <stdio.h>

#include <EDL_API.hxx>
#include <CDLFront.hxx>

#include <MS.hxx>
#include <MS_MetaSchema.hxx>
#include <MS_Package.hxx>
#include <MS_InstClass.hxx>
#include <MS_StdClass.hxx>
#include <MS_GenClass.hxx>
#include <MS_Alias.hxx>
#include <MS_HSequenceOfClass.hxx>
#include <MS_HSequenceOfMemberMet.hxx>
#include <MS_HSequenceOfExternMet.hxx>
#include <MS_ExternMet.hxx>
#include <MS_MemberMet.hxx>
#include <MS_Construc.hxx>
#include <MS_ClassMet.hxx>
#include <MS_InstMet.hxx>
#include <MS_Param.hxx>
#include <MS_HArray1OfParam.hxx>
#include <MS_DataMapIteratorOfMapOfGlobalEntity.hxx>

#include <Standard_NoSuchObject.hxx>
#include <Standard_Failure.hxx>

#include <WOKTools_Messages.hxx>
#include <WOKTools_Messages.hxx>
#include <WOKBuilder_MSTool.hxx>
#include <WOKBuilder_MSchema.hxx>

#include <TColStd_HSequenceOfHAsciiString.hxx>
#include <TCollection_HAsciiString.hxx>

// Ocas utilities
#define S(value)		(new TCollection_HAsciiString(value))
#define IsA(value,tipo)	value->IsKind(STANDARD_TYPE(MS_##tipo))
#define ToA(value,tipo)	Handle(MS_##tipo)::DownCast(value)

extern "C"
{
void CPP_Extract(const Handle(MS_MetaSchema)& aMeta,
				 const Handle(TCollection_HAsciiString)& aName,
				 const Handle(TColStd_HSequenceOfHAsciiString)& edlsfullpath,
				 const Handle(TCollection_HAsciiString)& outdir,
				 const Handle(TColStd_HSequenceOfHAsciiString)& outfile,
				 const Standard_CString DBMS);
}


Standard_Boolean ParseCommandLine(const Handle(TColStd_HSequenceOfHAsciiString)& cmd,
								  Handle(TColStd_HSequenceOfHAsciiString)& packs,
								  Handle(TColStd_HSequenceOfHAsciiString)& cdldirs,
								  Handle(TColStd_HSequenceOfHAsciiString)& cpppacks,
								  Handle(TColStd_HSequenceOfHAsciiString)& cppdirs,
								  Handle(TCollection_HAsciiString)& usage) 
{
	Handle(MS_MetaSchema) meta = WOKBuilder_MSTool::GetMSchema()->MetaSchema();

	if (cmd.IsNull() || cmd->Length()==0) 
	{
		usage->AssignCat(S("\n"));
		usage->AssignCat(S("Command Syntax:\n"));
		usage->AssignCat(S("  -h or /?          -> Print this help\n"));
		usage->AssignCat(S("  -cdldir           -> Set cdl directory (DEFAULT ./)\n"));
		usage->AssignCat(S("  -cppext           -> Do CPP extraction\n"));
		usage->AssignCat(S("  -!cppext          -> Don't do CPP extraction (DEFAULT))\n"));
		usage->AssignCat(S("  -cppdir <dir>     -> Set CPP output dir (DEFAULT ./)\n"));
		usage->AssignCat(S("\n"));

		// exit
		return false;
	}

	Standard_Boolean bCPPExt = false;

	// Start with the current directory
	Standard_CString cppdir= "./";
	Standard_CString cdldir="./";
	
	usage = new TCollection_HAsciiString();
	packs = new TColStd_HSequenceOfHAsciiString;
	cdldirs = new TColStd_HSequenceOfHAsciiString;
	cpppacks = new TColStd_HSequenceOfHAsciiString;
	cppdirs = new TColStd_HSequenceOfHAsciiString;

	Standard_Integer i;
	for (i=1; i<=cmd->Length(); i++)
	{
		//User want "help" explanation
		if (cmd->Value(i)->IsSameString(S("-h")) || cmd->Value(i)->IsSameString(S("/?")))
		{
			usage->AssignCat(S("\n"));
			usage->AssignCat(S("Command Syntax:\n"));
			usage->AssignCat(S("  -h or /?          -> Print this help\n"));
			usage->AssignCat(S("  -cdldir           -> Set cdl directory (DEFAULT ./)\n"));
			usage->AssignCat(S("  -cppext           -> Do CPP extraction\n"));
			usage->AssignCat(S("  -!cppext          -> Don't do CPP extraction (DEFAULT))\n"));
			usage->AssignCat(S("  -cppdir <dir>     -> Set CPP output dir (DEFAULT ./)\n"));
			usage->AssignCat(S("\n"));

			// exit
			return false;
		}

		// Do "Cpp Extraction" of the following packages
		if (cmd->Value(i)->IsSameString(S("-cppext")))
		{
			bCPPExt = true;
		}
		// DON'T do "Cpp Extraction" of the following packages
		else if (cmd->Value(i)->IsSameString(S("-!cppext")))
		{
			bCPPExt = false;
		}
		// "Cpp Extractor" output directory
		else if (cmd->Value(i)->IsSameString(S("-cppdir")))
		{
			i++;
			cppdir = cmd->Value(i)->ToCString();
		}
		// "CDL packages and classes" source dir
		else if (cmd->Value(i)->IsSameString(S("-cdldir")))
		{
			i++;
			cdldir = cmd->Value(i)->ToCString();
		}
		// We have a package name			
		else
		{
			//This is a package name
			packs->Append(cmd->Value(i));
			cdldirs->Append(S(cdldir));
			
			// "CPP Extraction" ?
			if (bCPPExt)
			{
				cpppacks->Append(cmd->Value(i));
				cppdirs->Append(S(cppdir));
			}
		}
	}

	return true;
}


void CPPExtract(const Standard_CString packagename, const Standard_CString outdir) 
{
	Handle(MS_MetaSchema) meta = WOKBuilder_MSTool::GetMSchema()->MetaSchema();
	Handle(MS_Package) package = meta->GetPackage(new TCollection_HAsciiString(packagename));

	InfoMsg << "OCWrappers 1Extraction - " << "Extracting package " << packagename << endm;

	Handle(TColStd_HSequenceOfHAsciiString) outfile = new TColStd_HSequenceOfHAsciiString;
	Handle(TColStd_HSequenceOfHAsciiString) edlfullpath = new TColStd_HSequenceOfHAsciiString;
	edlfullpath->Append(S("./edl/"));

	CPP_Extract(meta, S(packagename), edlfullpath, S(outdir), outfile,"");

	Standard_Integer i;

	//Class CPP Extraction
	for (i=1; !package->Classes().IsNull() && i <= package->Classes()->Length(); i++)
	{
		InfoMsg << "OCWrappers 2Extraction - " << "Extracting class " << package->Classes()->Value(i) << endm;
		CPP_Extract(meta, MS::BuildFullName(package->FullName(), package->Classes()->Value(i)), edlfullpath, S(outdir), outfile, "");
	}

	//Enum CPP Extraction
	for (i=1; !package->Enums().IsNull() && i <= package->Enums()->Length(); i++)
	{
		InfoMsg << "OCWrappers 3Extraction - " << "Extracting class " << package->Enums()->Value(i) << endm;
		CPP_Extract(meta, MS::BuildFullName(package->FullName(), package->Enums()->Value(i)), edlfullpath, S(outdir), outfile, "");
	}

	//ALIAS CPP Extraction
	for (i=1; !package->Aliases().IsNull() && i <= package->Aliases()->Length(); i++)
	{
		InfoMsg << "OCWrappers 4Extraction - " << "Extracting class " << package->Aliases()->Value(i) << endm;
		CPP_Extract(meta, MS::BuildFullName(package->FullName(), package->Aliases()->Value(i)), edlfullpath, S(outdir), outfile, "");
	}

	//Pointers CPP Extraction
	for (i=1; !package->Pointers().IsNull() && i <= package->Pointers()->Length(); i++)
	{
		InfoMsg << "OCWrappers 5Extraction - " << "Extracting class " << package->Pointers()->Value(i) << endm;
		CPP_Extract(meta, MS::BuildFullName(package->FullName(), package->Pointers()->Value(i)), edlfullpath, S(outdir), outfile, "");
	}
}


void CDLFront(const Standard_CString packagename, const Standard_CString cdldir) 
{
	Handle(MS_MetaSchema) meta = WOKBuilder_MSTool::GetMSchema()->MetaSchema();

	Handle(TColStd_HSequenceOfHAsciiString) aGlobalList = new TColStd_HSequenceOfHAsciiString;
	Handle(TColStd_HSequenceOfHAsciiString) aTypeList = new TColStd_HSequenceOfHAsciiString;
	Handle(TColStd_HSequenceOfHAsciiString) anInstList = new TColStd_HSequenceOfHAsciiString;
	Handle(TColStd_HSequenceOfHAsciiString) anGenList = new TColStd_HSequenceOfHAsciiString;

	InfoMsg << "OCWrappers Extraction - " << "Extracting packages " << packagename << endm;

	Handle(TCollection_HAsciiString) localcdldir = S(cdldir);
	localcdldir->AssignCat(packagename);
	localcdldir->AssignCat("/");

	Handle(TCollection_HAsciiString) packagefile = S(localcdldir); 
	packagefile->AssignCat(packagename);
	packagefile->AssignCat(".cdl");

	CDLTranslate(meta, packagefile, aGlobalList, aTypeList, anInstList, anGenList);

	Handle(MS_Package) package = meta->GetPackage(S(packagename));

	Handle(TColStd_HSequenceOfHAsciiString) iclasses = new TColStd_HSequenceOfHAsciiString;
	
	Standard_Integer i;
	for (i=1; i<=package->Classes()->Length(); i++)
	{
		Handle(TCollection_HAsciiString) type = S("");
		Handle(TCollection_HAsciiString) filename = S(localcdldir);
		
		type->AssignCat(MS::BuildFullName(S(packagename), package->Classes()->Value(i)));
		filename->AssignCat(type);
		filename->AssignCat(S(".cdl"));
		
		Handle(MS_Class) theClass = Handle(MS_Class)::DownCast(meta->GetType(type));

		InfoMsg << "OCWrappersExtraction - " << "Examining class *** " << theClass->FullName() << endm;

		if (IsA(theClass, StdClass) && !theClass->IsNested())
		{
			CDLTranslate(meta, filename, aGlobalList, aTypeList, anInstList, anGenList);
		}
		else if (IsA(theClass, GenClass))
		{
			CDLTranslate(meta, filename, aGlobalList, aTypeList, anInstList, anGenList);
		}
		else if (IsA(theClass, InstClass) && !theClass->IsNested())
		{
			Handle(MS_InstClass) iclass = ToA(theClass, InstClass);
			Handle(MS_GenClass) gclass = ToA(meta->GetType(iclass->GenClass()), GenClass);
			iclass->Instantiates();
			iclass->InstToStd();
		}
		
	}

	InfoMsg << "OCWrappers Extraction - Done" << endm;
}

int main(int argv, char **argc)
{
	Standard_Integer i;
	Handle(TColStd_HSequenceOfHAsciiString) cmd = new TColStd_HSequenceOfHAsciiString;
	Handle(TCollection_HAsciiString) usage;
	Handle(TColStd_HSequenceOfHAsciiString)	packs, cdldirs, cpppacks, cppdirs;

	// Build the string with all args
	for (i=1; i<argv; i++)
	{
		cmd->Append(new TCollection_HAsciiString(argc[i]));
	}

	// Call ParseCommand
	if (!ParseCommandLine(cmd, packs, cdldirs, cpppacks, cppdirs, usage))
	{
		InfoMsg << "OCWrappers Extraction - " << usage << endm;
		return 0;
	}
	
	//CDL Packages to parse
	InfoMsg << "OCWrappers Extraction - Packages = ";
	for (i=1; i<=packs->Length(); i++)
	{
		InfoMsg << packs->Value(i) << " ";
	}
	InfoMsg << endm;

	//CDL packages to "cpp" extract
	InfoMsg << "OCWrappers Extraction - Cpp Extraction = ";
	for (i=1; i<=cpppacks->Length(); i++)
	{
		InfoMsg << cpppacks->Value(i) << " ";
	}
	InfoMsg << endm;

	//CDL Parsing
	InfoMsg << "OCWrappers Extraction - Step 1 (of 2). CDL parsing" << endm;
	for (i=1; i<=packs->Length(); i++)
	{
		CDLFront(packs->Value(i)->ToCString(), cdldirs->Value(i)->ToCString());
	}
	InfoMsg << endm;

	//CPP Extraction
	InfoMsg << "OCWrappers Extraction - Step 2 (of 2). CPP extraction" << endm;
	for (i=1; i<=cpppacks->Length(); i++)
	{
		CPPExtract(cpppacks->Value(i)->ToCString(), cppdirs->Value(i)->ToCString());
	}
	InfoMsg << endm;
		
	return 0;
}



