// Copyright (c) SharpCrafters s.r.o. All rights reserved.
// This project is not open source. Please see the LICENSE.md file in the repository root for details.

using PostSharp.Engineering.BuildTools;
using PostSharp.Engineering.BuildTools.Build.Model;
using PostSharp.Engineering.BuildTools.Build.Solutions;
using PostSharp.Engineering.BuildTools.Dependencies.Definitions;
using Spectre.Console.Cli;
using MetalamaDependencies = PostSharp.Engineering.BuildTools.Dependencies.Definitions.MetalamaDependencies.V2024_1;

var product = new Product(MetalamaDependencies.NopCommerce)
{
    Solutions = new Solution[]
    {
        new DotNetSolution("src\\NopCommerce.sln"),
    },
    PublicArtifacts = Pattern.Create("Nop.Web.Framework.4.5.0.nupkg"),
    Dependencies = new[] { DevelopmentDependencies.PostSharpEngineering, MetalamaDependencies.Metalama },
};

var commandApp = new CommandApp();

commandApp.AddProductCommands( product );

return commandApp.Run( args );
