using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using Microsoft.Azure.KeyVault;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.SqlServer.Management.AlwaysEncrypted.AzureKeyVaultProvider;

namespace InsuranceAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        private static ClientCredential _clientCredential;

        async protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            string clientId = WebConfigurationManager.AppSettings["ClientId"];
            string clientSecret = WebConfigurationManager.AppSettings["ClientSecret"];
            _clientCredential = new ClientCredential(clientId, clientSecret);

            //SqlColumnEncryptionAzureKeyVaultProvider azureKeyVaultProvider = new SqlColumnEncryptionAzureKeyVaultProvider(Util.GetToken);
            //Dictionary<string, SqlColumnEncryptionKeyStoreProvider> providers = new Dictionary<string, SqlColumnEncryptionKeyStoreProvider>();
            //providers.Add(SqlColumnEncryptionAzureKeyVaultProvider.ProviderName, azureKeyVaultProvider);
            //SqlConnection.RegisterColumnEncryptionKeyStoreProviders(providers);

            //var kv = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(Util.GetToken));
            //var sec = await kv.GetSecretAsync(WebConfigurationManager.AppSettings["SecretUri"]);
            //Util.EncryptSecret = sec.Value;

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}
