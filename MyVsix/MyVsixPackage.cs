using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Task = System.Threading.Tasks.Task;

namespace MyVsix
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("MyVsix Hello World", "Sample VSIX used for artifact signing tests.", "1.0.0")]
    [Guid(MyVsixPackage.PackageGuidString)]
    public sealed class MyVsixPackage : AsyncPackage
    {
        public const string PackageGuidString = "4d2c0f35-9b1a-4e0a-9a2a-0d6e7f7b5c10";

        protected override Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            return Task.CompletedTask;
        }
    }
}
