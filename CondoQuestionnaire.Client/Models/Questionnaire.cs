using Microsoft.VisualBasic;
using System.Net;
using static CondoQuestionnaire.Client.Models.InsuranceInformationFinancialControls;
using static MudBlazor.CategoryTypes;

namespace CondoQuestionnaire.Client.Models
{
    public class Questionnaire
    {
        public Questionnaire()
        {
            Instructions = new Instructions();
            BasicProjectInformation = new BasicProjectInformation();
            ProjectCompleteInfo = new ProjectCompleteInfo();
            NewlyConvertedProjectInfo = new NewlyConvertedProjectInfo();
            FinancialInformation = new FinancialInformation();
            OwnershipOtherInformation = new OwnershipOtherInformation();
            InsuranceInformationFinancialControls = new InsuranceInformationFinancialControls();
            ContactInfo = new ContactInfo();
            CondominiumProject = new CondominiumProject();
        }
        public Instructions Instructions { get; set; }

        public BasicProjectInformation BasicProjectInformation { get; set; }

        public ProjectCompleteInfo ProjectCompleteInfo { get; set; }

        public NewlyConvertedProjectInfo NewlyConvertedProjectInfo { get; set; }

        public FinancialInformation FinancialInformation { get; set; } // check If yes Or No text

        public OwnershipOtherInformation OwnershipOtherInformation { get; set; }
        public InsuranceInformationFinancialControls InsuranceInformationFinancialControls { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public CondominiumProject CondominiumProject { get; set; }

    }
    public class NewlyConvertedProjectInfo
    {
        public bool IstheProjectConversionWithinThePastThtrryearsYesNo { get; set;}
        public string IstheProjectConversionWithinThePastThtrryearsYesNoString
        {

            get
            {
                if (IstheProjectConversionWithinThePastThtrryearsYesNo)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }

            }

        }


        public string? PropertyBuilt { get; set; }
        public string? PropertyConverted { get; set; }
        public bool WasTheConversionFullGutRehabilitation { get; set;}
        public string WasTheConversionFullGutRehabilitationString 
        {
            get
            {
                if(WasTheConversionFullGutRehabilitation)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }

            }
        }

        public bool DoesTheReportFromTheLicensed { get; set;}
        public string DoesTheReportFromTheLicensedString
        { 
            get
            {
                if (DoesTheReportFromTheLicensed)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }

        public bool AreAllRepairsAffectingSafety { get; set;}
        public string AreAllRepairsAffectingSafetyString
        { 
            get
            {
                if (AreAllRepairsAffectingSafety)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }

        public bool AreReplacementReserves { get; set;}
        public string AreReplacementReservesString
        { 
            get
            {
                if (AreReplacementReserves)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }

        public bool AreTheProjectReserves { get; set;}
        public string AreTheProjectReservesString
        {
            get
            {
                if (AreTheProjectReserves)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }

    }
    public class CondominiumProject
    {
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
        public string WhenLastBuilding { get; set; }

        public bool LastInspection { get; set; }
        public string LastInspectionString
        {
            get
            {
                if (LastInspection)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string IsTheHoaCorporative { get; set; }
        public bool IsTheHoaCorporativeSec { get; set; }
        public string IsTheHoaCorporativeSecString
        {
            get
            {
                if (IsTheHoaCorporativeSec)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string YesA { get; set; }
        public string YesB { get; set; }
        public string YesC { get; set; }
        public bool OutstandingViolations { get; set; }
        public string OutstandingViolationsString
        {
            get
            {
                if (OutstandingViolations)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string OutstandingViolationsYes { get; set; }

        public bool Anticipited { get; set; }
        public string AnticipitedString
        {
            get
            {
                if (Anticipited)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string AnticipitedYes { get; set; }

        public bool ProjectFunding { get; set; }
        public string ProjectFundingString
        {
            get
            {
                if (ProjectFunding)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public bool ProjectSchedule { get; set; }
        public string ProjectScheduleString
        {
            get
            {
                if (ProjectSchedule)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string YesProvideSchedule { get; set; }

        public bool ReverseStudyComp { get; set; }
        public string ReverseStudyCompString
        {
            get
            {
                if (ReverseStudyComp)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string TotalCurrent { get; set; }
        public bool AnyCurrentAssessment { get; set; }
        public string AnyCurrentAssessmentString
        {
            get
            {
                if (AnyCurrentAssessment)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }

        public string AssessmentA { get; set; }
        public string AssessmentB { get; set; }
        public string AssessmentC { get; set; }
        public bool PlannedSpecialAssessment { get; set; }
        public string PlannedSpecialAssessmentString
        {
            get
            {
                if (PlannedSpecialAssessment)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string TotalA { get; set; }
        public string TotalB { get; set; }
        public string TotalC { get; set; }

        public bool HoaObtainedloans { get; set; }
        public string HoaObtainedloansString
        {
            get
            {
                if (HoaObtainedloans)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string AmountBorrowed { get; set; }

        public string TermsOfPayment { get; set; }

        public string AdditionalInfo { get; set; }



        public string NameOFPrepare { get; set; }
        public string TitleOfPrepare { get; set; }
        public string PPhone { get; set; }
        public string PEmail { get; set; }
        public string PCompanyName { get; set; }
        public string PCompanyAddress { get; set; }
        public string DateCompleted { get; set; }
        public CondoNameAddress CondoProject { get; set; }

        public bool DidTheLastInspection { get; set; }
        public string DidTheLastInspectionString
        {
            get
            {
                if (DidTheLastInspection)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }

            }
        }

        public bool Replacement { get; set; }
        public bool IsTheHOACooperative { get; set; }
        public bool DoesTheProjectHaveSchedule { get; set; }
        public bool Funding { get; set; }
        public bool Maintaince { get; set; }
        public bool Planned { get; set; }
        public string TotalAmtA { get; set; }
        public string TotalAmtB { get; set; }
        public string TotalAmtC { get; set; }
        public bool Loans { get; set; }
        public bool AmtBorro { get; set; }
        public bool TermsOfpay { get; set; }


        public CondoNameAddress HasTheHOACooperative { get; set; }
        public CondoNameAddress currentReserveAccount { get; set; }
        public CondoNameAddress CurrentSpecialAssessments { get; set; }
        public CondoNameAddress PalnAssingnment { get; set; }
        public CondoNameAddress HOAObtained { get; set; }

        public string AdditionalComments { get; set; }

        public ContactInfo ContactInfoList { get; set; }
    }
    public class CondoNameAddress
    {
        public string ProjectName { get; set; }
        public string ProjectAddress { get; set; }
    }
    public class ContactInfo
    {
        public string NameOFPrepare { get; set; }
        public string TitleOfPrepare { get; set; }
        public string PPhone { get; set; }
        public string PEmail { get; set; }
        public string PCompanyName { get; set; }
        public string PCompanyAddress { get; set; }
        public string DateCompleted { get; set; }
    }
    public class InsuranceInformationFinancialControls
    {
        public InsuranceInformationFinancialControls()
        {

            InsuranceInfoFinancialControls.Add("100% replacement cost", false);
            InsuranceInfoFinancialControls.Add("Maximum coverage per condominium available under the National Flood Insurance Program", false);
            InsuranceInfoFinancialControls.Add("Some other amount (Enter amount here)", false);

            InsuranceInfoFinancialControlslist.Add("HOA maintains separate accounts for operating and reserve funds.", false);
            InsuranceInfoFinancialControlslist.Add("Appropriate access controls are in place for each account.", false);
            InsuranceInfoFinancialControlslist.Add("The bank sends copies of monthly bank statements directly to the HOA.", false);
            InsuranceInfoFinancialControlslist.Add("Two members of the HOA Board of Directors are required to sign any check written on the reserve account.", false);
            InsuranceInfoFinancialControlslist.Add("The Management Company maintains separate records and bank accounts for each HOA that uses its services.", false);
            InsuranceInfoFinancialControlslist.Add("The Management Company does not have the authority to draw checks on, or transfer funds from, the reserve account of the HOA.", false);

            InsuranceFinInfos = new List<InsuranceFinInfo>();

            InsuranceFinInfos.Add(new InsuranceFinInfo { TypeOfInsurance = "Hazard" });
            InsuranceFinInfos.Add(new InsuranceFinInfo { TypeOfInsurance = "Liability" });
            InsuranceFinInfos.Add(new InsuranceFinInfo { TypeOfInsurance = "Fidelity" });
            InsuranceFinInfos.Add(new InsuranceFinInfo { TypeOfInsurance = "Flood" });

        }
        public class InsuranceFinInfo
        {
            public string TypeOfInsurance { get; set; }

            public string CarrierAgentname { get; set; }

            public string CarrierAgentPhNo { get; set; }

            public string PolicyNo { get; set; }
        }
        public List<InsuranceFinInfo> InsuranceFinInfos { get; set; }


        public bool AreUnitsCommon { get; set; }
        public string AreUnitsCommonString 
        {
            get
            {
                if (AreUnitsCommon)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
     
        public string Amount { get; set; }
        public Dictionary<string, bool> InsuranceInfoFinancialControls { get; set; } = new Dictionary<string, bool>();

        public string InsuranceInfoFinancialControlsString
        {
            get
            {
                var outputString = new List<string>();
                outputString.AddRange(InsuranceInfoFinancialControls.Where(x => x.Value).Select(x => x.Key).ToList());

                return String.Join("<br/>", outputString);
            }
        }
        public Dictionary<string, bool> InsuranceInfoFinancialControlslist { get; set; } = new Dictionary<string, bool>();

        public string InsuranceInfoFinancialControlslistString
        {
            get
            {
                var outputString = new List<string>();
                outputString.AddRange(InsuranceInfoFinancialControlslist.Where(x => x.Value).Select(x => x.Key).ToList());

                return String.Join("<br/>", outputString);
            }
        }
        public bool RegardingHOAFinancial { get; set; }
        public OwnershipOtherInformation SupplayInfo { get; set; }
    }
    public class InsuranceFinInfos
    {
        public string TypeOfInsurance { get; set; }

        public string CarrierAgentname { get; set; }

        public string CarrierAgentPhNo { get; set; }

        public string PolicyNo { get; set; }
    }
    public class OwnershipOtherInformation
    {
        public OwnershipOtherInformation()
        {
            InformationConcerningOwnershipUnits = new List<InformationConcerningOwnershipUnits>();
            TableInfos = new List<TableInfo>();

            AllInfos = new List<AllInfo>();

            InformationConcerningOwnershipUnits.Add(new InformationConcerningOwnershipUnits { TypeOfInsurance = "Hazard" });
            InformationConcerningOwnershipUnits.Add(new InformationConcerningOwnershipUnits { TypeOfInsurance = "Liability" });
            InformationConcerningOwnershipUnits.Add(new InformationConcerningOwnershipUnits { TypeOfInsurance = "Fidelity" });
            InformationConcerningOwnershipUnits.Add(new InformationConcerningOwnershipUnits { TypeOfInsurance = "Flood" });

            TableInfos.Add(new TableInfo{ IndividualName = "" , DeveloperOrSponcer="" , NoOfUnits="",PerOwnedProjectUnits="",NumbermarketRent="",NumberLeasedUnderControl="" });
            TableInfos.Add(new TableInfo{ IndividualName = "", DeveloperOrSponcer = "", NoOfUnits = "", PerOwnedProjectUnits = "", NumbermarketRent = "", NumberLeasedUnderControl = "" });
            TableInfos.Add(new TableInfo{ IndividualName = "", DeveloperOrSponcer = "", NoOfUnits = "", PerOwnedProjectUnits = "", NumbermarketRent = "", NumberLeasedUnderControl = "" });

            AllInfos.Add(new AllInfo { TypeOfCommercial = "",NameOfOwener ="", NumberOfUnit = "",SqFootage = "",ProgectSq="" });
            AllInfos.Add(new AllInfo { TypeOfCommercial = "",NameOfOwener ="", NumberOfUnit = "", SqFootage ="", ProgectSq ="" });
            AllInfos.Add(new AllInfo { TypeOfCommercial = "",NameOfOwener ="", NumberOfUnit = "", SqFootage ="", ProgectSq ="" });
        }

        
        public List<InformationConcerningOwnershipUnits> InformationConcerningOwnershipUnits { get; set; }

        public List<TableInfo> TableInfos { get; set; }

        public List<AllInfo> AllInfos { get; set; }

        public bool DoTheUnitOwners { get; set; }
        public bool AreAnyUnits { get; set; }
        public string TotalSqure { get; set; }
        public string ExplainOwenship { get; set; }
        public string NonResiden { get; set; }

        public bool UnitsOfOwener { get; set; }
        public string UnitsOfOwenerString
        {
            get
            {
                if (UnitsOfOwener)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }

    }
    public class AllInfo
    {
        public string TypeOfCommercial { get; set; }

        public string NameOfOwener { get; set; }
        public string NumberOfUnit { get; set; }
        public string SqFootage { get; set; }
        public string ProgectSq { get; set; }

    }
    public class TableInfo
    {
        public string IndividualName { get; set; }
        public string DeveloperOrSponcer { get; set; }
        public string NoOfUnits { get; set; }
        public string PerOwnedProjectUnits { get; set; }
        public string NumbermarketRent { get; set; }
        public string NumberLeasedUnderControl { get; set; }
    }
    public class InformationConcerningOwnershipUnits
    {
        public string TypeOfInsurance { get; set; }

        public string CarrierAgentname { get; set; }

        public string CarrierAgentPhNo { get; set; }

        public string PolicyNo { get; set; }
    }

    public class FinancialInformation
    {
        public string HowManyUnitOwners { get; set; }
        public bool InTheEventLenderAcquires { get; set; }
        public string InTheEventLenderAcquiresString
        { 
            get
            {
                    if (InTheEventLenderAcquires)
                    {
                        return "Yes";
                    }
                    else
                    {
                        return "No";
                    }
            }
        }
        public bool IfYesForHowLongIsTheMortgagee { get; set; }
        public string IfYesForHowLongIsTheMortgageeString
        {
            get
            {
                if (IfYesForHowLongIsTheMortgagee)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }

            }
        }
        public bool IsTheHOAInvolved { get; set; }
        public string IsTheHOAInvolvedString
        { 
            get
            {
                if (IsTheHOAInvolved)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }

        public string AttorneyPhNo { get; set; }
        public string AttorneyName { get; set; }

    }

    public class ProjectCompleteInfo
    {
        public bool Project100Complete { get; set; }
        public string Project100CompleteString 
        { 
            get 
            { 
                if(Project100Complete)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            } 
        }
        public bool IstheProjectSubjecttoAdditional { get; set; }
        public string IstheProjectSubjecttoAdditionalString
        {
            get
            {
                if (IstheProjectSubjecttoAdditional)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public bool IsTheProjectLegallyPhased { get; set; }
        public string IsTheProjectLegallyPhasedString
        {
            get
            {
                if (IsTheProjectLegallyPhased)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public bool HasTheDeveloperTransferredControl { get; set; }
        public string HasTheDeveloperTransferredControlString
        {
            get
            {
                if (Project100Complete)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string Howmanyphaseshavebeencompleted { get; set; }
        public string HowmanyphaseshavebeencompletedLeagely { get; set; }
        public string Totalunit { get; set; }
        public bool FacilityFullyComplete { get; set; }
        public string FacilityFullyCompleteString
        {
            get
            {
                if (FacilityFullyComplete)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public bool TransferControl { get; set; }
        public string TransferControlString
        {
            get
            {
                if (Project100Complete)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public   DateTime? IsTheDevTransYes { get; set; }

        public   DateTime? IsTheDevTransNo { get; set; }

    }

    public class BasicProjectInformation
    {
        public BasicProjectInformation()
        {
            NameofMasterorUmbrellaAssociationOptions.Add("Hotel/motel/resort activities, mandatory or voluntary rental-pooling arrangements, or other restrictions on the unit owner’s ability to occupy the unit", false);
            NameofMasterorUmbrellaAssociationOptions.Add("Deed or resale restrictions", false);
            NameofMasterorUmbrellaAssociationOptions.Add("Manufactured homes", false);
            NameofMasterorUmbrellaAssociationOptions.Add("Mandatory fee-based memberships for use of project amenities or services", false);
            NameofMasterorUmbrellaAssociationOptions.Add("Non-incidental income from business operations", false);
            NameofMasterorUmbrellaAssociationOptions.Add("Supportive or continuing care for seniors or for residents with disabilities", false);
            
        }
        public string ProjectLegalName { get; set; }
        public string ProjectPhysicalAddress { get; set; }
        public string HOAManagementAddress { get; set; }
        public string HOAName { get; set; }
        public string HOATaxID { get; set; }
        public string HOAManagementCompanyTaxID { get; set; }
        public string NameofMasterorUmbrellaAssociation { get; set; }

        public string ProjectContainAny { get; set; }
        public Dictionary<string, bool> NameofMasterorUmbrellaAssociationOptions { get; set; } = new Dictionary<string, bool>();
        public string NameofMasterorUmbrellaAssociationOptionsString
        {
            get
            {
                var outputString = new List<string>();
                outputString.AddRange(NameofMasterorUmbrellaAssociationOptions.Where(x => x.Value).Select(x => x.Key).ToList());

                return String.Join("<br/>", outputString);
            }
        }
        public string ProvideAdditionalDetail { get; set; }

    }

    public class Instructions
    {
        public string formDueDate { get; set; } 
        public string lenderName { get; set; }
        public string lenderPhoneNumber { get; set; }
        public string contactName { get; set; }
        public string lenderFaxNumber { get; set; }
        public string lenderAddress { get; set; }
        public string lenderEmailAddress { get; set; }
    }
}
