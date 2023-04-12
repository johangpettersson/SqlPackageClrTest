using Microsoft.SqlServer.Dac;

var services = new DacServices("<connectionstring>");
var options = new DacDeployOptions();

using (var package = DacPackage.Load(@"<pathtodacpac>"))
{
    services.Deploy(package, "SqlPackageClrTest", false);

    var publishOptions = new PublishOptions()
    {
        DeployOptions = options,
        GenerateDeploymentReport = true
    };

    var result = services.Script(package, "SqlPackageClrTest", publishOptions);
    File.WriteAllText(@"<pathtopublishreport>", result.DeploymentReport);
    File.WriteAllText(@"<pathtogeneratedscript>", result.DatabaseScript);
}


services.Extract(@"<pathtoextracteddacpac>", "SqlPackageClrTest", "SqlPackageClrTest", Version.Parse("1.0.0.0"));
