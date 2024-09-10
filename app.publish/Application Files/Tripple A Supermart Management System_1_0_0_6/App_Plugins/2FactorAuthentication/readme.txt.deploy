Package based on Twilio sms provider

Needs to add
    <add key="Twilio.AccountSID" value="AccountSIDKey" />
    <add key="Twilio.AuthToken" value="AuthTokenKey" />
    <add key="Twilio.ServiceSid" value="ServiceSidKey" />

And for enable 2Fa auth you need to change owin:appStartup key value to "TwoFactorBackOfficeOwinStartup"
   <add key="owin:appStartup" value="TwoFactorBackOfficeOwinStartup" />

Or override BackOfficeUserManager and BackOfficeUserStore in your OwinStartup:
   protected override void ConfigureUmbracoAuthentication(IAppBuilder app)
        {
            app.SetUmbracoLoggerFactory();

            var applicationContext = Services;
            // There are several overloads of this method that allow you to customize the BackOfficeUserManager or even custom BackOfficeUserStore.
            app.ConfigureUserManagerForUmbracoBackOffice<TwoFactorBackOfficeUserManager, BackOfficeIdentityUser>(
                 Umbraco.Web.Composing.Current.RuntimeState,
                 GlobalSettings,
                 (options, context) =>
                 {
                     var membershipProvider = MembershipProviderExtensions
                        .GetUsersMembershipProvider()
                        .AsUmbracoMembershipProvider();

                     var userManager = TwoFactorBackOfficeUserManager.Create(
                         options,
                         applicationContext.UserService,
                         applicationContext.MemberTypeService,
                         applicationContext.EntityService,
                         applicationContext.ExternalLoginService,
                         membershipProvider,
                         GlobalSettings,
                         Mapper);

                     return userManager;
                 });

            // Default ConfigureUmbracoAuthentication code
            app
               .UseUmbracoBackOfficeCookieAuthentication(UmbracoContextAccessor, RuntimeState, Services.UserService, GlobalSettings, UmbracoSettings.Security, PipelineStage.Authenticate)
               .UseUmbracoBackOfficeExternalCookieAuthentication(UmbracoContextAccessor, RuntimeState, GlobalSettings, PipelineStage.Authenticate)
               .UseUmbracoPreviewAuthentication(UmbracoContextAccessor, RuntimeState, GlobalSettings, UmbracoSettings.Security, PipelineStage.Authorize)
               // For 2 fa auth
               .UseTwoFactorSignInCookie(global::Umbraco.Core.Constants.Security.BackOfficeTwoFactorAuthenticationType, TimeSpan.FromMinutes(5));
        }