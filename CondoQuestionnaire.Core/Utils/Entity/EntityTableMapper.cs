using CondoQuestionnaire.Core.Models;

namespace CondoQuestionnaire.Core.Utils.Entity;

public static class EntityToTableNameMapper
{
    private static readonly Dictionary<Type, string> TypesToTables = new()
    {
        {typeof(AddressModel), "Addresses"},
        {typeof(ContactModel), "Contacts"},
        {typeof(ContactMethodModel), "ContactMethods"},
        {typeof(CondoPropertyModel), "CondoProperties"},
        {typeof(PropertyManagementCompanyModel), "PropertyManagementCompanies"},
        {typeof(CondoApplicationModel), "CondoApplications"},
        {typeof(PropertyManagerProfileModel), "PropertyManagerProfiles"},
        {typeof(ApplicantProfileModel), "ApplicantProfiles"},
        {typeof(UserModel), "Users"}
    };

    public static string GetTableForEntity(IEntity entity)
    {
        return TypesToTables[entity.GetType()];
    }
    
    public static string GetTableForEntityType(Type entityType)
    {
        return TypesToTables[entityType];
    }
}