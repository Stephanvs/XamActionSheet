using System;
using ObjCRuntime;

[assembly: LinkWith ("libDoActionSheetFork.a", LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
