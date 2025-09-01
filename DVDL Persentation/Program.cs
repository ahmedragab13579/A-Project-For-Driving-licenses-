using DVDL_InfrastructureLayer;
using DVDL_Persentation.Appointments;
using DVDL_Persentation.Extensions;
using DVDL_Persentation.License_Information;
using DVDL_Persentation.Manage_Screens;
using DVDL_Persentation.Person_Information;
using DVDL_Persentation.Tests;
using Microsoft.Extensions.DependencyInjection;

namespace DVDL_Persentation
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }
        [STAThread]
        static void Main()
        {
            try
            {
                ConfigProtector.ProtectSections("connectionStrings", "appSettings");
            }
            catch
            {
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize(); 

            var services = new ServiceCollection();

            services.AddBusinessServices()
                    .AddWindowsForms();

            services.AddTransient<ThePersonInformationForm>();
            services.AddTransient<PersonLicenseHistory>();
            services.AddTransient<LocalDrivingLicenseInformations>();
            services.AddTransient<TheLoginScreenForm>();
            services.AddTransient<ManageDetainLicesneForm>();
            services.AddTransient<ManageApplicationTypesForm>();
            services.AddTransient<ManagePeopleForm>();
            services.AddTransient<ManageDrivers>();
            services.AddTransient<ManageInternationalLicense>();
            services.AddTransient<ManageTestsType>();
            services.AddTransient<ManageUsersForm>();
            services.AddTransient<ManageLocalDrivingLicenseApplicationForm>();
            services.AddTransient<UpdateApplication>();
            services.AddTransient<AddAnAppointment>();
            services.AddTransient<AppointmentForm>();
            services.AddTransient<ChangeLicenseForLostOrDamage>();
            services.AddTransient<RenewDrivingLicenseForm>();
            services.AddTransient<DetainLicenseFrom>();
            services.AddTransient<RelaseDetainLicenseFrom>();
            services.AddTransient<IssueInternationalLicense>();
            services.AddTransient<AddLocalDrivingLicenseApplicationForm>();
            services.AddTransient<IssueLocalDrivingLicenseForm>();
            services.AddTransient<LocalDrivingLicenseApplicationInfomations>();
            services.AddTransient<LocalLicenseApplicationInfomationForm>();
            services.AddTransient<PersonLicenseHistory>();
            services.AddTransient<ThePersonInformationForm>();
            services.AddTransient<TestForm>();
            services.AddTransient<UpdateTest>();
            services.AddTransient<AddOrUpdateUserForm>();
            services.AddTransient<ChangePasswordForm>();
            services.AddTransient<UserInformationForm>();
            services.AddTransient<AddOrUpdatePersonForm>();
            ServiceProvider = services.BuildServiceProvider();

            var loginForm = ServiceProvider.GetRequiredService<TheLoginScreenForm>();
            Application.Run(loginForm);
        }

    }
}
