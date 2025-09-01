using DVDL_Business.After.Application;
using DVDL_Business.After.ApplicationType;
using DVDL_Business.After.Appointment;
using DVDL_Business.After.Country;
using DVDL_Business.After.DetainLicense;
using DVDL_Business.After.Driver;
using DVDL_Business.After.InternationalLicense;
using DVDL_Business.After.License;
using DVDL_Business.After.LicenseType;
using DVDL_Business.After.LocalDrivingLIcense;
using DVDL_Business.After.LocalDrivingLIcense.LocalDrivingLicense_View;
using DVDL_Business.After.People;
using DVDL_Business.After.Test;
using DVDL_Business.After.TestType;
using DVDL_Business.After.User;
using DVDL_Persentation.Appointments;
using DVDL_Persentation.License_Information;
using DVDL_Persentation.Manage_Screens;
using DVDL_Persentation.Person_Information;
using DVDL_Persentation.Tests;
using FormsUtilities.Applications;
using FormsUtilities.Appointments.AddAppointment;
using FormsUtilities.Appointments.AppointmentInformation;
using FormsUtilities.LicenseInformation.ChangeLicense.ChangeLicenseForLostOrDamage;
using FormsUtilities.LicenseInformation.ChangeLicense.RenewDrivingLicense;
using FormsUtilities.LicenseInformation.DetainLicense.Detain;
using FormsUtilities.LicenseInformation.DetainLicense.Release;
using FormsUtilities.LicenseInformation.FindLicenseWithFilter;
using FormsUtilities.LicenseInformation.InternationalLicense.InternationalLicense;
using FormsUtilities.LicenseInformation.LocalLicense.AddDrivingLicense;
using FormsUtilities.LicenseInformation.LocalLicense.IssueDrivinglIcense;
using FormsUtilities.LicenseInformation.LocalLicense.LIcenseInformation;
using FormsUtilities.LoginScreen;
using FormsUtilities.ManageScreens.ManageApplicationTypes;
using FormsUtilities.ManageScreens.ManageDetainLicesne;
using FormsUtilities.ManageScreens.ManageDrivers;
using FormsUtilities.ManageScreens.ManageInternationalLicense;
using FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Status.Service;
using FormsUtilities.ManageScreens.ManageLocalDrivinglicense.Utilitys;
using FormsUtilities.ManageScreens.ManagePeople.Utility;
using FormsUtilities.ManageScreens.ManageTestType;
using FormsUtilities.ManageScreens.ManageUsers;
using FormsUtilities.PersonInformation.AddOrUpdatePerson;
using FormsUtilities.PersonInformation.PersonCard;
using FormsUtilities.PersonInformation.PersonLicenseHistory;
using FormsUtilities.Tests.TestForm;
using FormsUtilities.Tests.UpdateTest;
using FormsUtilities.UserInformation.AddOrUpdateUserInformation;
using FormsUtilities.UserInformation.ChangePasssword;
using FormsUtilities.UserInformation.UserCard;
using Microsoft.Extensions.DependencyInjection;


namespace DVDL_Persentation.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddTransient<IDetainLicenseService, DetainLicenseService>();
            services.AddTransient<IDriverService, DriverService>();
            services.AddTransient<ILicenseService, LicenseService>();
            services.AddTransient<ILocalDrivingLicenseViewService, LocalDrivingLicenseViewService>();
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IAppointmentService, AppointmentService>();
            services.AddTransient<IApplicationTypeService, ApplicationTypeService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IInternationalService, InternationalService>();
            services.AddTransient<ILicenseTypeService, LicenseTypeService>();
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<ITestTypeService, TestTypeService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IManagePeopleUtility, ManagePeopleUtility>();
            services.AddTransient<IApplicationTypeUtility, ApplicationTypeUtility>();
            services.AddTransient<IManageDetainLicenseUtility, ManageDetainLicenseUtility>();
            services.AddTransient<IManageDriversUtility, ManageDriversUtility>();
            services.AddTransient<IManageInternationalLicenseUtility,ManageInternationalLicenseUtility>();
            services.AddTransient<IManageTestTypeUtility, ManageTestTypeUtility>();
            services.AddTransient<IManageUsersUtility, ManageUsersUtility>();
            services.AddTransient<IManageLocalDrivingLIcenseUtility, ManageLocalDrivingLIcenseUtility>();
            services.AddTransient<IManageLocalDrivingLicenseStatus, ManageLocalLicenseStatus>();
            services.AddTransient<ILocalDrivingLicenseViewService, LocalDrivingLicenseViewService>();
            services.AddTransient<ILocalDrivingLicenseService, LocalDrivingLicenseService>();
            services.AddTransient<IChangeLicenseForLostOrDamage, ChangeLicenseForLostOrDamageUtility>();
            services.AddTransient<IRenewLicenseUtility, RenewLicenseUtility>();
            services.AddTransient<IManageDetainLicenseUtility, ManageDetainLicenseUtility>();
            services.AddTransient<IReleaseLicenseUtility, ReleaseLicenseUtility>();
            services.AddTransient<IInternationalLicenseUtility, InternationalLicenseUtility>();
            services.AddTransient<IAddDrivingLIcenseUtility, AddDrivingLIcenseUtility>();
            services.AddTransient<IIssueDrivingLicenseUtility, IssueDrivingLicenseUtility>();
            services.AddTransient<ILicenseInformationUtility, LicenseInformationUtility>();
            services.AddTransient<IPersonCardUtility, PersonCardUtility>();
            services.AddTransient<IPersonLicenseHistoryUtility, PersonLicenseHistoryUtility>();
            services.AddTransient<ITestInformationUtility, TestInformationUtility>();
            services.AddTransient<IUpdateTestUtility, UpdateTestUtility>();
            services.AddTransient<IAddOrUpdateUserInformation, AddOrUpdateUserInformation>();
            services.AddTransient<IAddOrUpdatePersonUtility, AddOrUpdatePersonUtility>();
            services.AddTransient<IChangePasswordUtility, ChangePasswordUtility>();
            services.AddTransient<IUsercardUtility, UsercardUtility>();
            services.AddTransient<ILoginScreenUtility, LoginScreenUtility>();
            services.AddTransient<IUpdateApplicationTypeUtility, UpdateApplicationTypeUtility>();
            services.AddTransient<IApplicationService, ApplicationService>();
            services.AddTransient<IFindLicenserWithFilterUtility, FindLicenserWithFilterUtility>();
            services.AddTransient<IManageDetainLicenseUtility, ManageDetainLicenseUtility>();
            services.AddTransient<IDetainLicenseUtility, DetainLicenseUtility>();
            services.AddTransient<IAddAnAppointmentUtility, AddAnAppointmentUtility>();
            services.AddTransient<IAppointmentInformationUtility, AppointmentInformationUtility>();

            return services;
        }

        public static IServiceCollection AddWindowsForms(this IServiceCollection services)
        {
            services.AddTransient<ManageDetainLicesneForm>();
            services.AddTransient<DetainLicenseFrom>();
            services.AddTransient<LocalDrivingLicenseInformations>();
            services.AddTransient<PersonLicenseHistory>();
            services.AddTransient<UpdateApplication>();
            services.AddTransient<AddAnAppointment>();
            services.AddTransient<AppointmentForm>();
            services.AddTransient<ChangeLicenseForLostOrDamage>();
            services.AddTransient<RenewDrivingLicenseForm>();
            services.AddTransient<RelaseDetainLicenseFrom>();
            services.AddTransient<IssueInternationalLicense>();
            services.AddTransient<ManageApplicationTypesForm>();
            services.AddTransient<ManageDrivers>();
            services.AddTransient<ManageInternationalLicense>();
            services.AddTransient<ManageLocalDrivingLicenseApplicationForm>();
            services.AddTransient<ManagePeopleForm>();
            services.AddTransient<ManageTestsType>();
            services.AddTransient<ManageUsersForm>();
            services.AddTransient<AddOrUpdatePersonForm>();
            services.AddTransient<ThePersonInformationForm>();
            services.AddTransient<TestForm>();
            services.AddTransient<UpdateTest>();
            services.AddTransient<AddOrUpdateUserForm>();
            services.AddTransient<ChangePasswordForm>();
            services.AddTransient<UserInformationForm>();
            services.AddTransient<UpdateApplication>();



            return services;

        }
    }
}
