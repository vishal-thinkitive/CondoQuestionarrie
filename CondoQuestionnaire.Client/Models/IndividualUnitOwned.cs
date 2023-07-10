namespace CondoQuestionnaire.Client.Models
{
    public class IndividualUnitOwned
    {
        public int? Id { get; set; }
        public string IndividualEntityName { get; set; }
        public bool? DeveloperOrSponsor { get; set; }
        public int? NumberOfUnitOwned { get; set; }
        public decimal? PercentageOwnedOfProjectUnit { get; set; }
        public int? NumberLeasedMarketRent { get; set; }
        public int? NumberLeasedRentControl { get; set; }

    }
}
