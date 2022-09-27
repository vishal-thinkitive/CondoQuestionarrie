using FluentMigrator;
using CondoQuestionnaire.Core.Models;

namespace CondoQuestionnaire.Migration.Migrations;

[Migration(version: 202209141931, description: "First Migration")]
public class InitalMigration : FluentMigrator.Migration {
    public override void Up()
            {
                Create.Table("Users")
                    .WithColumn(nameof(UserModel.Id)).AsGuid().PrimaryKey()
                    .WithColumn(nameof(UserModel.Name)).AsString()
                    .WithColumn(nameof(UserModel.Email)).AsString()
                    .WithColumn(nameof(UserModel.Phone)).AsString()
                    .WithColumn(nameof(UserModel.Salt)).AsString()
                    .WithColumn(nameof(UserModel.Password)).AsString()
                    .WithColumn(nameof(UserModel.CreatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(UserModel.UpdatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(UserModel.DeletedAtUtc)).AsDateTime().Nullable();
                
                
                Create.Table("Contacts")
                    .WithColumn(nameof(ContactModel.Id)).AsGuid().PrimaryKey().Identity()
                    .WithColumn(nameof(ContactModel.Name)).AsString()
                    .WithColumn(nameof(ContactModel.DefaultMethodId)).AsGuid().Nullable()
                    .WithColumn(nameof(ContactModel.CreatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(ContactModel.UpdatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(ContactModel.DeletedAtUtc)).AsDateTime().Nullable();
                
                
                Create.Table("ContactMethods")
                    .WithColumn(nameof(ContactMethodModel.Id)).AsGuid().PrimaryKey()
                    .WithColumn(nameof(ContactMethodModel.Label)).AsString()
                    .WithColumn(nameof(ContactMethodModel.ContactId)).AsGuid()
                        .ForeignKey("fk_Contacts_ContactMethods", "Contacts", nameof(ContactModel.Id))
                    .WithColumn(nameof(ContactMethodModel.Type)).AsString()
                    .WithColumn(nameof(ContactMethodModel.ReferenceValue)).AsString()
                    .WithColumn(nameof(ContactMethodModel.CreatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(ContactMethodModel.UpdatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(ContactMethodModel.DeletedAtUtc)).AsDateTime().Nullable();
                
                
                Create.Table("Addresses")
                    .WithColumn(nameof(AddressModel.Id)).AsGuid().PrimaryKey().Identity()
                    .WithColumn(nameof(AddressModel.Name)).AsString().Nullable()
                    .WithColumn(nameof(AddressModel.Line1)).AsString().Nullable()
                    .WithColumn(nameof(AddressModel.Line2)).AsString()
                    .WithColumn(nameof(AddressModel.Locality)).AsString()
                    .WithColumn(nameof(AddressModel.Region)).AsString().Indexed("idx_Addresses_Region")
                    .WithColumn(nameof(AddressModel.PostalCode)).AsString()
                    .WithColumn(nameof(AddressModel.Country)).AsString().Indexed("idx_Addresses_Country")
                    .WithColumn(nameof(AddressModel.Longitude)).AsInt32().Nullable()
                    .WithColumn(nameof(AddressModel.Latitude)).AsInt32().Nullable()
                    .WithColumn(nameof(AddressModel.CreatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(AddressModel.UpdatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(AddressModel.DeletedAtUtc)).AsDateTime().Nullable();
                
                
                Create.Table("CondoProperties")
                    .WithColumn(nameof(CondoPropertyModel.Id)).AsGuid().PrimaryKey().Identity()
                    .WithColumn(nameof(CondoPropertyModel.Name)).AsString()
                    .WithColumn(nameof(CondoPropertyModel.Type)).AsString().Indexed("idx_CondoProperties_Type")
                    .WithColumn(nameof(CondoPropertyModel.Status)).AsString().Indexed("idx_CondoProperties_Status")
                    .WithColumn(nameof(CondoPropertyModel.Source)).AsString().Indexed("idx_CondoProperties_Source")
                    .WithColumn(nameof(CondoPropertyModel.SourceRef)).AsString().Nullable()
                    .WithColumn(nameof(CondoPropertyModel.AddressId)).AsString().Nullable()
                    .ForeignKey("fk_Addresses_CondoProperties", "Addresses", nameof(AddressModel.Id))
                    .WithColumn(nameof(CondoPropertyModel.CreatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(CondoPropertyModel.UpdatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(CondoPropertyModel.DeletedAtUtc)).AsDateTime().Nullable();
                
                
                Create.Table("PropertyManagementCompanies")
                    .WithColumn(nameof(PropertyManagementCompanyModel.Id)).AsGuid().PrimaryKey().Identity()
                    .WithColumn(nameof(PropertyManagementCompanyModel.Name)).AsString()
                    .WithColumn(nameof(PropertyManagementCompanyModel.Dba)).AsString().Nullable()
                    .WithColumn(nameof(PropertyManagementCompanyModel.CreatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(PropertyManagementCompanyModel.UpdatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(PropertyManagementCompanyModel.DeletedAtUtc)).AsDateTime().Nullable();
                

                Create.Table("PropertyManagerProfiles")
                    .WithColumn(nameof(PropertyManagerProfileModel.Id)).AsGuid().PrimaryKey()
                    .WithColumn(nameof(PropertyManagerProfileModel.Name)).AsString()
                    .WithColumn(nameof(PropertyManagerProfileModel.FirstName)).AsString()
                    .WithColumn(nameof(PropertyManagerProfileModel.LastName)).AsString()
                    .WithColumn(nameof(PropertyManagerProfileModel.ContactId)).AsGuid().Nullable()
                        .ForeignKey("fk_Contacts_PropertyManagerProfiles", "Contacts", nameof(ContactModel.Id))
                    .WithColumn(nameof(PropertyManagerProfileModel.UserId)).AsGuid().Nullable()
                        .ForeignKey("fk_Users_PropertyManagerProfiles", "Users", nameof(UserModel.Id))
                    .WithColumn(nameof(PropertyManagerProfileModel.CurrentCompanyId)).AsGuid().Nullable()
                        .ForeignKey("fk_PropertyManagementCompanies_PropertyManagerProfiles", "PropertyManagementCompanies", nameof(PropertyManagementCompanyModel.Id))
                    .WithColumn(nameof(PropertyManagerProfileModel.CreatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(PropertyManagerProfileModel.UpdatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(PropertyManagerProfileModel.DeletedAtUtc)).AsDateTime().Nullable();
                
                
                Create.Table("ApplicantProfiles")
                    .WithColumn(nameof(ApplicantProfileModel.Id)).AsGuid().PrimaryKey()
                    .WithColumn(nameof(ApplicantProfileModel.Name)).AsString()
                    .WithColumn(nameof(ApplicantProfileModel.FirstName)).AsString()
                    .WithColumn(nameof(ApplicantProfileModel.LastName)).AsString()
                    .WithColumn(nameof(ApplicantProfileModel.ContactId)).AsGuid().Nullable()
                        .ForeignKey("fk_Contacts_ApplicantProfiles", "Contacts", nameof(ContactModel.Id))
                    .WithColumn(nameof(ApplicantProfileModel.UserId)).AsGuid().Nullable()
                        .ForeignKey("fk_Users_ApplicantProfiles", "Users", nameof(UserModel.Id))
                    .WithColumn(nameof(ApplicantProfileModel.CreatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(ApplicantProfileModel.UpdatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(ApplicantProfileModel.DeletedAtUtc)).AsDateTime().Nullable();
                
                
                Create.Table("CondoApplications")
                    .WithColumn(nameof(CondoApplicationModel.Id)).AsGuid().PrimaryKey()
                    .WithColumn(nameof(CondoApplicationModel.Status)).AsString().Indexed("idx_CondoApplications_Status")
                    .WithColumn(nameof(CondoApplicationModel.CurrentQuestionCode)).AsString().Indexed("idx_CondoApplications_CurrentQuestionCode")
                    .WithColumn(nameof(CondoApplicationModel.ApplicantId)).AsGuid().Nullable()
                        .ForeignKey("fk_ApplicantProfiles_CondoApplications", "ApplicantProfiles", nameof(ApplicantProfileModel.Id))
                    .WithColumn(nameof(CondoApplicationModel.CompletedAtUtc)).AsDateTime().Nullable()
                    .WithColumn(nameof(CondoApplicationModel.CreatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(CondoApplicationModel.UpdatedAtUtc)).AsDateTime()
                    .WithColumn(nameof(CondoApplicationModel.DeletedAtUtc)).AsDateTime().Nullable();

            }
    
            public override void Down()
            {
                Delete.Table("CondoApplications");
                Delete.Table("ApplicantProfiles");
                Delete.Table("PropertyManagerProfiles");
                Delete.Table("PropertyManagementCompanies");
                Delete.Table("CondoProperties");
                Delete.Table("Addresses");
                Delete.Table("ContactMethods");
                Delete.Table("Contacts");
                Delete.Table("Users");
            }
}