using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23UCH.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23UCH.Group
{
///<summary>
///Represents the RQA_I10_GUARANTOR_INSURANCE Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: GT1 (Guarantor) optional repeating</li>
///<li>1: RQA_I10_INSURANCE (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class RQA_I10_GUARANTOR_INSURANCE : AbstractGroup {

	///<summary> 
	/// Creates a new RQA_I10_GUARANTOR_INSURANCE Group.
	///</summary>
	public RQA_I10_GUARANTOR_INSURANCE(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(GT1), false, true);
	      this.add(typeof(RQA_I10_INSURANCE), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RQA_I10_GUARANTOR_INSURANCE - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns  first repetition of GT1 (Guarantor) - creates it if necessary
	///</summary>
	public GT1 GetGT1() {
	   GT1 ret = null;
	   try {
	      ret = (GT1)this.GetStructure("GT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of GT1
	/// * (Guarantor) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public GT1 GetGT1(int rep) { 
	   return (GT1)this.GetStructure("GT1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of GT1 
	 */ 
	public int GT1RepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("GT1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns  first repetition of RQA_I10_INSURANCE (a Group object) - creates it if necessary
	///</summary>
	public RQA_I10_INSURANCE GetINSURANCE() {
	   RQA_I10_INSURANCE ret = null;
	   try {
	      ret = (RQA_I10_INSURANCE)this.GetStructure("INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RQA_I10_INSURANCE
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RQA_I10_INSURANCE GetINSURANCE(int rep) { 
	   return (RQA_I10_INSURANCE)this.GetStructure("INSURANCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RQA_I10_INSURANCE 
	 */ 
	public int INSURANCERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("INSURANCE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
