﻿< Project Sdk = "Microsoft.NET.Sdk" >

  < PropertyGroup >
    < TargetFramework > net6.0 </ TargetFramework >

    < IsPackable > false </ IsPackable >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.NET.Test.Sdk" Version = "16.9.4" />
    < PackageReference Include = "MSTest.TestAdapter" Version = "2.2.3" />
    < PackageReference Include = "MSTest.TestFramework" Version = "2.2.3" />
    < PackageReference Include = "coverlet.collector" Version = "3.0.2" />
  </ ItemGroup >

  < ItemGroup >
    < ProjectReference Include = "..\Actividad09\Actividad9.csproj" />
  </ ItemGroup >

</ Project >
